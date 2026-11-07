using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1B0F38", Offset = "0x1B0F38")]
	public class AssetReferenceUIRestriction : Attribute
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A28C20", Offset = "0x2A28C20", VA = "0x2A28C20", Slot = "7")]
		public virtual bool ValidateAsset(Object obj)
		{
			return default;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A28C28", Offset = "0x2A28C28", VA = "0x2A28C28", Slot = "8")]
		public virtual bool ValidateAsset(string path)
		{
			return default;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A28AFC", Offset = "0x2A28AFC", VA = "0x2A28AFC")]
		public AssetReferenceUIRestriction()
		{
		}
	}
}
