using Rewired.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public sealed class TouchInteractableTransitioner : MonoBehaviour, TouchInteractable.IInteractionStateTransitionHandler, IVisibilityChangedHandler
	{
		[SerializeField]
		private bool _visible;

		[SerializeField]
		private TouchInteractable.TransitionTypeFlags _transitionType;

		[SerializeField]
		private ColorBlock _transitionColorTint;

		[SerializeField]
		private SpriteState _transitionSpriteState;

		[SerializeField]
		private AnimationTriggers _transitionAnimationTriggers;

		[SerializeField]
		private Graphic _targetGraphic;

		[SerializeField]
		private bool _syncFadeDurationWithTransitionEvent;

		[SerializeField]
		private bool _syncColorTintWithTransitionEvent;

		private TouchInteractable.InteractionState HhQEsgunwIBmdPnajRmqJgLKSCzB;

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

		public TouchInteractable.TransitionTypeFlags transitionType
		{
			get
			{
				return TouchInteractable.TransitionTypeFlags.None;
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

		public bool syncFadeDurationWithTransitionEvent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool syncColorTintWithTransitionEvent
		{
			get
			{
				return false;
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

		private TouchInteractableTransitioner()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}

		private void OnCanvasGroupWasChanged()
		{
		}

		private void OnAnimationPropertiesWereApplied()
		{
		}

		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		private void SLncskcXOyNomyPEQOTFtPPeUMxl(bool P_0)
		{
		}

		private void nnXqcpdOcMbRXjEWYqRtWFgsBQGCb(bool P_0, bool P_1)
		{
		}

		private bool CaQjRIyFeGifnfpNsppSXvnBcpzo()
		{
			return false;
		}

		private void INwDgTcjRJhaRDZhFMUCkMFDOPNsb()
		{
		}

		private void hglCsrIBOMheHfVQdYkhhXZRzOHp(TouchInteractable.InteractionState P_0, bool P_1)
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

		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args)
		{
		}

		public void OnVisibilityChanged(bool state)
		{
		}
	}
}
