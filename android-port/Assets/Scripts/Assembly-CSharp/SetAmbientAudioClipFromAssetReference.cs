using System.Collections;
using Audio;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SetAmbientAudioClipFromAssetReference : MonoBehaviour
{
	[SerializeField]
	private AmbientAudio ambientAudio;

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
