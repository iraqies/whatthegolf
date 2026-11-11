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

	public bool StopRigidOnCollision = true;

	public bool DoShake = true;

	public HammerThrowingCamera HammerCamera;

	private Rigidbody rigid;

	private Vector3 lastVel;

	private CinemachineBasicMultiChannelPerlin noise;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		if (BorderCollider != null && PropCollider != null)
		{
			Physics.IgnoreCollision(BorderCollider, PropCollider);
		}
		if (Camera != null)
		{
			noise = Camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
		}
	}

	private void FixedUpdate()
	{
		if (rigid != null)
		{
			lastVel = rigid.velocity;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null || ((1 << other.gameObject.layer) & CollisionLayer.value) == 0)
		{
			return;
		}
		if (rigid == null)
		{
			rigid = GetComponent<Rigidbody>();
		}
		if (StopRigidOnCollision && rigid != null)
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		if (Particles != null)
		{
			if (other.contacts != null && other.contacts.Length > 0)
			{
				Particles.transform.rotation = Quaternion.LookRotation(other.contacts[0].normal);
			}
			Particles.Play();
		}
		if (DoShake)
		{
			StartCoroutine(Shake(2f, 2f, 0.25f));
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (HammerCamera != null && other != null && other.CompareTag("CameraTrigger"))
		{
			HammerCamera.ForceReset(true);
		}
	}

	private IEnumerator Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		if (noise == null)
		{
			yield break;
		}
		noise.m_AmplitudeGain = amplitudeGain;
		noise.m_FrequencyGain = frequencyGain;
		yield return StartCoroutine(pTween.To(duration, t =>
		{
			if (noise != null)
			{
				noise.m_AmplitudeGain = Mathf.Lerp(amplitudeGain, 0f, t);
				noise.m_FrequencyGain = Mathf.Lerp(frequencyGain, 0f, t);
			}
		}));
		if (noise != null)
		{
			noise.m_AmplitudeGain = 0f;
			noise.m_FrequencyGain = 0f;
		}
	}
}
