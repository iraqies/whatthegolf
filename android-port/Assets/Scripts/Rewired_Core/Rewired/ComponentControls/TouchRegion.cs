using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x2000302")]
	[DisallowMultipleComponent]
	public sealed class TouchRegion : TouchInteractable
	{
		[Serializable]
		[Token(Token = "0x2000303")]
		private class ghVKEZJBJYQJvvstwXJnrgnXfsDt : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x2399B20", Offset = "0x2399B20", VA = "0x2399B20")]
			public ghVKEZJBJYQJvvstwXJnrgnXfsDt()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000304")]
		private class lTQAltguQayUUSZjuRqVFyuoqtzBA : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x2399B78", Offset = "0x2399B78", VA = "0x2399B78")]
			public lTQAltguQayUUSZjuRqVFyuoqtzBA()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000305")]
		private class INFDjiJnyNyrBINFJecsvtYIqrPeA : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x2399968", Offset = "0x2399968", VA = "0x2399968")]
			public INFDjiJnyNyrBINFJecsvtYIqrPeA()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000306")]
		private class clhedBWPziouPAAOAIrdSYmUdssL : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x2399AC8", Offset = "0x2399AC8", VA = "0x2399AC8")]
			public clhedBWPziouPAAOAIrdSYmUdssL()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000307")]
		private class bMdkKDfmBnVLDeOqapsCIEZDnLIq : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x600172D")]
			[Address(RVA = "0x2399A70", Offset = "0x2399A70", VA = "0x2399A70")]
			public bMdkKDfmBnVLDeOqapsCIEZDnLIq()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000308")]
		private class XFhydDPwQZlOXNQvZDlvktxFlUpT : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x600172E")]
			[Address(RVA = "0x2399A18", Offset = "0x2399A18", VA = "0x2399A18")]
			public XFhydDPwQZlOXNQvZDlvktxFlUpT()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000309")]
		private class ItJCBvpQxToTdxKYPgpoCjgfAhxHA : UnityEvent<PointerEventData>
		{
			[Token(Token = "0x600172F")]
			[Address(RVA = "0x23999C0", Offset = "0x23999C0", VA = "0x23999C0")]
			public ItJCBvpQxToTdxKYPgpoCjgfAhxHA()
			{
			}
		}

		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool _hideAtRuntime;

		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x130")]
		private ghVKEZJBJYQJvvstwXJnrgnXfsDt _onPointerDown;

		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x138")]
		private lTQAltguQayUUSZjuRqVFyuoqtzBA _onPointerUp;

		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x140")]
		private INFDjiJnyNyrBINFJecsvtYIqrPeA _onPointerEnter;

		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x148")]
		private clhedBWPziouPAAOAIrdSYmUdssL _onPointerExit;

		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x150")]
		private bMdkKDfmBnVLDeOqapsCIEZDnLIq _onBeginDrag;

		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x158")]
		private XFhydDPwQZlOXNQvZDlvktxFlUpT _onDrag;

		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x160")]
		private ItJCBvpQxToTdxKYPgpoCjgfAhxHA _onEndDrag;

		[Token(Token = "0x1700062A")]
		public bool hideAtRuntime
		{
			[Token(Token = "0x600170E")]
			[Address(RVA = "0x2432CFC", Offset = "0x2432CFC", VA = "0x2432CFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600170F")]
			[Address(RVA = "0x2432D04", Offset = "0x2432D04", VA = "0x2432D04")]
			set
			{
			}
		}

		[Token(Token = "0x1400003A")]
		public event UnityAction<PointerEventData> PointerDownEvent
		{
			[Token(Token = "0x6001710")]
			[Address(RVA = "0x2432D28", Offset = "0x2432D28", VA = "0x2432D28")]
			add
			{
			}
			[Token(Token = "0x6001711")]
			[Address(RVA = "0x2432D8C", Offset = "0x2432D8C", VA = "0x2432D8C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003B")]
		public event UnityAction<PointerEventData> PointerUpEvent
		{
			[Token(Token = "0x6001712")]
			[Address(RVA = "0x2432DF0", Offset = "0x2432DF0", VA = "0x2432DF0")]
			add
			{
			}
			[Token(Token = "0x6001713")]
			[Address(RVA = "0x2432E54", Offset = "0x2432E54", VA = "0x2432E54")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003C")]
		public event UnityAction<PointerEventData> PointerEnterEvent
		{
			[Token(Token = "0x6001714")]
			[Address(RVA = "0x2432EB8", Offset = "0x2432EB8", VA = "0x2432EB8")]
			add
			{
			}
			[Token(Token = "0x6001715")]
			[Address(RVA = "0x2432F1C", Offset = "0x2432F1C", VA = "0x2432F1C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003D")]
		public event UnityAction<PointerEventData> PointerExitEvent
		{
			[Token(Token = "0x6001716")]
			[Address(RVA = "0x2432F80", Offset = "0x2432F80", VA = "0x2432F80")]
			add
			{
			}
			[Token(Token = "0x6001717")]
			[Address(RVA = "0x2432FE4", Offset = "0x2432FE4", VA = "0x2432FE4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003E")]
		public event UnityAction<PointerEventData> BeginDragEvent
		{
			[Token(Token = "0x6001718")]
			[Address(RVA = "0x2433048", Offset = "0x2433048", VA = "0x2433048")]
			add
			{
			}
			[Token(Token = "0x6001719")]
			[Address(RVA = "0x24330AC", Offset = "0x24330AC", VA = "0x24330AC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003F")]
		public event UnityAction<PointerEventData> DragEvent
		{
			[Token(Token = "0x600171A")]
			[Address(RVA = "0x2433110", Offset = "0x2433110", VA = "0x2433110")]
			add
			{
			}
			[Token(Token = "0x600171B")]
			[Address(RVA = "0x2433174", Offset = "0x2433174", VA = "0x2433174")]
			remove
			{
			}
		}

		[Token(Token = "0x14000040")]
		public event UnityAction<PointerEventData> EndDragEvent
		{
			[Token(Token = "0x600171C")]
			[Address(RVA = "0x24331D8", Offset = "0x24331D8", VA = "0x24331D8")]
			add
			{
			}
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x243323C", Offset = "0x243323C", VA = "0x243323C")]
			remove
			{
			}
		}

		[Token(Token = "0x600171E")]
		[Address(RVA = "0x24332A0", Offset = "0x24332A0", VA = "0x24332A0")]
		private TouchRegion()
		{
		}

		[Token(Token = "0x600171F")]
		[Address(RVA = "0x2433460", Offset = "0x2433460", VA = "0x2433460", Slot = "8")]
		internal override void Awake()
		{
		}

		[Token(Token = "0x6001720")]
		[Address(RVA = "0x24334B4", Offset = "0x24334B4", VA = "0x24334B4", Slot = "7")]
		public override void ClearValue()
		{
		}

		[Token(Token = "0x6001721")]
		[Address(RVA = "0x24334B8", Offset = "0x24334B8", VA = "0x24334B8", Slot = "26")]
		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		[Token(Token = "0x6001722")]
		[Address(RVA = "0x24334BC", Offset = "0x24334BC", VA = "0x24334BC", Slot = "36")]
		internal void jdTaWudIAtigvcgWdtrrcBEKJLcPB(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001723")]
		[Address(RVA = "0x24335C8", Offset = "0x24335C8", VA = "0x24335C8", Slot = "37")]
		internal void MbXbjtguZaBfbfqmjlBSCyVMORejB(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001724")]
		[Address(RVA = "0x24336D4", Offset = "0x24336D4", VA = "0x24336D4", Slot = "38")]
		internal void vpQLxEpNsNjHEQUMTNafaJqaWgfe(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001725")]
		[Address(RVA = "0x24337E0", Offset = "0x24337E0", VA = "0x24337E0", Slot = "39")]
		internal void OCiTmGENfjrRiUQnHUcKDaHRzTDj(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001726")]
		[Address(RVA = "0x24338EC", Offset = "0x24338EC", VA = "0x24338EC", Slot = "40")]
		internal void CeCjfxfrPRDIAfCVrQPnmMvELNpzA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001727")]
		[Address(RVA = "0x24339F8", Offset = "0x24339F8", VA = "0x24339F8", Slot = "41")]
		internal void JuzlkzmoAOuJMYLEkFxWgiAjnolW(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001728")]
		[Address(RVA = "0x2433B04", Offset = "0x2433B04", VA = "0x2433B04", Slot = "42")]
		internal void LgBQosPAyBTzQOLHtYNFjeRHthOd(PointerEventData P_0)
		{
		}
	}
}
