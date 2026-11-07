using System.Collections.Generic;
using UnityEngine;

public class BossFPGBarrier : MonoBehaviour
{
	public List<AudioClip> HitClips;

	public LayerMask AcceptedLayers;

	public Rigidbody BarTrans;

	public float MoveSpeed;

	private bool isUp;

	private bool nextState;

	private float changeStateTimer;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetTarget(bool goUp)
	{
	}
}
