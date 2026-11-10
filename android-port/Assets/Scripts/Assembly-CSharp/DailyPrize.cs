using System;
using Cinemachine;
using Core;
using TMPro;
using UnityEngine;

public class DailyPrize : MonoBehaviour
{
	public CinemachineVirtualCamera cam;

	[SerializeField]
	private bool Locked;

	[SerializeField]
	private GameObject Wrapping;

	[SerializeField]
	private GameObject ToAnimate;

	[SerializeField]
	private GameObject ToShakeAfterUnwrap;

	[SerializeField]
	private float afterUnwrapshakeAmplitude = 1f;

	[SerializeField]
	private GolfBallController controller;

	private Rigidbody wrappingBoxRb;

	[SerializeField]
	private ParticleSystem PoofParticles;

	[SerializeField]
	private TextMeshPro StrokeText;

	[SerializeField]
	private GameObject Counter;

	[SerializeField]
	private Rigidbody testRb;

	[SerializeField]
	private Animator prizeAnimator;

	[SerializeField]
	private float shakeAmplitude = 0.2f;

	[SerializeField]
	private float unwrapBoostThreshold = 1.5f;

	[SerializeField]
	private AnimationCurve shakeOnAimCurve;

	private Animator CounterAnimator;

	public bool isWrapped;

	private bool isActive;

	public Action<Vector3> OnShootNotWrapped;

	public Action<Vector3> OnShootWrapped;

	public Action<Vector3> OnAimNotWrapped;

	public Action<Vector3> OnUnpack;

	public Action<Vector3> OnAimWrapped;

	public Action OnLoseFocus;

	public Action OnGetFocus;

	public Action<Vector3> OnUnpackImmidiate;

	private bool isInView;

	public void Activate(bool b)
	{
		isInView = b;
		if (cam != null)
		{
			cam.Priority = b ? 10 : 0;
		}
	}

	public void StartUnlockAnimation()
	{
	}

	public void UnWrap()
	{
		if (!isWrapped)
			return;

		isWrapped = false;
		var wrapAnim = gameObject.GetComponent("DailyPrizeWrapAnimator");
		if (wrapAnim != null)
		{
			Destroy(wrapAnim);
		}
		SetControllerEnabled(true);
		if (controller != null)
		{
			controller.OnShoot -= BounceCounter;
		}
		Locked = false;
		ShootWrapping(Vector3.zero);
		OnUnpack?.Invoke(Vector3.zero);
	}

	private void SetControllerEnabled(bool b)
	{
		if (controller != null)
		{
			controller.enabled = b;
		}
	}

	private void BounceCounter(Vector3 s)
	{
		if (CounterAnimator != null)
		{
			CounterAnimator.SetTrigger("Bounce");
		}
	}

	public void Lock(bool permanentlyLocked = true)
	{
		Locked = permanentlyLocked;
		isWrapped = true;
		SetControllerEnabled(false);
		if (controller != null)
		{
			controller.OnShoot += BounceCounter;
		}
	}

	private void Awake()
	{
		controller = GetComponent<GolfBallController>();
	}

	private void Start()
	{
		if (testRb != null)
		{
			isWrapped = true;
			SetKinematic(true);
		}
		SetUpWrapRb();
		if (Counter != null)
		{
			CounterAnimator = Counter.GetComponent<Animator>();
		}
	}

	private void SetUpWrapRb()
	{
		if (Wrapping == null)
			return;

		wrappingBoxRb = Wrapping.GetComponentInChildren<Rigidbody>();
		if (wrappingBoxRb != null)
		{
			wrappingBoxRb.angularDrag = 1f;
			wrappingBoxRb.isKinematic = true;
		}
	}

	public void AddEventToCounter(Action e)
	{
		if (Counter != null)
		{
			var countdown = Counter.transform.GetComponentInChildren<DailyCountdown>();
			if (countdown != null)
			{
				countdown.OnCountdownZero += e;
			}
		}
	}

	public void SetControllerActive(bool b)
	{
		if (controller == null)
			return;

		if (!b)
		{
			controller.StopAiming();
		}
		SetControllerEnabled(b);
	}

