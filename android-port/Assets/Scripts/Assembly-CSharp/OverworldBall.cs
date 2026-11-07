using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009DE")]
public class OverworldBall : MonoBehaviour
{
	[Token(Token = "0x400362F")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5000C", Offset = "0x5000C")]
	private Action<OverworldArea> m_OnEnterArea;

	[Token(Token = "0x4003630")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5001C", Offset = "0x5001C")]
	private Action<OverworldArea> m_OnExitArea;

	[Token(Token = "0x4003631")]
	[FieldOffset(Offset = "0x28")]
	public float clampYPosition;

	[Token(Token = "0x4003632")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x14000051")]
	public event Action<OverworldArea> OnEnterArea
	{
		[Token(Token = "0x6002E73")]
		[Address(RVA = "0x15A1A2C", Offset = "0x15A1A2C", VA = "0x15A1A2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A18", Offset = "0x68A18")]
		add
		{
		}
		[Token(Token = "0x6002E74")]
		[Address(RVA = "0x15A1AD0", Offset = "0x15A1AD0", VA = "0x15A1AD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A28", Offset = "0x68A28")]
		remove
		{
		}
	}

	[Token(Token = "0x14000052")]
	public event Action<OverworldArea> OnExitArea
	{
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x15A1B74", Offset = "0x15A1B74", VA = "0x15A1B74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A38", Offset = "0x68A38")]
		add
		{
		}
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x15A1C18", Offset = "0x15A1C18", VA = "0x15A1C18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A48", Offset = "0x68A48")]
		remove
		{
		}
	}

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x15A1CBC", Offset = "0x15A1CBC", VA = "0x15A1CBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x15A1D38", Offset = "0x15A1D38", VA = "0x15A1D38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x15A1DF4", Offset = "0x15A1DF4", VA = "0x15A1DF4")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x15A1EDC", Offset = "0x15A1EDC", VA = "0x15A1EDC")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0x15A1FC4", Offset = "0x15A1FC4", VA = "0x15A1FC4")]
	public OverworldBall()
	{
	}
}
