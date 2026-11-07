using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010C1")]
	public class MusicImitation : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20010C2")]
		public class ImitationSequence
		{
			[Token(Token = "0x4005845")]
			[FieldOffset(Offset = "0x10")]
			public ImitationBlock[] blocks;

			[Token(Token = "0x4005846")]
			[FieldOffset(Offset = "0x18")]
			public GameObject door;

			[Token(Token = "0x4005847")]
			[FieldOffset(Offset = "0x20")]
			public StingerData wwiseTrigger;

			[Token(Token = "0x4005848")]
			[FieldOffset(Offset = "0x28")]
			public Animator animator;

			[Token(Token = "0x4005849")]
			[FieldOffset(Offset = "0x30")]
			public string animatorTriggerName;

			[Token(Token = "0x6004B14")]
			[Address(RVA = "0x1804F6C", Offset = "0x1804F6C", VA = "0x1804F6C")]
			public ImitationSequence()
			{
			}
		}

		[Token(Token = "0x20010C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B44", Offset = "0x47B44")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x400584A")]
			[FieldOffset(Offset = "0x10")]
			public ImitationBlock playingBlock;

			[Token(Token = "0x400584B")]
			[FieldOffset(Offset = "0x18")]
			public Action<ImitationBlock> _003C_003E9__0;

			[Token(Token = "0x6004B15")]
			[Address(RVA = "0x1804788", Offset = "0x1804788", VA = "0x1804788")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6004B16")]
			[Address(RVA = "0x1804790", Offset = "0x1804790", VA = "0x1804790")]
			internal void _003CStart_003Eb__0(ImitationBlock b)
			{
			}
		}

		[Token(Token = "0x20010C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B54", Offset = "0x47B54")]
		private sealed class _003CStart_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400584C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400584D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400584E")]
			[FieldOffset(Offset = "0x20")]
			public MusicImitation _003C_003E4__this;

			[Token(Token = "0x400584F")]
			[FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			[Token(Token = "0x4005850")]
			[FieldOffset(Offset = "0x30")]
			private ImitationSequence[] _003C_003E7__wrap1;

			[Token(Token = "0x4005851")]
			[FieldOffset(Offset = "0x38")]
			private int _003C_003E7__wrap2;

			[Token(Token = "0x4005852")]
			[FieldOffset(Offset = "0x40")]
			private ImitationSequence _003Csequence_003E5__4;

			[Token(Token = "0x4005853")]
			[FieldOffset(Offset = "0x48")]
			private bool _003Crepeat_003E5__5;

			[Token(Token = "0x4005854")]
			[FieldOffset(Offset = "0x49")]
			private bool _003CallCorrect_003E5__6;

			[Token(Token = "0x4005855")]
			[FieldOffset(Offset = "0x50")]
			private ImitationBlock[] _003C_003E7__wrap6;

			[Token(Token = "0x4005856")]
			[FieldOffset(Offset = "0x58")]
			private int _003C_003E7__wrap7;

			[Token(Token = "0x4005857")]
			[FieldOffset(Offset = "0x60")]
			private ImitationBlock _003Cblock_003E5__9;

			[Token(Token = "0x170007EF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B1A")]
				[Address(RVA = "0x1804F1C", Offset = "0x1804F1C", VA = "0x1804F1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007F0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B1C")]
				[Address(RVA = "0x1804F64", Offset = "0x1804F64", VA = "0x1804F64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004B17")]
			[Address(RVA = "0x1804798", Offset = "0x1804798", VA = "0x1804798")]
			[DebuggerHidden]
			public _003CStart_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B18")]
			[Address(RVA = "0x18047C4", Offset = "0x18047C4", VA = "0x18047C4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B19")]
			[Address(RVA = "0x18047C8", Offset = "0x18047C8", VA = "0x18047C8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004B1A")]
			[Address(RVA = "0x1804F1C", Offset = "0x1804F1C", VA = "0x1804F1C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004B1B")]
			[Address(RVA = "0x1804F24", Offset = "0x1804F24", VA = "0x1804F24", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004B1C")]
			[Address(RVA = "0x1804F64", Offset = "0x1804F64", VA = "0x1804F64", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400583B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x400583C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClipSettings RewardSound;

		[Token(Token = "0x400583D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClipSettings FailClip;

		[Token(Token = "0x400583E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ImitationBlock[] allBlocks;

		[Token(Token = "0x400583F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ImitationSequence[] sequences;

		[Token(Token = "0x4005840")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StingerData lastAnswerStinger;

		[Token(Token = "0x4005841")]
		[FieldOffset(Offset = "0x48")]
		private MusicManager music;

		[Token(Token = "0x4005842")]
		[FieldOffset(Offset = "0x50")]
		private AudioSources voice;

		[Token(Token = "0x4005843")]
		[FieldOffset(Offset = "0x58")]
		private int sequenceIndex;

		[Token(Token = "0x4005844")]
		[FieldOffset(Offset = "0x5C")]
		private int blockIndex;

		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x1585EE8", Offset = "0x1585EE8", VA = "0x1585EE8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x1585F5C", Offset = "0x1585F5C", VA = "0x1585F5C")]
		public MusicImitation()
		{
		}
	}
}
