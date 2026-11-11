using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class BadlandsChickenCounter : MonoBehaviour
{
	public float CameraMinSpeed = 5f;

	public List<BadlandsChicken> Chickens;

	private void Start()
	{
		foreach (BadlandsChicken chicken in Chickens)
		{
			chicken.OnDeath = (Action<BadlandsChicken>)Delegate.Combine(chicken.OnDeath, new Action<BadlandsChicken>(OnDeath));
		}
	}

	private void OnDeath(BadlandsChicken deadChicken)
	{
		Chickens.Remove(deadChicken);
		if (Chickens.Count == 0)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	private void Update()
	{
		float num = Vector3.right.x * Time.deltaTime * CameraMinSpeed;
		foreach (BadlandsChicken chicken in Chickens)
		{
			if (chicken.GetScreenPosX() >= 0.3f)
			{
				num = Mathf.Max(num, (chicken.transform.position.x - CameraManager.Instance.transform.position.x) * Time.deltaTime * CameraMinSpeed);
			}
		}
		CameraManager.Instance.transform.position += new Vector3(num, 0f, 0f);
	}
}
