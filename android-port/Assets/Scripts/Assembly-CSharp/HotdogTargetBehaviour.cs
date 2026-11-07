using System;
using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000300")]
public class HotdogTargetBehaviour : MonoBehaviour
{
	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator Animator;

	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject HeldThing;

	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject HotdogPrefab;

	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x38")]
	public Action<HotdogTargetBehaviour> OnCollapsed;

	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0x40")]
	public AudioEventAsset sfxEventOnCollapse;

	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0x48")]
	public AudioEventAsset sfxOnSpeedup;

	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private DollyCartController FollowTarget;

	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float SpeedMod;

	[Token(Token = "0x40010AE")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float RotateAnimationSpeed;

	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float MoveSpeed;

	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float RotateSpeed;

	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x68")]
	public bool hasCollapsed;

	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x70")]
	private List<Color> saturation;

	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x14DCD64", Offset = "0x14DCD64", VA = "0x14DCD64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x14DCE28", Offset = "0x14DCE28", VA = "0x14DCE28")]
	public void Collapse()
	{
	}

	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x14DD030", Offset = "0x14DD030", VA = "0x14DD030")]
	private void Desaturate()
	{
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x14DD158", Offset = "0x14DD158", VA = "0x14DD158")]
	private void Saturate()
	{
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x14DD23C", Offset = "0x14DD23C", VA = "0x14DD23C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x14DD2B8", Offset = "0x14DD2B8", VA = "0x14DD2B8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x14DD2BC", Offset = "0x14DD2BC", VA = "0x14DD2BC")]
	public HotdogTargetBehaviour()
	{
	}
}
