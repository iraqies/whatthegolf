using UnityEngine;

public class SimpleSampler : MonoBehaviour
{
	[SerializeField]
	private SimpleStepSequencer _sequencer;

	[SerializeField]
	private AudioClip _audioClip;

	[SerializeField]
	private int _numVoices;

	[SerializeField]
	private SimpleSamplerVoice _samplerVoicePrefab;

	private SimpleSamplerVoice[] _samplerVoices;

	private int _nextVoiceIndex;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleTicked(double tickTime)
	{
	}
}
