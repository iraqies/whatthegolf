using UnityEngine;

public class SnowBallGrowOnRoll : MonoBehaviour
{
	public ParticleSystem Particles;

	public float GrowRate;

	public float TrailSize;

	public float MassGrowRate = 1f;

	public Transform trans;

	private Rigidbody rigid;

	private ParticleSystem.MainModule main;

	private bool onGround;

	private void Awake()
	{
		if (trans == null)
		{
			trans = base.transform;
		}
		rigid = GetComponent<Rigidbody>();
		if (Particles != null)
		{
			main = Particles.main;
		}
	}

	private void FixedUpdate()
	{
		if (!onGround || trans == null || rigid == null)
		{
			return;
		}
		trans.localScale += Vector3.one * rigid.angularVelocity.magnitude * GrowRate;
		if (Particles != null)
		{
			main.startSizeMultiplier = trans.localScale.magnitude * TrailSize;
		}
		rigid.mass = trans.localScale.magnitude * MassGrowRate;
	}

	private void OnCollisionStay(Collision other)
	{
		onGround = true;
		if (Particles != null && !Particles.isEmitting)
		{
			Particles.Play();
		}
	}

	private void OnCollisionExit(Collision other)
	{
		onGround = false;
		if (Particles != null && Particles.isPlaying)
		{
			Particles.Stop();
		}
	}
}
