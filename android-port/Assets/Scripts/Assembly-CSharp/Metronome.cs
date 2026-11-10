using System;
using UnityEngine;

public class Metronome : MonoBehaviour
{
	[SerializeField]
	private double _tempo = 120.0;

	[SerializeField]
	private int _subdivisions = 4;

	private double _tickLength;

	private double _nextTickTime;

	private bool running;

	public bool Running => running;

	public event Action<double> Ticked;

	public event Action onStart;

	public event Action onStop;

	public double GetTempo()
	{
		return _tempo;
	}

	public void SetTempo(double tempo)
	{
		_tempo = tempo;
		Recalculate();
	}

	public void SetSubdivisions(int sub)
	{
		_subdivisions = sub;
		Recalculate();
	}

	private void Reset()
	{
		Recalculate();
		_nextTickTime = AudioSettings.dspTime + _tickLength;
	}

	public void StartMetronome()
	{
		Recalculate();
		_nextTickTime = AudioSettings.dspTime;
		running = true;
		onStart?.Invoke();
	}

	public void StopMetronome()
	{
		running = false;
		onStop?.Invoke();
	}

	private void Recalculate()
	{
		double ticksPerSec = _tempo / 60.0 * (double)_subdivisions;
		_tickLength = ((ticksPerSec > 0.0) ? (1.0 / ticksPerSec) : 0.125);
	}

	private void OnValidate()
	{
		if (Application.isPlaying)
		{
			Recalculate();
		}
	}

	private void Update()
	{
		if (!running)
		{
			return;
		}
		if (_tickLength <= 0.0)
		{
			Recalculate();
		}
		double currentTime = AudioSettings.dspTime + (double)Time.deltaTime;
		while (currentTime > _nextTickTime)
		{
			Ticked?.Invoke(_nextTickTime);
			_nextTickTime += _tickLength;
		}
	}
}
