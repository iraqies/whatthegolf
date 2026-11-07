using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceLocations;

[Serializable]
[Token(Token = "0x20004B7")]
public class SceneField : ISerializationCallbackReceiver
{
	[Token(Token = "0x40018D9")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private UnityEngine.Object sceneAsset;

	[Token(Token = "0x40018DA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public AssetReferenceScene sceneReference;

	[Token(Token = "0x40018DB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4D7BC", Offset = "0x4D7BC")]
	private string deprecated_SceneName;

	[Token(Token = "0x40018DC")]
	[FieldOffset(Offset = "0x28")]
	public IResourceLocation ResourceLocation;

	[Token(Token = "0x17000265")]
	public string SceneName
	{
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x167B068", Offset = "0x167B068", VA = "0x167B068")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x167B084", Offset = "0x167B084", VA = "0x167B084", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x167B088", Offset = "0x167B088", VA = "0x167B088", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x167B08C", Offset = "0x167B08C", VA = "0x167B08C")]
	public SceneField()
	{
	}
}
