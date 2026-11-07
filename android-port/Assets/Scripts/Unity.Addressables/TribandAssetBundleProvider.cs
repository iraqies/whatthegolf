using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B0EC8", Offset = "0x1B0EC8")]
public class TribandAssetBundleProvider : AssetBundleProvider
{
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2A38918", Offset = "0x2A38918", VA = "0x2A38918", Slot = "15")]
	public override void Release(IResourceLocation location, object asset)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2A38920", Offset = "0x2A38920", VA = "0x2A38920", Slot = "18")]
	public override AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
	{
		return default;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2A38928", Offset = "0x2A38928", VA = "0x2A38928", Slot = "14")]
	public override bool CanProvide(Type t, IResourceLocation location)
	{
		return default;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2A38930", Offset = "0x2A38930", VA = "0x2A38930", Slot = "16")]
	public override Type GetDefaultType(IResourceLocation location)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2A38938", Offset = "0x2A38938", VA = "0x2A38938", Slot = "13")]
	public override bool Initialize(string id, string data)
	{
		return default;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2A38940", Offset = "0x2A38940", VA = "0x2A38940", Slot = "17")]
	public override void Provide(ProvideHandle providerInterface)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2A389B4", Offset = "0x2A389B4", VA = "0x2A389B4")]
	public TribandAssetBundleProvider()
	{
	}
}
