using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class OverworldBallInGravityHelper : MonoBehaviour
{
	public LayerMask wallLayerMask;

	public float raycastDistance;

	public bool useCustomStopThreshold;

	public float customStopThreshold;

	public AudioClipSettings sfxOnUp;

	public AudioClipSettings sfxOnRight;

	public AudioClipSettings sfxOnDown;

	public AudioClipSettings sfxOnLeft;

	private float baseStopThreshold;

	private OverworldBall2D ball;

	private GolfBallController controller;

	private int shotsSinceGrounded;

	private int maxInAirShots;

	private Vector2 currentWindDirection;

	private List<WindArea2D> zones;

	private float stillTime;

	private Vector3 lastPosition;

	private float stillThreshold;

	private void Awake()
	{
	}

	private void Controller_OnPreShoot(Vector3 obj)
	{
	}

	private void FixedUpdate()
	{
	}

	private bool IsGrounded()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	public void EnterGravityZone(WindArea2D zone, int zoneMaxInAirShots)
	{
	}

	public void ExitGravityZone(WindArea2D zone)
	{
	}

	private bool isInGravityZone()
	{
		return false;
	}
}
