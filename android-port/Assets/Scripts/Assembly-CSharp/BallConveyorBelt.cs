using System.Collections.Generic;
using UnityEngine;

public class BallConveyorBelt : MonoBehaviour
{
	public Transform BeltStart;

	public Transform BeltEnd;

	public GameObject BeltTransporter;

	public float Spacing;

	public float MoveSpeed;

	private List<Rigidbody> transporters;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
