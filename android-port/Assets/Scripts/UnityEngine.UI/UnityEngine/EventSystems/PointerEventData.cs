using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x2000087")]
	public class PointerEventData : BaseEventData
	{
		[Token(Token = "0x2000088")]
		public enum InputButton
		{
			[Token(Token = "0x400027D")]
			Left = 0,
			[Token(Token = "0x400027E")]
			Right = 1,
			[Token(Token = "0x400027F")]
			Middle = 2
		}

		[Token(Token = "0x2000089")]
		public enum FramePressState
		{
			[Token(Token = "0x4000281")]
			Pressed = 0,
			[Token(Token = "0x4000282")]
			Released = 1,
			[Token(Token = "0x4000283")]
			PressedAndReleased = 2,
			[Token(Token = "0x4000284")]
			NotChanged = 3
		}

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F843C", Offset = "0x1F843C")]
		private GameObject pointerEnter__BackingField;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_PointerPress;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F844C", Offset = "0x1F844C")]
		private GameObject lastPress__BackingField;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F845C", Offset = "0x1F845C")]
		private GameObject rawPointerPress__BackingField;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F846C", Offset = "0x1F846C")]
		private GameObject pointerDrag__BackingField;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F847C", Offset = "0x1F847C")]
		private GameObject pointerClick__BackingField;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F848C", Offset = "0x1F848C")]
		private RaycastResult pointerCurrentRaycast__BackingField;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F849C", Offset = "0x1F849C")]
		private RaycastResult pointerPressRaycast__BackingField;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0xF0")]
		public List<GameObject> hovered;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F84AC", Offset = "0x1F84AC")]
		private bool eligibleForClick__BackingField;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F84BC", Offset = "0x1F84BC")]
		private int pointerId__BackingField;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F84CC", Offset = "0x1F84CC")]
		private Vector2 position__BackingField;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F84DC", Offset = "0x1F84DC")]
		private Vector2 delta__BackingField;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F84EC", Offset = "0x1F84EC")]
		private Vector2 pressPosition__BackingField;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F84FC", Offset = "0x1F84FC")]
		private Vector3 worldPosition__BackingField;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x124")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F850C", Offset = "0x1F850C")]
		private Vector3 worldNormal__BackingField;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F851C", Offset = "0x1F851C")]
		private float clickTime__BackingField;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x134")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F852C", Offset = "0x1F852C")]
		private int clickCount__BackingField;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F853C", Offset = "0x1F853C")]
		private Vector2 scrollDelta__BackingField;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F854C", Offset = "0x1F854C")]
		private bool useDragThreshold__BackingField;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x141")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F855C", Offset = "0x1F855C")]
		private bool dragging__BackingField;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x144")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F856C", Offset = "0x1F856C")]
		private InputButton button__BackingField;

		[Token(Token = "0x17000169")]
		public GameObject pointerEnter
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x2C2BF7C", Offset = "0x2C2BF7C", VA = "0x2C2BF7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B34", Offset = "0x1F8B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x2C2BF84", Offset = "0x2C2BF84", VA = "0x2C2BF84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B44", Offset = "0x1F8B44")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public GameObject lastPress
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x2C2BF8C", Offset = "0x2C2BF8C", VA = "0x2C2BF8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B54", Offset = "0x1F8B54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x2C2BF94", Offset = "0x2C2BF94", VA = "0x2C2BF94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B64", Offset = "0x1F8B64")]
			private set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public GameObject rawPointerPress
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x2C2BF9C", Offset = "0x2C2BF9C", VA = "0x2C2BF9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B74", Offset = "0x1F8B74")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public GameObject pointerDrag
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x2C2BFA4", Offset = "0x2C2BFA4", VA = "0x2C2BFA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B84", Offset = "0x1F8B84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x2C2BFAC", Offset = "0x2C2BFAC", VA = "0x2C2BFAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B94", Offset = "0x1F8B94")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public GameObject pointerClick
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x2C2BFB4", Offset = "0x2C2BFB4", VA = "0x2C2BFB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8BA4", Offset = "0x1F8BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x2C2BFBC", Offset = "0x2C2BFBC", VA = "0x2C2BFBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8BB4", Offset = "0x1F8BB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public RaycastResult pointerCurrentRaycast
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x2C2BFC4", Offset = "0x2C2BFC4", VA = "0x2C2BFC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8BC4", Offset = "0x1F8BC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x2C2BFE0", Offset = "0x2C2BFE0", VA = "0x2C2BFE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8BD4", Offset = "0x1F8BD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public RaycastResult pointerPressRaycast
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x2C2BFFC", Offset = "0x2C2BFFC", VA = "0x2C2BFFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8BE4", Offset = "0x1F8BE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x2C2C018", Offset = "0x2C2C018", VA = "0x2C2C018")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8BF4", Offset = "0x1F8BF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public bool eligibleForClick
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2C2C034", Offset = "0x2C2C034", VA = "0x2C2C034")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C04", Offset = "0x1F8C04")]
			get
			{
				return default;
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x2C2C03C", Offset = "0x2C2C03C", VA = "0x2C2C03C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C14", Offset = "0x1F8C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public int pointerId
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x2C2C044", Offset = "0x2C2C044", VA = "0x2C2C044")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C24", Offset = "0x1F8C24")]
			get
			{
				return default;
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x2C2C04C", Offset = "0x2C2C04C", VA = "0x2C2C04C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C34", Offset = "0x1F8C34")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public Vector2 position
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x2C2C054", Offset = "0x2C2C054", VA = "0x2C2C054")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C44", Offset = "0x1F8C44")]
			get
			{
				return default;
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x2C2C060", Offset = "0x2C2C060", VA = "0x2C2C060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C54", Offset = "0x1F8C54")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public Vector2 delta
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x2C2C06C", Offset = "0x2C2C06C", VA = "0x2C2C06C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C64", Offset = "0x1F8C64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x2C2C078", Offset = "0x2C2C078", VA = "0x2C2C078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C74", Offset = "0x1F8C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public Vector2 pressPosition
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x2C2C084", Offset = "0x2C2C084", VA = "0x2C2C084")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C84", Offset = "0x1F8C84")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x2C2C090", Offset = "0x2C2C090", VA = "0x2C2C090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8C94", Offset = "0x1F8C94")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public float clickTime
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x2C2C09C", Offset = "0x2C2C09C", VA = "0x2C2C09C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8CA4", Offset = "0x1F8CA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x2C2C0A4", Offset = "0x2C2C0A4", VA = "0x2C2C0A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8CB4", Offset = "0x1F8CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public int clickCount
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x2C2C0AC", Offset = "0x2C2C0AC", VA = "0x2C2C0AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8CC4", Offset = "0x1F8CC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x2C2C0B4", Offset = "0x2C2C0B4", VA = "0x2C2C0B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8CD4", Offset = "0x1F8CD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public Vector2 scrollDelta
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x2C2C0BC", Offset = "0x2C2C0BC", VA = "0x2C2C0BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8CE4", Offset = "0x1F8CE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x2C2C0C8", Offset = "0x2C2C0C8", VA = "0x2C2C0C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8CF4", Offset = "0x1F8CF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public bool useDragThreshold
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x2C2C0D4", Offset = "0x2C2C0D4", VA = "0x2C2C0D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8D04", Offset = "0x1F8D04")]
			get
			{
				return default;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x2C2C0DC", Offset = "0x2C2C0DC", VA = "0x2C2C0DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8D14", Offset = "0x1F8D14")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public bool dragging
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x2C2C0E4", Offset = "0x2C2C0E4", VA = "0x2C2C0E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8D24", Offset = "0x1F8D24")]
			get
			{
				return default;
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x2C2C0EC", Offset = "0x2C2C0EC", VA = "0x2C2C0EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8D34", Offset = "0x1F8D34")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public InputButton button
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x2C2C0F4", Offset = "0x2C2C0F4", VA = "0x2C2C0F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8D44", Offset = "0x1F8D44")]
			get
			{
				return default;
			}
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x2C2C0FC", Offset = "0x2C2C0FC", VA = "0x2C2C0FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8D54", Offset = "0x1F8D54")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public Camera enterEventCamera
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x2C2C26C", Offset = "0x2C2C26C", VA = "0x2C2C26C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		public Camera pressEventCamera
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x2C1DAC4", Offset = "0x2C1DAC4", VA = "0x2C1DAC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		public GameObject pointerPress
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x2C2C31C", Offset = "0x2C2C31C", VA = "0x2C2C31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x2C2C324", Offset = "0x2C2C324", VA = "0x2C2C324")]
			set
			{
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2C2C104", Offset = "0x2C2C104", VA = "0x2C2C104")]
		public PointerEventData(EventSystem eventSystem)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2C2C1F4", Offset = "0x2C2C1F4", VA = "0x2C2C1F4")]
		public bool IsPointerMoving()
		{
			return default;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2C2C230", Offset = "0x2C2C230", VA = "0x2C2C230")]
		public bool IsScrolling()
		{
			return default;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2C2C3B4", Offset = "0x2C2C3B4", VA = "0x2C2C3B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
