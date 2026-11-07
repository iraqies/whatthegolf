using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x200009C")]
	[DisallowMultipleComponent]
	public class EventSystem : UIBehaviour
	{
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x18")]
		private List<BaseInputModule> m_SystemInputModules;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x20")]
		private BaseInputModule m_CurrentInputModule;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x0")]
		private static List<EventSystem> m_EventSystems;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F857C", Offset = "0x1F857C")]
		[SerializeField]
		private GameObject m_FirstSelected;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_sendNavigationEvents;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_DragThreshold;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_CurrentSelected;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_HasFocus;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x41")]
		private bool m_SelectionGuard;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x48")]
		private BaseEventData m_DummyData;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Comparison<RaycastResult> s_RaycastComparer;

		[Token(Token = "0x1700017E")]
		public static EventSystem current
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x2C00AA4", Offset = "0x2C00AA4", VA = "0x2C00AA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x2C00B78", Offset = "0x2C00B78", VA = "0x2C00B78")]
			set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public bool sendNavigationEvents
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x2C00D38", Offset = "0x2C00D38", VA = "0x2C00D38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x2C00D40", Offset = "0x2C00D40", VA = "0x2C00D40")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public int pixelDragThreshold
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x2C00D48", Offset = "0x2C00D48", VA = "0x2C00D48")]
			get
			{
				return default;
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x2C00D50", Offset = "0x2C00D50", VA = "0x2C00D50")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public BaseInputModule currentInputModule
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x2C00D58", Offset = "0x2C00D58", VA = "0x2C00D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		public GameObject firstSelectedGameObject
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x2C00D60", Offset = "0x2C00D60", VA = "0x2C00D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x2C00D68", Offset = "0x2C00D68", VA = "0x2C00D68")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public GameObject currentSelectedGameObject
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x2C00D70", Offset = "0x2C00D70", VA = "0x2C00D70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F8E58", Offset = "0x1F8E58")]
		public GameObject lastSelectedGameObject
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x2C00D78", Offset = "0x2C00D78", VA = "0x2C00D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000185")]
		public bool isFocused
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x2C00D80", Offset = "0x2C00D80", VA = "0x2C00D80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000186")]
		public bool alreadySelecting
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x2C00E1C", Offset = "0x2C00E1C", VA = "0x2C00E1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000187")]
		private BaseEventData baseEventDataCache
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x2C00E24", Offset = "0x2C00E24", VA = "0x2C00E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2C00D88", Offset = "0x2C00D88", VA = "0x2C00D88")]
		protected EventSystem()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2BF8354", Offset = "0x2BF8354", VA = "0x2BF8354")]
		public void UpdateModules()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2BF7D4C", Offset = "0x2BF7D4C", VA = "0x2BF7D4C")]
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2C00E90", Offset = "0x2C00E90", VA = "0x2C00E90")]
		public void SetSelectedGameObject(GameObject selected)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2C00F10", Offset = "0x2C00F10", VA = "0x2C00F10")]
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			return default;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2C0132C", Offset = "0x2C0132C", VA = "0x2C0132C")]
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2C01538", Offset = "0x2C01538", VA = "0x2C01538")]
		public bool IsPointerOverGameObject()
		{
			return default;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2C015E8", Offset = "0x2C015E8", VA = "0x2C015E8")]
		public bool IsPointerOverGameObject(int pointerId)
		{
			return default;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2C0169C", Offset = "0x2C0169C", VA = "0x2C0169C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2C0173C", Offset = "0x2C0173C", VA = "0x2C0173C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2C01844", Offset = "0x2C01844", VA = "0x2C01844")]
		private void TickModules()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2C0197C", Offset = "0x2C0197C", VA = "0x2C0197C", Slot = "17")]
		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2C0198C", Offset = "0x2C0198C", VA = "0x2C0198C", Slot = "18")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2C01C50", Offset = "0x2C01C50", VA = "0x2C01C50")]
		private void ChangeEventModule(BaseInputModule module)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2C01D74", Offset = "0x2C01D74", VA = "0x2C01D74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
