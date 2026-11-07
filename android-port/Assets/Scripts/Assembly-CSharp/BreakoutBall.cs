using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class BreakoutBall : MonoBehaviour
{
	public enum TransferVelocityMode
	{
		X = 0,
		Y = 1,
		XY = 2
	}

	public GolfBallController player;

	public float velTransferMagnitude;

	public float maxVel;

	public float maxHits;

	public AnimationCurve velocityEvolution;

	public float startNormalVel;

	public float minPlayAxisVel;

	public List<AudioClip> ShootSounds;

	public TransferVelocityMode velTransferMode;

	private Rigidbody2D rigid;

	private Vector2 lastVel;

	private Rigidbody2D playerRigid;

	private Vector2 lastPlayerVel;

	private Vector2 startOffset;

	private float startRot;

	private int hits;

	private float currentMaxVel;

	public string playerTag;

	public UnityAction OnTouchBat;

	private void Start()
	{
	}

	private void Player_OnShoot(Vector3 dir)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void CollideWithPlayer(Vector2 ballVel, Vector2 playerVel, Vector2 normal)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
