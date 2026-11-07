using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F60F4", Offset = "0x1F60F4")]
	public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		[Token(Token = "0x2000010")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text m_Text;

			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image m_Image;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RectTransform m_RectTransform;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Toggle m_Toggle;

			[Token(Token = "0x1700001D")]
			public Text text
			{
				[Token(Token = "0x6000080")]
				[Address(RVA = "0x2C44BFC", Offset = "0x2C44BFC", VA = "0x2C44BFC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000081")]
				[Address(RVA = "0x2C44C04", Offset = "0x2C44C04", VA = "0x2C44C04")]
				set
				{
				}
			}

			[Token(Token = "0x1700001E")]
			public Image image
			{
				[Token(Token = "0x6000082")]
				[Address(RVA = "0x2C44C0C", Offset = "0x2C44C0C", VA = "0x2C44C0C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000083")]
				[Address(RVA = "0x2C44C14", Offset = "0x2C44C14", VA = "0x2C44C14")]
				set
				{
				}
			}

			[Token(Token = "0x1700001F")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x6000084")]
				[Address(RVA = "0x2C44C1C", Offset = "0x2C44C1C", VA = "0x2C44C1C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000085")]
				[Address(RVA = "0x2C44C24", Offset = "0x2C44C24", VA = "0x2C44C24")]
				set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public Toggle toggle
			{
				[Token(Token = "0x6000086")]
				[Address(RVA = "0x2C44C2C", Offset = "0x2C44C2C", VA = "0x2C44C2C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000087")]
				[Address(RVA = "0x2C44C34", Offset = "0x2C44C34", VA = "0x2C44C34")]
				set
				{
				}
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2C44C3C", Offset = "0x2C44C3C", VA = "0x2C44C3C", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2C44CCC", Offset = "0x2C44CCC", VA = "0x2C44CCC", Slot = "7")]
			public virtual void OnCancel(BaseEventData eventData)
			{
			}

			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2C44D88", Offset = "0x2C44D88", VA = "0x2C44D88")]
			public DropdownItem()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000011")]
		public class OptionData
		{
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Text;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite m_Image;

			[Token(Token = "0x17000021")]
			public string text
			{
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x2C44D90", Offset = "0x2C44D90", VA = "0x2C44D90")]
				get
				{
					return null;
				}
				[Token(Token = "0x600008C")]
				[Address(RVA = "0x2C44D98", Offset = "0x2C44D98", VA = "0x2C44D98")]
				set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public Sprite image
			{
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x2C44DA0", Offset = "0x2C44DA0", VA = "0x2C44DA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600008E")]
				[Address(RVA = "0x2C44DA8", Offset = "0x2C44DA8", VA = "0x2C44DA8")]
				set
				{
				}
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2C44DB0", Offset = "0x2C44DB0", VA = "0x2C44DB0")]
			public OptionData()
			{
			}

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2C44DB8", Offset = "0x2C44DB8", VA = "0x2C44DB8")]
			public OptionData(string text)
			{
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2C44DE4", Offset = "0x2C44DE4", VA = "0x2C44DE4")]
			public OptionData(Sprite image)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000012")]
		public class OptionDataList
		{
			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<OptionData> m_Options;

			[Token(Token = "0x17000023")]
			public List<OptionData> options
			{
				[Token(Token = "0x6000092")]
				[Address(RVA = "0x2C44E10", Offset = "0x2C44E10", VA = "0x2C44E10")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000093")]
				[Address(RVA = "0x2C44E18", Offset = "0x2C44E18", VA = "0x2C44E18")]
				set
				{
				}
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x2C44E20", Offset = "0x2C44E20", VA = "0x2C44E20")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000013")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2C44BA4", Offset = "0x2C44BA4", VA = "0x2C44BA4")]
			public DropdownEvent()
			{
			}
		}

		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F615C", Offset = "0x1F615C")]
		private sealed class _003C_003Ec__DisplayClass63_0
		{
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x10")]
			public DropdownItem item;

			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x18")]
			public Dropdown _003C_003E4__this;

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2C44A34", Offset = "0x2C44A34", VA = "0x2C44A34")]
			public _003C_003Ec__DisplayClass63_0()
			{
			}

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2C44A3C", Offset = "0x2C44A3C", VA = "0x2C44A3C")]
			internal void _003CShow_003Eb__0(bool x)
			{
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F616C", Offset = "0x1F616C")]
		private sealed class _003CDelayedDestroyDropdownList_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x28")]
			public Dropdown _003C_003E4__this;

			[Token(Token = "0x17000024")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x2C44B54", Offset = "0x2C44B54", VA = "0x2C44B54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000025")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0x2C44B9C", Offset = "0x2C44B9C", VA = "0x2C44B9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2C44A68", Offset = "0x2C44A68", VA = "0x2C44A68")]
			[DebuggerHidden]
			public _003CDelayedDestroyDropdownList_003Ed__75(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2C44A94", Offset = "0x2C44A94", VA = "0x2C44A94", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2C44A98", Offset = "0x2C44A98", VA = "0x2C44A98", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2C44B54", Offset = "0x2C44B54", VA = "0x2C44B54", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2C44B5C", Offset = "0x2C44B5C", VA = "0x2C44B5C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x2C44B9C", Offset = "0x2C44B9C", VA = "0x2C44B9C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform m_Template;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text m_CaptionText;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image m_CaptionImage;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Text m_ItemText;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Image m_ItemImage;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int m_Value;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private OptionDataList m_Options;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private DropdownEvent m_OnValueChanged;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float m_AlphaFadeSpeed;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x140")]
		private GameObject m_Dropdown;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x148")]
		private GameObject m_Blocker;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x150")]
		private List<DropdownItem> m_Items;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x158")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x160")]
		private bool validTemplate;

		[Token(Token = "0x4000039")]
		private const int kHighSortingLayer = 30000;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		private static OptionData s_NoOptionData;

		[Token(Token = "0x17000014")]
		public RectTransform template
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2BFD650", Offset = "0x2BFD650", VA = "0x2BFD650")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2BFD658", Offset = "0x2BFD658", VA = "0x2BFD658")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Text captionText
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2BFD87C", Offset = "0x2BFD87C", VA = "0x2BFD87C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2BFD884", Offset = "0x2BFD884", VA = "0x2BFD884")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Image captionImage
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2BFD88C", Offset = "0x2BFD88C", VA = "0x2BFD88C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2BFD894", Offset = "0x2BFD894", VA = "0x2BFD894")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Text itemText
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2BFD89C", Offset = "0x2BFD89C", VA = "0x2BFD89C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2BFD8A4", Offset = "0x2BFD8A4", VA = "0x2BFD8A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Image itemImage
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2BFD8AC", Offset = "0x2BFD8AC", VA = "0x2BFD8AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2BFD8B4", Offset = "0x2BFD8B4", VA = "0x2BFD8B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public List<OptionData> options
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2BFD8BC", Offset = "0x2BFD8BC", VA = "0x2BFD8BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2BFD8D8", Offset = "0x2BFD8D8", VA = "0x2BFD8D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public DropdownEvent onValueChanged
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2BFD8F4", Offset = "0x2BFD8F4", VA = "0x2BFD8F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2BFD8FC", Offset = "0x2BFD8FC", VA = "0x2BFD8FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float alphaFadeSpeed
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2BFD904", Offset = "0x2BFD904", VA = "0x2BFD904")]
			get
			{
				return default;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2BFD90C", Offset = "0x2BFD90C", VA = "0x2BFD90C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int value
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2BFD914", Offset = "0x2BFD914", VA = "0x2BFD914")]
			get
			{
				return default;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2BFD91C", Offset = "0x2BFD91C", VA = "0x2BFD91C")]
			set
			{
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2BFDA34", Offset = "0x2BFDA34", VA = "0x2BFDA34")]
		public void SetValueWithoutNotify(int input)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2BFD924", Offset = "0x2BFD924", VA = "0x2BFD924")]
		private void Set(int value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2BFDA3C", Offset = "0x2BFDA3C", VA = "0x2BFDA3C")]
		protected Dropdown()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2BFDB5C", Offset = "0x2BFDB5C", VA = "0x2BFDB5C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2BFDC8C", Offset = "0x2BFDC8C", VA = "0x2BFDC8C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2BFDD2C", Offset = "0x2BFDD2C", VA = "0x2BFDD2C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2BFD660", Offset = "0x2BFD660", VA = "0x2BFD660")]
		public void RefreshShownValue()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2BFE2C4", Offset = "0x2BFE2C4", VA = "0x2BFE2C4")]
		public void AddOptions(List<OptionData> options)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2BFE338", Offset = "0x2BFE338", VA = "0x2BFE338")]
		public void AddOptions(List<string> options)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2BFE44C", Offset = "0x2BFE44C", VA = "0x2BFE44C")]
		public void AddOptions(List<Sprite> options)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2BFE560", Offset = "0x2BFE560", VA = "0x2BFE560")]
		public void ClearOptions()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2BFE5C8", Offset = "0x2BFE5C8", VA = "0x2BFE5C8")]
		private void SetupTemplate(Canvas rootCanvas)
		{
		}

		[Token(Token = "0x600006C")]
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2BFED74", Offset = "0x2BFED74", VA = "0x2BFED74", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2BFFA14", Offset = "0x2BFFA14", VA = "0x2BFFA14", Slot = "43")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2BFFA18", Offset = "0x2BFFA18", VA = "0x2BFFA18", Slot = "44")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2BFED78", Offset = "0x2BFED78", VA = "0x2BFED78")]
		public void Show()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2BFFFF8", Offset = "0x2BFFFF8", VA = "0x2BFFFF8", Slot = "45")]
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2C00488", Offset = "0x2C00488", VA = "0x2C00488", Slot = "46")]
		protected virtual void DestroyBlocker(GameObject blocker)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2C004F4", Offset = "0x2C004F4", VA = "0x2C004F4", Slot = "47")]
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2C00574", Offset = "0x2C00574", VA = "0x2C00574", Slot = "48")]
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2C005E0", Offset = "0x2C005E0", VA = "0x2C005E0", Slot = "49")]
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2C00660", Offset = "0x2C00660", VA = "0x2C00660", Slot = "50")]
		protected virtual void DestroyItem(DropdownItem item)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2BFFB94", Offset = "0x2BFFB94", VA = "0x2BFFB94")]
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2C00664", Offset = "0x2C00664", VA = "0x2C00664")]
		private void AlphaFadeList(float duration, float alpha)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2BFFE88", Offset = "0x2BFFE88", VA = "0x2BFFE88")]
		private void AlphaFadeList(float duration, float start, float end)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2C00790", Offset = "0x2C00790", VA = "0x2C00790")]
		private void SetAlpha(float alpha)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2BFFA1C", Offset = "0x2BFFA1C", VA = "0x2BFFA1C")]
		public void Hide()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2C00864", Offset = "0x2C00864", VA = "0x2C00864")]
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2BFDDDC", Offset = "0x2BFDDDC", VA = "0x2BFDDDC")]
		private void ImmediateDestroyDropdownList()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2C008E8", Offset = "0x2C008E8", VA = "0x2C008E8")]
		private void OnSelectItem(Toggle toggle)
		{
		}
	}
}
