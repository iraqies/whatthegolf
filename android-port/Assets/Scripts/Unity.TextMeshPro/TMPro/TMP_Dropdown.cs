using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B909C", Offset = "0x1B909C")]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		[Token(Token = "0x2000018")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TMP_Text m_Text;

			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image m_Image;

			[Token(Token = "0x400007B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RectTransform m_RectTransform;

			[Token(Token = "0x400007C")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Toggle m_Toggle;

			[Token(Token = "0x1700001B")]
			public TMP_Text text
			{
				[Token(Token = "0x6000086")]
				[Address(RVA = "0x2ADE8A8", Offset = "0x2ADE8A8", VA = "0x2ADE8A8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000087")]
				[Address(RVA = "0x2ADE8B0", Offset = "0x2ADE8B0", VA = "0x2ADE8B0")]
				set
				{
				}
			}

			[Token(Token = "0x1700001C")]
			public Image image
			{
				[Token(Token = "0x6000088")]
				[Address(RVA = "0x2ADE8B8", Offset = "0x2ADE8B8", VA = "0x2ADE8B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000089")]
				[Address(RVA = "0x2ADE8C0", Offset = "0x2ADE8C0", VA = "0x2ADE8C0")]
				set
				{
				}
			}

			[Token(Token = "0x1700001D")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x2ADE8C8", Offset = "0x2ADE8C8", VA = "0x2ADE8C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x2ADE8D0", Offset = "0x2ADE8D0", VA = "0x2ADE8D0")]
				set
				{
				}
			}

			[Token(Token = "0x1700001E")]
			public Toggle toggle
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0x2ADE8D8", Offset = "0x2ADE8D8", VA = "0x2ADE8D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x2ADE8E0", Offset = "0x2ADE8E0", VA = "0x2ADE8E0")]
				set
				{
				}
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2ADE8E8", Offset = "0x2ADE8E8", VA = "0x2ADE8E8", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2ADE978", Offset = "0x2ADE978", VA = "0x2ADE978", Slot = "7")]
			public virtual void OnCancel(BaseEventData eventData)
			{
			}

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2ADEA34", Offset = "0x2ADEA34", VA = "0x2ADEA34")]
			public DropdownItem()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000019")]
		public class OptionData
		{
			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Text;

			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite m_Image;

			[Token(Token = "0x1700001F")]
			public string text
			{
				[Token(Token = "0x6000091")]
				[Address(RVA = "0x2ADEA3C", Offset = "0x2ADEA3C", VA = "0x2ADEA3C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000092")]
				[Address(RVA = "0x2ADEA44", Offset = "0x2ADEA44", VA = "0x2ADEA44")]
				set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public Sprite image
			{
				[Token(Token = "0x6000093")]
				[Address(RVA = "0x2ADEA4C", Offset = "0x2ADEA4C", VA = "0x2ADEA4C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000094")]
				[Address(RVA = "0x2ADEA54", Offset = "0x2ADEA54", VA = "0x2ADEA54")]
				set
				{
				}
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2ADEA5C", Offset = "0x2ADEA5C", VA = "0x2ADEA5C")]
			public OptionData()
			{
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2ADEA64", Offset = "0x2ADEA64", VA = "0x2ADEA64")]
			public OptionData(string text)
			{
			}

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2ADEA90", Offset = "0x2ADEA90", VA = "0x2ADEA90")]
			public OptionData(Sprite image)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200001A")]
		public class OptionDataList
		{
			[Token(Token = "0x400007F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<OptionData> m_Options;

			[Token(Token = "0x17000021")]
			public List<OptionData> options
			{
				[Token(Token = "0x6000098")]
				[Address(RVA = "0x2ADEABC", Offset = "0x2ADEABC", VA = "0x2ADEABC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x2ADEAC4", Offset = "0x2ADEAC4", VA = "0x2ADEAC4")]
				set
				{
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2ADEACC", Offset = "0x2ADEACC", VA = "0x2ADEACC")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200001B")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2ADE850", Offset = "0x2ADE850", VA = "0x2ADE850")]
			public DropdownEvent()
			{
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9104", Offset = "0x1B9104")]
		private sealed class _003C_003Ec__DisplayClass69_0
		{
			[Token(Token = "0x4000080")]
			[FieldOffset(Offset = "0x10")]
			public DropdownItem item;

			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x18")]
			public TMP_Dropdown _003C_003E4__this;

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2ADE6E0", Offset = "0x2ADE6E0", VA = "0x2ADE6E0")]
			public _003C_003Ec__DisplayClass69_0()
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x2ADE6E8", Offset = "0x2ADE6E8", VA = "0x2ADE6E8")]
			internal void _003CShow_003Eb__0(bool x)
			{
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9114", Offset = "0x1B9114")]
		private sealed class _003CDelayedDestroyDropdownList_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000083")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x28")]
			public TMP_Dropdown _003C_003E4__this;

			[Token(Token = "0x17000022")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0x2ADE800", Offset = "0x2ADE800", VA = "0x2ADE800", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000023")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0x2ADE848", Offset = "0x2ADE848", VA = "0x2ADE848", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2ADE714", Offset = "0x2ADE714", VA = "0x2ADE714")]
			[DebuggerHidden]
			public _003CDelayedDestroyDropdownList_003Ed__81(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x2ADE740", Offset = "0x2ADE740", VA = "0x2ADE740", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2ADE744", Offset = "0x2ADE744", VA = "0x2ADE744", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2ADE800", Offset = "0x2ADE800", VA = "0x2ADE800", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2ADE808", Offset = "0x2ADE808", VA = "0x2ADE808", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2ADE848", Offset = "0x2ADE848", VA = "0x2ADE848", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_Template;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TMP_Text m_CaptionText;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image m_CaptionImage;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Graphic m_Placeholder;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TMP_Text m_ItemText;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image m_ItemImage;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private int m_Value;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private OptionDataList m_Options;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private DropdownEvent m_OnValueChanged;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float m_AlphaFadeSpeed;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x148")]
		private GameObject m_Dropdown;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x150")]
		private GameObject m_Blocker;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x158")]
		private List<DropdownItem> m_Items;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x160")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x168")]
		private bool validTemplate;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine m_Coroutine;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private static OptionData s_NoOptionData;

		[Token(Token = "0x17000010")]
		public RectTransform template
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2A7DBC0", Offset = "0x2A7DBC0", VA = "0x2A7DBC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2A7DBC8", Offset = "0x2A7DBC8", VA = "0x2A7DBC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public TMP_Text captionText
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2A7DE6C", Offset = "0x2A7DE6C", VA = "0x2A7DE6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2A7DE74", Offset = "0x2A7DE74", VA = "0x2A7DE74")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Image captionImage
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2A7DE7C", Offset = "0x2A7DE7C", VA = "0x2A7DE7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2A7DE84", Offset = "0x2A7DE84", VA = "0x2A7DE84")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Graphic placeholder
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2A7DE8C", Offset = "0x2A7DE8C", VA = "0x2A7DE8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2A7DE94", Offset = "0x2A7DE94", VA = "0x2A7DE94")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public TMP_Text itemText
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2A7DE9C", Offset = "0x2A7DE9C", VA = "0x2A7DE9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2A7DEA4", Offset = "0x2A7DEA4", VA = "0x2A7DEA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Image itemImage
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2A7DEAC", Offset = "0x2A7DEAC", VA = "0x2A7DEAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2A7DEB4", Offset = "0x2A7DEB4", VA = "0x2A7DEB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public List<OptionData> options
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2A7DEBC", Offset = "0x2A7DEBC", VA = "0x2A7DEBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2A7DED8", Offset = "0x2A7DED8", VA = "0x2A7DED8")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public DropdownEvent onValueChanged
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2A7DEF4", Offset = "0x2A7DEF4", VA = "0x2A7DEF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2A7DEFC", Offset = "0x2A7DEFC", VA = "0x2A7DEFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float alphaFadeSpeed
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2A7DF04", Offset = "0x2A7DF04", VA = "0x2A7DF04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2A7DF0C", Offset = "0x2A7DF0C", VA = "0x2A7DF0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int value
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2A7DF14", Offset = "0x2A7DF14", VA = "0x2A7DF14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2A7DF1C", Offset = "0x2A7DF1C", VA = "0x2A7DF1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool IsExpanded
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2A7E084", Offset = "0x2A7E084", VA = "0x2A7E084")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A7E07C", Offset = "0x2A7E07C", VA = "0x2A7E07C")]
		public void SetValueWithoutNotify(int input)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A7DF24", Offset = "0x2A7DF24", VA = "0x2A7DF24")]
		private void SetValue(int value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2A7E100", Offset = "0x2A7E100", VA = "0x2A7E100")]
		protected TMP_Dropdown()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2A7E220", Offset = "0x2A7E220", VA = "0x2A7E220", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A7E350", Offset = "0x2A7E350", VA = "0x2A7E350", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2A7E3F0", Offset = "0x2A7E3F0", VA = "0x2A7E3F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A7DBD0", Offset = "0x2A7DBD0", VA = "0x2A7DBD0")]
		public void RefreshShownValue()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A7E66C", Offset = "0x2A7E66C", VA = "0x2A7E66C")]
		public void AddOptions(List<OptionData> options)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A7E6E0", Offset = "0x2A7E6E0", VA = "0x2A7E6E0")]
		public void AddOptions(List<string> options)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A7E7EC", Offset = "0x2A7E7EC", VA = "0x2A7E7EC")]
		public void AddOptions(List<Sprite> options)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2A7E8F8", Offset = "0x2A7E8F8", VA = "0x2A7E8F8")]
		public void ClearOptions()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2A7E9AC", Offset = "0x2A7E9AC", VA = "0x2A7E9AC")]
		private void SetupTemplate()
		{
		}

		[Token(Token = "0x6000072")]
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2A7F118", Offset = "0x2A7F118", VA = "0x2A7F118", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2A7FDD8", Offset = "0x2A7FDD8", VA = "0x2A7FDD8", Slot = "43")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2A7FDDC", Offset = "0x2A7FDDC", VA = "0x2A7FDDC", Slot = "44")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2A7F11C", Offset = "0x2A7F11C", VA = "0x2A7F11C")]
		public void Show()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2A803E0", Offset = "0x2A803E0", VA = "0x2A803E0", Slot = "45")]
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2A80870", Offset = "0x2A80870", VA = "0x2A80870", Slot = "46")]
		protected virtual void DestroyBlocker(GameObject blocker)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2A808DC", Offset = "0x2A808DC", VA = "0x2A808DC", Slot = "47")]
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A8095C", Offset = "0x2A8095C", VA = "0x2A8095C", Slot = "48")]
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A809C8", Offset = "0x2A809C8", VA = "0x2A809C8", Slot = "49")]
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A80A48", Offset = "0x2A80A48", VA = "0x2A80A48", Slot = "50")]
		protected virtual void DestroyItem(DropdownItem item)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A7FF78", Offset = "0x2A7FF78", VA = "0x2A7FF78")]
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A80A4C", Offset = "0x2A80A4C", VA = "0x2A80A4C")]
		private void AlphaFadeList(float duration, float alpha)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A80270", Offset = "0x2A80270", VA = "0x2A80270")]
		private void AlphaFadeList(float duration, float start, float end)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A80AD0", Offset = "0x2A80AD0", VA = "0x2A80AD0")]
		private void SetAlpha(float alpha)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A7FDE0", Offset = "0x2A7FDE0", VA = "0x2A7FDE0")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A80BA4", Offset = "0x2A80BA4", VA = "0x2A80BA4")]
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A7E4A0", Offset = "0x2A7E4A0", VA = "0x2A7E4A0")]
		private void ImmediateDestroyDropdownList()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A80C28", Offset = "0x2A80C28", VA = "0x2A80C28")]
		private void OnSelectItem(Toggle toggle)
		{
		}
	}
}
