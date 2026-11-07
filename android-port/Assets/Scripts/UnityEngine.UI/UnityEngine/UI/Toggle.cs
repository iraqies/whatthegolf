using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F697C", Offset = "0x1F697C")]
	public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		[Token(Token = "0x2000068")]
		public enum ToggleTransition
		{
			[Token(Token = "0x4000226")]
			None = 0,
			[Token(Token = "0x4000227")]
			Fade = 1
		}

		[Serializable]
		[Token(Token = "0x2000069")]
		public class ToggleEvent : UnityEvent<bool>
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2C48C24", Offset = "0x2C48C24", VA = "0x2C48C24")]
			public ToggleEvent()
			{
			}
		}

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0xF8")]
		public ToggleTransition toggleTransition;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x100")]
		public Graphic graphic;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ToggleGroup m_Group;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x110")]
		public ToggleEvent onValueChanged;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool m_IsOn;

		[Token(Token = "0x1700014A")]
		public ToggleGroup group
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2C410E4", Offset = "0x2C410E4", VA = "0x2C410E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x2C410EC", Offset = "0x2C410EC", VA = "0x2C410EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public bool isOn
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x2C41EE4", Offset = "0x2C41EE4", VA = "0x2C41EE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x2C41EEC", Offset = "0x2C41EEC", VA = "0x2C41EEC")]
			set
			{
			}
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2C41364", Offset = "0x2C41364", VA = "0x2C41364")]
		protected Toggle()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2C41400", Offset = "0x2C41400", VA = "0x2C41400", Slot = "46")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2C41404", Offset = "0x2C41404", VA = "0x2C41404", Slot = "47")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2C41408", Offset = "0x2C41408", VA = "0x2C41408", Slot = "48")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2C4140C", Offset = "0x2C4140C", VA = "0x2C4140C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2C4191C", Offset = "0x2C4191C", VA = "0x2C4191C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2C41954", Offset = "0x2C41954", VA = "0x2C41954", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2C41980", Offset = "0x2C41980", VA = "0x2C41980", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2C41118", Offset = "0x2C41118", VA = "0x2C41118")]
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2C41EF4", Offset = "0x2C41EF4", VA = "0x2C41EF4")]
		public void SetIsOnWithoutNotify(bool value)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2C41AB0", Offset = "0x2C41AB0", VA = "0x2C41AB0")]
		private void Set(bool value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2C41288", Offset = "0x2C41288", VA = "0x2C41288")]
		private void PlayEffect(bool instant)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2C42074", Offset = "0x2C42074", VA = "0x2C42074", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2C4207C", Offset = "0x2C4207C", VA = "0x2C4207C")]
		private void InternalToggle()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2C420E0", Offset = "0x2C420E0", VA = "0x2C420E0", Slot = "49")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2C42154", Offset = "0x2C42154", VA = "0x2C42154", Slot = "50")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[SpecialName]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2C421B8", Offset = "0x2C421B8", VA = "0x2C421B8", Slot = "42")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
