using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005AE")]
public class MiniGolfCourseSwitchGoal : MonoBehaviour
{
	[Token(Token = "0x20005AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x407F0", Offset = "0x407F0")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001CFD")]
		[FieldOffset(Offset = "0x10")]
		public MiniGolfCourseSwitchGoal _003C_003E4__this;

		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 s;

		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x17F72A0", Offset = "0x17F72A0", VA = "0x17F72A0")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x17F72A8", Offset = "0x17F72A8", VA = "0x17F72A8")]
		internal void _003CWaitForGoal_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20005B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40800", Offset = "0x40800")]
	private sealed class _003CWaitForGoal_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001CFF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D01")]
		[FieldOffset(Offset = "0x20")]
		public MiniGolfCourseSwitchGoal _003C_003E4__this;

		[Token(Token = "0x170002CE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60019D7")]
			[Address(RVA = "0x17F767C", Offset = "0x17F767C", VA = "0x17F767C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002CF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60019D9")]
			[Address(RVA = "0x17F76C4", Offset = "0x17F76C4", VA = "0x17F76C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x17F7380", Offset = "0x17F7380", VA = "0x17F7380")]
		[DebuggerHidden]
		public _003CWaitForGoal_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x17F73AC", Offset = "0x17F73AC", VA = "0x17F73AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x17F73B0", Offset = "0x17F73B0", VA = "0x17F73B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x17F767C", Offset = "0x17F767C", VA = "0x17F767C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x17F7684", Offset = "0x17F7684", VA = "0x17F7684", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x17F76C4", Offset = "0x17F76C4", VA = "0x17F76C4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001CF6")]
	[FieldOffset(Offset = "0x18")]
	public float Delay;

	[Token(Token = "0x4001CF7")]
	[FieldOffset(Offset = "0x20")]
	public string HitText;

	[Token(Token = "0x4001CF8")]
	[FieldOffset(Offset = "0x28")]
	public Transform NextHolePosition;

	[Token(Token = "0x4001CF9")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController Controller;

	[Token(Token = "0x4001CFA")]
	[FieldOffset(Offset = "0x38")]
	private Transform cameraFollow;

	[Token(Token = "0x4001CFB")]
	[FieldOffset(Offset = "0x40")]
	private CBFollow follow;

	[Token(Token = "0x4001CFC")]
	[FieldOffset(Offset = "0x48")]
	private bool transitionStarted;

	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x15676AC", Offset = "0x15676AC", VA = "0x15676AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x156779C", Offset = "0x156779C", VA = "0x156779C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x15678B4", Offset = "0x15678B4", VA = "0x15678B4")]
	private IEnumerator WaitForGoal()
	{
		return null;
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x1567928", Offset = "0x1567928", VA = "0x1567928")]
	public MiniGolfCourseSwitchGoal()
	{
	}
}
