using System;
using System.Runtime.InteropServices;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000EF4")]
public class DailyPrize : MonoBehaviour
{
	[Token(Token = "0x40050C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CinemachineVirtualCamera cam;

	[Token(Token = "0x40050C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool Locked;

	[Token(Token = "0x40050CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject Wrapping;

	[Token(Token = "0x40050CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ToAnimate;

	[Token(Token = "0x40050CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject ToShakeAfterUnwrap;

	[Token(Token = "0x40050CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float afterUnwrapshakeAmplitude;

	[Token(Token = "0x40050CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x40050CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Rigidbody wrappingBoxRb;

	[Token(Token = "0x40050D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ParticleSystem PoofParticles;

	[Token(Token = "0x40050D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TextMeshPro StrokeText;

	[Token(Token = "0x40050D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject Counter;

	[Token(Token = "0x40050D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Rigidbody testRb;

	[Token(Token = "0x40050D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Animator prizeAnimator;

	[Token(Token = "0x40050D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float shakeAmplitude;

	[Token(Token = "0x40050D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float unwrapBoostThreshold;

	[Token(Token = "0x40050D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnimationCurve shakeOnAimCurve;

	[Token(Token = "0x40050D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Animator CounterAnimator;

	[Token(Token = "0x40050D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool isWrapped;

	[Token(Token = "0x40050DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	private bool isActive;

	[Token(Token = "0x40050DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action<Vector3> OnShootNotWrapped;

	[Token(Token = "0x40050DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Action<Vector3> OnShootWrapped;

	[Token(Token = "0x40050DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action<Vector3> OnAimNotWrapped;

	[Token(Token = "0x40050DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action<Vector3> OnUnpack;

	[Token(Token = "0x40050DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Action<Vector3> OnAimWrapped;

	[Token(Token = "0x40050E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action OnLoseFocus;

	[Token(Token = "0x40050E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Action OnGetFocus;

	[Token(Token = "0x40050E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Action<Vector3> OnUnpackImmidiate;

	[Token(Token = "0x40050E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool isInView;

	[Token(Token = "0x60045DD")]
	[Address(RVA = "0x18D2280", Offset = "0x18D2280", VA = "0x18D2280")]
	public void Activate(bool b)
	{
	}

	[Token(Token = "0x60045DE")]
	[Address(RVA = "0x18D23D8", Offset = "0x18D23D8", VA = "0x18D23D8")]
	public void StartUnlockAnimation()
	{
	}

	[Token(Token = "0x60045DF")]
	[Address(RVA = "0x18D23DC", Offset = "0x18D23DC", VA = "0x18D23DC")]
	public void UnWrap()
	{
	}

	[Token(Token = "0x60045E0")]
	[Address(RVA = "0x18D2598", Offset = "0x18D2598", VA = "0x18D2598")]
	private void SetControllerEnabled(bool b)
	{
	}

	[Token(Token = "0x60045E1")]
	[Address(RVA = "0x18D2814", Offset = "0x18D2814", VA = "0x18D2814")]
	private void BounceCounter(Vector3 s)
	{
	}

	[Token(Token = "0x60045E2")]
	[Address(RVA = "0x18D286C", Offset = "0x18D286C", VA = "0x18D286C")]
	public void Lock(bool permanentlyLocked = true)
	{
	}

	[Token(Token = "0x60045E3")]
	[Address(RVA = "0x18D2968", Offset = "0x18D2968", VA = "0x18D2968")]
	private void Awake()
	{
	}

	[Token(Token = "0x60045E4")]
	[Address(RVA = "0x18D29C4", Offset = "0x18D29C4", VA = "0x18D29C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60045E5")]
	[Address(RVA = "0x18D2ADC", Offset = "0x18D2ADC", VA = "0x18D2ADC")]
	private void SetUpWrapRb()
	{
	}

	[Token(Token = "0x60045E6")]
	[Address(RVA = "0x18D2BBC", Offset = "0x18D2BBC", VA = "0x18D2BBC")]
	public void AddEventToCounter(Action e)
	{
	}

	[Token(Token = "0x60045E7")]
	[Address(RVA = "0x18D2CBC", Offset = "0x18D2CBC", VA = "0x18D2CBC")]
	public void SetControllerActive(bool b)
	{
	}

	[Token(Token = "0x60045E8")]
	[Address(RVA = "0x18D22AC", Offset = "0x18D22AC", VA = "0x18D22AC")]
	public void UpdateController(bool isActive)
	{
	}

	[Token(Token = "0x60045E9")]
	[Address(RVA = "0x18C8A9C", Offset = "0x18C8A9C", VA = "0x18C8A9C")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60045EA")]
	[Address(RVA = "0x18D2664", Offset = "0x18D2664", VA = "0x18D2664")]
	private void ShootWrapping(Vector3 boost)
	{
	}

	[Token(Token = "0x60045EB")]
	[Address(RVA = "0x18C8DA8", Offset = "0x18C8DA8", VA = "0x18C8DA8")]
	public void OnAimStart()
	{
	}

	[Token(Token = "0x60045EC")]
	[Address(RVA = "0x18C8C58", Offset = "0x18C8C58", VA = "0x18C8C58")]
	public void OnAimUpdate(Vector3 boost)
	{
	}

	[Token(Token = "0x60045ED")]
	[Address(RVA = "0x18D2E24", Offset = "0x18D2E24", VA = "0x18D2E24")]
	private void AnimateBoxWhenAiming(Vector3 boost, [Optional] GameObject toShake)
	{
	}

	[Token(Token = "0x60045EE")]
	[Address(RVA = "0x18D2AC8", Offset = "0x18D2AC8", VA = "0x18D2AC8")]
	public void Place(bool isWrapped)
	{
	}

	[Token(Token = "0x60045EF")]
	[Address(RVA = "0x18D2D74", Offset = "0x18D2D74", VA = "0x18D2D74")]
	private void UnpackImmidiate(bool wrapIsActive = false)
	{
	}

	[Token(Token = "0x60045F0")]
	[Address(RVA = "0x18D3050", Offset = "0x18D3050", VA = "0x18D3050")]
	private void SetKinematic(bool b)
	{
	}

	[Token(Token = "0x60045F1")]
	[Address(RVA = "0x18D3108", Offset = "0x18D3108", VA = "0x18D3108")]
	public DailyPrize()
	{
	}
}
