using UnityEngine;

public class Sampler : MonoBehaviour
{
	[SerializeField]
	private StepSequencer _sequencer;

	[SerializeField]
	private AudioClip _audioClip;

	[SerializeField]
	private double _attackTime;

	[SerializeField]
	private double _releaseTime;

	[SerializeField]
	private int _numVoices;

	[SerializeField]
	private SamplerVoice _samplerVoicePrefab;

	private SamplerVoice[] _samplerVoices;

	private int _nextVoiceIndex;

	public void SetRelease(double _release)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleTicked(double tickTime, int midiNoteNumber, double duration)
	{
	}
}
