using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E1A")]
public class GooseSpawnedObject : MonoBehaviour
{
	[Token(Token = "0x2000E1B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E78", Offset = "0x44E78")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4004C9C")]
		[FieldOffset(Offset = "0x10")]
		public GooseSpawnedObject _003C_003E4__this;

		[Token(Token = "0x4004C9D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 minScale;

		[Token(Token = "0x4004C9E")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 targetScale;

		[Token(Token = "0x6004237")]
		[Address(RVA = "0x17B7AE8", Offset = "0x17B7AE8", VA = "0x17B7AE8")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6004238")]
		[Address(RVA = "0x17B7AF0", Offset = "0x17B7AF0", VA = "0x17B7AF0")]
		internal void _003CStart_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6004239")]
		[Address(RVA = "0x17B7BA0", Offset = "0x17B7BA0", VA = "0x17B7BA0")]
		internal void _003CStart_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000E1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E88", Offset = "0x44E88")]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004C9F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004CA0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004CA1")]
		[FieldOffset(Offset = "0x20")]
		public GooseSpawnedObject _003C_003E4__this;

		[Token(Token = "0x4004CA2")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		[Token(Token = "0x170006CC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600423D")]
			[Address(RVA = "0x17B7FA0", Offset = "0x17B7FA0", VA = "0x17B7FA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006CD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600423F")]
			[Address(RVA = "0x17B7FE8", Offset = "0x17B7FE8", VA = "0x17B7FE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600423A")]
		[Address(RVA = "0x17B7C50", Offset = "0x17B7C50", VA = "0x17B7C50")]
		[DebuggerHidden]
		public _003CStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600423B")]
		[Address(RVA = "0x17B7C7C", Offset = "0x17B7C7C", VA = "0x17B7C7C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600423C")]
		[Address(RVA = "0x17B7C80", Offset = "0x17B7C80", VA = "0x17B7C80", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600423D")]
		[Address(RVA = "0x17B7FA0", Offset = "0x17B7FA0", VA = "0x17B7FA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600423E")]
		[Address(RVA = "0x17B7FA8", Offset = "0x17B7FA8", VA = "0x17B7FA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600423F")]
		[Address(RVA = "0x17B7FE8", Offset = "0x17B7FE8", VA = "0x17B7FE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004C99")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float destroyDelay;

	[Token(Token = "0x4004C9A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float tweenDuration;

	[Token(Token = "0x4004C9B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve tweenCurve;

	[Token(Token = "0x6004235")]
	[Address(RVA = "0x14AF338", Offset = "0x14AF338", VA = "0x14AF338")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6004236")]
	[Address(RVA = "0x14AF3AC", Offset = "0x14AF3AC", VA = "0x14AF3AC")]
	public GooseSpawnedObject()
	{
	}
}
