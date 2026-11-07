using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B17")]
public class OverworldOptimizations : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000B18")]
	public class Physics2DSettings
	{
		[Token(Token = "0x4003E07")]
		[FieldOffset(Offset = "0x10")]
		public int velocityIterations;

		[Token(Token = "0x4003E08")]
		[FieldOffset(Offset = "0x14")]
		public int positionIterations;

		[Token(Token = "0x4003E09")]
		[FieldOffset(Offset = "0x18")]
		public float timeToSleep;

		[Token(Token = "0x4003E0A")]
		[FieldOffset(Offset = "0x1C")]
		public float linearSleepTolerance;

		[Token(Token = "0x4003E0B")]
		[FieldOffset(Offset = "0x20")]
		public float angularSleepTolerence;

		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x181CAD8", Offset = "0x181CAD8", VA = "0x181CAD8")]
		public Physics2DSettings()
		{
		}
	}

	[Token(Token = "0x2000B19")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x434F8", Offset = "0x434F8")]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003E0C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003E0D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x20")]
		public OverworldOptimizations _003C_003E4__this;

		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700056C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60034FA")]
			[Address(RVA = "0x181CAE0", Offset = "0x181CAE0", VA = "0x181CAE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700056D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60034FC")]
			[Address(RVA = "0x181CB28", Offset = "0x181CB28", VA = "0x181CB28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x181C888", Offset = "0x181C888", VA = "0x181C888")]
		[DebuggerHidden]
		public _003CStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x181C8B4", Offset = "0x181C8B4", VA = "0x181C8B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x181C8B8", Offset = "0x181C8B8", VA = "0x181C8B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x181CAE0", Offset = "0x181CAE0", VA = "0x181CAE0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x181CAE8", Offset = "0x181CAE8", VA = "0x181CAE8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x181CB28", Offset = "0x181CB28", VA = "0x181CB28", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003E05")]
	[FieldOffset(Offset = "0x18")]
	private Physics2DSettings defaultSettings;

	[Token(Token = "0x4003E06")]
	[FieldOffset(Offset = "0x20")]
	public Physics2DSettings optimizedSettings;

	[Token(Token = "0x60034F1")]
	[Address(RVA = "0x15C8244", Offset = "0x15C8244", VA = "0x15C8244")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60034F2")]
	[Address(RVA = "0x15C82B8", Offset = "0x15C82B8", VA = "0x15C82B8")]
	private void Instance_OnToggleOverworld(bool isActive)
	{
	}

	[Token(Token = "0x60034F3")]
	[Address(RVA = "0x15C82C4", Offset = "0x15C82C4", VA = "0x15C82C4")]
	public void EnterOverworld()
	{
	}

	[Token(Token = "0x60034F4")]
	[Address(RVA = "0x15C8390", Offset = "0x15C8390", VA = "0x15C8390")]
	public void ExitOverworld()
	{
	}

	[Token(Token = "0x60034F5")]
	[Address(RVA = "0x15C845C", Offset = "0x15C845C", VA = "0x15C845C")]
	public OverworldOptimizations()
	{
	}
}
