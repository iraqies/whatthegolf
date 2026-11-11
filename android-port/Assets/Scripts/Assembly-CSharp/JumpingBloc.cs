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
		rb = GetComponent<Rigidbody>();
	}

	public void Jump()
	{
		StopAllCoroutines();
		for (int i = 0; i < objectsToDragInJump.Count; i++)
		{
			objectsToDragInJump[i].constraints = (RigidbodyConstraints)58;
			objectsToDragInJump[i].AddForce(jumpForce, ForceMode.VelocityChange);
		}
		StartCoroutine(RemoveConstraints());
	}

	private IEnumerator RemoveConstraints()
	{
		yield return new WaitForSeconds(2.5f);
		jumped = true;
	}

	private void Update()
	{
		if (jumped)
		{
			for (int i = 0; i < objectsToDragInJump.Count; i++)
			{
				objectsToDragInJump[i].velocity = Vector3.zero;
				objectsToDragInJump[i].angularVelocity = Vector3.zero;
				objectsToDragInJump[i].constraints = RigidbodyConstraints.None;
			}
			jumped = false;
		}
	}
}
