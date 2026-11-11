using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class KaraokeWord : MonoBehaviour
{
	public enum WordState
	{
		Starting = 0,
		Playing = 1,
		Stopping = 2,
		None = 3
	}

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private Transform endMarkerTransform;

	[SerializeField]
	private ParticleSystem TreesSystem;

	[SerializeField]
	private ParticleSystem InstrumentSystem;

	[SerializeField]
	private int TreesAmount = 3;

	[SerializeField]
	private int InstrumentsAmount = 1;

	[SerializeField]
	private AudioSource audioSourcePrefab;

	[SerializeField]
	private AssetReference startClipAssetReference;

	[SerializeField]
	private AssetReference midClipAssetReference;

	[SerializeField]
	private AssetReference endClipAssetReference;

	[SerializeField]
	private float volume;

	[SerializeField]
	private float fadeInTime = 0.25f;

	[SerializeField]
	private float fadeOutTime = 0.3f;

	private AsyncOperationHandle<AudioClip> startAsyncOperationHandle;

	private AsyncOperationHandle<AudioClip> midAsyncOperationHandle;

	private AsyncOperationHandle<AudioClip> endAsyncOperationHandle;

	private float minX;

	private float maxX;

	public WordState currentState;

	private float timeInState;

	private AudioSource startSource;

	private AudioSource midSource;

	private AudioSource endSource;

	public bool InAnyPlayState { get; private set; }

	public float MinX => minX;

	public float MaxX => maxX;

	public void Awake()
	{
		minX = base.transform.position.x;
		if (endMarkerTransform != null)
		{
			maxX = endMarkerTransform.position.x;
		}
		StartCoroutine(LoadAudioClips());
	}

	private IEnumerator LoadAudioClips()
	{
		if (startClipAssetReference != null)
		{
			startAsyncOperationHandle = startClipAssetReference.LoadAssetAsync<AudioClip>();
		}
		if (midClipAssetReference != null)
		{
			midAsyncOperationHandle = midClipAssetReference.LoadAssetAsync<AudioClip>();
		}
		if (endClipAssetReference != null)
		{
			endAsyncOperationHandle = endClipAssetReference.LoadAssetAsync<AudioClip>();
		}
		if (audioSourcePrefab != null)
		{
			startSource = Object.Instantiate(audioSourcePrefab, base.transform);
			midSource = Object.Instantiate(audioSourcePrefab, base.transform);
			endSource = Object.Instantiate(audioSourcePrefab, base.transform);
		}
		yield return startAsyncOperationHandle;
		yield return midAsyncOperationHandle;
		yield return endAsyncOperationHandle;
		if (startSource != null && startAsyncOperationHandle.IsValid())
		{
			startSource.clip = startAsyncOperationHandle.Result;
		}
		if (midSource != null && midAsyncOperationHandle.IsValid())
		{
			midSource.clip = midAsyncOperationHandle.Result;
		}
		if (endSource != null && endAsyncOperationHandle.IsValid())
		{
			endSource.clip = endAsyncOperationHandle.Result;
		}
	}

	public void EnterWord()
	{
		currentState = WordState.Starting;
		timeInState = 0f;
		if (startSource != null)
		{
			startSource.Play();
		}
		if (midSource != null)
		{
			midSource.Play();
		}
		InAnyPlayState = true;
		if (TreesSystem != null)
		{
			TreesSystem.Emit(TreesAmount);
		}
		if (InstrumentSystem != null)
		{
			InstrumentSystem.Emit(InstrumentsAmount);
		}
	}

	public void ExitWord()
	{
		if (currentState != WordState.Stopping && currentState != WordState.None)
		{
			currentState = WordState.Stopping;
			timeInState = 0f;
			if (endSource != null)
			{
				endSource.Play();
			}
		}
	}

	private void Update()
	{
		if (currentState != WordState.None)
		{
			timeInState += Time.deltaTime;
		}
		switch (currentState)
		{
		case WordState.Starting:
		{
			float t2 = Mathf.Clamp01(timeInState / fadeInTime);
			float num = Mathf.Lerp(volume, 0f, t2);
			float num2 = Mathf.Lerp(0f, volume, t2);
			if (startSource != null)
			{
				startSource.volume = num;
			}
			if (midSource != null)
			{
				midSource.volume = num2;
			}
			if (timeInState >= fadeInTime)
			{
				currentState = WordState.Playing;
				if (startSource != null)
				{
					startSource.Stop();
				}
				if (midSource != null)
				{
					midSource.volume = volume;
				}
			}
			break;
		}
		case WordState.Stopping:
		{
			InAnyPlayState = false;
			if (startSource != null && startSource.isPlaying)
			{
				startSource.Stop();
			}
			float t = Mathf.Clamp01(timeInState / fadeOutTime);
			if (midSource != null)
			{
				midSource.volume = Mathf.Lerp(volume, 0f, t);
			}
			if (endSource != null)
			{
				endSource.volume = Mathf.Lerp(0f, volume, t);
			}
			if (timeInState >= fadeOutTime)
			{
				currentState = WordState.None;
				if (midSource != null)
				{
					midSource.volume = 0f;
					midSource.Stop();
				}
				if (endSource != null)
				{
					endSource.volume = volume;
				}
			}
			break;
		}
		}
	}

	private void OnDestroy()
	{
		if (startAsyncOperationHandle.IsValid())
		{
			Addressables.Release(startAsyncOperationHandle);
			startAsyncOperationHandle = default;
		}
		if (midAsyncOperationHandle.IsValid())
		{
			Addressables.Release(midAsyncOperationHandle);
			midAsyncOperationHandle = default;
		}
		if (endAsyncOperationHandle.IsValid())
		{
			Addressables.Release(endAsyncOperationHandle);
			endAsyncOperationHandle = default;
		}
	}
}
