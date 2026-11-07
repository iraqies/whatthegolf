using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A50")]
public class MainComputerSpeechbubble : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A51")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42C70", Offset = "0x42C70")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003901")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003902")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldMainDoorPlate, bool> _003C_003E9__8_0;

		[Token(Token = "0x4003903")]
		[FieldOffset(Offset = "0x10")]
		public static Func<OverworldMainDoorPlate, bool> _003C_003E9__11_0;

		[Token(Token = "0x600312B")]
		[Address(RVA = "0x17F14E8", Offset = "0x17F14E8", VA = "0x17F14E8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600312C")]
		[Address(RVA = "0x17F14F0", Offset = "0x17F14F0", VA = "0x17F14F0")]
		internal bool _003CRobot_OnPlateChanged_003Eb__8_0(OverworldMainDoorPlate p)
		{
			return default;
		}

		[Token(Token = "0x600312D")]
		[Address(RVA = "0x17F1508", Offset = "0x17F1508", VA = "0x17F1508")]
		internal bool _003CUpddateSpeechBubbles_003Eb__11_0(OverworldMainDoorPlate p)
		{
			return default;
		}
	}

	[Token(Token = "0x40038FB")]
	[FieldOffset(Offset = "0x20")]
	public List<SpeechbubbleList> textOnIndicatorOn;

	[Token(Token = "0x40038FC")]
	[FieldOffset(Offset = "0x28")]
	public SpeechbubbleList textOnHitBeforeIndicators;

	[Token(Token = "0x40038FD")]
	[FieldOffset(Offset = "0x30")]
	public SpeechbubbleList textOnHitWithSomeIndicators;

	[Token(Token = "0x40038FE")]
	[FieldOffset(Offset = "0x38")]
	public SpeechbubbleList textOnHitWithAllIndicators;

	[Token(Token = "0x40038FF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ShowSpeechbubbleOnHit hitbubble;

	[Token(Token = "0x4003900")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverworldMainDoorRobot robot;

	[Token(Token = "0x6003122")]
	[Address(RVA = "0x1555A54", Offset = "0x1555A54", VA = "0x1555A54", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6003123")]
	[Address(RVA = "0x1555AE0", Offset = "0x1555AE0", VA = "0x1555AE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003124")]
	[Address(RVA = "0x1555B74", Offset = "0x1555B74", VA = "0x1555B74")]
	private void Robot_OnPlateChanged()
	{
	}

	[Token(Token = "0x6003125")]
	[Address(RVA = "0x1555FD4", Offset = "0x1555FD4", VA = "0x1555FD4")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003126")]
	[Address(RVA = "0x155616C", Offset = "0x155616C", VA = "0x155616C")]
	private void Robot_OnIsReady()
	{
	}

	[Token(Token = "0x6003127")]
	[Address(RVA = "0x1555E0C", Offset = "0x1555E0C", VA = "0x1555E0C")]
	private void UpddateSpeechBubbles()
	{
	}

	[Token(Token = "0x6003128")]
	[Address(RVA = "0x1556170", Offset = "0x1556170", VA = "0x1556170")]
	public MainComputerSpeechbubble()
	{
	}

	[Token(Token = "0x6003129")]
	[Address(RVA = "0x1556178", Offset = "0x1556178", VA = "0x1556178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x697E4", Offset = "0x697E4")]
	private void _003CRobot_OnPlateChanged_003Eb__8_1()
	{
	}
}
