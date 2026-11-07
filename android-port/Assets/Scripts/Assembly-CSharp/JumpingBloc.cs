using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingBloc : MonoBehaviour
{
	public List<Rigidbody> objectsToDragInJump;

	public Vector3 jumpForce;

	private Rigidbody rb;

	private bool jumped;

	private void Start()
	{
	}

	public void Jump()
	{
	}

	private IEnumerator RemoveConstraints()
	{
		return null;
	}

	private void Update()
	{
	}
}
