using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class OnShotActionList : MonoBehaviour
{
	public GolfBallController controller;

	public float delay;

	public List<UnityEvent> events;

	private int indx;

	private void Start()
	{
		if (events.Count > 0)
		{
			controller.OnShoot += OnShoot;
		}
	}

	public void UpdateController(GolfBallController newController)
	{
		if (controller != null)
		{
			controller.OnShoot -= OnShoot;
		}
		controller = newController;
		controller.OnShoot += OnShoot;
	}

	private void OnShoot(Vector3 v)
	{
		StartCoroutine(Do());
		indx = (indx + 1) % events.Count;
	}

	private IEnumerator Do()
	{
		yield return new WaitForSeconds(delay);
		events[indx].Invoke();
	}
}
