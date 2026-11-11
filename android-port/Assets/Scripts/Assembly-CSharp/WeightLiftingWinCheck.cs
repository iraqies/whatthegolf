using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class WeightLiftingWinCheck : MonoBehaviour
{
	public float SleepMagnitude = 1f;

	public BoxCollider2D WinZone;

	public Collider2D BarCol;

	public List<Collider2D> ResetColliders;

	public List<Transform> WinPoints;

	public ClipSettingsCollection sfxOnWin;

	private Rigidbody2D rigid;

	private Vector3 startPos;

	private Quaternion startRot;

	private float nextGruntSfxTime;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		startPos = transform.position;
		startRot = transform.rotation;
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other != WinZone || rigid == null || rigid.velocity.magnitude > SleepMagnitude || WinPoints == null || WinZone == null)
		{
			return;
		}
		bool allInside = true;
		foreach (Transform pt in WinPoints)
		{
			if (pt != null)
			{
				Vector3 checkPos = new Vector3(pt.position.x, pt.position.y, WinZone.transform.position.z);
				allInside &= WinZone.bounds.Contains(checkPos);
			}
		}
		if (allInside && Level.Instance != null)
		{
			if (Level.Instance.Ball != null && Level.Instance.Ball.enabled && sfxOnWin != null)
			{
				sfxOnWin.Play(null, Vector3.zero, 1f, 1f);
			}
			if (Level.Instance.Goal != null)
			{
				Level.Instance.Goal.Complete();
			}
			if (Level.Instance.Ball != null)
			{
				Level.Instance.Ball.enabled = false;
			}
			rigid.isKinematic = true;
			rigid.velocity = Vector2.zero;
			rigid.angularVelocity = 0f;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (ResetColliders != null && ResetColliders.Contains(other))
		{
			Reset();
		}
	}

	private void Reset()
	{
		transform.position = startPos;
		transform.rotation = startRot;
	}
}
