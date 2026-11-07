using System.Collections;
using Cinemachine;
using UnityEngine;

public class HammerProp : MonoBehaviour
{
	public LayerMask CollisionLayer;

	public ParticleSystem Particles;

	public Collider BorderCollider;

	public Collider PropCollider;

	public CinemachineVirtualCamera Camera;

	public bool StopRigidOnCollision;

	public bool DoShake;

	public HammerThrowingCamera HammerCamera;

	private Rigidbody rigid;

	private Vector3 lastVel;

	private CinemachineBasicMultiChannelPerlin noise;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		return null;
	}
}
