using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RedBlueGames.Tools.TextTyper
{
	[Token(Token = "0x2001029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4755C", Offset = "0x4755C")]
	public sealed class TextTyper : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200102A")]
		public class CharacterPrintedEvent : UnityEvent<string>
		{
			[Token(Token = "0x600485A")]
			[Address(RVA = "0x1864D10", Offset = "0x1864D10", VA = "0x1864D10")]
			public CharacterPrintedEvent()
			{
			}
		}

		[Token(Token = "0x200102B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x475C4", Offset = "0x475C4")]
		private sealed class _003CTypeTextCharByChar_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005546")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005547")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005548")]
			[FieldOffset(Offset = "0x20")]
			public TextTyper _003C_003E4__this;

			[Token(Token = "0x4005549")]
			[FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x400554A")]
			[FieldOffset(Offset = "0x30")]
			private TypedTextGenerator _003Cgenerator_003E5__2;

			[Token(Token = "0x400554B")]
			[FieldOffset(Offset = "0x38")]
			private TypedTextGenerator.TypedText _003CtypedText_003E5__3;

			[Token(Token = "0x400554C")]
			[FieldOffset(Offset = "0x40")]
			private int _003CprintedCharCount_003E5__4;

			[Token(Token = "0x1700079F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600485E")]
				[Address(RVA = "0x1864CC0", Offset = "0x1864CC0", VA = "0x1864CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007A0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004860")]
				[Address(RVA = "0x1864D08", Offset = "0x1864D08", VA = "0x1864D08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600485B")]
			[Address(RVA = "0x1864A74", Offset = "0x1864A74", VA = "0x1864A74")]
			[DebuggerHidden]
			public _003CTypeTextCharByChar_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600485C")]
			[Address(RVA = "0x1864AA0", Offset = "0x1864AA0", VA = "0x1864AA0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600485D")]
			[Address(RVA = "0x1864AA4", Offset = "0x1864AA4", VA = "0x1864AA4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600485E")]
			[Address(RVA = "0x1864CC0", Offset = "0x1864CC0", VA = "0x1864CC0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600485F")]
			[Address(RVA = "0x1864CC8", Offset = "0x1864CC8", VA = "0x1864CC8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004860")]
			[Address(RVA = "0x1864D08", Offset = "0x1864D08", VA = "0x1864D08", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400553D")]
		private const float PrintDelaySetting = 0.02f;

		[Token(Token = "0x400553E")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<char> punctutationCharacters;

		[Token(Token = "0x400553F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent printCompleted;

		[Token(Token = "0x4005540")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterPrintedEvent characterPrinted;

		[Token(Token = "0x4005541")]
		[FieldOffset(Offset = "0x30")]
		private Text textComponent;

		[Token(Token = "0x4005542")]
		[FieldOffset(Offset = "0x38")]
		private string printingText;

		[Token(Token = "0x4005543")]
		[FieldOffset(Offset = "0x40")]
		private string oldText;

		[Token(Token = "0x4005544")]
		[FieldOffset(Offset = "0x48")]
		private float defaultPrintDelay;

		[Token(Token = "0x4005545")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine typeTextCoroutine;

		[Token(Token = "0x1700079C")]
		public UnityEvent PrintCompleted
		{
			[Token(Token = "0x600484E")]
			[Address(RVA = "0x1711910", Offset = "0x1711910", VA = "0x1711910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079D")]
		public CharacterPrintedEvent CharacterPrinted
		{
			[Token(Token = "0x600484F")]
			[Address(RVA = "0x1711918", Offset = "0x1711918", VA = "0x1711918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079E")]
		private Text TextComponent
		{
			[Token(Token = "0x6004850")]
			[Address(RVA = "0x1711920", Offset = "0x1711920", VA = "0x1711920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004851")]
		[Address(RVA = "0x17119CC", Offset = "0x17119CC", VA = "0x17119CC")]
		public void TypeText(string text, float printDelay = -1f)
		{
		}

		[Token(Token = "0x6004852")]
		[Address(RVA = "0x1711B60", Offset = "0x1711B60", VA = "0x1711B60")]
		public void Skip()
		{
		}

		[Token(Token = "0x6004853")]
		[Address(RVA = "0x1711C5C", Offset = "0x1711C5C", VA = "0x1711C5C")]
		public bool IsSkippable()
		{
			return default;
		}

		[Token(Token = "0x6004854")]
		[Address(RVA = "0x1711AB8", Offset = "0x1711AB8", VA = "0x1711AB8")]
		private void Cleanup()
		{
		}

		[Token(Token = "0x6004855")]
		[Address(RVA = "0x1711AE8", Offset = "0x1711AE8", VA = "0x1711AE8")]
		private IEnumerator TypeTextCharByChar(string text)
		{
			return null;
		}

		[Token(Token = "0x6004856")]
		[Address(RVA = "0x1711C6C", Offset = "0x1711C6C", VA = "0x1711C6C")]
		private float GetPrintDelayForCharacter(char characterToPrint)
		{
			return default;
		}

		[Token(Token = "0x6004857")]
		[Address(RVA = "0x1711CF4", Offset = "0x1711CF4", VA = "0x1711CF4")]
		private void OnCharacterPrinted(string printedCharacter)
		{
		}

		[Token(Token = "0x6004858")]
		[Address(RVA = "0x1711C48", Offset = "0x1711C48", VA = "0x1711C48")]
		private void OnTypewritingComplete()
		{
		}

		[Token(Token = "0x6004859")]
		[Address(RVA = "0x1711D64", Offset = "0x1711D64", VA = "0x1711D64")]
		public TextTyper()
		{
		}
	}
}
