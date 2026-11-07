using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x2000008")]
	[Attribute(Name = "RequireComponent", RVA = "0x1B0820", Offset = "0x1B0820")]
	[DisallowMultipleComponent]
	[Attribute(Name = "DefaultExecutionOrder", RVA = "0x1B0820", Offset = "0x1B0820")]
	[ExecuteInEditMode]
	[Attribute(Name = "MovedFromAttribute", RVA = "0x1B0820", Offset = "0x1B0820")]
	[Preserve]
	public sealed class SpriteSkin : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_RootBone;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] m_BoneTransforms;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Bounds m_Bounds;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseBatching;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool m_AlwaysUpdate;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x48")]
		private NativeByteArray m_DeformedVertices;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x50")]
		private int m_CurrentDeformVerticesLength;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x58")]
		private SpriteRenderer m_SpriteRenderer;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x60")]
		private int m_CurrentDeformSprite;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x64")]
		private bool m_ForceSkinning;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x65")]
		private bool m_BatchSkinning;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x66")]
		private bool m_IsValid;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		private int m_TransformsHash;

		[Token(Token = "0x17000008")]
		internal bool batchSkinning
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2A0E750", Offset = "0x2A0E750", VA = "0x2A0E750")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2A0E758", Offset = "0x2A0E758", VA = "0x2A0E758")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		internal Sprite sprite
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2A0E810", Offset = "0x2A0E810", VA = "0x2A0E810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		internal SpriteRenderer spriteRenderer
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2A0FCC4", Offset = "0x2A0FCC4", VA = "0x2A0FCC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public Transform[] boneTransforms
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2A0FCCC", Offset = "0x2A0FCCC", VA = "0x2A0FCCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2A0FCD4", Offset = "0x2A0FCD4", VA = "0x2A0FCD4")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Transform rootBone
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2A0FD1C", Offset = "0x2A0FD1C", VA = "0x2A0FD1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2A0FD24", Offset = "0x2A0FD24", VA = "0x2A0FD24")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		internal Bounds bounds
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2A0FD6C", Offset = "0x2A0FD6C", VA = "0x2A0FD6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2A0FD80", Offset = "0x2A0FD80", VA = "0x2A0FD80")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool alwaysUpdate
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2A0FD94", Offset = "0x2A0FD94", VA = "0x2A0FD94")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2A0FD9C", Offset = "0x2A0FD9C", VA = "0x2A0FD9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		internal bool isValid
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2A0EA38", Offset = "0x2A0EA38", VA = "0x2A0EA38")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A0E760", Offset = "0x2A0E760", VA = "0x2A0E760")]
		private int GetSpriteInstanceID()
		{
			return default;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A0E82C", Offset = "0x2A0E82C", VA = "0x2A0E82C")]
		internal void Awake()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A0E888", Offset = "0x2A0E888", VA = "0x2A0E888")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2A0E99C", Offset = "0x2A0E99C", VA = "0x2A0E99C")]
		internal void OnEditorEnable()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2A0E9F8", Offset = "0x2A0E9F8", VA = "0x2A0E9F8")]
		private void CacheValidFlag()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2A0EB20", Offset = "0x2A0EB20", VA = "0x2A0EB20")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2A0EBBC", Offset = "0x2A0EBBC", VA = "0x2A0EBBC")]
		internal void UseBatching(bool value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2A0EBD4", Offset = "0x2A0EBD4", VA = "0x2A0EBD4")]
		internal NativeByteArray GetDeformedVertices(int spriteVertexCount)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2A0ECB4", Offset = "0x2A0ECB4", VA = "0x2A0ECB4")]
		public bool HasCurrentDeformedVertices()
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2A0ED48", Offset = "0x2A0ED48", VA = "0x2A0ED48")]
		internal NativeArray<byte> GetCurrentDeformedVertices()
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2A0EE4C", Offset = "0x2A0EE4C", VA = "0x2A0EE4C")]
		internal NativeSlice<PositionVertex> GetCurrentDeformedVertexPositions()
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2A0EF84", Offset = "0x2A0EF84", VA = "0x2A0EF84")]
		internal NativeSlice<PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents()
		{
			return default;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A0F0BC", Offset = "0x2A0F0BC", VA = "0x2A0F0BC")]
		public IEnumerable<Vector3> GetDeformedVertexPositionData()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A0F3C4", Offset = "0x2A0F3C4", VA = "0x2A0F3C4")]
		public IEnumerable<Vector4> GetDeformedVertexTangentData()
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2A0F5E4", Offset = "0x2A0F5E4", VA = "0x2A0F5E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2A0F62C", Offset = "0x2A0F62C", VA = "0x2A0F62C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2A0E934", Offset = "0x2A0E934", VA = "0x2A0E934")]
		private void CacheCurrentSprite()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2A0FFA4", Offset = "0x2A0FFA4", VA = "0x2A0FFA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2A0EA54", Offset = "0x2A0EA54", VA = "0x2A0EA54")]
		internal void DeactivateSkinning()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2A0FFA8", Offset = "0x2A0FFA8", VA = "0x2A0FFA8")]
		internal void ResetSprite()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2A0FFEC", Offset = "0x2A0FFEC", VA = "0x2A0FFEC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A0FFF4", Offset = "0x2A0FFF4", VA = "0x2A0FFF4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A0E998", Offset = "0x2A0E998", VA = "0x2A0E998")]
		private void OnEnableBatch()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A0FCC0", Offset = "0x2A0FCC0", VA = "0x2A0FCC0")]
		internal void UpdateSpriteDeform()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A0EBB8", Offset = "0x2A0EBB8", VA = "0x2A0EBB8")]
		private void OnResetBatch()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A0EBD0", Offset = "0x2A0EBD0", VA = "0x2A0EBD0")]
		private void UseBatchingBatch()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A0F628", Offset = "0x2A0F628", VA = "0x2A0F628")]
		private void OnDisableBatch()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2A0FD18", Offset = "0x2A0FD18", VA = "0x2A0FD18")]
		private void OnBoneTransformChanged()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2A0FD68", Offset = "0x2A0FD68", VA = "0x2A0FD68")]
		private void OnRootBoneTransformChanged()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2A0FFF0", Offset = "0x2A0FFF0", VA = "0x2A0FFF0")]
		private void OnBeforeSerializeBatch()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2A0FFF8", Offset = "0x2A0FFF8", VA = "0x2A0FFF8")]
		private void OnAfterSerializeBatch()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2A0FFFC", Offset = "0x2A0FFFC", VA = "0x2A0FFFC")]
		public SpriteSkin()
		{
		}
	}
}
