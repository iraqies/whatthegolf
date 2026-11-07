using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyPrizeToaster : BaseDailyPrizeInteractions
{
	[SerializeField]
	private GameObject ToastPrefab;

	[SerializeField]
	private Rigidbody ToasterBody;

	[SerializeField]
	private Vector3 up;

	[SerializeField]
	private float forceMultiplyer;

	[SerializeField]
	private List<Transform> ToastPositions;

	private List<Rigidbody> toasts;

	[SerializeField]
	private float rnTorque;

	[SerializeField]
	private float minForce;

	private bool canShoot;

	private void Start()
	{
	}

	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	private void AddToast(Transform p)
	{
	}

	private IEnumerator AddToastRoutine(Transform p)
	{
		return null;
	}

	private IEnumerator ShootToastRoutine(Vector3 b)
	{
		return null;
	}

	private IEnumerator DestroyAfter(GameObject g)
	{
		return null;
	}

	private void ResetToasts()
	{
	}

	private float Mag(Vector3 b)
	{
		return 0f;
	}

	private float rnV3(float r)
	{
		return 0f;
	}

	public void ShootToast(Vector3 b)
	{
	}

	private Vector3 Dir(Rigidbody r)
	{
		return default;
	}
}
