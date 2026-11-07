using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventStepSequencer : MonoBehaviour
{
	[Serializable]
	public class Step
	{
		public bool Active;

		public int MidiNoteNumber;

		public double Duration;
	}

	public UnityEvent _onStart;

	public UnityEvent _onTick;

	public UnityEvent _onStop;

	public bool Suspend;

	[SerializeField]
	private Metronome _metronome;

	[SerializeField]
	private List<Step> _steps;

	private int _currentTick;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void HandleTicked(double tickTime)
	{
	}

	private void OnStop()
	{
	}

	private void OnStart()
	{
	}
}
