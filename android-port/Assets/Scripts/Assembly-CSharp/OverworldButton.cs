using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x20009E7")]
public class OverworldButton : MonoBehaviour
{
	[Token(Token = "0x400366B")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5008C", Offset = "0x5008C")]
	private Action<OverworldButton> m_OnPress;

	[Token(Token = "0x400366C")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro missingFlagsText;

	[Token(Token = "0x400366D")]
	[FieldOffset(Offset = "0x28")]
	public Collider wallCollider;

	[Token(Token = "0x400366E")]
	[FieldOffset(Offset = "0x30")]
	public Renderer CylinderSide;

	[Token(Token = "0x400366F")]
	[FieldOffset(Offset = "0x38")]
	public Renderer CylinderEnd;

	[Token(Token = "0x4003670")]
	[FieldOffset(Offset = "0x40")]
	public Material activeSide;

	[Token(Token = "0x4003671")]
	[FieldOffset(Offset = "0x48")]
	public Material activeEnd;

	[Token(Token = "0x4003672")]
	[FieldOffset(Offset = "0x50")]
	public Material inactiveSide;

	[Token(Token = "0x4003673")]
	[FieldOffset(Offset = "0x58")]
	public Material inactiveEnd;

	[Token(Token = "0x14000057")]
	public event Action<OverworldButton> OnPress
	{
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x15A843C", Offset = "0x15A843C", VA = "0x15A843C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AD8", Offset = "0x68AD8")]
		add
		{
		}
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x15A84E0", Offset = "0x15A84E0", VA = "0x15A84E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AE8", Offset = "0x68AE8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x15A8584", Offset = "0x15A8584", VA = "0x15A8584")]
	private void Start()
	{
	}

	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x15A874C", Offset = "0x15A874C", VA = "0x15A874C")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x15A8758", Offset = "0x15A8758", VA = "0x15A8758")]
	private void OverworldButton_OnBallHit()
	{
	}

	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x15A87B8", Offset = "0x15A87B8", VA = "0x15A87B8")]
	public void SetBridgeStatus(bool isActive)
	{
	}

	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x15A8824", Offset = "0x15A8824", VA = "0x15A8824")]
	public OverworldButton()
	{
	}
}
