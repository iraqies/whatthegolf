using System.Collections.Generic;
using Menu;
using UnityEngine;

public class FlipGravityOnShot : MonoBehaviour
{
	public Transform RoomFollow;

	private ConstantForce2D[] constantForces;

	private Dictionary<Rigidbody2D, ResetInfo2D> savedResetInfo;

	private bool savedGravity;

	private bool inverseGravity;

	private InGameMenu menu;

	private bool savePosition;

	private void Start()
	{
	}

	private void InstanceOnOnGolfStroke(Vector3 i)
	{
	}

	public void SetRoomPosition(Transform room)
	{
	}

	public void ResetAtCurrentScreen()
	{
	}

	private void FlipGravity()
	{
	}
}
