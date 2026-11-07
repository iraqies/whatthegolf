using UnityEngine;

public class HorseAutoJump2D : MonoBehaviour
{
	[SerializeField]
	private Rigidbody2D m_RigidbodyRoot;

	[SerializeField]
	private Rigidbody2D[] m_ApplyToRigidbodies;

	[SerializeField]
	private Transform m_GroundCheckPosition;

	[SerializeField]
	private float m_JumpCooldownMin;

	[SerializeField]
	private float m_JumpCooldownMax;

	[SerializeField]
	private float m_DirectionChangeCooldown;

	[SerializeField]
	private float m_JumpForce;

	[SerializeField]
	private float forwardVelocity;

	private float m_JumpCooldown;

	private float m_lastJumpTime;

	private float m_lastDirectionChangeTime;

	private int m_xDirection;

	private int m_lastDirection;

	private bool isGrounded;

	private void FixedUpdate()
	{
	}
}
