using UnityEngine;

public class SimpleSampler : MonoBehaviour
{
	[SerializeField]
	private SimpleStepSequencer _sequencer;

	[SerializeField]
	private AudioClip _audioClip;

	[SerializeField]
	private int _numVoices = 2;

	[SerializeField]
	private SimpleSamplerVoice _samplerVoicePrefab;

	private SimpleSamplerVoice[] _samplerVoices;

	private int _nextVoiceIndex;

	private void Awake()
	{
		_samplerVoices = new SimpleSamplerVoice[_numVoices];
		for (int i = 0; i < _numVoices; i++)
		{
			if (_samplerVoicePrefab != null)
			{
				SimpleSamplerVoice v = Instantiate(_samplerVoicePrefab);
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

	private void HandleTicked(double tickTime)
	{
		if (_samplerVoices == null || _samplerVoices.Length == 0)
		{
			return;
		}
		SimpleSamplerVoice voice = _samplerVoices[_nextVoiceIndex];
		if (voice != null)
		{
			voice.Play(_audioClip, tickTime);
		}
		_nextVoiceIndex = (_nextVoiceIndex + 1) % _samplerVoices.Length;
	}
}
