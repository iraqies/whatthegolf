using System;
using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class TrafficController : MonoBehaviour
{
	[Serializable]
	public class TrafficPoint
	{
		public List<Transform> PathPoints = new List<Transform>();

		public List<GameObject> CurrentCars = new List<GameObject>();

		public float Delay;
	}

	public List<TrafficPoint> TrafficPoints = new List<TrafficPoint>();

	private int trafficPointsSum;

	public List<GameObject> CarPrefabs = new List<GameObject>();

	public bool PrePopulate;

	public int NumberOfCars = 10;

	public Vector2 DelayRange = new Vector2(2f, 5f);

	public float CheckRadius = 60f;

	public Vector3 ScaleMod = Vector3.one;

	public List<AudioClip> engineLoopSequence = new List<AudioClip>();

	private List<CarAgent> _cars = new List<CarAgent>();

	private int engineLoopIndex;

	private Timeline timeline;

	private List<int> interestingPoints = new List<int>();

	public void ChangeTimelineClock(string newClockName)
	{
		if (timeline != null)
		{
			timeline.globalClockKey = newClockName;
			if (_cars != null)
			{
				foreach (CarAgent car in _cars)
				{
					if (car != null)
					{
						Timeline carTimeline = car.GetComponent<Timeline>();
						if (carTimeline != null)
							carTimeline.globalClockKey = newClockName;
					}
				}
			}
		}
	}

	private void Start()
	{
		timeline = GetComponent<Timeline>();
		_cars = new List<CarAgent>();
		if (interestingPoints == null)
			interestingPoints = new List<int>();

		if (CarPrefabs != null && CarPrefabs.Count > 0)
		{
			for (int i = 0; i < NumberOfCars; i++)
			{
				GameObject prefab = CarPrefabs[UnityEngine.Random.Range(0, CarPrefabs.Count)];
				if (prefab == null) continue;
				GameObject go = Instantiate(prefab, transform);
				go.SetActive(false);
				Vector3 ls = go.transform.localScale;
				go.transform.localScale = new Vector3(ls.x * ScaleMod.x, ls.y * ScaleMod.y, ls.z * ScaleMod.z);
				CarAgent agent = go.GetComponent<CarAgent>();
				if (agent != null)
					_cars.Add(agent);
			}
		}

		if (PrePopulate)
		{
			for (int i = 0; i < NumberOfCars; i++)
			{
				TrySpawnCars(true);
			}
		}
		else if (TrafficPoints != null)
		{
			foreach (TrafficPoint pt in TrafficPoints)
			{
				if (pt != null)
				{
					if (pt.CurrentCars == null) pt.CurrentCars = new List<GameObject>();
					pt.Delay = UnityEngine.Random.Range(0f, 2f);
				}
			}
		}
	}

	private void OnDisable()
	{
		if (_cars != null)
		{
			foreach (CarAgent car in _cars)
			{
				if (car != null && car.gameObject != null)
					car.gameObject.SetActive(false);
			}
		}
		if (TrafficPoints != null)
		{
			foreach (TrafficPoint pt in TrafficPoints)
			{
				if (pt != null)
				{
					pt.CurrentCars?.Clear();
					pt.Delay = 0f;
				}
			}
		}
	}

	private void Update()
	{
		trafficPointsSum = 0;
		if (TrafficPoints == null || TrafficPoints.Count == 0) return;

		for (int i = 0; i < TrafficPoints.Count; i++)
		{
			TrafficPoint pt = TrafficPoints[i];
			if (pt != null)
			{
				if (pt.CurrentCars == null) pt.CurrentCars = new List<GameObject>();
				trafficPointsSum += pt.CurrentCars.Count;
			}
		}

		if (trafficPointsSum < NumberOfCars)
		{
			TrySpawnCars(false);
		}

		foreach (TrafficPoint pt in TrafficPoints)
		{
			if (pt == null) continue;
			float dt = timeline != null ? timeline.deltaTime : Time.deltaTime;
			pt.Delay -= dt;
		}
	}

	public AudioClip GetNextEngineClip()
	{
		if (engineLoopSequence == null || engineLoopSequence.Count == 0 || engineLoopIndex < 0 || engineLoopIndex > engineLoopSequence.Count - 1)
			return null;
		AudioClip clip = engineLoopSequence[engineLoopIndex];
		engineLoopIndex = (engineLoopIndex + 1) % engineLoopSequence.Count;
		return clip;
	}

	private void TrySpawnCars(bool prePopulate = false)
	{
		if (interestingPoints == null) interestingPoints = new List<int>();
		interestingPoints.Clear();
		if (TrafficPoints == null || TrafficPoints.Count == 0 || _cars == null || _cars.Count == 0)
			return;

		int maxPerLane = Mathf.CeilToInt((float)NumberOfCars / (float)TrafficPoints.Count);
		for (int i = 0; i < TrafficPoints.Count; i++)
		{
			TrafficPoint pt = TrafficPoints[i];
			if (pt == null || pt.PathPoints == null || pt.PathPoints.Count < 2) continue;
			if (pt.CurrentCars == null) pt.CurrentCars = new List<GameObject>();
			if (pt.CurrentCars.Count < maxPerLane && pt.Delay <= 0f)
			{
				interestingPoints.Add(i);
			}
		}

		if (interestingPoints.Count == 0) return;

		int chosenPointIdx = interestingPoints[UnityEngine.Random.Range(0, interestingPoints.Count)];
		TrafficPoint chosenPoint = TrafficPoints[chosenPointIdx];
		if (chosenPoint == null || chosenPoint.PathPoints == null || chosenPoint.PathPoints.Count < 2)
			return;

		CarAgent chosenCar = null;
		for (int i = 0; i < _cars.Count; i++)
		{
			if (_cars[i] != null && !_cars[i].gameObject.activeSelf)
			{
				chosenCar = _cars[i];
				break;
			}
		}
		if (chosenCar == null) return;

		Vector3 spawnPos;
		int carLayer = LayerMask.NameToLayer("Car (OW Low)");
		int carLayerMask = carLayer >= 0 ? (1 << carLayer) : 0;

		if (prePopulate)
		{
			int segIdx = UnityEngine.Random.Range(0, chosenPoint.PathPoints.Count - 1);
			Transform pA = chosenPoint.PathPoints[segIdx];
			Transform pB = chosenPoint.PathPoints[segIdx + 1];
			if (pA == null || pB == null) return;
			float t = Mathf.Clamp01(UnityEngine.Random.Range(0f, 0.9f));
			spawnPos = Vector3.Lerp(pA.position, pB.position, t);
			if (CheckRadius > 0f && carLayerMask != 0)
			{
				Collider[] hits = Physics.OverlapSphere(spawnPos, CheckRadius, carLayerMask);
				if (hits != null && hits.Length > 0)
				{
					chosenCar.gameObject.SetActive(false);
					return;
				}
			}
		}
		else
		{
			if (chosenPoint.PathPoints[0] == null) return;
			spawnPos = chosenPoint.PathPoints[0].position;
			if (CheckRadius > 0f && carLayerMask != 0)
			{
				Collider[] hits = Physics.OverlapSphere(spawnPos, CheckRadius, carLayerMask);
				if (hits != null && hits.Length > 0)
				{
					chosenCar.gameObject.SetActive(false);
					return;
				}
			}
		}

		chosenCar.gameObject.SetActive(true);
		Vector3 forward = chosenPoint.PathPoints[1].position - chosenPoint.PathPoints[0].position;
		if (!prePopulate)
			spawnPos = chosenPoint.PathPoints[0].position;
		chosenCar.Iniitialize(spawnPos, forward, this, chosenPoint);

		if (timeline != null)
		{
			Timeline carTimeline = chosenCar.GetComponent<Timeline>();
			if (carTimeline != null)
				carTimeline.globalClockKey = timeline.globalClockKey;
		}

		if (chosenPoint.CurrentCars == null)
			chosenPoint.CurrentCars = new List<GameObject>();
		if (!chosenPoint.CurrentCars.Contains(chosenCar.gameObject))
			chosenPoint.CurrentCars.Add(chosenCar.gameObject);

		if (!prePopulate)
		{
			chosenPoint.Delay = UnityEngine.Random.Range(DelayRange.x, DelayRange.y);
		}
	}

	public void RemoveAndDeactivateCar(TrafficPoint point, CarAgent car)
	{
		if (point != null && point.CurrentCars != null && car != null)
		{
			point.CurrentCars.Remove(car.gameObject);
		}
		if (car != null && car.gameObject != null)
		{
			car.gameObject.SetActive(false);
		}
	}

	private void OnDrawGizmos()
	{
		if (TrafficPoints == null) return;
		Gizmos.color = Color.red;
		foreach (TrafficPoint pt in TrafficPoints)
		{
			if (pt == null || pt.PathPoints == null) continue;
			for (int i = 0; i < pt.PathPoints.Count - 1; i++)
			{
				if (pt.PathPoints[i] != null && pt.PathPoints[i + 1] != null)
				{
					Gizmos.DrawLine(pt.PathPoints[i].position, pt.PathPoints[i + 1].position);
				}
			}
		}
	}
}
