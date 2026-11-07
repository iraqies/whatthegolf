using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[Token(Token = "0x200030D")]
	[DisallowMultipleComponent]
	[Attribute(Name = "RequireComponent", RVA = "0x191CAC", Offset = "0x191CAC")]
	[ExecuteInEditMode]
	public sealed class TouchInteractableTransitioner : MonoBehaviour, TouchInteractable.IInteractionStateTransitionHandler, IVisibilityChangedHandler
	{
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _visible;

		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TouchInteractable.TransitionTypeFlags _transitionType;

		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ColorBlock _transitionColorTint;

		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SpriteState _transitionSpriteState;

		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationTriggers _transitionAnimationTriggers;

		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Graphic _targetGraphic;

		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _syncFadeDurationWithTransitionEvent;

		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0xA9")]
		[SerializeField]
		private bool _syncColorTintWithTransitionEvent;

		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0xAC")]
		private TouchInteractable.InteractionState HhQEsgunwIBmdPnajRmqJgLKSCzB;

		[Token(Token = "0x17000631")]
		public bool visible
		{
			[Token(Token = "0x6001741")]
			[Address(RVA = "0x24261C0", Offset = "0x24261C0", VA = "0x24261C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001742")]
			[Address(RVA = "0x24261C8", Offset = "0x24261C8", VA = "0x24261C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000632")]
		public TouchInteractable.TransitionTypeFlags transitionType
		{
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x2426258", Offset = "0x2426258", VA = "0x2426258")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x2426260", Offset = "0x2426260", VA = "0x2426260")]
			set
			{
			}
		}

		[Token(Token = "0x17000633")]
		public ColorBlock transitionColorTint
		{
			[Token(Token = "0x6001745")]
			[Address(RVA = "0x24262A4", Offset = "0x24262A4", VA = "0x24262A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x24262C8", Offset = "0x24262C8", VA = "0x24262C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000634")]
		public SpriteState transitionSpriteState
		{
			[Token(Token = "0x6001747")]
			[Address(RVA = "0x2426318", Offset = "0x2426318", VA = "0x2426318")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001748")]
			[Address(RVA = "0x2426328", Offset = "0x2426328", VA = "0x2426328")]
			set
			{
			}
		}

		[Token(Token = "0x17000635")]
		public AnimationTriggers transitionAnimationTriggers
		{
			[Token(Token = "0x6001749")]
			[Address(RVA = "0x2426390", Offset = "0x2426390", VA = "0x2426390")]
			get
			{
				return null;
			}
			[Token(Token = "0x600174A")]
			[Address(RVA = "0x2426398", Offset = "0x2426398", VA = "0x2426398")]
			set
			{
			}
		}

		[Token(Token = "0x17000636")]
		public Graphic targetGraphic
		{
			[Token(Token = "0x600174B")]
			[Address(RVA = "0x24263DC", Offset = "0x24263DC", VA = "0x24263DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600174C")]
			[Address(RVA = "0x24263E4", Offset = "0x24263E4", VA = "0x24263E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000637")]
		public bool syncFadeDurationWithTransitionEvent
		{
			[Token(Token = "0x600174D")]
			[Address(RVA = "0x2426494", Offset = "0x2426494", VA = "0x2426494")]
			get
			{
				return default;
			}
			[Token(Token = "0x600174E")]
			[Address(RVA = "0x242649C", Offset = "0x242649C", VA = "0x242649C")]
			set
			{
			}
		}

		[Token(Token = "0x17000638")]
		public bool syncColorTintWithTransitionEvent
		{
			[Token(Token = "0x600174F")]
			[Address(RVA = "0x24264E0", Offset = "0x24264E0", VA = "0x24264E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001750")]
			[Address(RVA = "0x24264E8", Offset = "0x24264E8", VA = "0x24264E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000639")]
		public Image image
		{
			[Token(Token = "0x6001751")]
			[Address(RVA = "0x242652C", Offset = "0x242652C", VA = "0x242652C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x24265AC", Offset = "0x24265AC", VA = "0x24265AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700063A")]
		public Animator animator
		{
			[Token(Token = "0x6001753")]
			[Address(RVA = "0x242665C", Offset = "0x242665C", VA = "0x242665C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001754")]
		[Address(RVA = "0x24266BC", Offset = "0x24266BC", VA = "0x24266BC")]
		private TouchInteractableTransitioner()
		{
		}

		[Token(Token = "0x6001755")]
		[Address(RVA = "0x24267F4", Offset = "0x24267F4", VA = "0x24267F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001756")]
		[Address(RVA = "0x24268B0", Offset = "0x24268B0", VA = "0x24268B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6001757")]
		[Address(RVA = "0x24268EC", Offset = "0x24268EC", VA = "0x24268EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6001758")]
		[Address(RVA = "0x2426978", Offset = "0x2426978", VA = "0x2426978")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6001759")]
		[Address(RVA = "0x2427068", Offset = "0x2427068", VA = "0x2427068")]
		private void Reset()
		{
		}

		[Token(Token = "0x600175A")]
		[Address(RVA = "0x24270CC", Offset = "0x24270CC", VA = "0x24270CC")]
		private void OnCanvasGroupWasChanged()
		{
		}

		[Token(Token = "0x600175B")]
		[Address(RVA = "0x24270FC", Offset = "0x24270FC", VA = "0x24270FC")]
		private void OnAnimationPropertiesWereApplied()
		{
		}

		[Token(Token = "0x600175C")]
		[Address(RVA = "0x2426228", Offset = "0x2426228", VA = "0x2426228")]
		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x600175D")]
		[Address(RVA = "0x2427038", Offset = "0x2427038", VA = "0x2427038")]
		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		[Token(Token = "0x600175E")]
		[Address(RVA = "0x24268E0", Offset = "0x24268E0", VA = "0x24268E0")]
		private void SLncskcXOyNomyPEQOTFtPPeUMxl(bool P_0)
		{
		}

		[Token(Token = "0x600175F")]
		[Address(RVA = "0x242620C", Offset = "0x242620C", VA = "0x242620C")]
		private void nnXqcpdOcMbRXjEWYqRtWFgsBQGCb(bool P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001760")]
		[Address(RVA = "0x242733C", Offset = "0x242733C", VA = "0x242733C")]
		private bool CaQjRIyFeGifnfpNsppSXvnBcpzo()
		{
			return default;
		}

		[Token(Token = "0x6001761")]
		[Address(RVA = "0x24268F0", Offset = "0x24268F0", VA = "0x24268F0")]
		private void INwDgTcjRJhaRDZhFMUCkMFDOPNsb()
		{
		}

		[Token(Token = "0x6001762")]
		[Address(RVA = "0x242712C", Offset = "0x242712C", VA = "0x242712C")]
		private void hglCsrIBOMheHfVQdYkhhXZRzOHp(TouchInteractable.InteractionState P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001763")]
		[Address(RVA = "0x2426BC8", Offset = "0x2426BC8", VA = "0x2426BC8")]
		private void xlgQtdzFtohQezQAfGKiojQhbSkC(Color P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001764")]
		[Address(RVA = "0x2426A5C", Offset = "0x2426A5C", VA = "0x2426A5C")]
		private void iPNYmRKNmVKLLvYVczPJNDOhpNp(Sprite P_0)
		{
		}

		[Token(Token = "0x6001765")]
		[Address(RVA = "0x2426CE0", Offset = "0x2426CE0", VA = "0x2426CE0")]
		private void nDvULZqHixCpCetWuBUNEVUJxDFfA(string P_0)
		{
		}

		[Token(Token = "0x6001766")]
		[Address(RVA = "0x24273B8", Offset = "0x24273B8", VA = "0x24273B8", Slot = "4")]
		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args)
		{
		}

		[Token(Token = "0x6001767")]
		[Address(RVA = "0x24274DC", Offset = "0x24274DC", VA = "0x24274DC", Slot = "5")]
		public void OnVisibilityChanged(bool state)
		{
		}
	}
}
