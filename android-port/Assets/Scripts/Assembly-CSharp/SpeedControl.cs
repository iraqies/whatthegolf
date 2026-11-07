using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{
	[SerializeField]
	private Metronome _metronome;

	[SerializeField]
	private float _tempoMin;

	[SerializeField]
	private float _tempoMax;

	[SerializeField]
	private float _releaseMin;

	[SerializeField]
	private float _releaseMax;

	public List<Sampler> samplers;

	public void OnSliderUpdate(float sliderValue)
	{
	}
}
