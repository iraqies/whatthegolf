using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
[Token(Token = "0x2000002")]
public class AssetReferenceScene : AssetReferenceT<SceneReference>
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string sceneName;

	[Token(Token = "0x17000001")]
	public string SceneName
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2A288C8", Offset = "0x2A288C8", VA = "0x2A288C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2A288D0", Offset = "0x2A288D0", VA = "0x2A288D0")]
	public AssetReferenceScene(string guid, string sceneName)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2A28940", Offset = "0x2A28940", VA = "0x2A28940", Slot = "21")]
	public override bool ValidateAsset(string path)
	{
		return default;
	}
}
