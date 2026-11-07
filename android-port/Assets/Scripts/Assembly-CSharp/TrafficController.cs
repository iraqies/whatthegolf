using System;
using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class TrafficController : MonoBehaviour
{
	[Serializable]
	public class TrafficPoint
	{
		public List<Transform> PathPoints;

		public List<GameObject> CurrentCars;

		public float Delay;
	}

	public List<TrafficPoint> TrafficPoints;

	private int trafficPointsSum;

	public List<GameObject> CarPrefabs;

	public bool PrePopulate;

	public int NumberOfCars;

	public Vector2 DelayRange;

	public float CheckRadius;

	public Vector3 ScaleMod;

	public List<AudioClip> engineLoopSequence;

	private List<CarAgent> _cars;

	private int engineLoopIndex;

	private Timeline timeline;

	private List<int> interestingPoints;

	public void ChangeTimelineClock(string newClockName)
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public AudioClip GetNextEngineClip()
	{
		return null;
	}

	private void TrySpawnCars(bool prePopulate = false)
	{
	}

	public void RemoveAndDeactivateCar(TrafficPoint point, CarAgent car)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