	public void UpdateController(bool isActive)
	{
		if (!isWrapped)
		{
			if (!isActive && this.isActive)
			{
				OnLoseFocus?.Invoke();
			}
			if (isActive && !this.isActive)
			{
				OnGetFocus?.Invoke();
			}
		}
		this.isActive = isActive;
		if (!isActive && controller != null && controller.shootArrow != null)
		{
			controller.shootArrow.gameObject.SetActive(false);
		}
		SetControllerEnabled(isActive);
		if (controller != null && controller.shooter != null)
		{
			controller.shooter.enabled = isActive;
		}
	}

	public void OnShoot(Vector3 boost)
	{
		if (isWrapped)
		{
			OnShootWrapped?.Invoke(boost);
		}
		else
		{
			OnShootNotWrapped?.Invoke(boost);
		}
		if (ToShakeAfterUnwrap != null)
		{
			ToShakeAfterUnwrap.transform.localPosition = Vector3.zero;
		}
	}

	private void ShootWrapping(Vector3 boost)
	{
		if (boost.magnitude <= unwrapBoostThreshold)
		{
			boost = new Vector3(0.4f, 0f, 0.9f);
		}
		if (PoofParticles != null)
		{
			PoofParticles.Play();
		}
		UnpackImmidiate(true);
		if (ToAnimate != null)
		{
			ToAnimate.transform.localScale = Vector3.one;
			ToAnimate.transform.localPosition = Vector3.zero;
		}
		if (wrappingBoxRb != null)
		{
			wrappingBoxRb.isKinematic = false;
			wrappingBoxRb.useGravity = true;
			wrappingBoxRb.AddForce(boost * 100f + Vector3.up * 60f, ForceMode.VelocityChange);
			wrappingBoxRb.AddRelativeTorque(new Vector3(boost.x * 10f, boost.y * 10f, boost.z * 10f), ForceMode.VelocityChange);
		}
	}

	public void OnAimStart()
	{
	}

	public void OnAimUpdate(Vector3 boost)
	{
		if (isWrapped)
		{
			if (!Locked)
			{
				AnimateBoxWhenAiming(boost, null);
				OnAimWrapped?.Invoke(boost);
				return;
			}
		}
		else if (!Locked && ToShakeAfterUnwrap != null)
		{
			AnimateBoxWhenAiming(boost, ToShakeAfterUnwrap);
			return;
		}
		OnAimNotWrapped?.Invoke(boost);
	}

	private void AnimateBoxWhenAiming(Vector3 boost, GameObject toShake = null)
	{
		float mag = boost.magnitude;
		float amp;
		if (toShake != null)
		{
			amp = afterUnwrapshakeAmplitude;
		}
		else
		{
			toShake = ToAnimate;
			if (toShake == null)
				return;
			amp = shakeAmplitude;
			float scaleOffset = mag * 0.3f;
			toShake.transform.localScale = new Vector3(1f + scaleOffset, 1f - scaleOffset, 1f + scaleOffset);
		}

		if (toShake == null)
			return;

		Vector3 fwd = toShake.transform.forward;
		float eval = shakeOnAimCurve != null ? shakeOnAimCurve.Evaluate((amp * Time.time * 4f) % 1f) : 0f;
		toShake.transform.localPosition = fwd * (amp * eval * mag);
		Vector3 lp = toShake.transform.localPosition;
		lp.y += mag * -0.13f;
		toShake.transform.localPosition = lp;
	}

	public void Place(bool isWrapped)
	{
		this.isWrapped = isWrapped;
		if (isWrapped)
		{
			SetKinematic(true);
		}
		else
		{
			UnpackImmidiate(false);
		}
	}

	private void UnpackImmidiate(bool wrapIsActive = false)
	{
		if (Wrapping != null)
		{
			Wrapping.SetActive(wrapIsActive);
		}
		if (Counter != null)
		{
			Counter.SetActive(false);
		}
		SetKinematic(false);
		OnUnpackImmidiate?.Invoke(Vector3.zero);
	}

	private void SetKinematic(bool b)
	{
		var rbs = GetComponentsInChildren<Rigidbody>();
		if (rbs != null)
		{
			for (int i = 0; i < rbs.Length; i++)
			{
				if (rbs[i] != null)
				{
					rbs[i].isKinematic = b;
				}
			}
		}
	}
}
