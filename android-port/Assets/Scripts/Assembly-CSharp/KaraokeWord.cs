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
	private int TreesAmount;

	[SerializeField]
	private int InstrumentsAmount;

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
	private float fadeInTime;

	[SerializeField]
	private float fadeOutTime;

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

	public float MinX => 0f;

	public float MaxX => 0f;

	public void Awake()
	{
	}

	private IEnumerator LoadAudioClips()
	{
		return null;
	}

	public void EnterWord()
	{
	}

	public void ExitWord()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
