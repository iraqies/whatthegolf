using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
public class AssetReferenceScene : AssetReferenceT<SceneReference>
{
	[SerializeField]
	private string sceneName;

	public string SceneName => null;

	public AssetReferenceScene(string guid, string sceneName)
		: base((string)null)
	{
	}

	public override bool ValidateAsset(string path)
	{
		return false;
	}
}
