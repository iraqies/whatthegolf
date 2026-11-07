using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityEngine.UI.CoroutineTween
{
	[Token(Token = "0x2000082")]
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F6A4C", Offset = "0x1F6A4C")]
		private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400025E")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x400025F")]
			[FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000260")]
			[FieldOffset(Offset = "0x0")]
			public T tweenInfo;

			[Token(Token = "0x4000261")]
			[FieldOffset(Offset = "0x0")]
			private float _003CelapsedTime_003E5__2;

			[Token(Token = "0x17000163")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600053F")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000164")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000541")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600053C")]
			[DebuggerHidden]
			public _003CStart_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600053D")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600053E")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600053F")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000540")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000541")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;

		[Token(Token = "0x6000537")]
		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		[Token(Token = "0x6000539")]
		public void StartTween(T info)
		{
		}

		[Token(Token = "0x600053A")]
		public void StopTween()
		{
		}

		[Token(Token = "0x600053B")]
		public TweenRunner()
		{
		}
	}
}
