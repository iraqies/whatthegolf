using System;
using System.Collections.Generic;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	public sealed class PlayerMouse : PlayerController, IPlayerController, IMouseInputSource
	{
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2>
		{
		}

		[SerializeField]
		private bool _defaultToCenter;

		[SerializeField]
		private float _pointerSpeed;

		[SerializeField]
		private bool _useHardwarePointerPosition;

		[SerializeField]
		private bool _clampToMovementArea;

		[SerializeField]
		private Rect _movementArea;

		[SerializeField]
		private Rewired.PlayerMouse.MovementAreaUnit _movementAreaUnit;

		[SerializeField]
		private ScreenPositionChangedHandler _onScreenPositionChanged;

		private new Rewired.PlayerMouse rmMLNGpqXVBSkkjZadentyrvdrgtA => MVmNVaAnZpWvkMHvvuWxKjqAiYHg();

		public bool defaultToCenter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool clampToMovementArea
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ScreenRect movementArea
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Rewired.PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			get
			{
				return Rewired.PlayerMouse.MovementAreaUnit.Screen;
			}
			set
			{
			}
		}

		public Vector2 screenPosition
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 screenPositionPrev => default;

		public Vector2 screenPositionDelta => default;

		public Rewired.PlayerController.MouseAxis xAxis => null;

		public Rewired.PlayerController.MouseAxis yAxis => null;

		public Rewired.PlayerController.MouseWheel wheel => null;

		public Rewired.PlayerController.Button leftButton => null;

		public Rewired.PlayerController.Button rightButton => null;

		public Rewired.PlayerController.Button middleButton => null;

		public float pointerSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useHardwarePointerPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool IMouseInputSource.enabled => false;

		Vector2 IMouseInputSource.screenPosition => default;

		Vector2 IMouseInputSource.screenPositionDelta => default;

		Vector2 IMouseInputSource.wheelDelta => default;

		bool IMouseInputSource.locked => false;

		bool IPlayerController.enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<Vector2> ScreenPositionChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private Rewired.PlayerMouse MVmNVaAnZpWvkMHvvuWxKjqAiYHg()
		{
			return null;
		}

		protected override void OnValidated()
		{
		}

		protected override void OnReset()
		{
		}

		protected override Rewired.PlayerController CreateSource(object args)
		{
			return null;
		}

		protected override void Deinitialize()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		internal override List<ElementInfo> JSZQIzdJrIgpNZMUgvzpsvgYGBNt()
		{
			return null;
		}

		private void ANgikIdwhGPHaecgsDERWPOVuXJs(Vector2 P_0)
		{
		}

		bool IMouseInputSource.GetButtonDown(int button)
		{
			return false;
		}

		bool IMouseInputSource.GetButtonUp(int button)
		{
			return false;
		}

		bool IMouseInputSource.GetButton(int button)
		{
			return false;
		}
	}
}
