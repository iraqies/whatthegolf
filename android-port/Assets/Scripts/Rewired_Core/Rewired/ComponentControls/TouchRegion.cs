using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TouchRegion : TouchInteractable
	{
		[Serializable]
		private class ghVKEZJBJYQJvvstwXJnrgnXfsDt : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class lTQAltguQayUUSZjuRqVFyuoqtzBA : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class INFDjiJnyNyrBINFJecsvtYIqrPeA : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class clhedBWPziouPAAOAIrdSYmUdssL : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class bMdkKDfmBnVLDeOqapsCIEZDnLIq : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class XFhydDPwQZlOXNQvZDlvktxFlUpT : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class ItJCBvpQxToTdxKYPgpoCjgfAhxHA : UnityEvent<PointerEventData>
		{
		}

		[SerializeField]
		private bool _hideAtRuntime;

		private ghVKEZJBJYQJvvstwXJnrgnXfsDt _onPointerDown;

		private lTQAltguQayUUSZjuRqVFyuoqtzBA _onPointerUp;

		private INFDjiJnyNyrBINFJecsvtYIqrPeA _onPointerEnter;

		private clhedBWPziouPAAOAIrdSYmUdssL _onPointerExit;

		private bMdkKDfmBnVLDeOqapsCIEZDnLIq _onBeginDrag;

		private XFhydDPwQZlOXNQvZDlvktxFlUpT _onDrag;

		private ItJCBvpQxToTdxKYPgpoCjgfAhxHA _onEndDrag;

		public bool hideAtRuntime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event UnityAction<PointerEventData> PointerDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> PointerUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> PointerEnterEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> PointerExitEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> BeginDragEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> DragEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> EndDragEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private TouchRegion()
		{
		}

		internal override void Awake()
		{
		}

		public override void ClearValue()
		{
		}

		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		internal override void OnPointerDown(PointerEventData P_0)
		{
		}

		internal override void OnPointerUp(PointerEventData P_0)
		{
		}

		internal override void OnPointerEnter(PointerEventData P_0)
		{
		}

		internal override void OnPointerExit(PointerEventData P_0)
		{
		}

		internal override void OnBeginDrag(PointerEventData P_0)
		{
		}

		internal override void OnDrag(PointerEventData P_0)
		{
		}

		internal override void OnEndDrag(PointerEventData P_0)
		{
		}
	}
}
