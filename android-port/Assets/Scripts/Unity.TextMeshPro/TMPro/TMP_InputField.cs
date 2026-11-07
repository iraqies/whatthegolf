using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x2000030")]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler
	{
		[Token(Token = "0x2000031")]
		public enum ContentType
		{
			[Token(Token = "0x4000174")]
			Standard = 0,
			[Token(Token = "0x4000175")]
			Autocorrected = 1,
			[Token(Token = "0x4000176")]
			IntegerNumber = 2,
			[Token(Token = "0x4000177")]
			DecimalNumber = 3,
			[Token(Token = "0x4000178")]
			Alphanumeric = 4,
			[Token(Token = "0x4000179")]
			Name = 5,
			[Token(Token = "0x400017A")]
			EmailAddress = 6,
			[Token(Token = "0x400017B")]
			Password = 7,
			[Token(Token = "0x400017C")]
			Pin = 8,
			[Token(Token = "0x400017D")]
			Custom = 9
		}

		[Token(Token = "0x2000032")]
		public enum InputType
		{
			[Token(Token = "0x400017F")]
			Standard = 0,
			[Token(Token = "0x4000180")]
			AutoCorrect = 1,
			[Token(Token = "0x4000181")]
			Password = 2
		}

		[Token(Token = "0x2000033")]
		public enum CharacterValidation
		{
			[Token(Token = "0x4000183")]
			None = 0,
			[Token(Token = "0x4000184")]
			Digit = 1,
			[Token(Token = "0x4000185")]
			Integer = 2,
			[Token(Token = "0x4000186")]
			Decimal = 3,
			[Token(Token = "0x4000187")]
			Alphanumeric = 4,
			[Token(Token = "0x4000188")]
			Name = 5,
			[Token(Token = "0x4000189")]
			Regex = 6,
			[Token(Token = "0x400018A")]
			EmailAddress = 7,
			[Token(Token = "0x400018B")]
			CustomValidator = 8
		}

		[Token(Token = "0x2000034")]
		public enum LineType
		{
			[Token(Token = "0x400018D")]
			SingleLine = 0,
			[Token(Token = "0x400018E")]
			MultiLineSubmit = 1,
			[Token(Token = "0x400018F")]
			MultiLineNewline = 2
		}

		[Token(Token = "0x2000035")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		[Serializable]
		[Token(Token = "0x2000036")]
		public class SubmitEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x2ADF724", Offset = "0x2ADF724", VA = "0x2ADF724")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x2ADF114", Offset = "0x2ADF114", VA = "0x2ADF114")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x2ADF6CC", Offset = "0x2ADF6CC", VA = "0x2ADF6CC")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000039")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x2ADF77C", Offset = "0x2ADF77C", VA = "0x2ADF77C")]
			public TextSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status>
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x2ADF7D4", Offset = "0x2ADF7D4", VA = "0x2ADF7D4")]
			public TouchScreenKeyboardEvent()
			{
			}
		}

		[Token(Token = "0x200003B")]
		protected enum EditState
		{
			[Token(Token = "0x4000191")]
			Continue = 0,
			[Token(Token = "0x4000192")]
			Finish = 1
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9154", Offset = "0x1B9154")]
		private sealed class _003CCaretBlink_003Ed__276 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x20")]
			public TMP_InputField _003C_003E4__this;

			[Token(Token = "0x17000089")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x2ADEDD8", Offset = "0x2ADEDD8", VA = "0x2ADEDD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700008A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600021D")]
				[Address(RVA = "0x2ADEE20", Offset = "0x2ADEE20", VA = "0x2ADEE20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x2ADEC84", Offset = "0x2ADEC84", VA = "0x2ADEC84")]
			[DebuggerHidden]
			public _003CCaretBlink_003Ed__276(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x2ADECB0", Offset = "0x2ADECB0", VA = "0x2ADECB0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x2ADECB4", Offset = "0x2ADECB4", VA = "0x2ADECB4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x2ADEDD8", Offset = "0x2ADEDD8", VA = "0x2ADEDD8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x2ADEDE0", Offset = "0x2ADEDE0", VA = "0x2ADEDE0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x2ADEE20", Offset = "0x2ADEE20", VA = "0x2ADEE20", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9164", Offset = "0x1B9164")]
		private sealed class _003CMouseDragOutsideRect_003Ed__294 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x20")]
			public TMP_InputField _003C_003E4__this;

			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x28")]
			public PointerEventData eventData;

			[Token(Token = "0x1700008B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x2ADF0C4", Offset = "0x2ADF0C4", VA = "0x2ADF0C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700008C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000223")]
				[Address(RVA = "0x2ADF10C", Offset = "0x2ADF10C", VA = "0x2ADF10C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2ADEE28", Offset = "0x2ADEE28", VA = "0x2ADEE28")]
			[DebuggerHidden]
			public _003CMouseDragOutsideRect_003Ed__294(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x2ADEE54", Offset = "0x2ADEE54", VA = "0x2ADEE54", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2ADEE58", Offset = "0x2ADEE58", VA = "0x2ADEE58", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2ADF0C4", Offset = "0x2ADF0C4", VA = "0x2ADF0C4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2ADF0CC", Offset = "0x2ADF0CC", VA = "0x2ADF0CC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2ADF10C", Offset = "0x2ADF10C", VA = "0x2ADF10C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0xF8")]
		protected TouchScreenKeyboard m_SoftKeyboard;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] kSeparators;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x100")]
		protected RectTransform m_RectTransform;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		protected RectTransform m_TextViewport;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x110")]
		protected RectMask2D m_TextComponentRectMask;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x118")]
		protected RectMask2D m_TextViewportRectMask;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x120")]
		private Rect m_CachedViewportRect;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected TMP_Text m_TextComponent;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x138")]
		protected RectTransform m_TextComponentRectTransform;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected Graphic m_Placeholder;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x158")]
		private bool m_IsDrivenByLayoutComponents;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private LayoutGroup m_LayoutGroup;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x168")]
		private IScrollHandler m_IScrollHandlerParent;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x170")]
		private float m_ScrollPosition;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		protected float m_ScrollSensitivity;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private ContentType m_ContentType;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private InputType m_InputType;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private char m_AsteriskChar;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private LineType m_LineType;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private bool m_HideMobileInput;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x18D")]
		[SerializeField]
		private bool m_HideSoftKeyboard;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private CharacterValidation m_CharacterValidation;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private string m_RegexValue;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float m_GlobalPointSize;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private int m_CharacterLimit;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private SubmitEvent m_OnEndEdit;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private SubmitEvent m_OnSubmit;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private SelectionEvent m_OnSelect;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private SelectionEvent m_OnDeselect;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private TextSelectionEvent m_OnTextSelection;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private OnValidateInput m_OnValidateInput;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private Color m_CaretColor;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private bool m_CustomCaretColor;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		private Color m_SelectionColor;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		protected string m_Text;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x220")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B9BDC", Offset = "0x1B9BDC")]
		[SerializeField]
		private float m_CaretBlinkRate;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x224")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B9C1C", Offset = "0x1B9C1C")]
		[SerializeField]
		private int m_CaretWidth;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private bool m_ReadOnly;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x229")]
		[SerializeField]
		private bool m_RichText;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x22C")]
		protected int m_StringPosition;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x230")]
		protected int m_StringSelectPosition;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x234")]
		protected int m_CaretPosition;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x238")]
		protected int m_CaretSelectPosition;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x240")]
		private RectTransform caretRectTrans;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x248")]
		protected UIVertex[] m_CursorVerts;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x250")]
		private CanvasRenderer m_CachedInputRenderer;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x258")]
		private Vector2 m_LastPosition;

		[NonSerialized]
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x260")]
		protected Mesh m_Mesh;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x268")]
		private bool m_AllowInput;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x269")]
		private bool m_ShouldActivateNextUpdate;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x26A")]
		private bool m_UpdateDrag;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x26B")]
		private bool m_DragPositionOutOfBounds;

		[Token(Token = "0x400014E")]
		private const float kHScrollSpeed = 0.05f;

		[Token(Token = "0x400014F")]
		private const float kVScrollSpeed = 0.1f;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x26C")]
		protected bool m_CaretVisible;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x270")]
		private Coroutine m_BlinkCoroutine;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x278")]
		private float m_BlinkStartTime;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x280")]
		private Coroutine m_DragCoroutine;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x288")]
		private string m_OriginalText;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x290")]
		private bool m_WasCanceled;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x291")]
		private bool m_HasDoneFocusTransition;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x298")]
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x2A0")]
		private bool m_PreventCallback;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x2A1")]
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x2A2")]
		private bool m_IsTextComponentUpdateRequired;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x2A3")]
		private bool m_isLastKeyBackspace;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x2A4")]
		private float m_PointerDownClickStartTime;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x2A8")]
		private float m_KeyDownStartTime;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x2AC")]
		private float m_DoubleClickDelay;

		[Token(Token = "0x400015F")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x2B0")]
		private bool m_IsCompositionActive;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x2B1")]
		private bool m_ShouldUpdateIMEWindowPosition;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x2B4")]
		private int m_PreviousIMEInsertionLine;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		protected bool m_OnFocusSelectAll;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x2C1")]
		protected bool m_isSelectAll;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x2C2")]
		[SerializeField]
		protected bool m_ResetOnDeActivation;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x2C3")]
		private bool m_SelectionStillActive;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x2C4")]
		private bool m_ReleaseSelection;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x2C8")]
		private GameObject m_PreviouslySelectedObject;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x2D1")]
		[SerializeField]
		protected bool m_isRichTextEditingAllowed;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x2D4")]
		[SerializeField]
		protected int m_LineLimit;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x2E0")]
		private bool m_isSelected;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x2E1")]
		private bool m_IsStringPositionDirty;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x2E2")]
		private bool m_IsCaretPositionDirty;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x2E3")]
		private bool m_forceRectTransformAdjustment;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x2E8")]
		private Event m_ProcessingEvent;

		[Token(Token = "0x17000048")]
		private BaseInput inputSystem
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2A8A2C0", Offset = "0x2A8A2C0", VA = "0x2A8A2C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private string compositionString
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x2A8A40C", Offset = "0x2A8A40C", VA = "0x2A8A40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private int compositionLength
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2A8A4AC", Offset = "0x2A8A4AC", VA = "0x2A8A4AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004B")]
		protected Mesh mesh
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2A8A888", Offset = "0x2A8A888", VA = "0x2A8A888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public bool shouldHideMobileInput
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2A8A93C", Offset = "0x2A8A93C", VA = "0x2A8A93C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2A8A988", Offset = "0x2A8A988", VA = "0x2A8A988")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool shouldHideSoftKeyboard
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2A8AA24", Offset = "0x2A8AA24", VA = "0x2A8AA24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2A8AABC", Offset = "0x2A8AABC", VA = "0x2A8AABC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public string text
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2A8AC24", Offset = "0x2A8AC24", VA = "0x2A8AC24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2A8AC2C", Offset = "0x2A8AC2C", VA = "0x2A8AC2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool isFocused
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2A8B398", Offset = "0x2A8B398", VA = "0x2A8B398")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000050")]
		public float caretBlinkRate
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2A8B3A0", Offset = "0x2A8B3A0", VA = "0x2A8B3A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2A8B3A8", Offset = "0x2A8B3A8", VA = "0x2A8B3A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int caretWidth
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2A8B4E8", Offset = "0x2A8B4E8", VA = "0x2A8B4E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2A8B4F0", Offset = "0x2A8B4F0", VA = "0x2A8B4F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public RectTransform textViewport
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2A8B628", Offset = "0x2A8B628", VA = "0x2A8B628")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2A8B630", Offset = "0x2A8B630", VA = "0x2A8B630")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public TMP_Text textComponent
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2A8B68C", Offset = "0x2A8B68C", VA = "0x2A8B68C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2A8B694", Offset = "0x2A8B694", VA = "0x2A8B694")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public Graphic placeholder
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2A8B70C", Offset = "0x2A8B70C", VA = "0x2A8B70C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2A8B714", Offset = "0x2A8B714", VA = "0x2A8B714")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2A8B770", Offset = "0x2A8B770", VA = "0x2A8B770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2A8B778", Offset = "0x2A8B778", VA = "0x2A8B778")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float scrollSensitivity
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2A8B968", Offset = "0x2A8B968", VA = "0x2A8B968")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2A8B970", Offset = "0x2A8B970", VA = "0x2A8B970")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Color caretColor
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2A8BA38", Offset = "0x2A8BA38", VA = "0x2A8BA38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2A8BA78", Offset = "0x2A8BA78", VA = "0x2A8BA78")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public bool customCaretColor
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2A8BB38", Offset = "0x2A8BB38", VA = "0x2A8BB38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2A8BB40", Offset = "0x2A8BB40", VA = "0x2A8BB40")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Color selectionColor
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2A8BBD0", Offset = "0x2A8BBD0", VA = "0x2A8BBD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2A8BBE4", Offset = "0x2A8BBE4", VA = "0x2A8BBE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public SubmitEvent onEndEdit
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2A8BCA4", Offset = "0x2A8BCA4", VA = "0x2A8BCA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2A8BCAC", Offset = "0x2A8BCAC", VA = "0x2A8BCAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public SubmitEvent onSubmit
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2A8BD08", Offset = "0x2A8BD08", VA = "0x2A8BD08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2A8BD10", Offset = "0x2A8BD10", VA = "0x2A8BD10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public SelectionEvent onSelect
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2A8BD6C", Offset = "0x2A8BD6C", VA = "0x2A8BD6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2A8BD74", Offset = "0x2A8BD74", VA = "0x2A8BD74")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public SelectionEvent onDeselect
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2A8BDD0", Offset = "0x2A8BDD0", VA = "0x2A8BDD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2A8BDD8", Offset = "0x2A8BDD8", VA = "0x2A8BDD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public TextSelectionEvent onTextSelection
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2A8BE34", Offset = "0x2A8BE34", VA = "0x2A8BE34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2A8BE3C", Offset = "0x2A8BE3C", VA = "0x2A8BE3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public TextSelectionEvent onEndTextSelection
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2A8BE98", Offset = "0x2A8BE98", VA = "0x2A8BE98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2A8BEA0", Offset = "0x2A8BEA0", VA = "0x2A8BEA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public OnChangeEvent onValueChanged
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2A8BEFC", Offset = "0x2A8BEFC", VA = "0x2A8BEFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2A8BF04", Offset = "0x2A8BF04", VA = "0x2A8BF04")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2A8BF60", Offset = "0x2A8BF60", VA = "0x2A8BF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2A8BF68", Offset = "0x2A8BF68", VA = "0x2A8BF68")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public OnValidateInput onValidateInput
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2A8BFC4", Offset = "0x2A8BFC4", VA = "0x2A8BFC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2A8BFCC", Offset = "0x2A8BFCC", VA = "0x2A8BFCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public int characterLimit
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2A8C028", Offset = "0x2A8C028", VA = "0x2A8C028")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2A8C030", Offset = "0x2A8C030", VA = "0x2A8C030")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float pointSize
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2A8C0F8", Offset = "0x2A8C0F8", VA = "0x2A8C0F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2A8C100", Offset = "0x2A8C100", VA = "0x2A8C100")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public TMP_FontAsset fontAsset
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2A8C2BC", Offset = "0x2A8C2BC", VA = "0x2A8C2BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2A8C2C4", Offset = "0x2A8C2C4", VA = "0x2A8C2C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool onFocusSelectAll
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2A8C43C", Offset = "0x2A8C43C", VA = "0x2A8C43C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2A8C444", Offset = "0x2A8C444", VA = "0x2A8C444")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool resetOnDeActivation
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2A8C44C", Offset = "0x2A8C44C", VA = "0x2A8C44C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2A8C454", Offset = "0x2A8C454", VA = "0x2A8C454")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool restoreOriginalTextOnEscape
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2A8C45C", Offset = "0x2A8C45C", VA = "0x2A8C45C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2A8C464", Offset = "0x2A8C464", VA = "0x2A8C464")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool isRichTextEditingAllowed
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2A8C46C", Offset = "0x2A8C46C", VA = "0x2A8C46C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2A8C474", Offset = "0x2A8C474", VA = "0x2A8C474")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public ContentType contentType
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2A8C47C", Offset = "0x2A8C47C", VA = "0x2A8C47C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2A8C484", Offset = "0x2A8C484", VA = "0x2A8C484")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public LineType lineType
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2A8C5E0", Offset = "0x2A8C5E0", VA = "0x2A8C5E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2A8C5E8", Offset = "0x2A8C5E8", VA = "0x2A8C5E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public int lineLimit
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2A8C780", Offset = "0x2A8C780", VA = "0x2A8C780")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2A8C788", Offset = "0x2A8C788", VA = "0x2A8C788")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public InputType inputType
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2A8C804", Offset = "0x2A8C804", VA = "0x2A8C804")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2A8C80C", Offset = "0x2A8C80C", VA = "0x2A8C80C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public TouchScreenKeyboardType keyboardType
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2A8C94C", Offset = "0x2A8C94C", VA = "0x2A8C94C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2A8C954", Offset = "0x2A8C954", VA = "0x2A8C954")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public CharacterValidation characterValidation
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2A8CA14", Offset = "0x2A8CA14", VA = "0x2A8CA14")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2A8CA1C", Offset = "0x2A8CA1C", VA = "0x2A8CA1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public TMP_InputValidator inputValidator
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2A8CADC", Offset = "0x2A8CADC", VA = "0x2A8CADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2A8CAE4", Offset = "0x2A8CAE4", VA = "0x2A8CAE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool readOnly
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2A8CC24", Offset = "0x2A8CC24", VA = "0x2A8CC24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2A8CC2C", Offset = "0x2A8CC2C", VA = "0x2A8CC2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool richText
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2A8CC34", Offset = "0x2A8CC34", VA = "0x2A8CC34")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2A8CC3C", Offset = "0x2A8CC3C", VA = "0x2A8CC3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool multiLine
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2A8CCEC", Offset = "0x2A8CCEC", VA = "0x2A8CCEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000074")]
		public char asteriskChar
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2A8CD00", Offset = "0x2A8CD00", VA = "0x2A8CD00")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2A8CD08", Offset = "0x2A8CD08", VA = "0x2A8CD08")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool wasCanceled
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2A8CD80", Offset = "0x2A8CD80", VA = "0x2A8CD80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000076")]
		protected int caretPositionInternal
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2A8CE0C", Offset = "0x2A8CE0C", VA = "0x2A8CE0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2A8CE4C", Offset = "0x2A8CE4C", VA = "0x2A8CE4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		protected int stringPositionInternal
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2A8CE98", Offset = "0x2A8CE98", VA = "0x2A8CE98")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2A8CED8", Offset = "0x2A8CED8", VA = "0x2A8CED8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		protected int caretSelectPositionInternal
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2A8CF10", Offset = "0x2A8CF10", VA = "0x2A8CF10")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2A8CF50", Offset = "0x2A8CF50", VA = "0x2A8CF50")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		protected int stringSelectPositionInternal
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x2A8CF9C", Offset = "0x2A8CF9C", VA = "0x2A8CF9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2A8CFDC", Offset = "0x2A8CFDC", VA = "0x2A8CFDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		private bool hasSelection
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2A8D014", Offset = "0x2A8D014", VA = "0x2A8D014")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007B")]
		public int caretPosition
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2A8D08C", Offset = "0x2A8D08C", VA = "0x2A8D08C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2A8D0CC", Offset = "0x2A8D0CC", VA = "0x2A8D0CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2A8D29C", Offset = "0x2A8D29C", VA = "0x2A8D29C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2A8D1AC", Offset = "0x2A8D1AC", VA = "0x2A8D1AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2A8D2DC", Offset = "0x2A8D2DC", VA = "0x2A8D2DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2A8D224", Offset = "0x2A8D224", VA = "0x2A8D224")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public int stringPosition
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2A8D31C", Offset = "0x2A8D31C", VA = "0x2A8D31C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2A8D35C", Offset = "0x2A8D35C", VA = "0x2A8D35C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public int selectionStringAnchorPosition
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2A8D4FC", Offset = "0x2A8D4FC", VA = "0x2A8D4FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2A8D424", Offset = "0x2A8D424", VA = "0x2A8D424")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public int selectionStringFocusPosition
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x2A8D53C", Offset = "0x2A8D53C", VA = "0x2A8D53C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2A8D490", Offset = "0x2A8D490", VA = "0x2A8D490")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		private static string clipboard
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x2A8F4E4", Offset = "0x2A8F4E4", VA = "0x2A8F4E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x2A8F540", Offset = "0x2A8F540", VA = "0x2A8F540")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x2A9836C", Offset = "0x2A9836C", VA = "0x2A9836C", Slot = "76")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000083")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2A98374", Offset = "0x2A98374", VA = "0x2A98374", Slot = "77")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000084")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x2A984E0", Offset = "0x2A984E0", VA = "0x2A984E0", Slot = "78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000085")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2A984E8", Offset = "0x2A984E8", VA = "0x2A984E8", Slot = "79")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000086")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x2A984F0", Offset = "0x2A984F0", VA = "0x2A984F0", Slot = "80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000087")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x2A9865C", Offset = "0x2A9865C", VA = "0x2A9865C", Slot = "81")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000088")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x2A98664", Offset = "0x2A98664", VA = "0x2A98664", Slot = "82")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2A8A4E0", Offset = "0x2A8A4E0", VA = "0x2A8A4E0")]
		protected TMP_InputField()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2A8ABE0", Offset = "0x2A8ABE0", VA = "0x2A8ABE0")]
		private bool isKeyboardUsingEvents()
		{
			return default;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2A8AD9C", Offset = "0x2A8AD9C", VA = "0x2A8AD9C")]
		public void SetTextWithoutNotify(string input)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2A8AC34", Offset = "0x2A8AC34", VA = "0x2A8AC34")]
		private void SetText(string value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2A8CD88", Offset = "0x2A8CD88", VA = "0x2A8CD88")]
		protected void ClampStringPos(ref int pos)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2A8CDC0", Offset = "0x2A8CDC0", VA = "0x2A8CDC0")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2A8D57C", Offset = "0x2A8D57C", VA = "0x2A8D57C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2A8E29C", Offset = "0x2A8E29C", VA = "0x2A8E29C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2A8E8A4", Offset = "0x2A8E8A4", VA = "0x2A8E8A4")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2A8EBE0", Offset = "0x2A8EBE0", VA = "0x2A8EBE0")]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2A8EC54", Offset = "0x2A8EC54", VA = "0x2A8EC54")]
		private void SetCaretVisible()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2A8B438", Offset = "0x2A8B438", VA = "0x2A8B438")]
		private void SetCaretActive()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2A8EC94", Offset = "0x2A8EC94", VA = "0x2A8EC94")]
		protected void OnFocus()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2A8ECD8", Offset = "0x2A8ECD8", VA = "0x2A8ECD8")]
		protected void SelectAll()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2A8ED14", Offset = "0x2A8ED14", VA = "0x2A8ED14")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2A8EEF4", Offset = "0x2A8EEF4", VA = "0x2A8EEF4")]
		public void MoveTextStart(bool shift)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2A8F06C", Offset = "0x2A8F06C", VA = "0x2A8F06C")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2A8F2A8", Offset = "0x2A8F2A8", VA = "0x2A8F2A8")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2A8F5BC", Offset = "0x2A8F5BC", VA = "0x2A8F5BC")]
		private bool InPlaceEditing()
		{
			return default;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2A8F760", Offset = "0x2A8F760", VA = "0x2A8F760")]
		private void UpdateStringPositionFromKeyboard()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2A8F94C", Offset = "0x2A8F94C", VA = "0x2A8F94C", Slot = "60")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2A91098", Offset = "0x2A91098", VA = "0x2A91098")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2A9121C", Offset = "0x2A9121C", VA = "0x2A9121C", Slot = "61")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2A91248", Offset = "0x2A91248", VA = "0x2A91248", Slot = "62")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2A91614", Offset = "0x2A91614", VA = "0x2A91614")]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2A9168C", Offset = "0x2A9168C", VA = "0x2A9168C", Slot = "63")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2A916B4", Offset = "0x2A916B4", VA = "0x2A916B4", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2A92094", Offset = "0x2A92094", VA = "0x2A92094")]
		protected EditState KeyPressed(Event evt)
		{
			return default;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2A93F84", Offset = "0x2A93F84", VA = "0x2A93F84", Slot = "64")]
		protected virtual bool IsValidChar(char c)
		{
			return default;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2A93F98", Offset = "0x2A93F98", VA = "0x2A93F98")]
		public void ProcessEvent(Event e)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2A93F9C", Offset = "0x2A93F9C", VA = "0x2A93F9C", Slot = "65")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2A94204", Offset = "0x2A94204", VA = "0x2A94204", Slot = "66")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2A94404", Offset = "0x2A94404", VA = "0x2A94404")]
		private float GetScrollPositionRelativeToViewport()
		{
			return default;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2A93074", Offset = "0x2A93074", VA = "0x2A93074")]
		private string GetSelectedString()
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2A94700", Offset = "0x2A94700", VA = "0x2A94700")]
		private int FindNextWordBegin()
		{
			return default;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2A93978", Offset = "0x2A93978", VA = "0x2A93978")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2A94804", Offset = "0x2A94804", VA = "0x2A94804")]
		private int FindPrevWordBegin()
		{
			return default;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2A933BC", Offset = "0x2A933BC", VA = "0x2A933BC")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2A948F0", Offset = "0x2A948F0", VA = "0x2A948F0")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2A94A5C", Offset = "0x2A94A5C", VA = "0x2A94A5C")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2A94BD4", Offset = "0x2A94BD4", VA = "0x2A94BD4")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2A94E10", Offset = "0x2A94E10", VA = "0x2A94E10")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2A93F6C", Offset = "0x2A93F6C", VA = "0x2A93F6C")]
		private void MoveDown(bool shift)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2A95054", Offset = "0x2A95054", VA = "0x2A95054")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2A93F64", Offset = "0x2A93F64", VA = "0x2A93F64")]
		private void MoveUp(bool shift)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2A95358", Offset = "0x2A95358", VA = "0x2A95358")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2A93F74", Offset = "0x2A93F74", VA = "0x2A93F74")]
		private void MovePageUp(bool shift)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2A95648", Offset = "0x2A95648", VA = "0x2A95648")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2A93F7C", Offset = "0x2A93F7C", VA = "0x2A93F7C")]
		private void MovePageDown(bool shift)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2A95A78", Offset = "0x2A95A78", VA = "0x2A95A78")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2A9318C", Offset = "0x2A9318C", VA = "0x2A9318C")]
		private void Delete()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2A92CAC", Offset = "0x2A92CAC", VA = "0x2A92CAC")]
		private void DeleteKey()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2A926A4", Offset = "0x2A926A4", VA = "0x2A926A4")]
		private void Backspace()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2A95EC0", Offset = "0x2A95EC0", VA = "0x2A95EC0", Slot = "67")]
		protected virtual void Append(string input)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2A95F78", Offset = "0x2A95F78", VA = "0x2A95F78", Slot = "68")]
		protected virtual void Append(char input)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2A962C0", Offset = "0x2A962C0", VA = "0x2A962C0")]
		private void Insert(char c)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2A93370", Offset = "0x2A93370", VA = "0x2A93370")]
		private void UpdateTouchKeyboardFromEditChanges()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2A91034", Offset = "0x2A91034", VA = "0x2A91034")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2A8B338", Offset = "0x2A8B338", VA = "0x2A8B338")]
		private void SendOnValueChanged()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2A96428", Offset = "0x2A96428", VA = "0x2A96428")]
		protected void SendOnEndEdit()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2A941A4", Offset = "0x2A941A4", VA = "0x2A941A4")]
		protected void SendOnSubmit()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2A96488", Offset = "0x2A96488", VA = "0x2A96488")]
		protected void SendOnFocus()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2A964E8", Offset = "0x2A964E8", VA = "0x2A964E8")]
		protected void SendOnFocusLost()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2A96548", Offset = "0x2A96548", VA = "0x2A96548")]
		protected void SendOnTextSelection()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2A9661C", Offset = "0x2A9661C", VA = "0x2A9661C")]
		protected void SendOnEndTextSelection()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2A906D4", Offset = "0x2A906D4", VA = "0x2A906D4")]
		protected void SendTouchScreenKeyboardStatusChanged()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2A8ADA4", Offset = "0x2A8ADA4", VA = "0x2A8ADA4")]
		protected void UpdateLabel()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2A8EAD8", Offset = "0x2A8EAD8", VA = "0x2A8EAD8")]
		private void UpdateScrollbar()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2A966E8", Offset = "0x2A966E8", VA = "0x2A966E8")]
		private void OnScrollbarValueChange(float value)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2A8E298", Offset = "0x2A8E298", VA = "0x2A8E298")]
		private void UpdateMaskRegions()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2A94524", Offset = "0x2A94524", VA = "0x2A94524")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2A8EA58", Offset = "0x2A8EA58", VA = "0x2A8EA58")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2A96728", Offset = "0x2A96728", VA = "0x2A96728")]
		private int GetMinCaretPositionFromStringIndex(int stringIndex)
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2A967AC", Offset = "0x2A967AC", VA = "0x2A967AC")]
		private int GetMaxCaretPositionFromStringIndex(int stringIndex)
		{
			return default;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2A8EE70", Offset = "0x2A8EE70", VA = "0x2A8EE70")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2A9682C", Offset = "0x2A9682C", VA = "0x2A9682C")]
		public void ForceLabelUpdate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2A8B5AC", Offset = "0x2A8B5AC", VA = "0x2A8B5AC")]
		private void MarkGeometryAsDirty()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2A96830", Offset = "0x2A96830", VA = "0x2A96830", Slot = "69")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2A96908", Offset = "0x2A96908", VA = "0x2A96908", Slot = "70")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2A9690C", Offset = "0x2A9690C", VA = "0x2A9690C", Slot = "71")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2A96840", Offset = "0x2A96840", VA = "0x2A96840")]
		private void UpdateGeometry()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2A8DD48", Offset = "0x2A8DD48", VA = "0x2A8DD48")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2A96910", Offset = "0x2A96910", VA = "0x2A96910")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2A96CF8", Offset = "0x2A96CF8", VA = "0x2A96CF8")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2A979B4", Offset = "0x2A979B4", VA = "0x2A979B4")]
		private void CreateCursorVerts()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2A973A0", Offset = "0x2A973A0", VA = "0x2A973A0")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2A97AFC", Offset = "0x2A97AFC", VA = "0x2A97AFC")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2A9074C", Offset = "0x2A9074C", VA = "0x2A9074C")]
		protected char Validate(string text, int pos, char ch)
		{
			return default;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2A9805C", Offset = "0x2A9805C", VA = "0x2A9805C")]
		public void ActivateInputField()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2A900DC", Offset = "0x2A900DC", VA = "0x2A900DC")]
		private void ActivateInputFieldInternal()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2A981A0", Offset = "0x2A981A0", VA = "0x2A981A0", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2A98204", Offset = "0x2A98204", VA = "0x2A98204", Slot = "72")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2A98224", Offset = "0x2A98224", VA = "0x2A98224")]
		public void OnControlClick()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2A90618", Offset = "0x2A90618", VA = "0x2A90618")]
		public void ReleaseSelection()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2A8E64C", Offset = "0x2A8E64C", VA = "0x2A8E64C")]
		public void DeactivateInputField(bool clearSelection = false)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2A98228", Offset = "0x2A98228", VA = "0x2A98228", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2A982A0", Offset = "0x2A982A0", VA = "0x2A982A0", Slot = "73")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2A8C4FC", Offset = "0x2A8C4FC", VA = "0x2A8C4FC")]
		private void EnforceContentType()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2A8A7D0", Offset = "0x2A8A7D0", VA = "0x2A8A7D0")]
		private void SetTextComponentWrapMode()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2A8CC44", Offset = "0x2A8CC44", VA = "0x2A8CC44")]
		private void SetTextComponentRichTextMode()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2A8C6B4", Offset = "0x2A8C6B4", VA = "0x2A8C6B4")]
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2A8C8CC", Offset = "0x2A8C8CC", VA = "0x2A8C8CC")]
		private void SetToCustom()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2A8CBA4", Offset = "0x2A8CBA4", VA = "0x2A8CBA4")]
		private void SetToCustom(CharacterValidation characterValidation)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2A98338", Offset = "0x2A98338", VA = "0x2A98338", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2A98364", Offset = "0x2A98364", VA = "0x2A98364", Slot = "74")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2A98368", Offset = "0x2A98368", VA = "0x2A98368", Slot = "75")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2A8C1C8", Offset = "0x2A8C1C8", VA = "0x2A8C1C8")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2A8C348", Offset = "0x2A8C348", VA = "0x2A8C348")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[SpecialName]
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2A98704", Offset = "0x2A98704", VA = "0x2A98704", Slot = "46")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
