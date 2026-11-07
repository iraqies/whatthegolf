using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001345")]
	public class SpectatorReactionAudio : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001346")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48BF0", Offset = "0x48BF0")]
		private struct _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x4006733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool fadeIn;

			[Token(Token = "0x4006734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SpectatorReactionAudio _003C_003E4__this;
		}

		[Token(Token = "0x2001347")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48C00", Offset = "0x48C00")]
		private sealed class _003CFadeCrowdLoop_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool fadeIn;

			[Token(Token = "0x4006738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpectatorReactionAudio _003C_003E4__this;

			[Token(Token = "0x4006739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

			[Token(Token = "0x400673A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float _003CvolumeTarget_003E5__2;

			[Token(Token = "0x400673B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float _003Cspeed_003E5__3;

			[Token(Token = "0x17000A26")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005A03")]
				[Address(RVA = "0x1857718", Offset = "0x1857718", VA = "0x1857718", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A27")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005A05")]
				[Address(RVA = "0x1857760", Offset = "0x1857760", VA = "0x1857760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005A00")]
			[Address(RVA = "0x1857528", Offset = "0x1857528", VA = "0x1857528")]
			[DebuggerHidden]
			public _003CFadeCrowdLoop_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005A01")]
			[Address(RVA = "0x1857554", Offset = "0x1857554", VA = "0x1857554", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005A02")]
			[Address(RVA = "0x1857558", Offset = "0x1857558", VA = "0x1857558", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005A03")]
			[Address(RVA = "0x1857718", Offset = "0x1857718", VA = "0x1857718", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005A04")]
			[Address(RVA = "0x1857720", Offset = "0x1857720", VA = "0x1857720", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005A05")]
			[Address(RVA = "0x1857760", Offset = "0x1857760", VA = "0x1857760", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TribuneWithSpectators tribune;

		[Token(Token = "0x4006726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Spectator spectator;

		[Token(Token = "0x4006727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float volumeMod;

		[Token(Token = "0x4006728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioEventAsset loopSfx;

		[Token(Token = "0x4006729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSource loopCheerSource;

		[Token(Token = "0x400672A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float fadeInSpeed;

		[Token(Token = "0x400672B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float fadeOutSpeed;

		[Token(Token = "0x400672C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioEventAsset oneshotSfx;

		[Token(Token = "0x400672D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isReactingToPlayer;

		[Token(Token = "0x400672E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Spectator currentSpectator;

		[Token(Token = "0x400672F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Coroutine fadeCoroutine;

		[Token(Token = "0x4006730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float cheerMaxVolume;

		[Token(Token = "0x4006731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStartTime;

		[Token(Token = "0x4006732")]
		private const float COOLDOWN = 5f;

		[Token(Token = "0x17000A25")]
		public Spectator CurrentSpectator
		{
			[Token(Token = "0x60059F7")]
			[Address(RVA = "0x16CE11C", Offset = "0x16CE11C", VA = "0x16CE11C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60059F8")]
			[Address(RVA = "0x16CE124", Offset = "0x16CE124", VA = "0x16CE124")]
			set
			{
			}
		}

		[Token(Token = "0x60059F9")]
		[Address(RVA = "0x16CE5E0", Offset = "0x16CE5E0", VA = "0x16CE5E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059FA")]
		[Address(RVA = "0x16CE810", Offset = "0x16CE810", VA = "0x16CE810")]
		private void Tribune_OnTribunePopulated()
		{
		}

		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x16CE4D8", Offset = "0x16CE4D8", VA = "0x16CE4D8")]
		private void OnSeeingTarget()
		{
		}

		[Token(Token = "0x60059FC")]
		[Address(RVA = "0x16CE950", Offset = "0x16CE950", VA = "0x16CE950")]
		private void OnLosingTarget()
		{
		}

		[Token(Token = "0x60059FD")]
		[Address(RVA = "0x16CE8D4", Offset = "0x16CE8D4", VA = "0x16CE8D4")]
		private IEnumerator FadeCrowdLoop(bool fadeIn)
		{
			return null;
		}

		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x16CE9F0", Offset = "0x16CE9F0", VA = "0x16CE9F0")]
		public SpectatorReactionAudio()
		{
		}

		[Token(Token = "0x60059FF")]
		[Address(RVA = "0x16CEA0C", Offset = "0x16CEA0C", VA = "0x16CEA0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721E8", Offset = "0x721E8")]
		private bool _003CFadeCrowdLoop_003Eg__AtTargetVolume_007C21_0(float max, ref _003C_003Ec__DisplayClass21_0 P_1)
		{
			return default;
		}
	}
}
