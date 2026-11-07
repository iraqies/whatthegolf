using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200030E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3EE4C", Offset = "0x3EE4C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3EE4C", Offset = "0x3EE4C")]
public class PortalsAsDoors : GolfBehaviour
{
	[Token(Token = "0x200030F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EEE8", Offset = "0x3EEE8")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x40010E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Bounds flagContainerBounds;

		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x182AB7C", Offset = "0x182AB7C", VA = "0x182AB7C")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x182AB84", Offset = "0x182AB84", VA = "0x182AB84")]
		internal bool _003COnPrePlayOrPreCompile_003Eb__0(OverworldGoal g)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000310")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EEF8", Offset = "0x3EEF8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40010E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40010E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<OverworldGoal, bool> _003C_003E9__8_0;

		[Token(Token = "0x40010E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<OverworldGoal, Vector3> _003C_003E9__8_1;

		[Token(Token = "0x40010E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<OverworldGoal, bool> _003C_003E9__9_0;

		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x182AB04", Offset = "0x182AB04", VA = "0x182AB04")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x182AB0C", Offset = "0x182AB0C", VA = "0x182AB0C")]
		internal bool _003COnTriggerEnter2D_003Eb__8_0(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x182AB34", Offset = "0x182AB34", VA = "0x182AB34")]
		internal Vector3 _003COnTriggerEnter2D_003Eb__8_1(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x182AB60", Offset = "0x182AB60", VA = "0x182AB60")]
		internal bool _003CCheckGoal_003Eb__9_0(OverworldGoal g)
		{
			return default;
		}
	}

	[Token(Token = "0x40010DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SimplePortal portal;

	[Token(Token = "0x40010DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SimplePortal linkedPortal;

	[Token(Token = "0x40010DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<OverworldGoal> goals;

	[Token(Token = "0x40010DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action OnPortalUsed;

	[Token(Token = "0x40010DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isOpen;

	[Token(Token = "0x40010E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverworldID overworldID;

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x161C8B4", Offset = "0x161C8B4", VA = "0x161C8B4", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x161CB04", Offset = "0x161CB04", VA = "0x161CB04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x161CDC0", Offset = "0x161CDC0", VA = "0x161CDC0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x161CC6C", Offset = "0x161CC6C", VA = "0x161CC6C")]
	private void CheckGoal([Optional] OverworldGoal goal)
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x161D11C", Offset = "0x161D11C", VA = "0x161D11C")]
	private void Open()
	{
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x161D308", Offset = "0x161D308", VA = "0x161D308")]
	private void LinkedPortalUsed(SimplePortal s, GameObject go, SimplePortal s2)
	{
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x161D414", Offset = "0x161D414", VA = "0x161D414")]
	public bool IsOpen()
	{
		return default;
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x161D490", Offset = "0x161D490", VA = "0x161D490")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x161D244", Offset = "0x161D244", VA = "0x161D244")]
	private void UnSubscribe()
	{
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x161D494", Offset = "0x161D494", VA = "0x161D494")]
	public PortalsAsDoors()
	{
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x161D49C", Offset = "0x161D49C", VA = "0x161D49C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60BEC", Offset = "0x60BEC")]
	private void _003CStart_003Eb__7_0(OverworldGoal g)
	{
	}

	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x161D54C", Offset = "0x161D54C", VA = "0x161D54C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60BFC", Offset = "0x60BFC")]
	private void _003CUnSubscribe_003Eb__14_0(OverworldGoal g)
	{
	}
}
