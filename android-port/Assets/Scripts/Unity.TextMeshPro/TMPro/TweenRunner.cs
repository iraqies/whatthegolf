using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000015")]
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B908C", Offset = "0x1B908C")]
		private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000064")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0x0")]
			public T tweenInfo;

			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x0")]
			private float _003CelapsedTime_003E5__2;

			[Token(Token = "0x1700000E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600004E")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700000F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000050")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600004B")]
			[DebuggerHidden]
			public _003CStart_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600004C")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600004D")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600004E")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600004F")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000050")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;

		[Token(Token = "0x6000046")]
		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		[Token(Token = "0x6000048")]
		public void StartTween(T info)
		{
		}

		[Token(Token = "0x6000049")]
		public void StopTween()
		{
		}

		[Token(Token = "0x600004A")]
		public TweenRunner()
		{
		}
	}
}
