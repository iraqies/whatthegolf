using UnityEngine;

public class Sheep : MonoBehaviour
{
	private Rigidbody2D rigid;

	public BlockShotIfNotGrounded grounding;

	public Vector2 force;

	public float cooldownDuration;

	public float lastImpulseTime;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
