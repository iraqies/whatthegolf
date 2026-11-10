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
	private Vector3 up = Vector3.up;

	[SerializeField]
	private float forceMultiplyer;

	[SerializeField]
	private List<Transform> ToastPositions;

	private List<Rigidbody> toasts = new List<Rigidbody>();

	[SerializeField]
	private float rnTorque;

	[SerializeField]
	private float minForce;

	private bool canShoot = true;

	private void Start()
	{
		ResetToasts();
	}

	public override void OnShootNotWrapped(Vector3 b)
	{
		if (canShoot)
		{
			StartCoroutine(ShootToastRoutine(b));
		}
	}

	private void AddToast(Transform p)
	{
		StartCoroutine(AddToastRoutine(p));
	}

	private IEnumerator AddToastRoutine(Transform p)
	{
		if (ToastPrefab != null && p != null)
		{
			GameObject inst = Instantiate(ToastPrefab, p);
			Rigidbody rb = inst.GetComponent<Rigidbody>();
			Joint joint = inst.GetComponentInChildren<Joint>();
			if (joint != null)
			{
				joint.enablePreprocessing = false;
				joint.connectedBody = ToasterBody;
			}
			if (toasts != null && rb != null)
			{
				toasts.Add(rb);
			}
		}
		yield return new WaitForSeconds(0.25f);
		canShoot = true;
	}

	private IEnumerator ShootToastRoutine(Vector3 b)
	{
		float m = Mag(b);
		canShoot = false;
		if (toasts != null)
		{
			toasts.ForEach(rb =>
			{
				if (rb != null)
					rb.isKinematic = false;
			});
			toasts.ForEach(rb =>
			{
				if (rb != null)
				{
					var j = rb.gameObject.GetComponent<Joint>();
					if (j != null)
						Destroy(j);
				}
			});
			toasts.ForEach(rb =>
			{
				if (rb != null)
				{
					rb.AddForce(Dir(rb) * m * forceMultiplyer, ForceMode.Impulse);
				}
			});
		}
		yield return new WaitForSeconds(0.2f);
		if (toasts != null)
		{
			toasts.ForEach(rb =>
			{
				if (rb != null)
				{
					rb.AddTorque(new Vector3(rnV3(rnTorque), rnV3(rnTorque), rnV3(rnTorque)) * m, ForceMode.Acceleration);
				}
			});
			toasts.ForEach(rb =>
			{
				if (rb != null)
				{
					StartCoroutine(DestroyAfter(rb.gameObject));
				}
			});
		}
		yield return new WaitForSeconds(0.1f);
		ResetToasts();
	}

	private IEnumerator DestroyAfter(GameObject g)
	{
		yield return new WaitForSeconds(3f);
		yield return StartCoroutine(pTween.To(0.2f, 0f, 1f, t =>
		{
			if (g != null)
			{
				g.transform.localScale = Vector3.Lerp(g.transform.localScale, Vector3.zero, Mathf.Clamp01(t));
			}
		}));
		if (g != null)
		{
			Destroy(g);
		}
	}

	private void ResetToasts()
	{
		if (toasts == null)
			toasts = new List<Rigidbody>();
		toasts.Clear();
		if (ToastPositions != null)
		{
			ToastPositions.ForEach(AddToast);
		}
		canShoot = true;
	}

	private float Mag(Vector3 b)
	{
		return Mathf.Max(minForce, b.magnitude);
	}

	private float rnV3(float r)
	{
		return Random.Range(-r, r);
	}

	public void ShootToast(Vector3 b)
	{
		if (canShoot)
		{
			StartCoroutine(ShootToastRoutine(b));
		}
	}

	private Vector3 Dir(Rigidbody r)
	{
		return up.normalized;
	}
}
