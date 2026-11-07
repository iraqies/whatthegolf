using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002E0")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[Token(Token = "0x20002E1")]
		public enum InteractionState
		{
			[Token(Token = "0x4000F38")]
			Normal = 0,
			[Token(Token = "0x4000F39")]
			Highlighted = 1,
			[Token(Token = "0x4000F3A")]
			Pressed = 2,
			[Token(Token = "0x4000F3B")]
			Disabled = 3
		}

		[Token(Token = "0x20002E2")]
		[Flags]
		public enum TransitionTypeFlags
		{
			[Token(Token = "0x4000F3D")]
			None = 0,
			[Token(Token = "0x4000F3E")]
			ColorTint = 1,
			[Token(Token = "0x4000F3F")]
			SpriteSwap = 2,
			[Token(Token = "0x4000F40")]
			Animation = 4
		}

		[Token(Token = "0x20002E3")]
		[Flags]
		public enum MouseButtonFlags
		{
			[Token(Token = "0x4000F42")]
			None = 0,
			[Token(Token = "0x4000F43")]
			LeftButton = 1,
			[Token(Token = "0x4000F44")]
			RightButton = 2,
			[Token(Token = "0x4000F45")]
			MiddleButton = 4,
			[Token(Token = "0x4000F46")]
			AnyButton = -1
		}

		[Serializable]
		[Token(Token = "0x20002E4")]
		public class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs>
		{
			[Token(Token = "0x60015F4")]
			[Address(RVA = "0x2398FA4", Offset = "0x2398FA4", VA = "0x2398FA4")]
			public InteractionStateTransitionEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002E5")]
		public class VisibilityChangedEventHandler : UnityEvent<bool>
		{
			[Token(Token = "0x60015F5")]
			[Address(RVA = "0x2398FFC", Offset = "0x2398FFC", VA = "0x2398FFC")]
			public VisibilityChangedEventHandler()
			{
			}
		}

		[Token(Token = "0x20002E6")]
		public class InteractionStateTransitionArgs
		{
			[Token(Token = "0x4000F47")]
			[FieldOffset(Offset = "0x10")]
			private TouchInteractable mdNLcIIFZogxyEqNhtpLBiKIlHKdb;

			[Token(Token = "0x4000F48")]
			[FieldOffset(Offset = "0x18")]
			private InteractionState IcXfJYgXoAwFSLAcAfqjnBioHaOP;

			[Token(Token = "0x4000F49")]
			[FieldOffset(Offset = "0x1C")]
			private float hRUQtuehVIxYwRwXawPyYQlptzd;

			[Token(Token = "0x170005DE")]
			public TouchInteractable sender
			{
				[Token(Token = "0x60015F6")]
				[Address(RVA = "0x2398F74", Offset = "0x2398F74", VA = "0x2398F74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170005DF")]
			public InteractionState state
			{
				[Token(Token = "0x60015F7")]
				[Address(RVA = "0x2398F7C", Offset = "0x2398F7C", VA = "0x2398F7C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170005E0")]
			public float duration
			{
				[Token(Token = "0x60015F8")]
				[Address(RVA = "0x2398F84", Offset = "0x2398F84", VA = "0x2398F84")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x2398F8C", Offset = "0x2398F8C", VA = "0x2398F8C")]
			internal InteractionStateTransitionArgs()
			{
			}

			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x2398F94", Offset = "0x2398F94", VA = "0x2398F94")]
			internal void MPIdpLqhJeCJHWkSZORdXwngeGgr(TouchInteractable P_0, InteractionState P_1, float P_2)
			{
			}
		}

		[Token(Token = "0x20002E7")]
		public interface IInteractionStateTransitionHandler
		{
			[Token(Token = "0x60015FB")]
			void OnInteractionStateTransition(InteractionStateTransitionArgs data);
		}

		[Serializable]
		[Token(Token = "0x20002E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191BE4", Offset = "0x191BE4")]
		private sealed class sAYmuinILTdHAaVFmcDvAtpjkrKib
		{
			[Token(Token = "0x4000F4A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly sAYmuinILTdHAaVFmcDvAtpjkrKib _003C_003E9;

			[Token(Token = "0x4000F4B")]
			[FieldOffset(Offset = "0x8")]
			public static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> _003C_003E9__152_0;

			[Token(Token = "0x60015FD")]
			[Address(RVA = "0x23990B4", Offset = "0x23990B4", VA = "0x23990B4")]
			public sAYmuinILTdHAaVFmcDvAtpjkrKib()
			{
			}

			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x23990BC", Offset = "0x23990BC", VA = "0x23990BC")]
			internal void sKyZmbYJtmutnzXBpDUqXErvBbehA(IInteractionStateTransitionHandler P_0, InteractionStateTransitionArgs P_1)
			{
			}
		}

		[Token(Token = "0x4000F17")]
		public const int POINTER_ID_NULL = int.MinValue;

		[Token(Token = "0x4000F18")]
		public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1;

		[Token(Token = "0x4000F19")]
		public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2;

		[Token(Token = "0x4000F1A")]
		public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3;

		[Token(Token = "0x4000F1B")]
		internal const int MAX_MOUSE_BUTTONS = 3;

		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _interactable;

		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _visible;

		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _hideWhenIdle;

		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MouseButtonFlags _allowedMouseButtons;

		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TransitionTypeFlags _transitionType;

		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ColorBlock _transitionColorTint;

		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SpriteState _transitionSpriteState;

		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AnimationTriggers _transitionAnimationTriggers;

		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Graphic _targetGraphic;

		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private InteractionStateTransitionEventHandler _onInteractionStateTransition;

		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private VisibilityChangedEventHandler _onVisibilityChanged;

		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UnityEvent _onInteractionStateChangedToNormal;

		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UnityEvent _onInteractionStateChangedToHighlighted;

		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UnityEvent _onInteractionStateChangedToPressed;

		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UnityEvent _onInteractionStateChangedToDisabled;

		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<CanvasGroup> _canvasGroupCache;

		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x108")]
		private bool _groupsAllowInteraction;

		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x10C")]
		private InteractionState _interactionState;

		[NonSerialized]
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x110")]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		[NonSerialized]
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x111")]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x112")]
		private bool _varWatch_visible;

		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x113")]
		private bool _varWatch_interactable;

		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x114")]
		private bool _allowSendingEvents;

		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x0")]
		private static InteractionStateTransitionArgs _transitionArgs;

		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x118")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers;

		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x120")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers;

		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x8")]
		private static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate;

		[Token(Token = "0x170005CF")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IVisibilityChangedHandler, bool> wLIJGrhiyTLONXbMWiyIGwppCVOk
		{
			[Token(Token = "0x60015A1")]
			[Address(RVA = "0x2423ED4", Offset = "0x2423ED4", VA = "0x2423ED4")]
			get
			{
				return bQeYGvhlVSfWwwbxhQXtQdRLHOCB();
			}
		}

		[Token(Token = "0x170005D0")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> ffhjypFMUoylOtTdlgaohUZSHIqR
		{
			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x2423FA0", Offset = "0x2423FA0", VA = "0x2423FA0")]
			get
			{
				return FhIIixVqymOdhUkYxJHkSaXinkSM();
			}
		}

		[Token(Token = "0x170005D1")]
		public bool interactable
		{
			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x242420C", Offset = "0x242420C", VA = "0x242420C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015A4")]
			[Address(RVA = "0x2424214", Offset = "0x2424214", VA = "0x2424214")]
			set
			{
			}
		}

		[Token(Token = "0x170005D2")]
		public bool visible
		{
			[Token(Token = "0x60015A5")]
			[Address(RVA = "0x2424238", Offset = "0x2424238", VA = "0x2424238")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015A6")]
			[Address(RVA = "0x2424240", Offset = "0x2424240", VA = "0x2424240")]
			set
			{
			}
		}

		[Token(Token = "0x170005D3")]
		public bool hideWhenIdle
		{
			[Token(Token = "0x60015A7")]
			[Address(RVA = "0x242434C", Offset = "0x242434C", VA = "0x242434C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015A8")]
			[Address(RVA = "0x2424354", Offset = "0x2424354", VA = "0x2424354")]
			set
			{
			}
		}

		[Token(Token = "0x170005D4")]
		public MouseButtonFlags allowedMouseButtons
		{
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x2424378", Offset = "0x2424378", VA = "0x2424378")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015AA")]
			[Address(RVA = "0x2424380", Offset = "0x2424380", VA = "0x2424380")]
			set
			{
			}
		}

		[Token(Token = "0x170005D5")]
		public TransitionTypeFlags transitionType
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x24243A4", Offset = "0x24243A4", VA = "0x24243A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015AC")]
			[Address(RVA = "0x241EB88", Offset = "0x241EB88", VA = "0x241EB88")]
			set
			{
			}
		}

		[Token(Token = "0x170005D6")]
		public ColorBlock transitionColorTint
		{
			[Token(Token = "0x60015AD")]
			[Address(RVA = "0x24243AC", Offset = "0x24243AC", VA = "0x24243AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015AE")]
			[Address(RVA = "0x24243D8", Offset = "0x24243D8", VA = "0x24243D8")]
			set
			{
			}
		}

		[Token(Token = "0x170005D7")]
		public SpriteState transitionSpriteState
		{
			[Token(Token = "0x60015AF")]
			[Address(RVA = "0x2424410", Offset = "0x2424410", VA = "0x2424410")]
			get
			{
				return default;
			}
			[Token(Token = "0x60015B0")]
			[Address(RVA = "0x242441C", Offset = "0x242441C", VA = "0x242441C")]
			set
			{
			}
		}

		[Token(Token = "0x170005D8")]
		public AnimationTriggers transitionAnimationTriggers
		{
			[Token(Token = "0x60015B1")]
			[Address(RVA = "0x242447C", Offset = "0x242447C", VA = "0x242447C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015B2")]
			[Address(RVA = "0x2424484", Offset = "0x2424484", VA = "0x2424484")]
			set
			{
			}
		}

		[Token(Token = "0x170005D9")]
		public Graphic targetGraphic
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x24244A8", Offset = "0x24244A8", VA = "0x24244A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015B4")]
			[Address(RVA = "0x24244B0", Offset = "0x24244B0", VA = "0x24244B0")]
			set
			{
			}
		}

		[Token(Token = "0x170005DA")]
		public Image image
		{
			[Token(Token = "0x60015B5")]
			[Address(RVA = "0x242455C", Offset = "0x242455C", VA = "0x242455C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015B6")]
			[Address(RVA = "0x24245DC", Offset = "0x24245DC", VA = "0x24245DC")]
			set
			{
			}
		}

		[Token(Token = "0x170005DB")]
		public Animator animator
		{
			[Token(Token = "0x60015B7")]
			[Address(RVA = "0x2424688", Offset = "0x2424688", VA = "0x2424688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DC")]
		public InteractionState interactionState
		{
			[Token(Token = "0x60015B8")]
			[Address(RVA = "0x24246E8", Offset = "0x24246E8", VA = "0x24246E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170005DD")]
		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> acccfaKFznMHaCXBovceQcVIvoxB
		{
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x2424094", Offset = "0x2424094", VA = "0x2424094")]
			get
			{
				return FJhyMdiMOzgSpzoUupEJPcNisnjG();
			}
		}

		[Token(Token = "0x1400002B")]
		public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent
		{
			[Token(Token = "0x6001595")]
			[Address(RVA = "0x2423C64", Offset = "0x2423C64", VA = "0x2423C64")]
			add
			{
			}
			[Token(Token = "0x6001596")]
			[Address(RVA = "0x2423CC8", Offset = "0x2423CC8", VA = "0x2423CC8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002C")]
		public event UnityAction<bool> VisibilityChangedEvent
		{
			[Token(Token = "0x6001597")]
			[Address(RVA = "0x2423D2C", Offset = "0x2423D2C", VA = "0x2423D2C")]
			add
			{
			}
			[Token(Token = "0x6001598")]
			[Address(RVA = "0x2423D90", Offset = "0x2423D90", VA = "0x2423D90")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002D")]
		public event UnityAction InteractionStateChangedToNormal
		{
			[Token(Token = "0x6001599")]
			[Address(RVA = "0x2423DF4", Offset = "0x2423DF4", VA = "0x2423DF4")]
			add
			{
			}
			[Token(Token = "0x600159A")]
			[Address(RVA = "0x2423E10", Offset = "0x2423E10", VA = "0x2423E10")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002E")]
		public event UnityAction InteractionStateChangedToHighlighted
		{
			[Token(Token = "0x600159B")]
			[Address(RVA = "0x2423E2C", Offset = "0x2423E2C", VA = "0x2423E2C")]
			add
			{
			}
			[Token(Token = "0x600159C")]
			[Address(RVA = "0x2423E48", Offset = "0x2423E48", VA = "0x2423E48")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002F")]
		public event UnityAction InteractionStateChangedToPressed
		{
			[Token(Token = "0x600159D")]
			[Address(RVA = "0x2423E64", Offset = "0x2423E64", VA = "0x2423E64")]
			add
			{
			}
			[Token(Token = "0x600159E")]
			[Address(RVA = "0x2423E80", Offset = "0x2423E80", VA = "0x2423E80")]
			remove
			{
			}
		}

		[Token(Token = "0x14000030")]
		public event UnityAction InteractionStateChangedToDisabled
		{
			[Token(Token = "0x600159F")]
			[Address(RVA = "0x2423E9C", Offset = "0x2423E9C", VA = "0x2423E9C")]
			add
			{
			}
			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x2423EB8", Offset = "0x2423EB8", VA = "0x2423EB8")]
			remove
			{
			}
		}

		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x2423ED4", Offset = "0x2423ED4", VA = "0x2423ED4")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IVisibilityChangedHandler, bool> bQeYGvhlVSfWwwbxhQXtQdRLHOCB()
		{
			return null;
		}

		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x2423FA0", Offset = "0x2423FA0", VA = "0x2423FA0")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> FhIIixVqymOdhUkYxJHkSaXinkSM()
		{
			return null;
		}

		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x241DBFC", Offset = "0x241DBFC", VA = "0x241DBFC")]
		internal TouchInteractable()
		{
		}

		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x241E54C", Offset = "0x241E54C", VA = "0x241E54C", Slot = "8")]
		internal override void Awake()
		{
		}

		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x242491C", Offset = "0x242491C", VA = "0x242491C", Slot = "12")]
		internal override void OnCanvasGroupChanged()
		{
		}

		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x2424BE4", Offset = "0x2424BE4", VA = "0x2424BE4", Slot = "14")]
		internal override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x241E680", Offset = "0x241E680", VA = "0x241E680", Slot = "9")]
		internal override void OnEnable()
		{
		}

		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x241E7C4", Offset = "0x241E7C4", VA = "0x241E7C4", Slot = "10")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x241E848", Offset = "0x241E848", VA = "0x241E848", Slot = "11")]
		internal override void OnValidate()
		{
		}

		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x241EB14", Offset = "0x241EB14", VA = "0x241EB14", Slot = "15")]
		internal override void Reset()
		{
		}

		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x241F7F8", Offset = "0x241F7F8", VA = "0x241F7F8", Slot = "21")]
		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x24253F4", Offset = "0x24253F4", VA = "0x24253F4", Slot = "23")]
		internal override void AOKLCSwSOHWHrUKFiqLEizXMqAyJ()
		{
		}

		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x2424CDC", Offset = "0x2424CDC", VA = "0x2424CDC")]
		private void INwDgTcjRJhaRDZhFMUCkMFDOPNsb()
		{
		}

		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x242541C", Offset = "0x242541C", VA = "0x242541C")]
		private void hglCsrIBOMheHfVQdYkhhXZRzOHp(InteractionState P_0, bool P_1)
		{
		}

		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x2424ED4", Offset = "0x2424ED4", VA = "0x2424ED4")]
		private void xlgQtdzFtohQezQAfGKiojQhbSkC(Color P_0, bool P_1)
		{
		}

		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x2424D68", Offset = "0x2424D68", VA = "0x2424D68")]
		private void iPNYmRKNmVKLLvYVczPJNDOhpNp(Sprite P_0)
		{
		}

		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x2424FEC", Offset = "0x2424FEC", VA = "0x2424FEC")]
		private void nDvULZqHixCpCetWuBUNEVUJxDFfA(string P_0)
		{
		}

		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x2424C7C", Offset = "0x2424C7C", VA = "0x2424C7C")]
		private void SLncskcXOyNomyPEQOTFtPPeUMxl(bool P_0)
		{
		}

		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x2421B6C", Offset = "0x2421B6C", VA = "0x2421B6C")]
		public bool IsInteractable()
		{
			return default;
		}

		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x2425788", Offset = "0x2425788", VA = "0x2425788", Slot = "34")]
		internal virtual bool jlMJYbxJlzjsBwCBJxvDZPhnPAZF()
		{
			return default;
		}

		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x241FFF4", Offset = "0x241FFF4", VA = "0x241FFF4")]
		internal void MyVxLtVZLEiRaloNqnuyxYfDkCJB(BaseEventData P_0)
		{
		}

		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x241FC8C", Offset = "0x241FC8C", VA = "0x241FC8C", Slot = "35")]
		internal virtual bool mxaQUajJeAklKpqxemiTJFTBFCaq(GameObject P_0)
		{
			return default;
		}

		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x2425814", Offset = "0x2425814", VA = "0x2425814")]
		private bool eLaloPrgLtqtgnSHTUWIpzqjkpdg(BaseEventData P_0)
		{
			return default;
		}

		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x24258F0", Offset = "0x24258F0", VA = "0x24258F0")]
		private bool eLaloPrgLtqtgnSHTUWIpzqjkpdg(bool P_0, GameObject P_1)
		{
			return default;
		}

		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x24257CC", Offset = "0x24257CC", VA = "0x24257CC")]
		private InteractionState BsKBAlIXlthRFOWqhXlGmOZChYRP(BaseEventData P_0)
		{
			return default;
		}

		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x2424C0C", Offset = "0x2424C0C", VA = "0x2424C0C")]
		private bool nZWiGUpTvdikApDJloojrjuVmTkT(InteractionState P_0)
		{
			return default;
		}

		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x2425A30", Offset = "0x2425A30", VA = "0x2425A30")]
		private void qYjwmIsGNqaqsrYpkWNnmZsdgRjL()
		{
		}

		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x2425A84", Offset = "0x2425A84", VA = "0x2425A84")]
		private void omTzsBWpbINbKcsCkDetNsakDXSg()
		{
		}

		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x2424284", Offset = "0x2424284", VA = "0x2424284")]
		private void nnXqcpdOcMbRXjEWYqRtWFgsBQGCb(bool P_0, bool P_1)
		{
		}

		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x24246F0", Offset = "0x24246F0", VA = "0x24246F0")]
		private void ZOHvREfiEGuSoZkpvCoiaVVliwbJ()
		{
		}

		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x2425AD8", Offset = "0x2425AD8", VA = "0x2425AD8")]
		private void ZESmGDtKgyfxEWszxkXiDLpKTdRJ()
		{
		}

		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x2424B14", Offset = "0x2424B14", VA = "0x2424B14")]
		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x2425344", Offset = "0x2425344", VA = "0x2425344")]
		private void VeGtVHSUfBgpypkoecTaTsuYNRxB()
		{
		}

		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x2421BF8", Offset = "0x2421BF8", VA = "0x2421BF8", Slot = "36")]
		internal virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x2421E44", Offset = "0x2421E44", VA = "0x2421E44", Slot = "37")]
		internal virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x2422378", Offset = "0x2422378", VA = "0x2422378", Slot = "38")]
		internal virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x2422604", Offset = "0x2422604", VA = "0x2422604", Slot = "39")]
		internal virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x2425B90", Offset = "0x2425B90", VA = "0x2425B90", Slot = "40")]
		internal virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x2425C60", Offset = "0x2425C60", VA = "0x2425C60", Slot = "41")]
		internal virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x2425D30", Offset = "0x2425D30", VA = "0x2425D30", Slot = "42")]
		internal virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x2425E00", Offset = "0x2425E00", VA = "0x2425E00", Slot = "27")]
		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x2425E10", Offset = "0x2425E10", VA = "0x2425E10", Slot = "28")]
		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x2425E20", Offset = "0x2425E20", VA = "0x2425E20", Slot = "29")]
		private void UnityEngine_002EEventSystems_002EIPointerEnterHandler_002EOnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x2425E30", Offset = "0x2425E30", VA = "0x2425E30", Slot = "30")]
		private void UnityEngine_002EEventSystems_002EIPointerExitHandler_002EOnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x2425E40", Offset = "0x2425E40", VA = "0x2425E40", Slot = "31")]
		private void UnityEngine_002EEventSystems_002EIBeginDragHandler_002EOnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x2425E50", Offset = "0x2425E50", VA = "0x2425E50", Slot = "32")]
		private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x2425E60", Offset = "0x2425E60", VA = "0x2425E60", Slot = "33")]
		private void UnityEngine_002EEventSystems_002EIEndDragHandler_002EOnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x2420F08", Offset = "0x2420F08", VA = "0x2420F08")]
		internal static bool uwuMHSNgPoeyIZKBbzpvCZyfdwOl(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x24210D4", Offset = "0x24210D4", VA = "0x24210D4")]
		internal static Vector3 TgEgBYQvFnhTTkcyuYMooLsCFzzE(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x2421898", Offset = "0x2421898", VA = "0x2421898")]
		internal static bool pmexXrLSDjTQXxgZQgGydOXadJnJ(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x24215D0", Offset = "0x24215D0", VA = "0x24215D0")]
		internal static bool sWBkWrgBUhjXAreNdBTEqWiNGgHjA(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x2425E70", Offset = "0x2425E70", VA = "0x2425E70")]
		private static int YTEbllrnkaeDPiJskuNKvBBwFwSGb(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x2425FF4", Offset = "0x2425FF4", VA = "0x2425FF4")]
		internal static bool AgilIEWjYyfxLMkJfmkwQMfVpnhH(MouseButtonFlags P_0, int P_1)
		{
			return default;
		}

		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x2426100", Offset = "0x2426100", VA = "0x2426100")]
		private static bool manQAANcvozYeLgCmwQAxmgWUWgm(MouseButtonFlags P_0, int P_1)
		{
			return default;
		}

		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x2425F68", Offset = "0x2425F68", VA = "0x2425F68")]
		private static int ZZKspXACPzCYUfirNRryGoDTWAdNA(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x242230C", Offset = "0x242230C", VA = "0x242230C")]
		internal static bool ZbAsyupCrOtBnZlFjdZxrpdrFStI(MouseButtonFlags P_0, out int P_1)
		{
			return default;
		}

		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x2422874", Offset = "0x2422874", VA = "0x2422874")]
		internal static bool AgilIEWjYyfxLMkJfmkwQMfVpnhH(int P_0, MouseButtonFlags P_1, EventTriggerType P_2)
		{
			return default;
		}

		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x2422270", Offset = "0x2422270", VA = "0x2422270")]
		internal static bool LTWUvUGhphDXhnFmUjsOImULiiXRA(MouseButtonFlags P_0)
		{
			return default;
		}

		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x2424094", Offset = "0x2424094", VA = "0x2424094")]
		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> FJhyMdiMOzgSpzoUupEJPcNisnjG()
		{
			return null;
		}

		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x24261B8", Offset = "0x24261B8", VA = "0x24261B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197330", Offset = "0x197330")]
		private void jAefcAGxJBlZZkeVtQJgVULtgxiH(bool P_0)
		{
		}
	}
}
