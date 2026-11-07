using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Metronome : MonoBehaviour
{
	[CompilerGenerated]
	private Action<double> m_Ticked;

	[CompilerGenerated]
	private Action m_onStart;

	[CompilerGenerated]
	private Action m_onStop;

	[SerializeField]
	private double _tempo;

	[SerializeField]
	private int _subdivisions;

	private double _tickLength;

	private double _nextTickTime;

	private bool running;

	public bool Running => false;

	public event Action<double> Ticked
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

	public event Action onStart
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

	public event Action onStop
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

	public double GetTempo()
	{
		return 0.0;
	}

	public void SetTempo(double tempo)
	{
	}

	public void SetSubdivisions(int sub)
	{
	}

	private void Reset()
	{
	}

	public void StartMetronome()
	{
	}

	public void StopMetronome()
	{
	}

	private void Recalculate()
	{
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}
}
