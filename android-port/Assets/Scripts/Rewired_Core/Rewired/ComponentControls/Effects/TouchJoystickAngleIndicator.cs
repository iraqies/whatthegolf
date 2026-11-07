using Rewired.UI;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public sealed class TouchJoystickAngleIndicator : MonoBehaviour, TouchJoystick.IStickPositionChangedHandler, IVisibilityChangedHandler
	{
		[SerializeField]
		private bool _visible;

		[SerializeField]
		private bool _targetAngleFromRotation;

		[SerializeField]
		private float _targetAngle;

		[SerializeField]
		private bool _fadeWithValue;

		[SerializeField]
		private bool _fadeWithAngle;

		[SerializeField]
		private float _fadeRange;

		[SerializeField]
		private Color _activeColor;

		[SerializeField]
		private Color _normalColor;

		private Image xSSmRGYJjzzTnLfidiIkYrQAcdKEA;

		private RectTransform QDYYpoeyByWqXkmYyeqJcfBaSimc;

		private Vector2 kvOHmnbCowVtSYAttNsuKXfrBeJl;

		private bool WKLCOIhVKGKJSYhEOFPFfPADIEsLA;

		private IRegistrar<TouchJoystickAngleIndicator> riiiBNuTETGdwiEWHZGOTWgEFAMW;

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

		public bool targetAngleFromRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float targetAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool fadeWithValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool fadeWithAngle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fadeRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color activeColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Color normalColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		internal Image AnFrappGeuvMAKfZPbOgepDZqzOu => trfJpcALrJXcZNxujKYadHGkSGom();

		internal Sprite NQaCBBkZNqrlljgZNmxaaJmozkHxA => vaLvOGxPwaiwMQNrQnfROcYsHWZt();

		internal RectTransform dHBtGVwmKSUQYlNEBqhwMLJxhsUgA => UQQILlGuuskLnOkXMjNkJJUXcqqP();

		internal Image trfJpcALrJXcZNxujKYadHGkSGom()
		{
			return null;
		}

		internal Sprite vaLvOGxPwaiwMQNrQnfROcYsHWZt()
		{
			return null;
		}

		internal RectTransform UQQILlGuuskLnOkXMjNkJJUXcqqP()
		{
			return null;
		}

		private TouchJoystickAngleIndicator()
		{
		}

		internal bool qGAjaUBiEqcaBXNmBhvHvwJEdCCg(out Vector2 P_0)
		{
			P_0 = default;
			return false;
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

		private void OnTransformParentChanged()
		{
		}

		private void nnXqcpdOcMbRXjEWYqRtWFgsBQGCb(bool P_0, bool P_1)
		{
		}

		private void pZzjNtjoEFhrCKbZMkXpacmYGzEhA(Vector2 P_0)
		{
		}

		private void ZOHvREfiEGuSoZkpvCoiaVVliwbJ()
		{
		}

		private void ZESmGDtKgyfxEWszxkXiDLpKTdRJ()
		{
		}

		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		private void TNsFHmCGSRxKxAgWYaxXYcDGUIxvA()
		{
		}

		private void gGrGtoyINBNDSswRwWaVZCwMHTpC()
		{
		}

		public void OnVisibilityChanged(bool state)
		{
		}

		public void OnTouchJoystickStickPositionChanged(Vector2 value)
		{
		}

		void TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 value)
		{
		}
	}
}
