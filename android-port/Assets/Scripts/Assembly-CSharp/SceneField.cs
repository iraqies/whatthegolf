using System;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceLocations;

[Serializable]
public class SceneField : ISerializationCallbackReceiver
{
	[SerializeField]
	private UnityEngine.Object sceneAsset;

	[SerializeField]
	public AssetReferenceScene sceneReference;

	[SerializeField]
	private string deprecated_SceneName;

	public IResourceLocation ResourceLocation;

	public string SceneName
	{
		get
		{
			if (sceneReference != null && !string.IsNullOrEmpty(sceneReference.SceneName))
				return sceneReference.SceneName;
			if (!string.IsNullOrEmpty(deprecated_SceneName))
				return deprecated_SceneName;
			return sceneAsset != null ? sceneAsset.name : string.Empty;
		}
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
