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

	public string SceneName => null;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
