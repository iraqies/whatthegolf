using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6A7C", Offset = "0x1F6A7C")]
	public abstract class BaseInputModule : UIBehaviour
	{
		[NonSerialized]
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		protected List<RaycastResult> m_RaycastResultCache;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x20")]
		private AxisEventData m_AxisEventData;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x28")]
		private EventSystem m_EventSystem;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x30")]
		private BaseEventData m_BaseEventData;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x38")]
		protected BaseInput m_InputOverride;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x40")]
		private BaseInput m_DefaultInput;

		[Token(Token = "0x170001A3")]
		public BaseInput input
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2BF8048", Offset = "0x2BF8048", VA = "0x2BF8048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A4")]
		public BaseInput inputOverride
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x2BF82CC", Offset = "0x2BF82CC", VA = "0x2BF82CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2BF82D4", Offset = "0x2BF82D4", VA = "0x2BF82D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		protected EventSystem eventSystem
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x2BF82DC", Offset = "0x2BF82DC", VA = "0x2BF82DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2BF82E4", Offset = "0x2BF82E4", VA = "0x2BF82E4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2BF84CC", Offset = "0x2BF84CC", VA = "0x2BF84CC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000608")]
		public abstract void Process();

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2BF8500", Offset = "0x2BF8500", VA = "0x2BF8500")]
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			return default;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2BF863C", Offset = "0x2BF863C", VA = "0x2BF863C")]
		protected static MoveDirection DetermineMoveDirection(float x, float y)
		{
			return default;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x2BF86B8", Offset = "0x2BF86B8", VA = "0x2BF86B8")]
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			return default;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2BF8738", Offset = "0x2BF8738", VA = "0x2BF8738")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x2BF88D8", Offset = "0x2BF88D8", VA = "0x2BF88D8")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2BF8EF0", Offset = "0x2BF8EF0", VA = "0x2BF8EF0", Slot = "18")]
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2BF9028", Offset = "0x2BF9028", VA = "0x2BF9028", Slot = "19")]
		protected virtual BaseEventData GetBaseEventData()
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x2BF90C8", Offset = "0x2BF90C8", VA = "0x2BF90C8", Slot = "20")]
		public virtual bool IsPointerOverGameObject(int pointerId)
		{
			return default;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2BF90D0", Offset = "0x2BF90D0", VA = "0x2BF90D0", Slot = "21")]
		public virtual bool ShouldActivateModule()
		{
			return default;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x2BF911C", Offset = "0x2BF911C", VA = "0x2BF911C", Slot = "22")]
		public virtual void DeactivateModule()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2BF9120", Offset = "0x2BF9120", VA = "0x2BF9120", Slot = "23")]
		public virtual void ActivateModule()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x2BF9124", Offset = "0x2BF9124", VA = "0x2BF9124", Slot = "24")]
		public virtual void UpdateModule()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2BF9128", Offset = "0x2BF9128", VA = "0x2BF9128", Slot = "25")]
		public virtual bool IsModuleSupported()
		{
			return default;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x2BF9130", Offset = "0x2BF9130", VA = "0x2BF9130")]
		protected BaseInputModule()
		{
		}
	}
}
