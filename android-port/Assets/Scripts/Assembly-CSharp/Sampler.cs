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
	private int _numVoices = 2;

	[SerializeField]
	private SamplerVoice _samplerVoicePrefab;

	private SamplerVoice[] _samplerVoices;

	private int _nextVoiceIndex;

	public void SetRelease(double _release)
	{
		_releaseTime = _release;
	}

	private void Start()
	{
		_samplerVoices = new SamplerVoice[_numVoices];
		for (int i = 0; i < _numVoices; i++)
		{
			if (_samplerVoicePrefab != null)
			{
				SamplerVoice v = Instantiate(_samplerVoicePrefab);
				v.transform.parent = transform;
				v.transform.localPosition = Vector3.zero;
				_samplerVoices[i] = v;
			}
		}
	}

	private void OnEnable()
	{
		if (_sequencer != null)
		{
			_sequencer.Ticked += HandleTicked;
		}
	}

	private void OnDisable()
	{
		if (_sequencer != null)
		{
			_sequencer.Ticked -= HandleTicked;
		}
	}

	private void HandleTicked(double tickTime, int midiNoteNumber, double duration)
	{
		if (_samplerVoices == null || _samplerVoices.Length == 0)
		{
			return;
		}
		float pitch = MusicMathUtils.MidiNoteToPitch(midiNoteNumber, 60);
		SamplerVoice voice = _samplerVoices[_nextVoiceIndex];
		if (voice != null)
		{
			voice.Play(_audioClip, pitch, tickTime, _attackTime, duration, _releaseTime);
		}
		_nextVoiceIndex = (_nextVoiceIndex + 1) % _samplerVoices.Length;
	}
}
