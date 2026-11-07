using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C9")]
public class RigidbodyCollisionInfo : MonoBehaviour
{
	[Token(Token = "0x40014C8")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D1B0", Offset = "0x4D1B0")]
	private bool CanSendActualObjectHit__BackingField;

	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x20")]
	private HitInfo hitInfo;

	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0x58")]
	private TriggerInfo triggerInfo;

	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x78")]
	public Action<HitInfo> onCollision;

	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x80")]
	public Action<TriggerInfo> onTrigger;

	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x88")]
	public Action<Collider> OnTrigger3D;

	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x90")]
	public Action<Collider2D> OnTrigger2D;

	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x98")]
	public Action<Collision> CollisionEnter3D;

	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0xA0")]
	public Action<Collision2D> CollisionEnter2D;

	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0xA8")]
	public Action<Collision> CollisionExit3D;

	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0xB0")]
	public Action<Collision2D> CollisionExit2D;

	[Token(Token = "0x17000215")]
	public bool CanSendActualObjectHit
	{
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x16572F4", Offset = "0x16572F4", VA = "0x16572F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6C", Offset = "0x61A6C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x16572FC", Offset = "0x16572FC", VA = "0x16572FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7C", Offset = "0x61A7C")]
		set
		{
		}
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x1657304", Offset = "0x1657304", VA = "0x1657304")]
	public static RigidbodyCollisionInfo GetOrAdd(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x1657408", Offset = "0x1657408", VA = "0x1657408")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x1657624", Offset = "0x1657624", VA = "0x1657624")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x1657694", Offset = "0x1657694", VA = "0x1657694")]
	private void OnCollisionExit2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x1657704", Offset = "0x1657704", VA = "0x1657704")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x16577F0", Offset = "0x16577F0", VA = "0x16577F0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x1657A00", Offset = "0x1657A00", VA = "0x1657A00")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x1657AEC", Offset = "0x1657AEC", VA = "0x1657AEC")]
	public RigidbodyCollisionInfo()
	{
	}
}
