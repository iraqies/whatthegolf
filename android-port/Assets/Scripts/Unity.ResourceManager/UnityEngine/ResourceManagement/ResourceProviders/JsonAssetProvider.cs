using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B7BA0", Offset = "0x1B7BA0")]
	public class JsonAssetProvider : TextDataProvider
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2A6871C", Offset = "0x2A6871C", VA = "0x2A6871C", Slot = "19")]
		public override object Convert(Type type, string text)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2A68728", Offset = "0x2A68728", VA = "0x2A68728")]
		public JsonAssetProvider()
		{
		}
	}
}
