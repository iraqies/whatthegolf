using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.U2D;
using UnityEngine.U2D.Common;

namespace UnityEngine.U2D.Animation
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[Preserve]
	public sealed class SpriteSkin : MonoBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		private Transform m_RootBone;

		[SerializeField]
		private Transform[] m_BoneTransforms;

		[SerializeField]
		private Bounds m_Bounds;

		[SerializeField]
		private bool m_UseBatching;

		[SerializeField]
		private bool m_AlwaysUpdate = true;

		private NativeByteArray m_DeformedVertices;

		private int m_CurrentDeformVerticesLength;

		private SpriteRenderer m_SpriteRenderer;

		private int m_CurrentDeformSprite;

		private bool m_ForceSkinning;

		private bool m_BatchSkinning;

		private bool m_IsValid;

		private int m_TransformsHash;

		private NativeArray<byte> m_RawVertexBuffer;

		private Vector2[] m_OriginalVertices;

		private BoneWeight[] m_BoneWeights;

		private Matrix4x4[] m_Bindposes;

		private Matrix4x4[] m_SkinMatrices;

		private int m_VertexStride = 12;

		internal bool batchSkinning
		{
			get => m_BatchSkinning;
			set => m_BatchSkinning = value;
		}

		internal Sprite sprite => m_SpriteRenderer != null ? m_SpriteRenderer.sprite : null;

		internal SpriteRenderer spriteRenderer => m_SpriteRenderer;

		public Transform[] boneTransforms
		{
			get => m_BoneTransforms;
			internal set
			{
				m_BoneTransforms = value;
				CacheValidFlag();
			}
		}

		public Transform rootBone
		{
			get => m_RootBone;
			internal set
			{
				m_RootBone = value;
				CacheValidFlag();
			}
		}

		internal Bounds bounds
		{
			get => m_Bounds;
			set => m_Bounds = value;
		}

		public bool alwaysUpdate
		{
			get => m_AlwaysUpdate;
			set => m_AlwaysUpdate = value;
		}

		internal bool isValid => m_IsValid;

		private int GetSpriteInstanceID()
		{
			return sprite != null ? sprite.GetInstanceID() : 0;
		}

		internal void Awake()
		{
			m_SpriteRenderer = GetComponent<SpriteRenderer>();
		}

		private void OnEnable()
		{
			if (m_SpriteRenderer == null)
				m_SpriteRenderer = GetComponent<SpriteRenderer>();
			CacheCurrentSprite();
			CacheValidFlag();
			m_ForceSkinning = true;
		}

		internal void OnEditorEnable()
		{
			Awake();
		}

		private void CacheValidFlag()
		{
			m_IsValid = m_SpriteRenderer != null && sprite != null && m_RootBone != null && m_BoneTransforms != null && m_BoneTransforms.Length > 0;
			if (m_IsValid)
			{
				for (int i = 0; i < m_BoneTransforms.Length; i++)
				{
					if (m_BoneTransforms[i] == null)
					{
						m_IsValid = false;
						break;
					}
				}
			}
		}

		private void Reset()
		{
			Awake();
			CacheValidFlag();
		}

		internal void UseBatching(bool value)
		{
			m_UseBatching = value;
		}

		internal NativeByteArray GetDeformedVertices(int spriteVertexCount)
		{
			return m_DeformedVertices;
		}

		public bool HasCurrentDeformedVertices()
		{
			return m_RawVertexBuffer.IsCreated && m_RawVertexBuffer.Length > 0;
		}

		internal NativeArray<byte> GetCurrentDeformedVertices()
		{
			return m_RawVertexBuffer;
		}

		internal NativeSlice<PositionVertex> GetCurrentDeformedVertexPositions()
		{
			return default;
		}

		internal NativeSlice<PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents()
		{
			return default;
		}

		public IEnumerable<Vector3> GetDeformedVertexPositionData()
		{
			return null;
		}

		public IEnumerable<Vector4> GetDeformedVertexTangentData()
		{
			return null;
		}

		private void OnDisable()
		{
			DeactivateSkinning();
		}

		private void LateUpdate()
		{
			if (m_SpriteRenderer == null)
				m_SpriteRenderer = GetComponent<SpriteRenderer>();
			if (!m_AlwaysUpdate && m_SpriteRenderer != null && !m_SpriteRenderer.isVisible && !m_ForceSkinning)
				return;
			UpdateSpriteDeform();
		}

		private void CacheCurrentSprite()
		{
			int id = GetSpriteInstanceID();
			if (id == m_CurrentDeformSprite && m_OriginalVertices != null)
				return;

			m_CurrentDeformSprite = id;
			Sprite sp = sprite;
			if (sp == null)
			{
				m_OriginalVertices = null;
				m_BoneWeights = null;
				m_Bindposes = null;
				return;
			}

			m_OriginalVertices = sp.vertices;
			m_Bindposes = sp.GetBindPoses().ToArray();

			NativeSlice<BoneWeight> bwSlice = sp.GetVertexAttribute<BoneWeight>(VertexAttribute.BlendWeight);
			if (bwSlice.Length == m_OriginalVertices.Length)
			{
				m_BoneWeights = new BoneWeight[bwSlice.Length];
				for (int i = 0; i < bwSlice.Length; i++)
					m_BoneWeights[i] = bwSlice[i];
			}
			else
			{
				m_BoneWeights = null;
			}

			bool hasNormals = sp.HasVertexAttribute(VertexAttribute.Normal);
			bool hasTangents = sp.HasVertexAttribute(VertexAttribute.Tangent);
			m_VertexStride = 12 + (hasNormals ? 12 : 0) + (hasTangents ? 16 : 0);

			if (m_RawVertexBuffer.IsCreated)
				m_RawVertexBuffer.Dispose();
			if (m_OriginalVertices != null && m_OriginalVertices.Length > 0)
				m_RawVertexBuffer = new NativeArray<byte>(m_OriginalVertices.Length * m_VertexStride, Allocator.Persistent);
		}

		private void OnDestroy()
		{
			DeactivateSkinning();
		}

		internal void DeactivateSkinning()
		{
			if (m_SpriteRenderer != null)
			{
				if (sprite != null)
					InternalEngineBridge.SetLocalAABB(m_SpriteRenderer, sprite.bounds);
				m_SpriteRenderer.DeactivateDeformableBuffer();
			}
			if (m_RawVertexBuffer.IsCreated)
				m_RawVertexBuffer.Dispose();
			m_CurrentDeformSprite = 0;
		}

		internal void ResetSprite()
		{
			m_CurrentDeformSprite = 0;
			CacheValidFlag();
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void OnEnableBatch()
		{
		}

		internal unsafe void UpdateSpriteDeform()
		{
			CacheCurrentSprite();
			CacheValidFlag();
			if (!m_IsValid || m_OriginalVertices == null || m_Bindposes == null || m_BoneWeights == null || !m_RawVertexBuffer.IsCreated)
				return;

			int boneCount = m_BoneTransforms.Length;
			if (m_Bindposes.Length < boneCount)
				return;
			if (m_SkinMatrices == null || m_SkinMatrices.Length != boneCount)
				m_SkinMatrices = new Matrix4x4[boneCount];

			Matrix4x4 worldToLocal = transform.worldToLocalMatrix;
			for (int i = 0; i < boneCount; i++)
			{
				m_SkinMatrices[i] = worldToLocal * m_BoneTransforms[i].localToWorldMatrix * m_Bindposes[i];
			}

			int vCount = m_OriginalVertices.Length;
			NativeSlice<byte> rawSlice = new NativeSlice<byte>(m_RawVertexBuffer);
			NativeSlice<Vector3> posSlice = rawSlice.SliceWithStride<Vector3>(0, m_VertexStride);
			for (int i = 0; i < vCount; i++)
			{
				Vector3 v = m_OriginalVertices[i];
				BoneWeight bw = m_BoneWeights[i];
				Vector3 res = Vector3.zero;
				if (bw.weight0 > 0f && bw.boneIndex0 >= 0 && bw.boneIndex0 < boneCount)
					res += m_SkinMatrices[bw.boneIndex0].MultiplyPoint3x4(v) * bw.weight0;
				if (bw.weight1 > 0f && bw.boneIndex1 >= 0 && bw.boneIndex1 < boneCount)
					res += m_SkinMatrices[bw.boneIndex1].MultiplyPoint3x4(v) * bw.weight1;
				if (bw.weight2 > 0f && bw.boneIndex2 >= 0 && bw.boneIndex2 < boneCount)
					res += m_SkinMatrices[bw.boneIndex2].MultiplyPoint3x4(v) * bw.weight2;
				if (bw.weight3 > 0f && bw.boneIndex3 >= 0 && bw.boneIndex3 < boneCount)
					res += m_SkinMatrices[bw.boneIndex3].MultiplyPoint3x4(v) * bw.weight3;
				posSlice[i] = res;
			}

			InternalEngineBridge.SetDeformableBuffer(m_SpriteRenderer, m_RawVertexBuffer);
			m_ForceSkinning = false;
		}

		private void OnResetBatch()
		{
		}

		private void UseBatchingBatch()
		{
		}

		private void OnDisableBatch()
		{
		}

		private void OnBoneTransformChanged()
		{
		}

		private void OnRootBoneTransformChanged()
		{
		}

		private void OnBeforeSerializeBatch()
		{
		}

		private void OnAfterSerializeBatch()
		{
		}
	}
}
