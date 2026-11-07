using System.Collections.Generic;
using UnityEngine;

public class SendRigidBodiesFlying : MonoBehaviour
{
	public List<Rigidbody> rbListToPush;

	public Vector3 force;

	public Vector3 torque;

	public Vector3 randomAmplitude;

	public Vector3 randomTorque;

	private Vector3 randomVector;

	public void Jump()
	{
	}
}
