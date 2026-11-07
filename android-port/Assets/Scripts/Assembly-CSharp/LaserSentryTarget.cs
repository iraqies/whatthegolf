using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000869")]
public class LaserSentryTarget : MonoBehaviour
{
	[Token(Token = "0x4002DEA")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F394", Offset = "0x4F394")]
	private Action m_OnLasered;

	[Token(Token = "0x4002DEB")]
	[FieldOffset(Offset = "0x20")]
	public float extraExplosionForce;

	[Token(Token = "0x4002DEC")]
	[FieldOffset(Offset = "0x24")]
	public float extraUpForce;

	[Token(Token = "0x4002DED")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody[] rigids;

	[Token(Token = "0x14000036")]
	public event Action OnLasered
	{
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x151DFE4", Offset = "0x151DFE4", VA = "0x151DFE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66E20", Offset = "0x66E20")]
		add
		{
		}
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x151E088", Offset = "0x151E088", VA = "0x151E088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66E30", Offset = "0x66E30")]
		remove
		{
		}
	}

	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x151E12C", Offset = "0x151E12C", VA = "0x151E12C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x151E188", Offset = "0x151E188", VA = "0x151E188")]
	public void Laser(Vector3 position, float radius)
	{
	}

	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x151E298", Offset = "0x151E298", VA = "0x151E298")]
	public LaserSentryTarget()
	{
	}
}
