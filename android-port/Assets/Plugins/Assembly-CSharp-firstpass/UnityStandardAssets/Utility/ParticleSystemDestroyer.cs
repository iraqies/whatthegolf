using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000055")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3328C", Offset = "0x3328C")]
		private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000157")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000158")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000159")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer _003C_003E4__this;

			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x28")]
			private ParticleSystem[] _003Csystems_003E5__2;

			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x30")]
			private float _003CstopTime_003E5__3;

			[Token(Token = "0x17000029")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000160")]
				[Address(RVA = "0x1351A4C", Offset = "0x1351A4C", VA = "0x1351A4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000162")]
				[Address(RVA = "0x1351A94", Offset = "0x1351A94", VA = "0x1351A94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x13516E0", Offset = "0x13516E0", VA = "0x13516E0")]
			[DebuggerHidden]
			public _003CStart_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x135170C", Offset = "0x135170C", VA = "0x135170C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1351710", Offset = "0x1351710", VA = "0x1351710", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1351A4C", Offset = "0x1351A4C", VA = "0x1351A4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1351A54", Offset = "0x1351A54", VA = "0x1351A54", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1351A94", Offset = "0x1351A94", VA = "0x1351A94", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x13BD9F4", Offset = "0x13BD9F4", VA = "0x13BD9F4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x13BDA68", Offset = "0x13BDA68", VA = "0x13BDA68")]
		public void Stop()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x13BDA74", Offset = "0x13BDA74", VA = "0x13BDA74")]
		public ParticleSystemDestroyer()
		{
		}
	}
}
