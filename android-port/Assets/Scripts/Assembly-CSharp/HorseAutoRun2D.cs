using UnityEngine;

public class HorseAutoRun2D : MonoBehaviour
{
	[SerializeField]
	private Rigidbody2D m_RigidbodyRoot;

	[SerializeField]
	private Rigidbody2D[] m_ApplyToRigidbodies;

	[SerializeField]
	private Transform m_GroundCheckPosition;

	[SerializeField]
	private float m_JumpCooldown;

	[SerializeField]
	private float m_JumpForce;

	[SerializeField]
	private float forwardVelocity;

	[SerializeField]
	private float steadyForwardVelocity;

	private float m_lastJumpTime;

	private bool isGrounded;

	private void FixedUpdate()
	{
	}
}
