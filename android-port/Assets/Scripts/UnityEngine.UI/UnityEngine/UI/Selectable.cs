using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x200005B")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		[Token(Token = "0x200005C")]
		public enum Transition
		{
			[Token(Token = "0x40001E8")]
			None = 0,
			[Token(Token = "0x40001E9")]
			ColorTint = 1,
			[Token(Token = "0x40001EA")]
			SpriteSwap = 2,
			[Token(Token = "0x40001EB")]
			Animation = 3
		}

		[Token(Token = "0x200005D")]
		protected enum SelectionState
		{
			[Token(Token = "0x40001ED")]
			Normal = 0,
			[Token(Token = "0x40001EE")]
			Highlighted = 1,
			[Token(Token = "0x40001EF")]
			Pressed = 2,
			[Token(Token = "0x40001F0")]
			Selected = 3,
			[Token(Token = "0x40001F1")]
			Disabled = 4
		}

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x0")]
		protected static Selectable[] s_Selectables;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x8")]
		protected static int s_SelectableCount;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x18")]
		private bool m_EnableCalled;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F8064", Offset = "0x1F8064")]
		private Navigation m_Navigation;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F80B0", Offset = "0x1F80B0")]
		[SerializeField]
		private Transition m_Transition;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F80FC", Offset = "0x1F80FC")]
		[SerializeField]
		private ColorBlock m_Colors;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F8148", Offset = "0x1F8148")]
		[SerializeField]
		private SpriteState m_SpriteState;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F8194", Offset = "0x1F8194")]
		[SerializeField]
		private AnimationTriggers m_AnimationTriggers;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool m_Interactable;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F81F0", Offset = "0x1F81F0")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F81F0", Offset = "0x1F81F0")]
		private Graphic m_TargetGraphic;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_GroupsAllowInteraction;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0xE4")]
		protected int m_CurrentIndex;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8260", Offset = "0x1F8260")]
		private bool isPointerInside__BackingField;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0xE9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8270", Offset = "0x1F8270")]
		private bool isPointerDown__BackingField;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0xEA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8280", Offset = "0x1F8280")]
		private bool hasSelection__BackingField;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<CanvasGroup> m_CanvasGroupCache;

		[Token(Token = "0x17000112")]
		public static Selectable[] allSelectablesArray
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2C37898", Offset = "0x2C37898", VA = "0x2C37898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		public static int allSelectableCount
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x2C3793C", Offset = "0x2C3793C", VA = "0x2C3793C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000114")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8E1C", Offset = "0x1F8E1C")]
		public static List<Selectable> allSelectables
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x2C379A0", Offset = "0x2C379A0", VA = "0x2C379A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public Navigation navigation
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x2C37B28", Offset = "0x2C37B28", VA = "0x2C37B28")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x2C37B3C", Offset = "0x2C37B3C", VA = "0x2C37B3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public Transition transition
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2C37C84", Offset = "0x2C37C84", VA = "0x2C37C84")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2C37C8C", Offset = "0x2C37C8C", VA = "0x2C37C8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public ColorBlock colors
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x2C37D58", Offset = "0x2C37D58", VA = "0x2C37D58")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x2C37D84", Offset = "0x2C37D84", VA = "0x2C37D84")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public SpriteState spriteState
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x2C37E6C", Offset = "0x2C37E6C", VA = "0x2C37E6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x2C37E7C", Offset = "0x2C37E7C", VA = "0x2C37E7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public AnimationTriggers animationTriggers
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x2C37F4C", Offset = "0x2C37F4C", VA = "0x2C37F4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x2C37F54", Offset = "0x2C37F54", VA = "0x2C37F54")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public Graphic targetGraphic
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x2C38020", Offset = "0x2C38020", VA = "0x2C38020")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2C38028", Offset = "0x2C38028", VA = "0x2C38028")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public bool interactable
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x2C380F4", Offset = "0x2C380F4", VA = "0x2C380F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x2C380FC", Offset = "0x2C380FC", VA = "0x2C380FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		private bool isPointerInside
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x2C382F0", Offset = "0x2C382F0", VA = "0x2C382F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F89F8", Offset = "0x1F89F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x2C382F8", Offset = "0x2C382F8", VA = "0x2C382F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A08", Offset = "0x1F8A08")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		private bool isPointerDown
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x2C38300", Offset = "0x2C38300", VA = "0x2C38300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A18", Offset = "0x1F8A18")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x2C38308", Offset = "0x2C38308", VA = "0x2C38308")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A28", Offset = "0x1F8A28")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		private bool hasSelection
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x2C38310", Offset = "0x2C38310", VA = "0x2C38310")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A38", Offset = "0x1F8A38")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x2C38318", Offset = "0x2C38318", VA = "0x2C38318")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A48", Offset = "0x1F8A48")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public Image image
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x2C38320", Offset = "0x2C38320", VA = "0x2C38320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x2C383A0", Offset = "0x2C383A0", VA = "0x2C383A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public Animator animator
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x2C383A8", Offset = "0x2C383A8", VA = "0x2C383A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		protected SelectionState currentSelectionState
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x2C38780", Offset = "0x2C38780", VA = "0x2C38780")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2C37A4C", Offset = "0x2C37A4C", VA = "0x2C37A4C")]
		public static int AllSelectablesNoAlloc(Selectable[] selectables)
		{
			return default;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2C35A68", Offset = "0x2C35A68", VA = "0x2C35A68")]
		protected Selectable()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2C38400", Offset = "0x2C38400", VA = "0x2C38400", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2C384A8", Offset = "0x2C384A8", VA = "0x2C384A8", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2C3853C", Offset = "0x2C3853C", VA = "0x2C3853C")]
		private bool ParentGroupAllowsInteraction()
		{
			return default;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2C386F0", Offset = "0x2C386F0", VA = "0x2C386F0", Slot = "24")]
		public virtual bool IsInteractable()
		{
			return default;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2C38710", Offset = "0x2C38710", VA = "0x2C38710", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2C35F8C", Offset = "0x2C35F8C", VA = "0x2C35F8C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2C387DC", Offset = "0x2C387DC", VA = "0x2C387DC", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2C37C14", Offset = "0x2C37C14", VA = "0x2C37C14")]
		private void OnSetProperty()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2C362A8", Offset = "0x2C362A8", VA = "0x2C362A8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2C387F0", Offset = "0x2C387F0", VA = "0x2C387F0", Slot = "25")]
		protected virtual void InstantClearState()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2C38DE4", Offset = "0x2C38DE4", VA = "0x2C38DE4", Slot = "26")]
		protected virtual void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2C38FB4", Offset = "0x2C38FB4", VA = "0x2C38FB4")]
		public Selectable FindSelectable(Vector3 dir)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2C393D0", Offset = "0x2C393D0", VA = "0x2C393D0")]
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			return default;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2C39530", Offset = "0x2C39530", VA = "0x2C39530")]
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2C37354", Offset = "0x2C37354", VA = "0x2C37354", Slot = "27")]
		public virtual Selectable FindSelectableOnLeft()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2C3742C", Offset = "0x2C3742C", VA = "0x2C3742C", Slot = "28")]
		public virtual Selectable FindSelectableOnRight()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2C37504", Offset = "0x2C37504", VA = "0x2C37504", Slot = "29")]
		public virtual Selectable FindSelectableOnUp()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2C375DC", Offset = "0x2C375DC", VA = "0x2C375DC", Slot = "30")]
		public virtual Selectable FindSelectableOnDown()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2C372C0", Offset = "0x2C372C0", VA = "0x2C372C0", Slot = "31")]
		public virtual void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2C38888", Offset = "0x2C38888", VA = "0x2C38888")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2C389A0", Offset = "0x2C389A0", VA = "0x2C389A0")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2C38B0C", Offset = "0x2C38B0C", VA = "0x2C38B0C")]
		private void TriggerAnimation(string triggername)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2C395F4", Offset = "0x2C395F4", VA = "0x2C395F4")]
		protected bool IsHighlighted()
		{
			return default;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2C39660", Offset = "0x2C39660", VA = "0x2C39660")]
		protected bool IsPressed()
		{
			return default;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2C396B4", Offset = "0x2C396B4", VA = "0x2C396B4")]
		private void EvaluateAndTransitionToSelectionState()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2C36B68", Offset = "0x2C36B68", VA = "0x2C36B68", Slot = "32")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2C36F1C", Offset = "0x2C36F1C", VA = "0x2C36F1C", Slot = "33")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2C3975C", Offset = "0x2C3975C", VA = "0x2C3975C", Slot = "34")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2C3980C", Offset = "0x2C3980C", VA = "0x2C3980C", Slot = "35")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2C398B8", Offset = "0x2C398B8", VA = "0x2C398B8", Slot = "36")]
		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2C39968", Offset = "0x2C39968", VA = "0x2C39968", Slot = "37")]
		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2C39A14", Offset = "0x2C39A14", VA = "0x2C39A14", Slot = "38")]
		public virtual void Select()
		{
		}
	}
}
