using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SetAudioClipFromAssetReference : MonoBehaviour
{
	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AssetReference audioClipAssetReference;

	private AsyncOperationHandle<AudioClip> asyncOperationHandle;

	private void Awake()
	{
	}

	private IEnumerator LoadAudioClip()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
