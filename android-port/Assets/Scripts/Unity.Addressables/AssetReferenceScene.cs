using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
public class AssetReferenceScene : AssetReferenceT<SceneReference>
{
	[SerializeField]
	private string sceneName;

	public string SceneName => sceneName;

	public AssetReferenceScene(string guid, string sceneName)
		: base(guid)
	{
		this.sceneName = sceneName;
	}

	public override bool ValidateAsset(string path) => !string.IsNullOrEmpty(path) && path.EndsWith(".unity");
}
