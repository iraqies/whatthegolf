using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Core.UI
{
	[Token(Token = "0x2001474")]
	public class InGameFullScreenText : MonoBehaviour
	{
		[Token(Token = "0x2001475")]
		private struct Text
		{
			[Token(Token = "0x4007043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TextMeshPro textMeshPro;

			[Token(Token = "0x4007044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Renderer renderer;

			[Token(Token = "0x4007045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform rectTransform;

			[Token(Token = "0x4007046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Color initialTextColor;

			[Token(Token = "0x4007047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color initialTextOutlineColor;
		}

		[Token(Token = "0x2001476")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4917C", Offset = "0x4917C")]
		private sealed class _003CHide_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4007048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4007049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400704A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400704B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public InGameFullScreenText _003C_003E4__this;

			[Token(Token = "0x17000AF7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006072")]
				[Address(RVA = "0x17C5858", Offset = "0x17C5858", VA = "0x17C5858", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000AF8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006074")]
				[Address(RVA = "0x17C58A0", Offset = "0x17C58A0", VA = "0x17C58A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600606F")]
			[Address(RVA = "0x17C576C", Offset = "0x17C576C", VA = "0x17C576C")]
			[DebuggerHidden]
			public _003CHide_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006070")]
			[Address(RVA = "0x17C5798", Offset = "0x17C5798", VA = "0x17C5798", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006071")]
			[Address(RVA = "0x17C579C", Offset = "0x17C579C", VA = "0x17C579C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6006072")]
			[Address(RVA = "0x17C5858", Offset = "0x17C5858", VA = "0x17C5858", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6006073")]
			[Address(RVA = "0x17C5860", Offset = "0x17C5860", VA = "0x17C5860", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6006074")]
			[Address(RVA = "0x17C58A0", Offset = "0x17C58A0", VA = "0x17C58A0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4007040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshPro[] _texts;

		[Token(Token = "0x4007041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text[] texts;

		[Token(Token = "0x4007042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine _autoHide;

		[Token(Token = "0x6006069")]
		[Address(RVA = "0x14EA770", Offset = "0x14EA770", VA = "0x14EA770")]
		public void Init()
		{
		}

		[Token(Token = "0x600606A")]
		[Address(RVA = "0x14EA960", Offset = "0x14EA960", VA = "0x14EA960")]
		public void Prepare([Optional] string text)
		{
		}

		[Token(Token = "0x600606B")]
		[Address(RVA = "0x14EAB80", Offset = "0x14EAB80", VA = "0x14EAB80")]
		public void Show(float showDuration = 0f)
		{
		}

		[Token(Token = "0x600606C")]
		[Address(RVA = "0x14EADA0", Offset = "0x14EADA0", VA = "0x14EADA0")]
		public void HideInstantly()
		{
		}

		[Token(Token = "0x600606D")]
		[Address(RVA = "0x14EAD1C", Offset = "0x14EAD1C", VA = "0x14EAD1C")]
		private IEnumerator Hide(float delay)
		{
			return null;
		}

		[Token(Token = "0x600606E")]
		[Address(RVA = "0x14EAE18", Offset = "0x14EAE18", VA = "0x14EAE18")]
		public InGameFullScreenText()
		{
		}
	}
}
