using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008A2")]
public class ShootingGalleryTarget : MonoBehaviour, IHitscanTarget, IAudioEvent
{
	[Token(Token = "0x4002F69")]
	[FieldOffset(Offset = "0x18")]
	public bool Hit;

	[Token(Token = "0x4002F6A")]
	[FieldOffset(Offset = "0x19")]
	public bool IsGoal;

	[Token(Token = "0x4002F6B")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask AcceptedHitLayers;

	[Token(Token = "0x4002F6C")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F53C", Offset = "0x4F53C")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x1700043A")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x16A3824", Offset = "0x16A3824", VA = "0x16A3824", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67034", Offset = "0x67034")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x16A382C", Offset = "0x16A382C", VA = "0x16A382C", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67044", Offset = "0x67044")]
		set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x16A3834", Offset = "0x16A3834", VA = "0x16A3834", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x16A3874", Offset = "0x16A3874", VA = "0x16A3874", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x16A38B4", Offset = "0x16A38B4", VA = "0x16A38B4", Slot = "4")]
	public void OnHit(Vector3 point)
	{
	}

	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x16A39A0", Offset = "0x16A39A0", VA = "0x16A39A0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x16A3A6C", Offset = "0x16A3A6C", VA = "0x16A3A6C")]
	public ShootingGalleryTarget()
	{
	}
}
