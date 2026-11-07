using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F3")]
public class FakePainterChallenge : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E330", Offset = "0x3E330")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__7_0;

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x17A2E2C", Offset = "0x17A2E2C", VA = "0x17A2E2C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x17A2E34", Offset = "0x17A2E34", VA = "0x17A2E34")]
		internal void _003CFakeControllerOnOnShoot_003Eb__7_0(float t)
		{
		}
	}

	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController FakeController;

	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController ActualController;

	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x28")]
	public RollingCowShooter Shooter;

	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x30")]
	public Animator CameraAnimator;

	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 StartShot;

	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x44")]
	private bool hasShot;

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x145C204", Offset = "0x145C204", VA = "0x145C204")]
	private void Start()
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x145C2B4", Offset = "0x145C2B4", VA = "0x145C2B4")]
	private void FakeControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x145C5F8", Offset = "0x145C5F8", VA = "0x145C5F8")]
	public FakePainterChallenge()
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x145C600", Offset = "0x145C600", VA = "0x145C600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F5DC", Offset = "0x5F5DC")]
	private void _003CFakeControllerOnOnShoot_003Eb__7_1()
	{
	}
}
