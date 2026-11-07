using UnityEngine;

public class WwiseAudioSources : MonoBehaviour
{
	public class SourceInfo
	{
		public MusicClip parent;

		public AudioSource source;

		public float lastStart;
	}

	[SerializeField]
	private int count;

	[SerializeField]
	private AudioSource audioSourcePrefab;

	private SourceInfo[] audioSources;

	private int index;

	private bool didInit;

	public void Awake()
	{
	}

	private void Init()
	{
	}

	public SourceInfo Get(MusicClip parent)
	{
		return null;
	}
}
