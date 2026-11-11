using System.Collections.Generic;
using Core;
using UnityEngine;

public class FPGFlying : GolfBallShooterBase
{
	public Animator Animator;

	public float RotateSpeed;

	public float ModelRotateSpeed;

	public float SoarThreshold;

	public float FlySpeed;

	public float WalkSpeed;

	public float MaxSpeed;

	public float MaxDiveSpeed;

	public float GroundedDistance;

	public float ModelRotateAngleMax;

	public LayerMask GroundedLayers;

	public Transform Model;

	public Vector2 HeadRanges;

	public float MaxHeight;

	public float ExtraDownForceWhenNotFlying = 10f;

	public float TakeOffDotThreshold = 0.3f;

	public ParticleSystem DiveParticles;

	public List<AudioClip> FlyStartClips;

	public AudioSource DiveSource;

	private bool isFlying;

	private bool isSoaring;

	private bool isGrounded;

	private new Rigidbody rigid;

	private Vector3 flyDirection;

	private Quaternion startModelRotation;

	private float extraAnimationSpeed;

	private BoxCollider collider;

	private float headPos;

	private Vector3 lastDir;

	private bool lastFrameGrounded;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		collider = GetComponent<BoxCollider>();
		if (Model != null)
		{
			startModelRotation = Model.localRotation;
		}
		headPos = 0.5f;
		if (GolfBallController != null && GolfBallController.Level != null)
		{
			GolfBallController.Level.OnComplete += delegate
			{
				if (DiveSource != null)
				{
					DiveSource.Stop();
				}
			};
		}
	}

	public override void OnAimStart()
	{
		base.OnAimStart();
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(FlyStartClips, delegate(AudioSource s)
			{
				s.volume = 0.25f;
				s.pitch = Random.Range(0.95f, 1.05f);
			});
		}
	}

	private void Update()
	{
		if (GolfBallController == null || GolfBallController.mainCamera == null || Model == null)
		{
			return;
		}
		isGrounded = Physics.Raycast(base.transform.position, Vector3.down, GroundedDistance, GroundedLayers);
		if (isGrounded && !lastFrameGrounded && DiveSource != null)
		{
			DiveSource.Stop();
		}
		lastFrameGrounded = isGrounded;
		Vector3 forward = GolfBallController.mainCamera.transform.forward;
		float num = Vector3.Dot(forward, Vector3.down);
		isFlying = GolfBallController.IsAiming;
		isSoaring = num > SoarThreshold && !isGrounded;
		if (isFlying && isGrounded && Vector3.Dot(forward, Vector3.up) < TakeOffDotThreshold)
		{
			isFlying = false;
			if (Animator != null)
			{
				Animator.SetBool("Walking", true);
			}
			Vector3 normalized = new Vector3(forward.x, 0f, forward.z).normalized;
			if (normalized.sqrMagnitude > 0.0001f)
			{
				Model.rotation = Quaternion.LookRotation(normalized, Vector3.up);
			}
		}
		else if (Animator != null)
		{
			Animator.SetBool("Walking", false);
		}
		if (Animator != null)
		{
			Animator.SetBool("Flying", isFlying);
			Animator.SetBool("Soaring", isSoaring);
			Animator.SetBool("Grounded", isGrounded);
		}
		if (isFlying)
		{
			Quaternion to = Quaternion.LookRotation(forward, Vector3.up);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, to, RotateSpeed * Time.unscaledDeltaTime);
			Vector3 vector = Model.InverseTransformDirection(forward);
			Vector3 vector2 = Model.InverseTransformDirection(lastDir);
			float num2 = Mathf.Clamp((vector.x - vector2.x) * -2000f, 0f - ModelRotateAngleMax, ModelRotateAngleMax);
			Quaternion to2 = Quaternion.Euler(0f, 0f, num2);
			Model.localRotation = Quaternion.RotateTowards(Model.localRotation, to2, ModelRotateSpeed * Time.unscaledDeltaTime);
			if (num2 < -1f)
			{
				headPos = Mathf.MoveTowards(headPos, HeadRanges.x, Time.deltaTime);
			}
			else if (num2 > 1f)
			{
				headPos = Mathf.MoveTowards(headPos, HeadRanges.y, Time.deltaTime);
			}
			else
			{
				headPos = Mathf.MoveTowards(headPos, 0.5f, Time.deltaTime * 2f);
			}
			if (Animator != null)
			{
				Animator.SetFloat("HeadAngle", headPos);
			}
			lastDir = forward;
		}
		else if (!isGrounded)
		{
			headPos = Mathf.MoveTowards(headPos, 0.5f, Time.deltaTime);
			Model.localRotation = Quaternion.RotateTowards(Model.localRotation, startModelRotation, ModelRotateSpeed * Time.unscaledDeltaTime);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(Vector3.down, Vector3.up), RotateSpeed * 0.5f * Time.unscaledDeltaTime);
		}
		else
		{
			headPos = Mathf.MoveTowards(headPos, 0.5f, Time.deltaTime);
			Model.localRotation = Quaternion.RotateTowards(Model.localRotation, startModelRotation, ModelRotateSpeed * Time.unscaledDeltaTime);
			Vector3 forward2 = new Vector3(base.transform.forward.x, 0f, base.transform.forward.z);
			if (forward2.sqrMagnitude > 0.0001f)
			{
				base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(forward2, Vector3.up), RotateSpeed * Time.unscaledDeltaTime);
			}
		}
		if (DiveParticles != null)
		{
			if (isSoaring && isFlying)
			{
				DiveParticles.Play();
				if (DiveSource != null && !DiveSource.isPlaying)
				{
					DiveSource.Play();
				}
			}
			else
			{
				DiveParticles.Stop();
				if (DiveSource != null)
				{
					DiveSource.Stop();
				}
			}
		}
		if (Animator != null)
		{
			extraAnimationSpeed = Mathf.MoveTowards(extraAnimationSpeed, isFlying ? 1f : 0f, Time.unscaledDeltaTime);
			Animator.speed = 1f + extraAnimationSpeed;
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigid == null)
		{
			return;
		}
		if (isFlying)
		{
			rigid.AddForce(base.transform.forward * FlySpeed * Time.fixedUnscaledDeltaTime);
			float num = (isSoaring ? MaxDiveSpeed : MaxSpeed);
			if (rigid.velocity.magnitude > num)
			{
				rigid.velocity = rigid.velocity.normalized * num;
			}
		}
		else if (GolfBallController != null && GolfBallController.IsAiming && GolfBallController.mainCamera != null)
		{
			Vector3 forward = GolfBallController.mainCamera.transform.forward;
			Vector3 normalized = new Vector3(forward.x, 0f, forward.z).normalized;
			rigid.AddForce(normalized * WalkSpeed * Time.fixedUnscaledDeltaTime);
			if (rigid.velocity.magnitude > MaxSpeed)
			{
				rigid.velocity = rigid.velocity.normalized * MaxSpeed;
			}
		}
		else
		{
			rigid.AddForce(Vector3.down * ExtraDownForceWhenNotFlying * Time.fixedDeltaTime, ForceMode.Acceleration);
		}
		if (base.transform.position.y > MaxHeight && rigid.velocity.y > 0f)
		{
			rigid.velocity = new Vector3(rigid.velocity.x, 0f, rigid.velocity.z);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!isGrounded && other != null && other.contacts != null && other.contacts.Length != 0 && Model != null)
		{
			Vector3 forward = new Vector3(Model.forward.x, 0f, Model.forward.z);
			if (forward.sqrMagnitude > 0.0001f)
			{
				base.transform.rotation = Quaternion.LookRotation(forward, other.contacts[0].normal);
			}
			Model.localRotation = Quaternion.identity;
		}
	}
}
