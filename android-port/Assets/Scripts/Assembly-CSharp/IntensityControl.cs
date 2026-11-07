using System;
using UnityEngine;

public class IntensityControl : MonoBehaviour
{
	[Serializable]
	public class SequencerIntensityPair
	{
		public StepSequencer Sequencer;

		public float Intensity;
	}

	[SerializeField]
	private SequencerIntensityPair[] _sequencerIntensityPairs;

	public void OnSliderUpdate(float sliderValue)
	{
	}

	private void Start()
	{
	}
}
