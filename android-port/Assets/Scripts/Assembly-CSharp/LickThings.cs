using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000705")]
public class LickThings : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000706")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41210", Offset = "0x41210")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Rigidbody, float> _003C_003E9__12_0;

		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Rigidbody, float> _003C_003E9__12_1;

		[Token(Token = "0x600206C")]
		[Address(RVA = "0x17E921C", Offset = "0x17E921C", VA = "0x17E921C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600206D")]
		[Address(RVA = "0x17E9224", Offset = "0x17E9224", VA = "0x17E9224")]
		internal float _003COnTriggerEnter_003Eb__12_0(Rigidbody r)
		{
			return default;
		}

		[Token(Token = "0x600206E")]
		[Address(RVA = "0x17E9240", Offset = "0x17E9240", VA = "0x17E9240")]
		internal float _003COnTriggerEnter_003Eb__12_1(Rigidbody r)
		{
			return default;
		}
	}

	[Token(Token = "0x40024E3")]
	[FieldOffset(Offset = "0x18")]
	public List<AudioClip> LickSFX;

	[Token(Token = "0x40024E4")]
	[FieldOffset(Offset = "0x20")]
	public float SpringForcePerKilo;

	[Token(Token = "0x40024E5")]
	[FieldOffset(Offset = "0x28")]
	public Collider StartLickedObject;

	[Token(Token = "0x40024E6")]
	[FieldOffset(Offset = "0x30")]
	public List<string> BlacklistTag;

	[Token(Token = "0x40024E7")]
	[FieldOffset(Offset = "0x38")]
	public Renderer TongueRenderer;

	[Token(Token = "0x40024E8")]
	[FieldOffset(Offset = "0x40")]
	private LineRope rope;

	[Token(Token = "0x40024E9")]
	[FieldOffset(Offset = "0x48")]
	private SpringJoint joint;

	[Token(Token = "0x40024EA")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody currentlyLicked;

	[Token(Token = "0x40024EB")]
	[FieldOffset(Offset = "0x58")]
	private GameObject tongueLineEnd;

	[Token(Token = "0x6002066")]
	[Address(RVA = "0x15311CC", Offset = "0x15311CC", VA = "0x15311CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002067")]
	[Address(RVA = "0x15312AC", Offset = "0x15312AC", VA = "0x15312AC")]
	private void LickThings_OnReset()
	{
	}

	[Token(Token = "0x6002068")]
	[Address(RVA = "0x1531394", Offset = "0x1531394", VA = "0x1531394")]
	private void Start()
	{
	}

	[Token(Token = "0x6002069")]
	[Address(RVA = "0x1531480", Offset = "0x1531480", VA = "0x1531480")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600206A")]
	[Address(RVA = "0x1531B64", Offset = "0x1531B64", VA = "0x1531B64")]
	public LickThings()
	{
	}
}
