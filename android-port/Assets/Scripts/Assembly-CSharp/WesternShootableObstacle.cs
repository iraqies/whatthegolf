using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6F")]
public class WesternShootableObstacle : MonoBehaviour, IHitscanTarget
{
	[Token(Token = "0x4004417")]
	[FieldOffset(Offset = "0x18")]
	public float forceOnHit;

	[Token(Token = "0x4004418")]
	[FieldOffset(Offset = "0x20")]
	private Collider2D m_collider;

	[Token(Token = "0x4004419")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D m_Rigidbody;

	[Token(Token = "0x400441A")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x511BC", Offset = "0x511BC")]
	private Action<IHitscanTarget> OnHitscanHit__BackingField;

	[Token(Token = "0x1700060C")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x1751DD0", Offset = "0x1751DD0", VA = "0x1751DD0", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B644", Offset = "0x6B644")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x1751DD8", Offset = "0x1751DD8", VA = "0x1751DD8", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B654", Offset = "0x6B654")]
		set
		{
		}
	}

	[Token(Token = "0x6003AFF")]
	[Address(RVA = "0x1751D50", Offset = "0x1751D50", VA = "0x1751D50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003B02")]
	[Address(RVA = "0x1751DE0", Offset = "0x1751DE0", VA = "0x1751DE0", Slot = "4")]
	public void OnHit(Vector3 point)
	{
	}

	[Token(Token = "0x6003B03")]
	[Address(RVA = "0x1751E94", Offset = "0x1751E94", VA = "0x1751E94")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003B04")]
	[Address(RVA = "0x1751F58", Offset = "0x1751F58", VA = "0x1751F58")]
	public WesternShootableObstacle()
	{
	}
}
