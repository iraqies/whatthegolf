using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C1F")]
public class RainCloud2D : MonoBehaviour, IToggleable
{
	[Serializable]
	[Token(Token = "0x2000C20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FC0", Offset = "0x43FC0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40042E4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40042E5")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__10_0;

		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x1830220", Offset = "0x1830220", VA = "0x1830220")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x1830228", Offset = "0x1830228", VA = "0x1830228")]
		internal void _003CToggle_003Eb__10_0(float v)
		{
		}
	}

	[Token(Token = "0x40042DF")]
	[FieldOffset(Offset = "0x18")]
	public bool startOn;

	[Token(Token = "0x40042E0")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem particles;

	[Token(Token = "0x40042E1")]
	[FieldOffset(Offset = "0x28")]
	public float triggerDelay;

	[Token(Token = "0x40042E2")]
	[FieldOffset(Offset = "0x30")]
	public MonoBehaviour[] toggleBehaviours;

	[Token(Token = "0x40042E3")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5103C", Offset = "0x5103C")]
	private bool IsOn__BackingField;

	[Token(Token = "0x17000600")]
	public bool IsOn
	{
		[Token(Token = "0x6003A00")]
		[Address(RVA = "0x163EC00", Offset = "0x163EC00", VA = "0x163EC00", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B404", Offset = "0x6B404")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003A01")]
		[Address(RVA = "0x163EC08", Offset = "0x163EC08", VA = "0x163EC08", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B414", Offset = "0x6B414")]
		set
		{
		}
	}

	[Token(Token = "0x6003A02")]
	[Address(RVA = "0x163EC10", Offset = "0x163EC10", VA = "0x163EC10")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A03")]
	[Address(RVA = "0x163EE58", Offset = "0x163EE58", VA = "0x163EE58", Slot = "5")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6003A04")]
	[Address(RVA = "0x163EC28", Offset = "0x163EC28", VA = "0x163EC28", Slot = "7")]
	public void Toggle(bool status)
	{
	}

	[Token(Token = "0x6003A05")]
	[Address(RVA = "0x163EE68", Offset = "0x163EE68", VA = "0x163EE68")]
	public RainCloud2D()
	{
	}

	[Token(Token = "0x6003A06")]
	[Address(RVA = "0x163EE70", Offset = "0x163EE70", VA = "0x163EE70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B424", Offset = "0x6B424")]
	private void _003CToggle_003Eb__10_1()
	{
	}
}
