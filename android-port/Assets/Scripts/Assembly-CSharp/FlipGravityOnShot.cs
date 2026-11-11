using System.Collections.Generic;
using Core;
using Menu;
using UnityEngine;

public class FlipGravityOnShot : MonoBehaviour
{
	public Transform RoomFollow;

	private ConstantForce2D[] constantForces;

	private Dictionary<Rigidbody2D, ResetInfo2D> savedResetInfo = new Dictionary<Rigidbody2D, ResetInfo2D>();

	private bool savedGravity;

	private bool inverseGravity;

	private InGameMenu menu;

	private bool savePosition;

	private void Start()
	{
		menu = Object.FindObjectOfType<InGameMenu>();
		savedResetInfo = new Dictionary<Rigidbody2D, ResetInfo2D>();
		Rigidbody2D[] rbs = gameObject.GetComponentsInChildren<Rigidbody2D>();
		if (rbs != null)
		{
			for (int i = 0; i < rbs.Length; i++)
			{
				if (rbs[i] != null && !savedResetInfo.ContainsKey(rbs[i]))
				{
					savedResetInfo.Add(rbs[i], new ResetInfo2D
					{
						Position = rbs[i].position,
						Rotation = rbs[i].rotation,
						Velocity = rbs[i].velocity,
						AngularVelocity = rbs[i].angularVelocity
					});
				}
			}
		}
		if (Level.Instance != null && Level.Instance.Ball != null)
		{
			Level.Instance.Ball.OnShoot += InstanceOnOnGolfStroke;
		}
		constantForces = GetComponentsInChildren<ConstantForce2D>();
	}

	private void InstanceOnOnGolfStroke(Vector3 i)
	{
		if (savePosition && savedResetInfo != null)
		{
			foreach (KeyValuePair<Rigidbody2D, ResetInfo2D> kvp in savedResetInfo)
			{
				if (kvp.Key != null && kvp.Value != null)
				{
					kvp.Value.Position = kvp.Key.position;
					kvp.Value.Rotation = kvp.Key.rotation;
					kvp.Value.Velocity = kvp.Key.velocity;
					kvp.Value.AngularVelocity = kvp.Key.angularVelocity;
				}
			}
			savedGravity = inverseGravity;
			savePosition = false;
		}
		FlipGravity();
	}

	public void SetRoomPosition(Transform room)
	{
		if (RoomFollow != null && room != null)
		{
			RoomFollow.position = room.position;
		}
		savePosition = true;
	}

	public void ResetAtCurrentScreen()
	{
		if (savedResetInfo != null)
		{
			foreach (KeyValuePair<Rigidbody2D, ResetInfo2D> kvp in savedResetInfo)
			{
				if (kvp.Key != null && kvp.Value != null)
				{
					kvp.Key.position = kvp.Value.Position;
					kvp.Key.rotation = kvp.Value.Rotation;
					kvp.Key.velocity = kvp.Value.Velocity;
					kvp.Key.angularVelocity = kvp.Value.AngularVelocity;
				}
			}
		}
		if (inverseGravity != savedGravity)
		{
			FlipGravity();
		}
	}

	private void FlipGravity()
	{
		inverseGravity = !inverseGravity;
		Physics2D.gravity = -Physics2D.gravity;
		if (constantForces != null)
		{
			for (int i = 0; i < constantForces.Length; i++)
			{
				if (constantForces[i] != null)
				{
					constantForces[i].force = -constantForces[i].force;
				}
			}
		}
	}

	private void OnDestroy()
	{
		if (inverseGravity)
		{
			Physics2D.gravity = -Physics2D.gravity;
			inverseGravity = false;
		}
	}
}
