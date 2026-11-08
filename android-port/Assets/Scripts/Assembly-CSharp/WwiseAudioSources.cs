using UnityEngine;

public class WwiseAudioSources : MonoBehaviour
{
	public class SourceInfo
	{
		public MusicClip parent;
		public AudioSource source;
		public float lastStart;
	}

	[SerializeField] private int count = 16;
	[SerializeField] private AudioSource audioSourcePrefab;
	private SourceInfo[] audioSources;
	private int index;
	private bool didInit;

	public void Awake()
	{
		Init();
	}

	private void Init()
	{
		if (didInit && audioSources != null && audioSources.Length > 0) return;
		didInit = true;
		int n = Mathf.Max(count, 8);
		audioSources = new SourceInfo[n];
		for (int i = 0; i < n; i++)
		{
			AudioSource src;
			if (audioSourcePrefab != null)
			{
				src = Instantiate(audioSourcePrefab, transform);
			}
			else
			{
				var go = new GameObject("WwiseSource_" + i);
				go.transform.SetParent(transform, false);
				src = go.AddComponent<AudioSource>();
			}
			src.playOnAwake = false;
			src.spatialBlend = 0f;
			audioSources[i] = new SourceInfo { source = src };
		}
	}

	public SourceInfo Get(MusicClip parent)
	{
		Init();
		if (audioSources == null || audioSources.Length == 0) return null;
		var info = audioSources[index % audioSources.Length];
		index = (index + 1) % audioSources.Length;
		if (info.parent != null && info.parent != parent)
			info.parent.SourceWasTaken();
		info.parent = parent;
		info.lastStart = Time.unscaledTime;
		return info;
	}
}
