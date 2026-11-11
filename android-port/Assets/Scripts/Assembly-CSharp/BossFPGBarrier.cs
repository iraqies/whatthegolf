using System.Collections.Generic;
using UnityEngine;

public class BossFPGBarrier : MonoBehaviour
{
	public List<AudioClip> HitClips;

	public LayerMask AcceptedLayers;

	public Rigidbody BarTrans;

	public float MoveSpeed = 10f;

	private bool isUp;

	private bool nextState;

	private float changeStateTimer;

	private void OnCollisionEnter(Collision collision)
	{
		if ((int)AcceptedLayers == ((int)AcceptedLayers | (1 << collision.gameObject.layer)))
		{
			isUp = true;
			nextState = true;
			changeStateTimer = 1000000f;
		}
	}

	private void OnDisable()
	{
		isUp = false;
		BarTrans.MoveRotation(Quaternion.Euler(BarTrans.rotation.eulerAngles.x, BarTrans.rotation.eulerAngles.y, 90f));
		changeStateTimer = 0f;
		nextState = false;
	}

	private void FixedUpdate()
	{
		BarTrans.MoveRotation(Quaternion.RotateTowards(BarTrans.rotation, Quaternion.Euler(BarTrans.rotation.eulerAngles.x, BarTrans.rotation.eulerAngles.y, isUp ? 15f : 90f), MoveSpeed * Time.fixedDeltaTime));
		if (changeStateTimer > 0f)
		{
			changeStateTimer -= Time.fixedDeltaTime;
			if (changeStateTimer <= 0f)
			{
				isUp = nextState;
			}
		}
	}

	public void SetTarget(bool goUp)
	{
		if (changeStateTimer > 0f)
		{
			nextState = goUp;
		}
		else
		{
			isUp = goUp;
		}
		changeStateTimer = 0.5f;
	}
}
