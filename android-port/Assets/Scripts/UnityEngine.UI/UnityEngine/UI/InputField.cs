using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000021")]
	public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
	{
		[Token(Token = "0x2000022")]
		public enum ContentType
		{
			[Token(Token = "0x40000D5")]
			Standard = 0,
			[Token(Token = "0x40000D6")]
			Autocorrected = 1,
			[Token(Token = "0x40000D7")]
			IntegerNumber = 2,
			[Token(Token = "0x40000D8")]
			DecimalNumber = 3,
			[Token(Token = "0x40000D9")]
			Alphanumeric = 4,
			[Token(Token = "0x40000DA")]
			Name = 5,
			[Token(Token = "0x40000DB")]
			EmailAddress = 6,
			[Token(Token = "0x40000DC")]
			Password = 7,
			[Token(Token = "0x40000DD")]
			Pin = 8,
			[Token(Token = "0x40000DE")]
			Custom = 9
		}

		[Token(Token = "0x2000023")]
		public enum InputType
		{
			[Token(Token = "0x40000E0")]
			Standard = 0,
			[Token(Token = "0x40000E1")]
			AutoCorrect = 1,
			[Token(Token = "0x40000E2")]
			Password = 2
		}

		[Token(Token = "0x2000024")]
		public enum CharacterValidation
		{
			[Token(Token = "0x40000E4")]
			None = 0,
			[Token(Token = "0x40000E5")]
			Integer = 1,
			[Token(Token = "0x40000E6")]
			Decimal = 2,
			[Token(Token = "0x40000E7")]
			Alphanumeric = 3,
			[Token(Token = "0x40000E8")]
			Name = 4,
			[Token(Token = "0x40000E9")]
			EmailAddress = 5
		}

		[Token(Token = "0x2000025")]
		public enum LineType
		{
			[Token(Token = "0x40000EB")]
			SingleLine = 0,
			[Token(Token = "0x40000EC")]
			MultiLineSubmit = 1,
			[Token(Token = "0x40000ED")]
			MultiLineNewline = 2
		}

		[Token(Token = "0x2000026")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		[Serializable]
		[Token(Token = "0x2000027")]
		public class SubmitEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2C45BF0", Offset = "0x2C45BF0", VA = "0x2C45BF0")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000028")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x2C45638", Offset = "0x2C45638", VA = "0x2C45638")]
			public OnChangeEvent()
			{
			}
		}

		[Token(Token = "0x2000029")]
		protected enum EditState
		{
			[Token(Token = "0x40000EF")]
			Continue = 0,
			[Token(Token = "0x40000F0")]
			Finish = 1
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F62E4", Offset = "0x1F62E4")]
		private sealed class _003CCaretBlink_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000F3")]
			[FieldOffset(Offset = "0x20")]
			public InputField _003C_003E4__this;

			[Token(Token = "0x17000090")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0x2C452C4", Offset = "0x2C452C4", VA = "0x2C452C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000091")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600020A")]
				[Address(RVA = "0x2C4530C", Offset = "0x2C4530C", VA = "0x2C4530C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2C45178", Offset = "0x2C45178", VA = "0x2C45178")]
			[DebuggerHidden]
			public _003CCaretBlink_003Ed__165(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x2C451A4", Offset = "0x2C451A4", VA = "0x2C451A4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2C451A8", Offset = "0x2C451A8", VA = "0x2C451A8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0x2C452C4", Offset = "0x2C452C4", VA = "0x2C452C4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x2C452CC", Offset = "0x2C452CC", VA = "0x2C452CC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x2C4530C", Offset = "0x2C4530C", VA = "0x2C4530C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F62F4", Offset = "0x1F62F4")]
		private sealed class _003CMouseDragOutsideRect_003Ed__187 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0x20")]
			public PointerEventData eventData;

			[Token(Token = "0x40000F7")]
			[FieldOffset(Offset = "0x28")]
			public InputField _003C_003E4__this;

			[Token(Token = "0x17000092")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x2C455E8", Offset = "0x2C455E8", VA = "0x2C455E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000093")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x2C45630", Offset = "0x2C45630", VA = "0x2C45630", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x2C45314", Offset = "0x2C45314", VA = "0x2C45314")]
			[DebuggerHidden]
			public _003CMouseDragOutsideRect_003Ed__187(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0x2C45340", Offset = "0x2C45340", VA = "0x2C45340", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x2C45344", Offset = "0x2C45344", VA = "0x2C45344", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0x2C455E8", Offset = "0x2C455E8", VA = "0x2C455E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x2C455F0", Offset = "0x2C455F0", VA = "0x2C455F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x2C45630", Offset = "0x2C45630", VA = "0x2C45630", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xF8")]
		protected TouchScreenKeyboard m_Keyboard;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] kSeparators;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_IsQuestDevice;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7534", Offset = "0x1F7534")]
		protected Text m_TextComponent;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		protected Graphic m_Placeholder;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ContentType m_ContentType;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F75A0", Offset = "0x1F75A0")]
		private InputType m_InputType;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F75EC", Offset = "0x1F75EC")]
		private char m_AsteriskChar;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7638", Offset = "0x1F7638")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private LineType m_LineType;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7694", Offset = "0x1F7694")]
		[SerializeField]
		private bool m_HideMobileInput;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F76E0", Offset = "0x1F76E0")]
		[SerializeField]
		private CharacterValidation m_CharacterValidation;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F772C", Offset = "0x1F772C")]
		[SerializeField]
		private int m_CharacterLimit;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7778", Offset = "0x1F7778")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7778", Offset = "0x1F7778")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7778", Offset = "0x1F7778")]
		private SubmitEvent m_OnEndEdit;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F780C", Offset = "0x1F780C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F780C", Offset = "0x1F780C")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F787C", Offset = "0x1F787C")]
		private OnValidateInput m_OnValidateInput;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F78C8", Offset = "0x1F78C8")]
		[SerializeField]
		private Color m_CaretColor;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private bool m_CustomCaretColor;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private Color m_SelectionColor;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7934", Offset = "0x1F7934")]
		protected string m_Text;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F7980", Offset = "0x1F7980")]
		[SerializeField]
		private float m_CaretBlinkRate;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F79C0", Offset = "0x1F79C0")]
		[SerializeField]
		private int m_CaretWidth;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private bool m_ReadOnly;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x181")]
		[SerializeField]
		private bool m_ShouldActivateOnSelect;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x184")]
		protected int m_CaretPosition;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x188")]
		protected int m_CaretSelectPosition;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x190")]
		private RectTransform caretRectTrans;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x198")]
		protected UIVertex[] m_CursorVerts;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x1A0")]
		private TextGenerator m_InputTextCache;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x1A8")]
		private CanvasRenderer m_CachedInputRenderer;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x1B0")]
		private bool m_PreventFontCallback;

		[NonSerialized]
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x1B8")]
		protected Mesh m_Mesh;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x1C0")]
		private bool m_AllowInput;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x1C1")]
		private bool m_ShouldActivateNextUpdate;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x1C2")]
		private bool m_UpdateDrag;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x1C3")]
		private bool m_DragPositionOutOfBounds;

		[Token(Token = "0x40000C2")]
		private const float kHScrollSpeed = 0.05f;

		[Token(Token = "0x40000C3")]
		private const float kVScrollSpeed = 0.1f;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x1C4")]
		protected bool m_CaretVisible;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x1C8")]
		private Coroutine m_BlinkCoroutine;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x1D0")]
		private float m_BlinkStartTime;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x1D4")]
		protected int m_DrawStart;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x1D8")]
		protected int m_DrawEnd;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x1E0")]
		private Coroutine m_DragCoroutine;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x1E8")]
		private string m_OriginalText;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x1F0")]
		private bool m_WasCanceled;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x1F1")]
		private bool m_HasDoneFocusTransition;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x1F8")]
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x200")]
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x201")]
		private bool m_IsCompositionActive;

		[Token(Token = "0x40000D0")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		[Token(Token = "0x40000D1")]
		private const string kOculusQuestDeviceModel = "Oculus Quest";

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x208")]
		private Event m_ProcessingEvent;

		[Token(Token = "0x40000D3")]
		private const int k_MaxTextLength = 16382;

		[Token(Token = "0x17000064")]
		private BaseInput input
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2C1846C", Offset = "0x2C1846C", VA = "0x2C1846C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private string compositionString
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2C185B8", Offset = "0x2C185B8", VA = "0x2C185B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		protected Mesh mesh
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2C18904", Offset = "0x2C18904", VA = "0x2C18904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		protected TextGenerator cachedInputTextGenerator
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2C189B8", Offset = "0x2C189B8", VA = "0x2C189B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public bool shouldHideMobileInput
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2C18A7C", Offset = "0x2C18A7C", VA = "0x2C18A7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2C18A20", Offset = "0x2C18A20", VA = "0x2C18A20")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public virtual bool shouldActivateOnSelect
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2C18AD0", Offset = "0x2C18AD0", VA = "0x2C18AD0", Slot = "60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2C18AC8", Offset = "0x2C18AC8", VA = "0x2C18AC8", Slot = "59")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public string text
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2C18B04", Offset = "0x2C18B04", VA = "0x2C18B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2C18B0C", Offset = "0x2C18B0C", VA = "0x2C18B0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool isFocused
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2C19434", Offset = "0x2C19434", VA = "0x2C19434")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006C")]
		public float caretBlinkRate
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2C1943C", Offset = "0x2C1943C", VA = "0x2C1943C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2C19444", Offset = "0x2C19444", VA = "0x2C19444")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int caretWidth
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2C19584", Offset = "0x2C19584", VA = "0x2C19584")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2C1958C", Offset = "0x2C1958C", VA = "0x2C1958C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Text textComponent
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2C196C4", Offset = "0x2C196C4", VA = "0x2C196C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2C196CC", Offset = "0x2C196CC", VA = "0x2C196CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Graphic placeholder
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2C1997C", Offset = "0x2C1997C", VA = "0x2C1997C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2C19984", Offset = "0x2C19984", VA = "0x2C19984")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Color caretColor
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2C199E0", Offset = "0x2C199E0", VA = "0x2C199E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2C19A20", Offset = "0x2C19A20", VA = "0x2C19A20")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool customCaretColor
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2C19AAC", Offset = "0x2C19AAC", VA = "0x2C19AAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2C19AB4", Offset = "0x2C19AB4", VA = "0x2C19AB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public Color selectionColor
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2C19B44", Offset = "0x2C19B44", VA = "0x2C19B44")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2C19B58", Offset = "0x2C19B58", VA = "0x2C19B58")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public SubmitEvent onEndEdit
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2C19BE4", Offset = "0x2C19BE4", VA = "0x2C19BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2C19BEC", Offset = "0x2C19BEC", VA = "0x2C19BEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F8DE4", Offset = "0x1F8DE4")]
		public OnChangeEvent onValueChange
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2C19C48", Offset = "0x2C19C48", VA = "0x2C19C48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2C19C50", Offset = "0x2C19C50", VA = "0x2C19C50")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public OnChangeEvent onValueChanged
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2C19D08", Offset = "0x2C19D08", VA = "0x2C19D08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2C19CAC", Offset = "0x2C19CAC", VA = "0x2C19CAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public OnValidateInput onValidateInput
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2C19D10", Offset = "0x2C19D10", VA = "0x2C19D10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2C19D18", Offset = "0x2C19D18", VA = "0x2C19D18")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int characterLimit
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2C19D74", Offset = "0x2C19D74", VA = "0x2C19D74")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2C19D7C", Offset = "0x2C19D7C", VA = "0x2C19D7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public ContentType contentType
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2C19E44", Offset = "0x2C19E44", VA = "0x2C19E44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2C19E4C", Offset = "0x2C19E4C", VA = "0x2C19E4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public LineType lineType
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2C19FA8", Offset = "0x2C19FA8", VA = "0x2C19FA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2C19FB0", Offset = "0x2C19FB0", VA = "0x2C19FB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public InputType inputType
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2C1A148", Offset = "0x2C1A148", VA = "0x2C1A148")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2C1A150", Offset = "0x2C1A150", VA = "0x2C1A150")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public TouchScreenKeyboard touchScreenKeyboard
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2C1A290", Offset = "0x2C1A290", VA = "0x2C1A290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public TouchScreenKeyboardType keyboardType
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2C1A298", Offset = "0x2C1A298", VA = "0x2C1A298")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2C1A2A0", Offset = "0x2C1A2A0", VA = "0x2C1A2A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public CharacterValidation characterValidation
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2C1A360", Offset = "0x2C1A360", VA = "0x2C1A360")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x2C1A368", Offset = "0x2C1A368", VA = "0x2C1A368")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool readOnly
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2C1A428", Offset = "0x2C1A428", VA = "0x2C1A428")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2C1A430", Offset = "0x2C1A430", VA = "0x2C1A430")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool multiLine
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2C1A438", Offset = "0x2C1A438", VA = "0x2C1A438")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000080")]
		public char asteriskChar
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2C1A44C", Offset = "0x2C1A44C", VA = "0x2C1A44C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2C1A454", Offset = "0x2C1A454", VA = "0x2C1A454")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool wasCanceled
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2C1A4CC", Offset = "0x2C1A4CC", VA = "0x2C1A4CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000082")]
		protected int caretPositionInternal
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2C1A50C", Offset = "0x2C1A50C", VA = "0x2C1A50C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2C1A53C", Offset = "0x2C1A53C", VA = "0x2C1A53C")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		protected int caretSelectPositionInternal
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2C1A574", Offset = "0x2C1A574", VA = "0x2C1A574")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2C1A5A4", Offset = "0x2C1A5A4", VA = "0x2C1A5A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		private bool hasSelection
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2C1A5DC", Offset = "0x2C1A5DC", VA = "0x2C1A5DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000085")]
		public int caretPosition
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x2C1A634", Offset = "0x2C1A634", VA = "0x2C1A634")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2C1A664", Offset = "0x2C1A664", VA = "0x2C1A664")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x2C1A7B0", Offset = "0x2C1A7B0", VA = "0x2C1A7B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x2C1A6F8", Offset = "0x2C1A6F8", VA = "0x2C1A6F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x2C1A7E0", Offset = "0x2C1A7E0", VA = "0x2C1A7E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x2C1A754", Offset = "0x2C1A754", VA = "0x2C1A754")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		private static string clipboard
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x2C1B35C", Offset = "0x2C1B35C", VA = "0x2C1B35C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x2C1B3B8", Offset = "0x2C1B3B8", VA = "0x2C1B3B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public virtual float minWidth
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x2C23488", Offset = "0x2C23488", VA = "0x2C23488", Slot = "75")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008A")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x2C23490", Offset = "0x2C23490", VA = "0x2C23490", Slot = "76")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008B")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x2C235A0", Offset = "0x2C235A0", VA = "0x2C235A0", Slot = "77")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008C")]
		public virtual float minHeight
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x2C235A8", Offset = "0x2C235A8", VA = "0x2C235A8", Slot = "78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x2C235B0", Offset = "0x2C235B0", VA = "0x2C235B0", Slot = "79")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x2C236EC", Offset = "0x2C236EC", VA = "0x2C236EC", Slot = "80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x2C236F4", Offset = "0x2C236F4", VA = "0x2C236F4", Slot = "81")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2C18658", Offset = "0x2C18658", VA = "0x2C18658")]
		protected InputField()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2C18EA0", Offset = "0x2C18EA0", VA = "0x2C18EA0")]
		public void SetTextWithoutNotify(string input)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2C18B14", Offset = "0x2C18B14", VA = "0x2C18B14")]
		private void SetText(string value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2C1A4D4", Offset = "0x2C1A4D4", VA = "0x2C1A4D4")]
		protected void ClampPos(ref int pos)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2C1A810", Offset = "0x2C1A810", VA = "0x2C1A810", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2C1AA98", Offset = "0x2C1AA98", VA = "0x2C1AA98", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C1AF6C", Offset = "0x2C1AF6C", VA = "0x2C1AF6C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2C1AFE4", Offset = "0x2C1AFE4", VA = "0x2C1AFE4")]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2C1B058", Offset = "0x2C1B058", VA = "0x2C1B058")]
		private void SetCaretVisible()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2C194D4", Offset = "0x2C194D4", VA = "0x2C194D4")]
		private void SetCaretActive()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2C1B098", Offset = "0x2C1B098", VA = "0x2C1B098")]
		private void UpdateCaretMaterial()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2C1B1E0", Offset = "0x2C1B1E0", VA = "0x2C1B1E0")]
		protected void OnFocus()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2C1B214", Offset = "0x2C1B214", VA = "0x2C1B214")]
		protected void SelectAll()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2C1B248", Offset = "0x2C1B248", VA = "0x2C1B248")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2C1B2C4", Offset = "0x2C1B2C4", VA = "0x2C1B2C4")]
		public void MoveTextStart(bool shift)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2C1B434", Offset = "0x2C1B434", VA = "0x2C1B434")]
		private bool TouchScreenKeyboardShouldBeUsed()
		{
			return default;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2C1B4CC", Offset = "0x2C1B4CC", VA = "0x2C1B4CC")]
		private bool InPlaceEditing()
		{
			return default;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2C1B504", Offset = "0x2C1B504", VA = "0x2C1B504")]
		private bool InPlaceEditingChanged()
		{
			return default;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2C1B594", Offset = "0x2C1B594", VA = "0x2C1B594")]
		private void UpdateCaretFromKeyboard()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2C1B6A0", Offset = "0x2C1B6A0", VA = "0x2C1B6A0", Slot = "61")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2C1CCF0", Offset = "0x2C1CCF0", VA = "0x2C1CCF0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F8848", Offset = "0x1F8848")]
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			return default;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2C1CF48", Offset = "0x2C1CF48", VA = "0x2C1CF48")]
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			return default;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2C1D184", Offset = "0x2C1D184", VA = "0x2C1D184")]
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			return default;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2C1D5D4", Offset = "0x2C1D5D4", VA = "0x2C1D5D4")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2C1D6C4", Offset = "0x2C1D6C4", VA = "0x2C1D6C4", Slot = "62")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2C1D6F0", Offset = "0x2C1D6F0", VA = "0x2C1D6F0", Slot = "63")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2C1DB74", Offset = "0x2C1DB74", VA = "0x2C1DB74")]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2C1DBEC", Offset = "0x2C1DBEC", VA = "0x2C1DBEC", Slot = "64")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C1DC14", Offset = "0x2C1DC14", VA = "0x2C1DC14", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C1DEB8", Offset = "0x2C1DEB8", VA = "0x2C1DEB8")]
		protected EditState KeyPressed(Event evt)
		{
			return default;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C1F064", Offset = "0x2C1F064", VA = "0x2C1F064")]
		private bool IsValidChar(char c)
		{
			return default;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C1F0D0", Offset = "0x2C1F0D0", VA = "0x2C1F0D0")]
		public void ProcessEvent(Event e)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2C1F0D4", Offset = "0x2C1F0D4", VA = "0x2C1F0D4", Slot = "65")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2C1E9EC", Offset = "0x2C1E9EC", VA = "0x2C1E9EC")]
		private string GetSelectedString()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C1F278", Offset = "0x2C1F278", VA = "0x2C1F278")]
		private int FindtNextWordBegin()
		{
			return default;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2C1EEDC", Offset = "0x2C1EEDC", VA = "0x2C1EEDC")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2C1F35C", Offset = "0x2C1F35C", VA = "0x2C1F35C")]
		private int FindtPrevWordBegin()
		{
			return default;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C1ED64", Offset = "0x2C1ED64", VA = "0x2C1ED64")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2C1F428", Offset = "0x2C1F428", VA = "0x2C1F428")]
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			return default;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2C1F54C", Offset = "0x2C1F54C", VA = "0x2C1F54C")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2C1FAD0", Offset = "0x2C1FAD0", VA = "0x2C1FAD0")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C1F05C", Offset = "0x2C1F05C", VA = "0x2C1F05C")]
		private void MoveDown(bool shift)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C1FFE4", Offset = "0x2C1FFE4", VA = "0x2C1FFE4")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C1F054", Offset = "0x2C1F054", VA = "0x2C1F054")]
		private void MoveUp(bool shift)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2C20198", Offset = "0x2C20198", VA = "0x2C20198")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2C1EACC", Offset = "0x2C1EACC", VA = "0x2C1EACC")]
		private void Delete()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2C1E7FC", Offset = "0x2C1E7FC", VA = "0x2C1E7FC")]
		private void ForwardSpace()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2C1E598", Offset = "0x2C1E598", VA = "0x2C1E598")]
		private void Backspace()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2C2031C", Offset = "0x2C2031C", VA = "0x2C2031C")]
		private void Insert(char c)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2C1ED08", Offset = "0x2C1ED08", VA = "0x2C1ED08")]
		private void UpdateTouchKeyboardFromEditChanges()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2C1CC68", Offset = "0x2C1CC68", VA = "0x2C1CC68")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2C18EA8", Offset = "0x2C18EA8", VA = "0x2C18EA8")]
		private void SendOnValueChanged()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2C204BC", Offset = "0x2C204BC", VA = "0x2C204BC")]
		protected void SendOnSubmit()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2C2054C", Offset = "0x2C2054C", VA = "0x2C2054C", Slot = "66")]
		protected virtual void Append(string input)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2C20614", Offset = "0x2C20614", VA = "0x2C20614", Slot = "67")]
		protected virtual void Append(char input)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2C18F38", Offset = "0x2C18F38", VA = "0x2C18F38")]
		protected void UpdateLabel()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2C218CC", Offset = "0x2C218CC", VA = "0x2C218CC")]
		private bool IsSelectionVisible()
		{
			return default;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2C2197C", Offset = "0x2C2197C", VA = "0x2C2197C")]
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			return default;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2C1D438", Offset = "0x2C1D438", VA = "0x2C1D438")]
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			return default;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2C208C4", Offset = "0x2C208C4", VA = "0x2C208C4")]
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2C21AF4", Offset = "0x2C21AF4", VA = "0x2C21AF4")]
		public void ForceLabelUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2C19648", Offset = "0x2C19648", VA = "0x2C19648")]
		private void MarkGeometryAsDirty()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2C21AF8", Offset = "0x2C21AF8", VA = "0x2C21AF8", Slot = "68")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2C21FA4", Offset = "0x2C21FA4", VA = "0x2C21FA4", Slot = "69")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2C21FA8", Offset = "0x2C21FA8", VA = "0x2C21FA8", Slot = "70")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2C21B08", Offset = "0x2C21B08", VA = "0x2C21B08")]
		private void UpdateGeometry()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2C1C0C8", Offset = "0x2C1C0C8", VA = "0x2C1C0C8")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2C21FAC", Offset = "0x2C21FAC", VA = "0x2C21FAC")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2C22208", Offset = "0x2C22208", VA = "0x2C22208")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2C230D4", Offset = "0x2C230D4", VA = "0x2C230D4")]
		private void CreateCursorVerts()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2C2295C", Offset = "0x2C2295C", VA = "0x2C2295C")]
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2C1C618", Offset = "0x2C1C618", VA = "0x2C1C618")]
		protected char Validate(string text, int pos, char ch)
		{
			return default;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2C2321C", Offset = "0x2C2321C", VA = "0x2C2321C")]
		public void ActivateInputField()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2C1BCF4", Offset = "0x2C1BCF4", VA = "0x2C1BCF4")]
		private void ActivateInputFieldInternal()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2C23364", Offset = "0x2C23364", VA = "0x2C23364", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2C233B0", Offset = "0x2C233B0", VA = "0x2C233B0", Slot = "71")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2C1AD14", Offset = "0x2C1AD14", VA = "0x2C1AD14")]
		public void DeactivateInputField()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2C233D0", Offset = "0x2C233D0", VA = "0x2C233D0", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2C23400", Offset = "0x2C23400", VA = "0x2C23400", Slot = "72")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2C19EC4", Offset = "0x2C19EC4", VA = "0x2C19EC4")]
		private void EnforceContentType()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2C18840", Offset = "0x2C18840", VA = "0x2C18840")]
		private void EnforceTextHOverflow()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2C1A07C", Offset = "0x2C1A07C", VA = "0x2C1A07C")]
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2C1A210", Offset = "0x2C1A210", VA = "0x2C1A210")]
		private void SetToCustom()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2C23454", Offset = "0x2C23454", VA = "0x2C23454", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2C23480", Offset = "0x2C23480", VA = "0x2C23480", Slot = "73")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C23484", Offset = "0x2C23484", VA = "0x2C23484", Slot = "74")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[SpecialName]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2C23798", Offset = "0x2C23798", VA = "0x2C23798", Slot = "46")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
