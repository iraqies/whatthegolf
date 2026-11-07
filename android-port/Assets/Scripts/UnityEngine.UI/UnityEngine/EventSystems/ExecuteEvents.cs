using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000A1")]
	public static class ExecuteEvents
	{
		[Token(Token = "0x20000A2")]
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);

		[Serializable]
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F6A6C", Offset = "0x1F6A6C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x2C44FFC", Offset = "0x2C44FFC", VA = "0x2C44FFC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x2C45004", Offset = "0x2C45004", VA = "0x2C45004")]
			internal void _003C_002Ecctor_003Eb__79_0(List<IEventSystemHandler> l)
			{
			}
		}

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x20")]
		private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x28")]
		private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x30")]
		private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x38")]
		private static readonly EventFunction<IDragHandler> s_DragHandler;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x40")]
		private static readonly EventFunction<IEndDragHandler> s_EndDragHandler;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x48")]
		private static readonly EventFunction<IDropHandler> s_DropHandler;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x50")]
		private static readonly EventFunction<IScrollHandler> s_ScrollHandler;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x58")]
		private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x60")]
		private static readonly EventFunction<ISelectHandler> s_SelectHandler;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x68")]
		private static readonly EventFunction<IDeselectHandler> s_DeselectHandler;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x70")]
		private static readonly EventFunction<IMoveHandler> s_MoveHandler;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x78")]
		private static readonly EventFunction<ISubmitHandler> s_SubmitHandler;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x80")]
		private static readonly EventFunction<ICancelHandler> s_CancelHandler;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x88")]
		private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x90")]
		private static readonly List<Transform> s_InternalTransformList;

		[Token(Token = "0x1700018A")]
		public static EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2C03464", Offset = "0x2C03464", VA = "0x2C03464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		public static EventFunction<IPointerExitHandler> pointerExitHandler
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2C034C8", Offset = "0x2C034C8", VA = "0x2C034C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		public static EventFunction<IPointerDownHandler> pointerDownHandler
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x2C0352C", Offset = "0x2C0352C", VA = "0x2C0352C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018D")]
		public static EventFunction<IPointerUpHandler> pointerUpHandler
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x2C03590", Offset = "0x2C03590", VA = "0x2C03590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		public static EventFunction<IPointerClickHandler> pointerClickHandler
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x2C035F4", Offset = "0x2C035F4", VA = "0x2C035F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x2C03658", Offset = "0x2C03658", VA = "0x2C03658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		public static EventFunction<IBeginDragHandler> beginDragHandler
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x2C036BC", Offset = "0x2C036BC", VA = "0x2C036BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000191")]
		public static EventFunction<IDragHandler> dragHandler
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x2C03720", Offset = "0x2C03720", VA = "0x2C03720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		public static EventFunction<IEndDragHandler> endDragHandler
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x2C03784", Offset = "0x2C03784", VA = "0x2C03784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000193")]
		public static EventFunction<IDropHandler> dropHandler
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x2C037E8", Offset = "0x2C037E8", VA = "0x2C037E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		public static EventFunction<IScrollHandler> scrollHandler
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x2C0384C", Offset = "0x2C0384C", VA = "0x2C0384C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x2C038B0", Offset = "0x2C038B0", VA = "0x2C038B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000196")]
		public static EventFunction<ISelectHandler> selectHandler
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x2C03914", Offset = "0x2C03914", VA = "0x2C03914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000197")]
		public static EventFunction<IDeselectHandler> deselectHandler
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x2C03978", Offset = "0x2C03978", VA = "0x2C03978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		public static EventFunction<IMoveHandler> moveHandler
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x2C039DC", Offset = "0x2C039DC", VA = "0x2C039DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		public static EventFunction<ISubmitHandler> submitHandler
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x2C03A40", Offset = "0x2C03A40", VA = "0x2C03A40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public static EventFunction<ICancelHandler> cancelHandler
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x2C03AA4", Offset = "0x2C03AA4", VA = "0x2C03AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BF")]
		public static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2C023E4", Offset = "0x2C023E4", VA = "0x2C023E4")]
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2C024F4", Offset = "0x2C024F4", VA = "0x2C024F4")]
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2C02604", Offset = "0x2C02604", VA = "0x2C02604")]
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2C02714", Offset = "0x2C02714", VA = "0x2C02714")]
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2C02824", Offset = "0x2C02824", VA = "0x2C02824")]
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2C02934", Offset = "0x2C02934", VA = "0x2C02934")]
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2C02A44", Offset = "0x2C02A44", VA = "0x2C02A44")]
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2C02B54", Offset = "0x2C02B54", VA = "0x2C02B54")]
		private static void Execute(IDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2C02C64", Offset = "0x2C02C64", VA = "0x2C02C64")]
		private static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2C02D74", Offset = "0x2C02D74", VA = "0x2C02D74")]
		private static void Execute(IDropHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2C02E84", Offset = "0x2C02E84", VA = "0x2C02E84")]
		private static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2C02F94", Offset = "0x2C02F94", VA = "0x2C02F94")]
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2C03054", Offset = "0x2C03054", VA = "0x2C03054")]
		private static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2C03114", Offset = "0x2C03114", VA = "0x2C03114")]
		private static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2C031D4", Offset = "0x2C031D4", VA = "0x2C031D4")]
		private static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2C032E4", Offset = "0x2C032E4", VA = "0x2C032E4")]
		private static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2C033A4", Offset = "0x2C033A4", VA = "0x2C033A4")]
		private static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2C03B08", Offset = "0x2C03B08", VA = "0x2C03B08")]
		private static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
		}

		[Token(Token = "0x60005E3")]
		public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor) where T : IEventSystemHandler
		{
			return default;
		}

		[Token(Token = "0x60005E4")]
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		private static bool ShouldSendToComponent<T>(Component component) where T : IEventSystemHandler
		{
			return default;
		}

		[Token(Token = "0x60005E6")]
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) where T : IEventSystemHandler
		{
		}

		[Token(Token = "0x60005E7")]
		public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler
		{
			return default;
		}

		[Token(Token = "0x60005E8")]
		public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			return null;
		}
	}
}
