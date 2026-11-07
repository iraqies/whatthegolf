using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E49")]
public class AchievementsLoader : MonoBehaviour
{
	[Token(Token = "0x2000E4A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F68", Offset = "0x44F68")]
	private sealed class _003CShowAchievementsCR_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AchievementsLoader _003C_003E4__this;

		[Token(Token = "0x170006DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60042E5")]
			[Address(RVA = "0x1768150", Offset = "0x1768150", VA = "0x1768150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60042E7")]
			[Address(RVA = "0x1768198", Offset = "0x1768198", VA = "0x1768198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60042E2")]
		[Address(RVA = "0x1767CC8", Offset = "0x1767CC8", VA = "0x1767CC8")]
		[DebuggerHidden]
		public _003CShowAchievementsCR_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60042E3")]
		[Address(RVA = "0x1767CF4", Offset = "0x1767CF4", VA = "0x1767CF4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60042E4")]
		[Address(RVA = "0x1767CF8", Offset = "0x1767CF8", VA = "0x1767CF8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x1768150", Offset = "0x1768150", VA = "0x1768150", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60042E6")]
		[Address(RVA = "0x1768158", Offset = "0x1768158", VA = "0x1768158", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60042E7")]
		[Address(RVA = "0x1768198", Offset = "0x1768198", VA = "0x1768198", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E4B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F78", Offset = "0x44F78")]
	private struct _003COnTriggerExit2D_003Ed__7 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AchievementsLoader _003C_003E4__this;

		[Token(Token = "0x4004D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _003C_003Eu__1;

		[Token(Token = "0x60042E8")]
		[Address(RVA = "0x1767A38", Offset = "0x1767A38", VA = "0x1767A38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x1767CBC", Offset = "0x1767CBC", VA = "0x1767CBC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4004D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool _interactionDisabled;

	[Token(Token = "0x4004D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool _wantsToEnableInteraction;

	[Token(Token = "0x60042DA")]
	[Address(RVA = "0x1403ED0", Offset = "0x1403ED0", VA = "0x1403ED0")]
	private void EnableInteraction()
	{
	}

	[Token(Token = "0x60042DB")]
	[Address(RVA = "0x1403EFC", Offset = "0x1403EFC", VA = "0x1403EFC")]
	private void DisableInteraction()
	{
	}

	[Token(Token = "0x60042DC")]
	[Address(RVA = "0x1403F2C", Offset = "0x1403F2C", VA = "0x1403F2C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60042DD")]
	[Address(RVA = "0x1403F30", Offset = "0x1403F30", VA = "0x1403F30")]
	public void ShowAchievements()
	{
	}

	[Token(Token = "0x60042DE")]
	[Address(RVA = "0x1404018", Offset = "0x1404018", VA = "0x1404018")]
	private IEnumerator ShowAchievementsCR()
	{
		return null;
	}

	[Token(Token = "0x60042DF")]
	[Address(RVA = "0x140408C", Offset = "0x140408C", VA = "0x140408C")]
	public void OnTriggerExit2D(Collider2D collider)
	{
	}

	[Token(Token = "0x60042E0")]
	[Address(RVA = "0x1404124", Offset = "0x1404124", VA = "0x1404124")]
	public AchievementsLoader()
	{
	}

	[Token(Token = "0x60042E1")]
	[Address(RVA = "0x140412C", Offset = "0x140412C", VA = "0x140412C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D934", Offset = "0x6D934")]
	private void _003CShowAchievementsCR_003Eb__6_0(bool success)
	{
	}
}
