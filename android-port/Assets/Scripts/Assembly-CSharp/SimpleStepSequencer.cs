using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SimpleStepSequencer : MonoBehaviour
{
	[Serializable]
	public class Step
	{
		public bool Active;

		public int MidiNoteNumber;

		public double Duration;
	}

	public delegate void HandleTick(double tickTime);

	[CompilerGenerated]
	private HandleTick m_Ticked;

	public bool Suspend;

	[SerializeField]
	private Metronome _metronome;

	[SerializeField]
	private List<Step> _steps;

	private int _currentTick;

	public event HandleTick Ticked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void HandleTicked(double tickTime)
	{
	}
}
