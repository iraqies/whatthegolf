using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE3")]
public class EnableComponentAfterDelay : MonoBehaviour
{
	[Token(Token = "0x2000BE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43E68", Offset = "0x43E68")]
	private sealed class _003CEnableAfterDelay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40041E6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40041E7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40041E8")]
		[FieldOffset(Offset = "0x20")]
		public EnableComponentAfterDelay _003C_003E4__this;

		[Token(Token = "0x170005F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003905")]
			[Address(RVA = "0x179EEB0", Offset = "0x179EEB0", VA = "0x179EEB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003907")]
			[Address(RVA = "0x179EEF8", Offset = "0x179EEF8", VA = "0x179EEF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003902")]
		[Address(RVA = "0x179EDB4", Offset = "0x179EDB4", VA = "0x179EDB4")]
		[DebuggerHidden]
		public _003CEnableAfterDelay_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003903")]
		[Address(RVA = "0x179EDE0", Offset = "0x179EDE0", VA = "0x179EDE0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003904")]
		[Address(RVA = "0x179EDE4", Offset = "0x179EDE4", VA = "0x179EDE4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003905")]
		[Address(RVA = "0x179EEB0", Offset = "0x179EEB0", VA = "0x179EEB0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003906")]
		[Address(RVA = "0x179EEB8", Offset = "0x179EEB8", VA = "0x179EEB8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003907")]
		[Address(RVA = "0x179EEF8", Offset = "0x179EEF8", VA = "0x179EEF8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40041E3")]
	[FieldOffset(Offset = "0x18")]
	public MonoBehaviour component;

	[Token(Token = "0x40041E4")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x40041E5")]
	[FieldOffset(Offset = "0x24")]
	public bool OnAwake;

	[Token(Token = "0x60038FF")]
	[Address(RVA = "0x1442CB0", Offset = "0x1442CB0", VA = "0x1442CB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003900")]
	[Address(RVA = "0x1442DBC", Offset = "0x1442DBC", VA = "0x1442DBC")]
	private IEnumerator EnableAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x6003901")]
	[Address(RVA = "0x1442E30", Offset = "0x1442E30", VA = "0x1442E30")]
	public EnableComponentAfterDelay()
	{
	}
}
