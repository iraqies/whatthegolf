using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000B10")]
public class MouseSpringAction : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000B11")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x434D8", Offset = "0x434D8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003DD6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003DD7")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__8_0;

		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x17F9280", Offset = "0x17F9280", VA = "0x17F9280")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x17F9288", Offset = "0x17F9288", VA = "0x17F9288")]
		internal void _003CFixedUpdate_003Eb__8_0(AudioSource t)
		{
		}
	}

	[Token(Token = "0x4003DD0")]
	[FieldOffset(Offset = "0x18")]
	public SpringJoint2D joint;

	[Token(Token = "0x4003DD1")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnFullPull;

	[Token(Token = "0x4003DD2")]
	[FieldOffset(Offset = "0x28")]
	public float InvokeThreshold;

	[Token(Token = "0x4003DD3")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> ReleaseSounds;

	[Token(Token = "0x4003DD4")]
	[FieldOffset(Offset = "0x38")]
	private float origDistance;

	[Token(Token = "0x4003DD5")]
	[FieldOffset(Offset = "0x3C")]
	private float delay;

	[Token(Token = "0x60034D1")]
	[Address(RVA = "0x1570464", Offset = "0x1570464", VA = "0x1570464")]
	private void Awake()
	{
	}

	[Token(Token = "0x60034D2")]
	[Address(RVA = "0x15704D4", Offset = "0x15704D4", VA = "0x15704D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60034D3")]
	[Address(RVA = "0x15704F8", Offset = "0x15704F8", VA = "0x15704F8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034D4")]
	[Address(RVA = "0x1570720", Offset = "0x1570720", VA = "0x1570720")]
	public MouseSpringAction()
	{
	}
}
