using System;
using System.Collections.Generic;
using UnityEngine;

public class StepSequencer : MonoBehaviour
{
	[Serializable]
	public class Step
	{
		public bool Active;

		public int MidiNoteNumber = 60;

		public double Duration = 2.0;
	}

	public delegate void HandleTick(double tickTime, int midiNoteNumber, double duration);

	public bool Suspend;

	[SerializeField]
	private Metronome _metronome;

	[SerializeField]
	private List<Step> _steps;

	private int _currentTick;

	public event HandleTick Ticked;

	private void OnEnable()
	{
		if (_metronome != null)
		{
			_metronome.Ticked += HandleTicked;
		}
	}

	private void OnDisable()
	{
		if (_metronome != null)
		{
			_metronome.Ticked -= HandleTicked;
		}
	}

	public void HandleTicked(double tickTime)
	{
		if (_steps == null || _steps.Count == 0)
		{
			return;
		}
		Step step = _steps[_currentTick];
		if (step != null && step.Active && !Suspend)
		{
			Ticked?.Invoke(tickTime, step.MidiNoteNumber, step.Duration);
		}
		_currentTick = (_currentTick + 1) % _steps.Count;
	}
}
