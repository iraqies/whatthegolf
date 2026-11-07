using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20002E4")]
public class PortalblePuppet : PortableObject
{
	[Token(Token = "0x20002E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED2C", Offset = "0x3ED2C")]
	private sealed class _003CPortCR_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x20")]
		public PortalblePuppet _003C_003E4__this;

		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x17000194")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D50")]
			[Address(RVA = "0x182AA54", Offset = "0x182AA54", VA = "0x182AA54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000195")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D52")]
			[Address(RVA = "0x182AA9C", Offset = "0x182AA9C", VA = "0x182AA9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x182A7D0", Offset = "0x182A7D0", VA = "0x182A7D0")]
		[DebuggerHidden]
		public _003CPortCR_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x182A7FC", Offset = "0x182A7FC", VA = "0x182A7FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x182A800", Offset = "0x182A800", VA = "0x182A800", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x182AA54", Offset = "0x182AA54", VA = "0x182AA54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x182AA5C", Offset = "0x182AA5C", VA = "0x182AA5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x182AA9C", Offset = "0x182AA9C", VA = "0x182AA9C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PuppetMaster Puppet;

	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UserControlThirdPerson Character;

	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform Root;

	[Token(Token = "0x4000FE0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GolfBallController Controller;

	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x161C774", Offset = "0x161C774", VA = "0x161C774", Slot = "4")]
	public override void Port(Vector3 position)
	{
	}

	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0x161C814", Offset = "0x161C814", VA = "0x161C814")]
	private IEnumerator PortCR(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x161C8AC", Offset = "0x161C8AC", VA = "0x161C8AC")]
	public PortalblePuppet()
	{
	}
}
