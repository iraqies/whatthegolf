using UnityEngine;

public class SnowBallGrowOnRoll : MonoBehaviour
{
	public ParticleSystem Particles;

	public float GrowRate;

	public float TrailSize;

	public float MassGrowRate;

	public Transform trans;

	private Rigidbody rigid;

	private ParticleSystem.MainModule main;

	private bool onGround;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}
}
