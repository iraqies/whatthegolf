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
	private float afterUnwrapshakeAmplitude;

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
	private float shakeAmplitude;

	[SerializeField]
	private float unwrapBoostThreshold;

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
	}

	public void StartUnlockAnimation()
	{
	}

	public void UnWrap()
	{
	}

	private void SetControllerEnabled(bool b)
	{
	}

	private void BounceCounter(Vector3 s)
	{
	}

	public void Lock(bool permanentlyLocked = true)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetUpWrapRb()
	{
	}

	public void AddEventToCounter(Action e)
	{
	}

	public void SetControllerActive(bool b)
	{
	}

	public void UpdateController(bool isActive)
	{
	}

	public void OnShoot(Vector3 boost)
	{
	}

	private void ShootWrapping(Vector3 boost)
	{
	}

	public void OnAimStart()
	{
	}

	public void OnAimUpdate(Vector3 boost)
	{
	}

	private void AnimateBoxWhenAiming(Vector3 boost, GameObject toShake = null)
	{
	}

	public void Place(bool isWrapped)
	{
	}

	private void UnpackImmidiate(bool wrapIsActive = false)
	{
	}

	private void SetKinematic(bool b)
	{
	}
}
