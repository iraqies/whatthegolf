using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using WhatTheGolf.LevelDesigner.Audio;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012C3")]
	public class AudioSettingsManager : BaseManager, IRequireEvents<AudioEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[Token(Token = "0x20012C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x488EC", Offset = "0x488EC")]
		private sealed class _003CSetInitialMixerSnapshot_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006522")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006523")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006524")]
			[FieldOffset(Offset = "0x20")]
			public AudioSettingsManager _003C_003E4__this;

			[Token(Token = "0x170009E9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60056E6")]
				[Address(RVA = "0x17702E0", Offset = "0x17702E0", VA = "0x17702E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009EA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60056E8")]
				[Address(RVA = "0x1770328", Offset = "0x1770328", VA = "0x1770328", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60056E3")]
			[Address(RVA = "0x17701DC", Offset = "0x17701DC", VA = "0x17701DC")]
			[DebuggerHidden]
			public _003CSetInitialMixerSnapshot_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60056E4")]
			[Address(RVA = "0x1770208", Offset = "0x1770208", VA = "0x1770208", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60056E5")]
			[Address(RVA = "0x177020C", Offset = "0x177020C", VA = "0x177020C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60056E6")]
			[Address(RVA = "0x17702E0", Offset = "0x17702E0", VA = "0x17702E0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60056E7")]
			[Address(RVA = "0x17702E8", Offset = "0x17702E8", VA = "0x17702E8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60056E8")]
			[Address(RVA = "0x1770328", Offset = "0x1770328", VA = "0x1770328", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400650C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MusicStateSettings m_MusicStateSettings;

		[Token(Token = "0x400650D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AmbientAudio m_AmbiencePrefab;

		[Token(Token = "0x400650E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PaintBrushSFX m_PaintBrushSFX;

		[Token(Token = "0x400650F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioMixerSnapshot m_EditModeAudioSnapshot;

		[Token(Token = "0x4006510")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioMixerSnapshot m_PlayModeAudioSnapshot;

		[Token(Token = "0x4006511")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioMixerSnapshot m_EditModeMusicSnapshot;

		[Token(Token = "0x4006512")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AudioMixerSnapshot m_PlayModeMusicSnapshot;

		[Token(Token = "0x4006513")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnPropPlaced;

		[Token(Token = "0x4006514")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectHoverAny;

		[Token(Token = "0x4006515")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectSelectAny;

		[Token(Token = "0x4006516")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectDelete;

		[Token(Token = "0x4006517")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnObjectDeleteByEraser;

		[Token(Token = "0x4006518")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnButtonHoverAny;

		[Token(Token = "0x4006519")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnButtonDownAny;

		[Token(Token = "0x400651A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnSave;

		[Token(Token = "0x400651B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnUndo;

		[Token(Token = "0x400651C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnRedo;

		[Token(Token = "0x400651D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnPublishStart;

		[Token(Token = "0x400651E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnPublishSuccess;

		[Token(Token = "0x400651F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnPublishFail;

		[Token(Token = "0x4006520")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ClipSettingsCollection m_SfxOnFail;

		[Token(Token = "0x4006521")]
		[FieldOffset(Offset = "0xD8")]
		private float m_NextUISfxTime;

		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x150B9B0", Offset = "0x150B9B0", VA = "0x150B9B0", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60056DC")]
		[Address(RVA = "0x150BC24", Offset = "0x150BC24", VA = "0x150BC24")]
		private IEnumerator SetInitialMixerSnapshot()
		{
			return null;
		}

		[Token(Token = "0x60056DD")]
		[Address(RVA = "0x150BC98", Offset = "0x150BC98", VA = "0x150BC98", Slot = "5")]
		public void OnEvent(AudioEvent evt)
		{
		}

		[Token(Token = "0x60056DE")]
		[Address(RVA = "0x150BE1C", Offset = "0x150BE1C", VA = "0x150BE1C", Slot = "6")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x60056DF")]
		[Address(RVA = "0x150C058", Offset = "0x150C058", VA = "0x150C058")]
		private void MusicTransitionEditMode()
		{
		}

		[Token(Token = "0x60056E0")]
		[Address(RVA = "0x150BFE0", Offset = "0x150BFE0", VA = "0x150BFE0")]
		private void MusicTransitionPlaymode()
		{
		}

		[Token(Token = "0x60056E1")]
		[Address(RVA = "0x150C0D0", Offset = "0x150C0D0", VA = "0x150C0D0")]
		public AudioSettingsManager()
		{
		}

		[Token(Token = "0x60056E2")]
		[Address(RVA = "0x150C0D8", Offset = "0x150C0D8", VA = "0x150C0D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B74", Offset = "0x71B74")]
		private void _003CInit_003Eb__22_0()
		{
		}
	}
}
