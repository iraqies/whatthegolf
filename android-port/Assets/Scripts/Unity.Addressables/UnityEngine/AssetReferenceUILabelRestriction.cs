using Il2CppDummyDll;

namespace UnityEngine
{
	[Token(Token = "0x200000A")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x1B0F70", Offset = "0x1B0F70")]
	public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction
	{
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		public string[] m_AllowedLabels;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		public string m_CachedToString;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A28AD0", Offset = "0x2A28AD0", VA = "0x2A28AD0")]
		public AssetReferenceUILabelRestriction(params string[] allowedLabels)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A28B04", Offset = "0x2A28B04", VA = "0x2A28B04", Slot = "7")]
		public override bool ValidateAsset(Object obj)
		{
			return default;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A28B0C", Offset = "0x2A28B0C", VA = "0x2A28B0C", Slot = "8")]
		public override bool ValidateAsset(string path)
		{
			return default;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2A28B14", Offset = "0x2A28B14", VA = "0x2A28B14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
