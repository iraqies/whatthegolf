using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000394")]
public class EndAreaMusicZone : MonoBehaviour
{
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x18")]
	public uint OnEnterRTPC;

	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x20")]
	public Transform StartTarget;

	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x28")]
	public Transform EndTarget;

	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x30")]
	public float startValue;

	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x34")]
	public float endValue;

	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x38")]
	public Action<EndAreaMusicZone> OnZoneEntered;

	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CDD0", Offset = "0x4CDD0")]
	private bool AreaActive__BackingField;

	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x48")]
	private OverworldBall2D ball;

	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x50")]
	private float m_maxDistance;

	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x54")]
	private float m_lastUpdateTime;

	[Token(Token = "0x40013C4")]
	private const float m_updateRate = 0.12f;

	[Token(Token = "0x17000203")]
	public bool AreaActive
	{
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x1443734", Offset = "0x1443734", VA = "0x1443734")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175C", Offset = "0x6175C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x144373C", Offset = "0x144373C", VA = "0x144373C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6176C", Offset = "0x6176C")]
		private set
		{
		}
	}

	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x1443744", Offset = "0x1443744", VA = "0x1443744")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x1443874", Offset = "0x1443874", VA = "0x1443874")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x1443924", Offset = "0x1443924", VA = "0x1443924")]
	private void Update()
	{
	}

	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x14439E4", Offset = "0x14439E4", VA = "0x14439E4")]
	private void SetByDistance(int ms)
	{
	}

	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x1443AA8", Offset = "0x1443AA8", VA = "0x1443AA8")]
	public EndAreaMusicZone()
	{
	}
}
