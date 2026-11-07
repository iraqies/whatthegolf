using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000B0")]
	public abstract class BaseRaycaster : UIBehaviour
	{
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x18")]
		private BaseRaycaster m_RootRaycaster;

		[Token(Token = "0x170001B5")]
		public abstract Camera eventCamera
		{
			[Token(Token = "0x600066F")]
			get;
		}

		[Token(Token = "0x170001B6")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8F90", Offset = "0x1F8F90")]
		public virtual int priority
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x2BF9618", Offset = "0x2BF9618", VA = "0x2BF9618", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B7")]
		public virtual int sortOrderPriority
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2BF9620", Offset = "0x2BF9620", VA = "0x2BF9620", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B8")]
		public virtual int renderOrderPriority
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x2BF9628", Offset = "0x2BF9628", VA = "0x2BF9628", Slot = "21")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001B9")]
		public BaseRaycaster rootRaycaster
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x2BF9630", Offset = "0x2BF9630", VA = "0x2BF9630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066E")]
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2BF970C", Offset = "0x2BF970C", VA = "0x2BF970C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2BF99EC", Offset = "0x2BF99EC", VA = "0x2BF99EC", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2BF9A64", Offset = "0x2BF9A64", VA = "0x2BF9A64", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2BF9ADC", Offset = "0x2BF9ADC", VA = "0x2BF9ADC", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2BF9B04", Offset = "0x2BF9B04", VA = "0x2BF9B04", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x2BF9B2C", Offset = "0x2BF9B2C", VA = "0x2BF9B2C")]
		protected BaseRaycaster()
		{
		}
	}
}
