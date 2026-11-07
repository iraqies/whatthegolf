using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B7AE8", Offset = "0x1B7AE8")]
	internal class BinaryAssetProvider<TAdapter> : BinaryDataProvider where TAdapter : BinaryStorageBuffer.ISerializationAdapter, new()
	{
		[Token(Token = "0x60001B2")]
		public override object Convert(Type type, byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		public BinaryAssetProvider()
		{
		}
	}
}
