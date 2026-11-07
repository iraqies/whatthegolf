using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200134B")]
	public class AmbientAudioPlayer : MonoBehaviour
	{
		[Token(Token = "0x200134C")]
		public class AmbientPlayingInfo
		{
			[Token(Token = "0x4006756")]
			[FieldOffset(Offset = "0x10")]
			public AmbientAudio ambient;

			[Token(Token = "0x4006757")]
			[FieldOffset(Offset = "0x18")]
			public AudioSource source;

			[Token(Token = "0x4006758")]
			[FieldOffset(Offset = "0x20")]
			public bool toKill;

			[Token(Token = "0x4006759")]
			[FieldOffset(Offset = "0x21")]
			public bool isDead;

			[Token(Token = "0x6005A19")]
			[Address(RVA = "0x1769E30", Offset = "0x1769E30", VA = "0x1769E30")]
			public AmbientPlayingInfo()
			{
			}
		}

		[Token(Token = "0x200134D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48C10", Offset = "0x48C10")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x400675A")]
			[FieldOffset(Offset = "0x10")]
			public AmbientPlayingInfo ambientInfo;

			[Token(Token = "0x6005A1A")]
			[Address(RVA = "0x1769278", Offset = "0x1769278", VA = "0x1769278")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6005A1B")]
			[Address(RVA = "0x1769280", Offset = "0x1769280", VA = "0x1769280")]
			internal void _003CInitializeDelayed_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200134E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48C20", Offset = "0x48C20")]
		private sealed class _003CInitializeDelayed_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400675B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400675C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400675D")]
			[FieldOffset(Offset = "0x20")]
			public List<AmbientAudio> ambients;

			[Token(Token = "0x400675E")]
			[FieldOffset(Offset = "0x28")]
			public AmbientAudioPlayer _003C_003E4__this;

			[Token(Token = "0x17000A2A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005A1F")]
				[Address(RVA = "0x1769E38", Offset = "0x1769E38", VA = "0x1769E38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A2B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005A21")]
				[Address(RVA = "0x1769E80", Offset = "0x1769E80", VA = "0x1769E80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005A1C")]
			[Address(RVA = "0x17692A0", Offset = "0x17692A0", VA = "0x17692A0")]
			[DebuggerHidden]
			public _003CInitializeDelayed_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005A1D")]
			[Address(RVA = "0x17692CC", Offset = "0x17692CC", VA = "0x17692CC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005A1E")]
			[Address(RVA = "0x17692D0", Offset = "0x17692D0", VA = "0x17692D0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005A1F")]
			[Address(RVA = "0x1769E38", Offset = "0x1769E38", VA = "0x1769E38", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005A20")]
			[Address(RVA = "0x1769E40", Offset = "0x1769E40", VA = "0x1769E40", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005A21")]
			[Address(RVA = "0x1769E80", Offset = "0x1769E80", VA = "0x1769E80", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006754")]
		[FieldOffset(Offset = "0x18")]
		private List<AmbientPlayingInfo> currentAmbients;

		[Token(Token = "0x4006755")]
		[FieldOffset(Offset = "0x20")]
		private List<AmbientPlayingInfo> toKill;

		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x140DBAC", Offset = "0x140DBAC", VA = "0x140DBAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x140DC3C", Offset = "0x140DC3C", VA = "0x140DC3C")]
		public void SetOneshotTimeOnActive(float time)
		{
		}

		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x140DDAC", Offset = "0x140DDAC", VA = "0x140DDAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x140DFDC", Offset = "0x140DFDC", VA = "0x140DFDC")]
		private IEnumerator InitializeDelayed(List<AmbientAudio> ambients)
		{
			return null;
		}

		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x140E054", Offset = "0x140E054", VA = "0x140E054")]
		public void SetAmbients(List<AmbientAudio> ambients)
		{
		}

		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x140E0D4", Offset = "0x140E0D4", VA = "0x140E0D4")]
		public void InitializeNewScene()
		{
		}

		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x140E1CC", Offset = "0x140E1CC", VA = "0x140E1CC")]
		public AmbientAudioPlayer()
		{
		}
	}
}
