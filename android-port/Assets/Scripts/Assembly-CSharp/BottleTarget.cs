using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000895")]
public class BottleTarget : MonoBehaviour, IHitscanTarget
{
	[Token(Token = "0x4002F1E")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnHitUnityEvent;

	[Token(Token = "0x4002F1F")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F50C", Offset = "0x4F50C")]
	private Action<IHitscanTarget> OnHitscanHit__BackingField;

	[Token(Token = "0x17000431")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x1701E44", Offset = "0x1701E44", VA = "0x1701E44", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66F34", Offset = "0x66F34")]
		get
		{
			return null;
		}
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x1701E4C", Offset = "0x1701E4C", VA = "0x1701E4C", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66F44", Offset = "0x66F44")]
		set
		{
		}
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0x1701E54", Offset = "0x1701E54", VA = "0x1701E54", Slot = "4")]
	public void OnHit(Vector3 point)
	{
	}

	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x1701E68", Offset = "0x1701E68", VA = "0x1701E68")]
	public BottleTarget()
	{
	}
}
