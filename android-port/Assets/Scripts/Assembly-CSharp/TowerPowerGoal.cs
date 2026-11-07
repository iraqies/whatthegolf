using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000276")]
[ExecuteAlways]
public class TowerPowerGoal : MonoBehaviour
{
	[Token(Token = "0x2000277")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E774", Offset = "0x3E774")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x10")]
		public TowerPowerGoal _003C_003E4__this;

		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x18")]
		public float start;

		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x1C")]
		public float power;

		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1869934", Offset = "0x1869934", VA = "0x1869934")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x186993C", Offset = "0x186993C", VA = "0x186993C")]
		internal void _003CChangeArrow_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1869A3C", Offset = "0x1869A3C", VA = "0x1869A3C")]
		internal void _003CChangeArrow_003Eb__1()
		{
		}
	}

	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4AF0C", Offset = "0x4AF0C")]
	public float TargetShotPower;

	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x1C")]
	public Color MinColor;

	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x2C")]
	public Color MaxColor;

	[Token(Token = "0x4000CEA")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve ColorCurve;

	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x48")]
	public Transform ArrowHeadJoint;

	[Token(Token = "0x4000CEC")]
	[FieldOffset(Offset = "0x50")]
	public Material ArrowMat;

	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection PowerIncreaseClip;

	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x60")]
	private float currentPower;

	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x64")]
	private float audioTimer;

	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x171F898", Offset = "0x171F898", VA = "0x171F898")]
	private void Update()
	{
	}

	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x171FAF4", Offset = "0x171FAF4", VA = "0x171FAF4")]
	public void ChangeArrow(float duration, float power)
	{
	}

	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x171F8E0", Offset = "0x171F8E0", VA = "0x171F8E0")]
	private void ChangeLength(float power)
	{
	}

	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x171F9AC", Offset = "0x171F9AC", VA = "0x171F9AC")]
	private void ChangeColor(float power)
	{
	}

	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x171FC84", Offset = "0x171FC84", VA = "0x171FC84")]
	public TowerPowerGoal()
	{
	}
}
