using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Serializable]
	[Token(Token = "0x2000043")]
	public class AssetBundleRequestOptions : ILocationSizeData
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7F94", Offset = "0x1B7F94")]
		private string m_Hash;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7FE0", Offset = "0x1B7FE0")]
		private uint m_Crc;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B802C", Offset = "0x1B802C")]
		[SerializeField]
		private int m_Timeout;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B8078", Offset = "0x1B8078")]
		private bool m_ChunkedTransfer;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B80C4", Offset = "0x1B80C4")]
		[SerializeField]
		private int m_RedirectLimit;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B8110", Offset = "0x1B8110")]
		private int m_RetryCount;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_BundleName;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AssetLoadMode m_AssetLoadMode;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private long m_BundleSize;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_UseCrcForCachedBundles;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool m_UseUWRForLocalBundles;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool m_ClearOtherCachedVersionsWhenLoaded;

		[Token(Token = "0x1700003A")]
		public string Hash
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2A5D2A4", Offset = "0x2A5D2A4", VA = "0x2A5D2A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2A5D2AC", Offset = "0x2A5D2AC", VA = "0x2A5D2AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public uint Crc
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2A5D2B4", Offset = "0x2A5D2B4", VA = "0x2A5D2B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2A5D2BC", Offset = "0x2A5D2BC", VA = "0x2A5D2BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public int Timeout
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2A5D2C4", Offset = "0x2A5D2C4", VA = "0x2A5D2C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2A5D2CC", Offset = "0x2A5D2CC", VA = "0x2A5D2CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool ChunkedTransfer
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2A5D2D4", Offset = "0x2A5D2D4", VA = "0x2A5D2D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2A5D2DC", Offset = "0x2A5D2DC", VA = "0x2A5D2DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int RedirectLimit
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2A5D2E4", Offset = "0x2A5D2E4", VA = "0x2A5D2E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2A5D2F8", Offset = "0x2A5D2F8", VA = "0x2A5D2F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int RetryCount
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2A5D300", Offset = "0x2A5D300", VA = "0x2A5D300")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2A5D308", Offset = "0x2A5D308", VA = "0x2A5D308")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public string BundleName
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2A5D310", Offset = "0x2A5D310", VA = "0x2A5D310")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2A5D318", Offset = "0x2A5D318", VA = "0x2A5D318")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public AssetLoadMode AssetLoadMode
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2A5D320", Offset = "0x2A5D320", VA = "0x2A5D320")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2A5D328", Offset = "0x2A5D328", VA = "0x2A5D328")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public long BundleSize
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2A5D330", Offset = "0x2A5D330", VA = "0x2A5D330")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2A5D338", Offset = "0x2A5D338", VA = "0x2A5D338")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool UseCrcForCachedBundle
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2A5D340", Offset = "0x2A5D340", VA = "0x2A5D340")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2A5D348", Offset = "0x2A5D348", VA = "0x2A5D348")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool UseUnityWebRequestForLocalBundles
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2A5D350", Offset = "0x2A5D350", VA = "0x2A5D350")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2A5D358", Offset = "0x2A5D358", VA = "0x2A5D358")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool ClearOtherCachedVersionsWhenLoaded
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2A5D360", Offset = "0x2A5D360", VA = "0x2A5D360")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2A5D368", Offset = "0x2A5D368", VA = "0x2A5D368")]
			set
			{
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2A5D370", Offset = "0x2A5D370", VA = "0x2A5D370", Slot = "5")]
		public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager)
		{
			return default;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2A5D570", Offset = "0x2A5D570", VA = "0x2A5D570")]
		public AssetBundleRequestOptions()
		{
		}
	}
}
