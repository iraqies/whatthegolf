using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000052")]
	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B91FC", Offset = "0x1B91FC")]
		private sealed class _003CDoSpriteAnimationInternal_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x20")]
			public TMP_SpriteAnimator _003C_003E4__this;

			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x28")]
			public int start;

			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x2C")]
			public int end;

			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x30")]
			public TMP_SpriteAsset spriteAsset;

			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x38")]
			public int currentCharacter;

			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0x3C")]
			public int framerate;

			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x40")]
			private int _003CcurrentFrame_003E5__2;

			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x48")]
			private TMP_CharacterInfo _003CcharInfo_003E5__3;

			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x1C0")]
			private int _003CmaterialIndex_003E5__4;

			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x1C4")]
			private int _003CvertexIndex_003E5__5;

			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x1C8")]
			private TMP_MeshInfo _003CmeshInfo_003E5__6;

			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x218")]
			private float _003CbaseSpriteScale_003E5__7;

			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x21C")]
			private float _003CelapsedTime_003E5__8;

			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x220")]
			private float _003CtargetTime_003E5__9;

			[Token(Token = "0x170000B1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0x2AE00F0", Offset = "0x2AE00F0", VA = "0x2AE00F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000B2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0x2AE0138", Offset = "0x2AE0138", VA = "0x2AE0138", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2ADF83C", Offset = "0x2ADF83C", VA = "0x2ADF83C")]
			[DebuggerHidden]
			public _003CDoSpriteAnimationInternal_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2ADF868", Offset = "0x2ADF868", VA = "0x2ADF868", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2ADF86C", Offset = "0x2ADF86C", VA = "0x2ADF86C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2AE00F0", Offset = "0x2AE00F0", VA = "0x2AE00F0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x2AE00F8", Offset = "0x2AE00F8", VA = "0x2AE00F8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x2AE0138", Offset = "0x2AE0138", VA = "0x2AE0138", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, bool> m_animations;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2A9C804", Offset = "0x2A9C804", VA = "0x2A9C804")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2A9C860", Offset = "0x2A9C860", VA = "0x2A9C860")]
		public void StopAllAnimations()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2A9C8C0", Offset = "0x2A9C8C0", VA = "0x2A9C8C0")]
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2A9C9EC", Offset = "0x2A9C9EC", VA = "0x2A9C9EC")]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2A9CA90", Offset = "0x2A9CA90", VA = "0x2A9CA90")]
		public TMP_SpriteAnimator()
		{
		}
	}
}
