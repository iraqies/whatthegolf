using System;
using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000982")]
public class OverworldMainDoorPlate : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x2000983")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x424D8", Offset = "0x424D8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003466")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003467")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameObject> _003C_003E9__27_0;

		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x1814404", Offset = "0x1814404", VA = "0x1814404")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x181440C", Offset = "0x181440C", VA = "0x181440C")]
		internal void _003CStart_003Eb__27_0(GameObject o)
		{
		}
	}

	[Token(Token = "0x4003453")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FCDC", Offset = "0x4FCDC")]
	private Action<bool, bool> m_OnStateChange;

	[Token(Token = "0x4003454")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FCEC", Offset = "0x4FCEC")]
	private Action m_OnInit;

	[Token(Token = "0x4003455")]
	[FieldOffset(Offset = "0x30")]
	public bool isOn;

	[Token(Token = "0x4003456")]
	[FieldOffset(Offset = "0x34")]
	public Color colorOn;

	[Token(Token = "0x4003457")]
	[FieldOffset(Offset = "0x44")]
	public Color colorOff;

	[Token(Token = "0x4003458")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer sprite;

	[Token(Token = "0x4003459")]
	[FieldOffset(Offset = "0x60")]
	public GameObject DoorIsClosed;

	[Token(Token = "0x400345A")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DoorIsOpen;

	[Token(Token = "0x400345B")]
	[FieldOffset(Offset = "0x70")]
	public GameObject LevelsComplete;

	[Token(Token = "0x400345C")]
	[FieldOffset(Offset = "0x78")]
	public GameObject CrownsComplete;

	[Token(Token = "0x400345D")]
	[FieldOffset(Offset = "0x80")]
	public Transform returningBallTransform;

	[Token(Token = "0x400345E")]
	[FieldOffset(Offset = "0x88")]
	public PlateInfoManager plateInfo;

	[Token(Token = "0x400345F")]
	[FieldOffset(Offset = "0x90")]
	public Animator animator;

	[Token(Token = "0x4003460")]
	[FieldOffset(Offset = "0x98")]
	public OverworldMainDoorRobot computer;

	[Token(Token = "0x4003461")]
	[FieldOffset(Offset = "0xA0")]
	public PlayClipOnAudioEvent SFX_TurnOn;

	[Token(Token = "0x4003462")]
	[FieldOffset(Offset = "0xA8")]
	public bool DontColorSprite;

	[Token(Token = "0x4003463")]
	[FieldOffset(Offset = "0xA9")]
	public bool isMovingBallOut;

	[Token(Token = "0x4003464")]
	[FieldOffset(Offset = "0xAA")]
	public bool isInitialized;

	[Token(Token = "0x4003465")]
	[FieldOffset(Offset = "0xB0")]
	public List<GameObject> ReversableObjects;

	[Token(Token = "0x14000042")]
	public event Action<bool, bool> OnStateChange
	{
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x15BD8E0", Offset = "0x15BD8E0", VA = "0x15BD8E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67FC4", Offset = "0x67FC4")]
		add
		{
		}
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x15BD984", Offset = "0x15BD984", VA = "0x15BD984")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67FD4", Offset = "0x67FD4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000043")]
	public event Action OnInit
	{
		[Token(Token = "0x6002C7D")]
		[Address(RVA = "0x15B2554", Offset = "0x15B2554", VA = "0x15B2554")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67FE4", Offset = "0x67FE4")]
		add
		{
		}
		[Token(Token = "0x6002C7E")]
		[Address(RVA = "0x15B2740", Offset = "0x15B2740", VA = "0x15B2740")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67FF4", Offset = "0x67FF4")]
		remove
		{
		}
	}

	[Token(Token = "0x6002C7F")]
	[Address(RVA = "0x15BDA28", Offset = "0x15BDA28", VA = "0x15BDA28", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002C80")]
	[Address(RVA = "0x15B3340", Offset = "0x15B3340", VA = "0x15B3340")]
	public void SetState(bool on, bool onLoad = false)
	{
	}

	[Token(Token = "0x6002C81")]
	[Address(RVA = "0x15BDADC", Offset = "0x15BDADC", VA = "0x15BDADC")]
	public void ChangeState(bool isOn, bool isLoad)
	{
	}

	[Token(Token = "0x6002C82")]
	[Address(RVA = "0x15BDB54", Offset = "0x15BDB54", VA = "0x15BDB54")]
	public void Initialize(OverworldMainDoorRobot overworldMainDoorRobot)
	{
	}

	[Token(Token = "0x6002C83")]
	[Address(RVA = "0x15BDB74", Offset = "0x15BDB74", VA = "0x15BDB74")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C84")]
	[Address(RVA = "0x15BDDE4", Offset = "0x15BDDE4", VA = "0x15BDDE4")]
	private void ChangeState(PlateInfoManager.AreaState state)
	{
	}

	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x15BDF84", Offset = "0x15BDF84", VA = "0x15BDF84")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002C86")]
	[Address(RVA = "0x15BE0B4", Offset = "0x15BE0B4", VA = "0x15BE0B4")]
	public OverworldMainDoorPlate()
	{
	}
}
