using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000003")]
	public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		[Serializable]
		[Token(Token = "0x2000004")]
		public class ButtonClickedEvent : UnityEvent
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2C449D4", Offset = "0x2C449D4", VA = "0x2C449D4")]
			public ButtonClickedEvent()
			{
			}
		}

		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F60E4", Offset = "0x1F60E4")]
		private sealed class _003COnFinishSubmit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x20")]
			public Button _003C_003E4__this;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x28")]
			private float _003CfadeTime_003E5__2;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x2C")]
			private float _003CelapsedTime_003E5__3;

			[Token(Token = "0x17000007")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000012")]
				[Address(RVA = "0x2C44984", Offset = "0x2C44984", VA = "0x2C44984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000008")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000014")]
				[Address(RVA = "0x2C449CC", Offset = "0x2C449CC", VA = "0x2C449CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2C44898", Offset = "0x2C44898", VA = "0x2C44898")]
			[DebuggerHidden]
			public _003COnFinishSubmit_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2C448C4", Offset = "0x2C448C4", VA = "0x2C448C4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2C448C8", Offset = "0x2C448C8", VA = "0x2C448C8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2C44984", Offset = "0x2C44984", VA = "0x2C44984", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2C4498C", Offset = "0x2C4498C", VA = "0x2C4498C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2C449CC", Offset = "0x2C449CC", VA = "0x2C449CC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6DB4", Offset = "0x1F6DB4")]
		[SerializeField]
		private ButtonClickedEvent m_OnClick;

		[Token(Token = "0x17000006")]
		public ButtonClickedEvent onClick
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2BF9BCC", Offset = "0x2BF9BCC", VA = "0x2BF9BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2BF9BD4", Offset = "0x2BF9BD4", VA = "0x2BF9BD4")]
			set
			{
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2BF9B34", Offset = "0x2BF9B34", VA = "0x2BF9B34")]
		protected Button()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2BF9BDC", Offset = "0x2BF9BDC", VA = "0x2BF9BDC")]
		private void Press()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2BF9C78", Offset = "0x2BF9C78", VA = "0x2BF9C78", Slot = "41")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2BF9D20", Offset = "0x2BF9D20", VA = "0x2BF9D20", Slot = "42")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2BF9E68", Offset = "0x2BF9E68", VA = "0x2BF9E68")]
		private IEnumerator OnFinishSubmit()
		{
			return null;
		}
	}
}
