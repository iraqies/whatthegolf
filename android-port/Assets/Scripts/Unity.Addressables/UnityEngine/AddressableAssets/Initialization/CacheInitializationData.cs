using System;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	[Token(Token = "0x2000059")]
	public class CacheInitializationData
	{
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B178C", Offset = "0x1B178C")]
		[SerializeField]
		private bool m_CompressionEnabled;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B17D8", Offset = "0x1B17D8")]
		[SerializeField]
		private string m_CacheDirectoryOverride;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1824", Offset = "0x1B1824")]
		[SerializeField]
		private int m_ExpirationDelay;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1870", Offset = "0x1B1870")]
		private bool m_LimitCacheSize;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B18BC", Offset = "0x1B18BC")]
		private long m_MaximumCacheSize;

		[Token(Token = "0x1700005D")]
		public bool CompressionEnabled
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2A28F8C", Offset = "0x2A28F8C", VA = "0x2A28F8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2A28F94", Offset = "0x2A28F94", VA = "0x2A28F94")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public string CacheDirectoryOverride
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2A28F9C", Offset = "0x2A28F9C", VA = "0x2A28F9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2A28FA4", Offset = "0x2A28FA4", VA = "0x2A28FA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B205C", Offset = "0x1B205C")]
		public int ExpirationDelay
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2A28FAC", Offset = "0x2A28FAC", VA = "0x2A28FAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2A28FB4", Offset = "0x2A28FB4", VA = "0x2A28FB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool LimitCacheSize
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x2A28FBC", Offset = "0x2A28FBC", VA = "0x2A28FBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2A28FC4", Offset = "0x2A28FC4", VA = "0x2A28FC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public long MaximumCacheSize
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x2A28FCC", Offset = "0x2A28FCC", VA = "0x2A28FCC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x2A28FD4", Offset = "0x2A28FD4", VA = "0x2A28FD4")]
			set
			{
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2A28FDC", Offset = "0x2A28FDC", VA = "0x2A28FDC")]
		public CacheInitializationData()
		{
		}
	}
}
