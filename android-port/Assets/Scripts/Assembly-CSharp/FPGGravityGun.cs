using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006F2")]
public class FPGGravityGun : MonoBehaviour
{
	[Token(Token = "0x20006F3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x411F0", Offset = "0x411F0")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x400247F")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody root;

		[Token(Token = "0x6002015")]
		[Address(RVA = "0x17A2490", Offset = "0x17A2490", VA = "0x17A2490")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6002016")]
		[Address(RVA = "0x17A2498", Offset = "0x17A2498", VA = "0x17A2498")]
		internal bool _003COnAimUpdate_003Eb__0(SpringJoint j)
		{
			return default;
		}
	}

	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x400246F")]
	[FieldOffset(Offset = "0x20")]
	public List<LineRenderer> Trail;

	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x28")]
	public List<ParticleSystem> Particles;

	[Token(Token = "0x4002471")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0x38")]
	public float GravityGunRotateSpeed;

	[Token(Token = "0x4002473")]
	[FieldOffset(Offset = "0x3C")]
	public float LineWidth;

	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0x40")]
	public float PulseSpeed;

	[Token(Token = "0x4002475")]
	[FieldOffset(Offset = "0x44")]
	public int MaxHeldObjectsSize;

	[Token(Token = "0x4002476")]
	[FieldOffset(Offset = "0x48")]
	public float Range;

	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0x4C")]
	public float BeamSize;

	[Token(Token = "0x4002478")]
	[FieldOffset(Offset = "0x50")]
	public float SuckForce;

	[Token(Token = "0x4002479")]
	[FieldOffset(Offset = "0x54")]
	public LayerMask AffectedLayers;

	[Token(Token = "0x400247A")]
	[FieldOffset(Offset = "0x58")]
	public float ShootForce;

	[Token(Token = "0x400247B")]
	[FieldOffset(Offset = "0x5C")]
	public float CaptureDistance;

	[Token(Token = "0x400247C")]
	[FieldOffset(Offset = "0x60")]
	private List<SpringJoint> joints;

	[Token(Token = "0x400247D")]
	[FieldOffset(Offset = "0x68")]
	private bool isSucking;

	[Token(Token = "0x400247E")]
	[FieldOffset(Offset = "0x6C")]
	private float currentSizeSum;

	[Token(Token = "0x600200E")]
	[Address(RVA = "0x1457DC8", Offset = "0x1457DC8", VA = "0x1457DC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600200F")]
	[Address(RVA = "0x1457FD4", Offset = "0x1457FD4", VA = "0x1457FD4")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6002010")]
	[Address(RVA = "0x1457FD8", Offset = "0x1457FD8", VA = "0x1457FD8")]
	private void OnAimUpdate(Vector3 boost, bool onlyAim)
	{
	}

	[Token(Token = "0x6002011")]
	[Address(RVA = "0x1458484", Offset = "0x1458484", VA = "0x1458484")]
	private void OnAimStart()
	{
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0x1458494", Offset = "0x1458494", VA = "0x1458494")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0x1458710", Offset = "0x1458710", VA = "0x1458710")]
	private void Update()
	{
	}

	[Token(Token = "0x6002014")]
	[Address(RVA = "0x1458ED4", Offset = "0x1458ED4", VA = "0x1458ED4")]
	public FPGGravityGun()
	{
	}
}
