using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.ComponentControls
{
	[Serializable]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		public enum InteractionState
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Disabled = 3
		}

		[Flags]
		public enum TransitionTypeFlags
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 4
		}

		[Flags]
		public enum MouseButtonFlags
		{
			None = 0,
			LeftButton = 1,
			RightButton = 2,
			MiddleButton = 4,
			AnyButton = -1
		}

		[Serializable]
		public class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs>
		{
		}

		[Serializable]
		public class VisibilityChangedEventHandler : UnityEvent<bool>
		{
		}

		public class InteractionStateTransitionArgs
		{
			private TouchInteractable mdNLcIIFZogxyEqNhtpLBiKIlHKdb;

			private InteractionState IcXfJYgXoAwFSLAcAfqjnBioHaOP;

			private float hRUQtuehVIxYwRwXawPyYQlptzd;

			public TouchInteractable sender => null;

			public InteractionState state => InteractionState.Normal;

			public float duration => 0f;

			internal InteractionStateTransitionArgs()
			{
			}

			internal void MPIdpLqhJeCJHWkSZORdXwngeGgr(TouchInteractable P_0, InteractionState P_1, float P_2)
			{
			}
		}

		public interface IInteractionStateTransitionHandler
		{
			void OnInteractionStateTransition(InteractionStateTransitionArgs data);
		}

		[Serializable]
		private sealed class sAYmuinILTdHAaVFmcDvAtpjkrKib
		{
			public static readonly sAYmuinILTdHAaVFmcDvAtpjkrKib _003C_003E9;

			public static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> _003C_003E9__152_0;

			internal void sKyZmbYJtmutnzXBpDUqXErvBbehA(IInteractionStateTransitionHandler P_0, InteractionStateTransitionArgs P_1)
			{
			}
		}

		public const int POINTER_ID_NULL = int.MinValue;

		public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1;

		public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2;

		public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3;

		internal const int MAX_MOUSE_BUTTONS = 3;

		[SerializeField]
		private bool _interactable;

		[SerializeField]
		private bool _visible;

		[SerializeField]
		private bool _hideWhenIdle;

		[SerializeField]
		private MouseButtonFlags _allowedMouseButtons;

		[SerializeField]
		private TransitionTypeFlags _transitionType;

		[SerializeField]
		private ColorBlock _transitionColorTint;

		[SerializeField]
		private SpriteState _transitionSpriteState;

		[SerializeField]
		private AnimationTriggers _transitionAnimationTriggers;

		[SerializeField]
		private Graphic _targetGraphic;

		[SerializeField]
		private InteractionStateTransitionEventHandler _onInteractionStateTransition;

		[SerializeField]
		private VisibilityChangedEventHandler _onVisibilityChanged;

		[SerializeField]
		private UnityEvent _onInteractionStateChangedToNormal;

		[SerializeField]
		private UnityEvent _onInteractionStateChangedToHighlighted;

		[SerializeField]
		private UnityEvent _onInteractionStateChangedToPressed;

		[SerializeField]
		private UnityEvent _onInteractionStateChangedToDisabled;

		private readonly List<CanvasGroup> _canvasGroupCache;

		private bool _groupsAllowInteraction;

		private InteractionState _interactionState;

		[NonSerialized]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		[NonSerialized]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		private bool _varWatch_visible;

		private bool _varWatch_interactable;

		private bool _allowSendingEvents;

		private static InteractionStateTransitionArgs _transitionArgs;

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers;

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers;

		private static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate;

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IVisibilityChangedHandler, bool> wLIJGrhiyTLONXbMWiyIGwppCVOk => bQeYGvhlVSfWwwbxhQXtQdRLHOCB();

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> ffhjypFMUoylOtTdlgaohUZSHIqR => FhIIixVqymOdhUkYxJHkSaXinkSM();

		public bool interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hideWhenIdle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MouseButtonFlags allowedMouseButtons
		{
			get
			{
				return MouseButtonFlags.None;
			}
			set
			{
			}
		}

		public TransitionTypeFlags transitionType
		{
			get
			{
				return TransitionTypeFlags.None;
			}
			set
			{
			}
		}

		public ColorBlock transitionColorTint
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public SpriteState transitionSpriteState
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public AnimationTriggers transitionAnimationTriggers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Graphic targetGraphic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Image image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Animator animator => null;

		public InteractionState interactionState => InteractionState.Normal;

		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> acccfaKFznMHaCXBovceQcVIvoxB => FJhyMdiMOzgSpzoUupEJPcNisnjG();

		public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<bool> VisibilityChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToNormal
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToHighlighted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToPressed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToDisabled
		{
			add
			{
			}
			remove
			{
			}
		}

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IVisibilityChangedHandler, bool> bQeYGvhlVSfWwwbxhQXtQdRLHOCB()
		{
			return null;
		}

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> FhIIixVqymOdhUkYxJHkSaXinkSM()
		{
			return null;
		}

		internal TouchInteractable()
		{
		}

		internal override void Awake()
		{
		}

		internal override void OnCanvasGroupChanged()
		{
		}

		internal override void OnDidApplyAnimationProperties()
		{
		}

		internal override void OnEnable()
		{
		}

		internal override void OnDisable()
		{
		}

		internal override void OnValidate()
		{
		}

		internal override void Reset()
		{
		}

		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		internal override void AOKLCSwSOHWHrUKFiqLEizXMqAyJ()
		{
		}

		private void INwDgTcjRJhaRDZhFMUCkMFDOPNsb()
		{
		}

		private void hglCsrIBOMheHfVQdYkhhXZRzOHp(InteractionState P_0, bool P_1)
		{
		}

		private void xlgQtdzFtohQezQAfGKiojQhbSkC(Color P_0, bool P_1)
		{
		}

		private void iPNYmRKNmVKLLvYVczPJNDOhpNp(Sprite P_0)
		{
		}

		private void nDvULZqHixCpCetWuBUNEVUJxDFfA(string P_0)
		{
		}

		private void SLncskcXOyNomyPEQOTFtPPeUMxl(bool P_0)
		{
		}

		public bool IsInteractable()
		{
			return false;
		}

		internal virtual bool jlMJYbxJlzjsBwCBJxvDZPhnPAZF()
		{
			return false;
		}

		internal void MyVxLtVZLEiRaloNqnuyxYfDkCJB(BaseEventData P_0)
		{
		}

		internal virtual bool mxaQUajJeAklKpqxemiTJFTBFCaq(GameObject P_0)
		{
			return false;
		}

		private bool eLaloPrgLtqtgnSHTUWIpzqjkpdg(BaseEventData P_0)
		{
			return false;
		}

		private bool eLaloPrgLtqtgnSHTUWIpzqjkpdg(bool P_0, GameObject P_1)
		{
			return false;
		}

		private InteractionState BsKBAlIXlthRFOWqhXlGmOZChYRP(BaseEventData P_0)
		{
			return InteractionState.Normal;
		}

		private bool nZWiGUpTvdikApDJloojrjuVmTkT(InteractionState P_0)
		{
			return false;
		}

		private void qYjwmIsGNqaqsrYpkWNnmZsdgRjL()
		{
		}

		private void omTzsBWpbINbKcsCkDetNsakDXSg()
		{
		}

		private void nnXqcpdOcMbRXjEWYqRtWFgsBQGCb(bool P_0, bool P_1)
		{
		}

		private void ZOHvREfiEGuSoZkpvCoiaVVliwbJ()
		{
		}

		private void ZESmGDtKgyfxEWszxkXiDLpKTdRJ()
		{
		}

		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		private void VeGtVHSUfBgpypkoecTaTsuYNRxB()
		{
		}

		internal virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		internal virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		internal virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		internal virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		internal virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		internal virtual void OnDrag(PointerEventData eventData)
		{
		}

		internal virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
		}

		void IDragHandler.OnDrag(PointerEventData eventData)
		{
		}

		void IEndDragHandler.OnEndDrag(PointerEventData eventData)
		{
		}

		internal static bool uwuMHSNgPoeyIZKBbzpvCZyfdwOl(int P_0)
		{
			return false;
		}

		internal static Vector3 TgEgBYQvFnhTTkcyuYMooLsCFzzE(int P_0)
		{
			return default;
		}

		internal static bool pmexXrLSDjTQXxgZQgGydOXadJnJ(int P_0)
		{
			return false;
		}

		internal static bool sWBkWrgBUhjXAreNdBTEqWiNGgHjA(int P_0)
		{
			return false;
		}

		private static int YTEbllrnkaeDPiJskuNKvBBwFwSGb(int P_0)
		{
			return 0;
		}

		internal static bool AgilIEWjYyfxLMkJfmkwQMfVpnhH(MouseButtonFlags P_0, int P_1)
		{
			return false;
		}

		private static bool manQAANcvozYeLgCmwQAxmgWUWgm(MouseButtonFlags P_0, int P_1)
		{
			return false;
		}

		private static int ZZKspXACPzCYUfirNRryGoDTWAdNA(int P_0)
		{
			return 0;
		}

		internal static bool ZbAsyupCrOtBnZlFjdZxrpdrFStI(MouseButtonFlags P_0, out int P_1)
		{
			P_1 = default;
			return false;
		}

		internal static bool AgilIEWjYyfxLMkJfmkwQMfVpnhH(int P_0, MouseButtonFlags P_1, EventTriggerType P_2)
		{
			return false;
		}

		internal static bool LTWUvUGhphDXhnFmUjsOImULiiXRA(MouseButtonFlags P_0)
		{
			return false;
		}

		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> FJhyMdiMOzgSpzoUupEJPcNisnjG()
		{
			return null;
		}

		[CompilerGenerated]
		private void jAefcAGxJBlZZkeVtQJgVULtgxiH(bool P_0)
		{
		}
	}
}
