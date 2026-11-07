using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Scripting;

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
		private bool m_AlwaysUpdate;

		private NativeByteArray m_DeformedVertices;

		private int m_CurrentDeformVerticesLength;

		private SpriteRenderer m_SpriteRenderer;

		private int m_CurrentDeformSprite;

		private bool m_ForceSkinning;

		private bool m_BatchSkinning;

		private bool m_IsValid;

		private int m_TransformsHash;

		internal bool batchSkinning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Sprite sprite => null;

		internal SpriteRenderer spriteRenderer => null;

		public Transform[] boneTransforms
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Transform rootBone
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal Bounds bounds
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public bool alwaysUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isValid => false;

		private int GetSpriteInstanceID()
		{
			return 0;
		}

		internal void Awake()
		{
		}

		private void OnEnable()
		{
		}

		internal void OnEditorEnable()
		{
		}

		private void CacheValidFlag()
		{
		}

		private void Reset()
		{
		}

		internal void UseBatching(bool value)
		{
		}

		internal NativeByteArray GetDeformedVertices(int spriteVertexCount)
		{
			return null;
		}

		public bool HasCurrentDeformedVertices()
		{
			return false;
		}

		internal NativeArray<byte> GetCurrentDeformedVertices()
		{
			return default;
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
		}

		private void LateUpdate()
		{
		}

		private void CacheCurrentSprite()
		{
		}

		private void OnDestroy()
		{
		}

		internal void DeactivateSkinning()
		{
		}

		internal void ResetSprite()
		{
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

		internal void UpdateSpriteDeform()
		{
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
