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
	}

	public void UpdateController(GolfBallController newController)
	{
	}

	private void OnShoot(Vector3 v)
	{
	}

	private IEnumerator Do()
	{
		return null;
	}
}
