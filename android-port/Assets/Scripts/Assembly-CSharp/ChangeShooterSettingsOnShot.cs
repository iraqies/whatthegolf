using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B1")]
public class ChangeShooterSettingsOnShot : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20005B2")]
	public class ChangeShotData
	{
		[Token(Token = "0x4001D06")]
		[FieldOffset(Offset = "0x10")]
		public int ShotNumber;

		[Token(Token = "0x4001D07")]
		[FieldOffset(Offset = "0x18")]
		public Transform NewArrowPosition;

		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0x20")]
		public ShooterBase NewShooter;

		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x17833E0", Offset = "0x17833E0", VA = "0x17833E0")]
		public ChangeShotData()
		{
		}
	}

	[Token(Token = "0x4001D02")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4001D03")]
	[FieldOffset(Offset = "0x20")]
	public List<ChangeShotData> ChangeShotDatas;

	[Token(Token = "0x4001D04")]
	[FieldOffset(Offset = "0x28")]
	private int shots;

	[Token(Token = "0x4001D05")]
	[FieldOffset(Offset = "0x30")]
	private GolfBallShooterBase shooterBase;

	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x18985EC", Offset = "0x18985EC", VA = "0x18985EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x189869C", Offset = "0x189869C", VA = "0x189869C")]
	private void OnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x18987E4", Offset = "0x18987E4", VA = "0x18987E4")]
	public ChangeShooterSettingsOnShot()
	{
	}

	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x18987EC", Offset = "0x18987EC", VA = "0x18987EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x635F4", Offset = "0x635F4")]
	private bool _003COnShoot_003Eb__6_0(ChangeShotData s)
	{
		return default;
	}
}
