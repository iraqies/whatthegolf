using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class Karaoke2DShooter : ShooterBase
{
	[SerializeField]
	private float forwardSpeed;

	[SerializeField]
	private float jumpSpeed;

	[SerializeField]
	private float checkY;

	[SerializeField]
	private float checkLength;

	[SerializeField]
	private float checkRadius;

	[SerializeField]
	private float fallLimit;

	[SerializeField]
	private float groundSkin;

	[SerializeField]
	private float failY;

	private Vector2 velocity;

	private Vector2 gravity;

	private bool isGrounded;

	[CompilerGenerated]
	private Action m_OnBeginForwardMovement;

	private bool isMoving;

	public bool IsGrounded => false;

	public event Action OnBeginForwardMovement
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	private float GetGroundY(float checkX)
	{
		return 0f;
	}

	public void Update()
	{
	}
}
