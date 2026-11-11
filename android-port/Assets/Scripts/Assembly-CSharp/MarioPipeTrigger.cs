using System.Collections;
using CameraStack;
using Core;
using UnityEngine;

public class MarioPipeTrigger : ChallengeTriggerBase
{
	public Vector3 downDirection = Vector3.down;

	public Transform midPointTop;

	public Collider midCollider;

	public Collider[] ignoreWith;

	public CameraBehavior overrideCameraBehaviour;

	private GolfBallShooterBase shooter;

	private void Awake()
	{
		if (midCollider == null)
		{
			midCollider = GetComponent<Collider>();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
		{
			return;
		}
		GolfBallShooterBase s = collision.gameObject.GetComponent<GolfBallShooterBase>();
		if (s != null && s.GolfBallController != null)
		{
			shooter = s;
			shooter.GolfBallController.OnPreShoot += OnShoot;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
		{
			return;
		}
		GolfBallShooterBase s = collision.gameObject.GetComponent<GolfBallShooterBase>();
		if (s != null && s == shooter)
		{
			if (shooter.GolfBallController != null)
			{
				shooter.GolfBallController.OnPreShoot -= OnShoot;
			}
			shooter = null;
		}
	}

	private void OnShoot(Vector3 obj)
	{
		if (shooter == null)
		{
			return;
		}
		if (Vector3.Dot(obj.normalized, downDirection.normalized) > 0.5f)
		{
			StartCoroutine(PipeRoutine());
		}
	}

	private IEnumerator PipeRoutine()
	{
		if (shooter == null)
		{
			yield break;
		}
		Rigidbody rb = shooter.GetComponent<Rigidbody>();
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.DisableInteraction(true);
		}
		if (rb != null)
		{
			rb.isKinematic = true;
		}
		if (midCollider != null)
		{
			midCollider.enabled = false;
		}
		Collider[] playerCols = shooter.GetComponentsInChildren<Collider>();
		if (ignoreWith != null && playerCols != null)
		{
			for (int i = 0; i < ignoreWith.Length; i++)
			{
				for (int j = 0; j < playerCols.Length; j++)
				{
					if (ignoreWith[i] != null && playerCols[j] != null)
					{
						Physics.IgnoreCollision(ignoreWith[i], playerCols[j], true);
					}
				}
			}
		}
		if (midPointTop != null && rb != null)
		{
			while ((rb.position - midPointTop.position).magnitude > 0.1f)
			{
				rb.MovePosition(Vector3.MoveTowards(rb.position, midPointTop.position, Time.deltaTime * 5f));
				yield return null;
			}
		}
		float timer = 0f;
		while (timer < 0.5f && rb != null)
		{
			timer += Time.deltaTime;
			rb.MovePosition(rb.position + downDirection.normalized * (Time.deltaTime * 5f));
			yield return null;
		}
		if (rb != null)
		{
			rb.isKinematic = false;
		}
		if (overrideCameraBehaviour != null && CameraManager.Instance != null)
		{
			CameraManager.Instance.SwitchBehavior(overrideCameraBehaviour);
		}
		OnTrigger?.Invoke(this);
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
		}
	}
}
