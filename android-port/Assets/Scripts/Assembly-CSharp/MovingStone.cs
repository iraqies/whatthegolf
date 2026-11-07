using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone : MonoBehaviour
{
	public bool isSuperPutt;

	public float tweenTime;

	public float offsetTime;

	public float waitTime;

	public List<Transform> targets;

	public AudioSource audioSource;

	public List<AudioClip> clipAtEnd;

	private Rigidbody2D rigid;

	private List<Vector3> targetPositions;

	private Coroutine lastRoutine;

	private bool didInitialize;

	private Rigidbody2D ball;

	private Vector2 lastBallPos;

	private float totalBallMovement;

	private float volume;

	private float pitch;

	public void Initialize()
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void FixedUpdate()
	{
	}

	private IEnumerator Routine()
	{
		return null;
	}
}
