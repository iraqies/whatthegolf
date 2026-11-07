using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B0F00", Offset = "0x1B0F00")]
public class TribandAssetProvider : BundledAssetProvider
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2A389BC", Offset = "0x2A389BC", VA = "0x2A389BC", Slot = "14")]
	public override bool CanProvide(Type t, IResourceLocation location)
	{
		return default;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2A38AFC", Offset = "0x2A38AFC", VA = "0x2A38AFC", Slot = "16")]
	public override Type GetDefaultType(IResourceLocation location)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2A38C28", Offset = "0x2A38C28", VA = "0x2A38C28", Slot = "15")]
	public override void Release(IResourceLocation location, object obj)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2A38D64", Offset = "0x2A38D64", VA = "0x2A38D64", Slot = "18")]
	public override AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
	{
		return default;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2A38E38", Offset = "0x2A38E38", VA = "0x2A38E38", Slot = "13")]
	public override bool Initialize(string id, string data)
	{
		return default;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2A38EF4", Offset = "0x2A38EF4", VA = "0x2A38EF4", Slot = "17")]
	public override void Provide(ProvideHandle providerInterface)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2A39050", Offset = "0x2A39050", VA = "0x2A39050")]
	public TribandAssetProvider()
	{
	}
}
