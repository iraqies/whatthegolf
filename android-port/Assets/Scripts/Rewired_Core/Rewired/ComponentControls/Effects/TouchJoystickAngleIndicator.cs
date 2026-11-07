using Il2CppDummyDll;
using Rewired.UI;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[Token(Token = "0x200030E")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x191D34", Offset = "0x191D34")]
	[Attribute(Name = "RequireComponent", RVA = "0x191D34", Offset = "0x191D34")]
	public sealed class TouchJoystickAngleIndicator : MonoBehaviour, TouchJoystick.IStickPositionChangedHandler, IVisibilityChangedHandler
	{
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _visible;

		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _targetAngleFromRotation;

		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194BCC", Offset = "0x194BCC")]
		[SerializeField]
		private float _targetAngle;

		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _fadeWithValue;

		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _fadeWithAngle;

		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194C30", Offset = "0x194C30")]
		[SerializeField]
		private float _fadeRange;

		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _activeColor;

		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _normalColor;

		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x48")]
		private Image xSSmRGYJjzzTnLfidiIkYrQAcdKEA;

		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform QDYYpoeyByWqXkmYyeqJcfBaSimc;

		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 kvOHmnbCowVtSYAttNsuKXfrBeJl;

		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x60")]
		private bool WKLCOIhVKGKJSYhEOFPFfPADIEsLA;

		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x68")]
		private IRegistrar<TouchJoystickAngleIndicator> riiiBNuTETGdwiEWHZGOTWgEFAMW;

		[Token(Token = "0x1700063B")]
		public bool visible
		{
			[Token(Token = "0x6001768")]
			[Address(RVA = "0x242E564", Offset = "0x242E564", VA = "0x242E564")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001769")]
			[Address(RVA = "0x242E56C", Offset = "0x242E56C", VA = "0x242E56C")]
			set
			{
			}
		}

		[Token(Token = "0x1700063C")]
		public bool targetAngleFromRotation
		{
			[Token(Token = "0x600176A")]
			[Address(RVA = "0x242E68C", Offset = "0x242E68C", VA = "0x242E68C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600176B")]
			[Address(RVA = "0x242E694", Offset = "0x242E694", VA = "0x242E694")]
			set
			{
			}
		}

		[Token(Token = "0x1700063D")]
		public float targetAngle
		{
			[Token(Token = "0x600176C")]
			[Address(RVA = "0x242E6A8", Offset = "0x242E6A8", VA = "0x242E6A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600176D")]
			[Address(RVA = "0x242E6E8", Offset = "0x242E6E8", VA = "0x242E6E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700063E")]
		public bool fadeWithValue
		{
			[Token(Token = "0x600176E")]
			[Address(RVA = "0x242E700", Offset = "0x242E700", VA = "0x242E700")]
			get
			{
				return default;
			}
			[Token(Token = "0x600176F")]
			[Address(RVA = "0x242E708", Offset = "0x242E708", VA = "0x242E708")]
			set
			{
			}
		}

		[Token(Token = "0x1700063F")]
		public bool fadeWithAngle
		{
			[Token(Token = "0x6001770")]
			[Address(RVA = "0x242E71C", Offset = "0x242E71C", VA = "0x242E71C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001771")]
			[Address(RVA = "0x242E724", Offset = "0x242E724", VA = "0x242E724")]
			set
			{
			}
		}

		[Token(Token = "0x17000640")]
		public float fadeRange
		{
			[Token(Token = "0x6001772")]
			[Address(RVA = "0x242E738", Offset = "0x242E738", VA = "0x242E738")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001773")]
			[Address(RVA = "0x242E740", Offset = "0x242E740", VA = "0x242E740")]
			set
			{
			}
		}

		[Token(Token = "0x17000641")]
		public Color activeColor
		{
			[Token(Token = "0x6001774")]
			[Address(RVA = "0x242E758", Offset = "0x242E758", VA = "0x242E758")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001775")]
			[Address(RVA = "0x242E764", Offset = "0x242E764", VA = "0x242E764")]
			set
			{
			}
		}

		[Token(Token = "0x17000642")]
		public Color normalColor
		{
			[Token(Token = "0x6001776")]
			[Address(RVA = "0x242E770", Offset = "0x242E770", VA = "0x242E770")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001777")]
			[Address(RVA = "0x242E77C", Offset = "0x242E77C", VA = "0x242E77C")]
			set
			{
			}
		}

		[Token(Token = "0x17000643")]
		internal Image AnFrappGeuvMAKfZPbOgepDZqzOu
		{
			[Token(Token = "0x6001778")]
			[Address(RVA = "0x242E788", Offset = "0x242E788", VA = "0x242E788")]
			get
			{
				return trfJpcALrJXcZNxujKYadHGkSGom();
			}
		}

		[Token(Token = "0x17000644")]
		internal Sprite NQaCBBkZNqrlljgZNmxaaJmozkHxA
		{
			[Token(Token = "0x6001779")]
			[Address(RVA = "0x242E7E4", Offset = "0x242E7E4", VA = "0x242E7E4")]
			get
			{
				return vaLvOGxPwaiwMQNrQnfROcYsHWZt();
			}
		}

		[Token(Token = "0x17000645")]
		internal RectTransform dHBtGVwmKSUQYlNEBqhwMLJxhsUgA
		{
			[Token(Token = "0x600177A")]
			[Address(RVA = "0x242E91C", Offset = "0x242E91C", VA = "0x242E91C")]
			get
			{
				return UQQILlGuuskLnOkXMjNkJJUXcqqP();
			}
		}

		[Token(Token = "0x6001778")]
		[Address(RVA = "0x242E788", Offset = "0x242E788", VA = "0x242E788")]
		internal Image trfJpcALrJXcZNxujKYadHGkSGom()
		{
			return null;
		}

		[Token(Token = "0x6001779")]
		[Address(RVA = "0x242E7E4", Offset = "0x242E7E4", VA = "0x242E7E4")]
		internal Sprite vaLvOGxPwaiwMQNrQnfROcYsHWZt()
		{
			return null;
		}

		[Token(Token = "0x600177A")]
		[Address(RVA = "0x242E91C", Offset = "0x242E91C", VA = "0x242E91C")]
		internal RectTransform UQQILlGuuskLnOkXMjNkJJUXcqqP()
		{
			return null;
		}

		[Token(Token = "0x600177B")]
		[Address(RVA = "0x242E978", Offset = "0x242E978", VA = "0x242E978")]
		private TouchJoystickAngleIndicator()
		{
		}

		[Token(Token = "0x600177C")]
		[Address(RVA = "0x242EA14", Offset = "0x242EA14", VA = "0x242EA14")]
		internal bool qGAjaUBiEqcaBXNmBhvHvwJEdCCg(out Vector2 P_0)
		{
			return default;
		}

		[Token(Token = "0x600177D")]
		[Address(RVA = "0x242EB88", Offset = "0x242EB88", VA = "0x242EB88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600177E")]
		[Address(RVA = "0x242ECBC", Offset = "0x242ECBC", VA = "0x242ECBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600177F")]
		[Address(RVA = "0x242F1E8", Offset = "0x242F1E8", VA = "0x242F1E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6001780")]
		[Address(RVA = "0x242F2C8", Offset = "0x242F2C8", VA = "0x242F2C8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6001781")]
		[Address(RVA = "0x242F328", Offset = "0x242F328", VA = "0x242F328")]
		private void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6001782")]
		[Address(RVA = "0x242E584", Offset = "0x242E584", VA = "0x242E584")]
		private void nnXqcpdOcMbRXjEWYqRtWFgsBQGCb(bool P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001783")]
		[Address(RVA = "0x242EE38", Offset = "0x242EE38", VA = "0x242EE38")]
		private void pZzjNtjoEFhrCKbZMkXpacmYGzEhA(Vector2 P_0)
		{
		}

		[Token(Token = "0x6001784")]
		[Address(RVA = "0x242ECB0", Offset = "0x242ECB0", VA = "0x242ECB0")]
		private void ZOHvREfiEGuSoZkpvCoiaVVliwbJ()
		{
		}

		[Token(Token = "0x6001785")]
		[Address(RVA = "0x242F308", Offset = "0x242F308", VA = "0x242F308")]
		private void ZESmGDtKgyfxEWszxkXiDLpKTdRJ()
		{
		}

		[Token(Token = "0x6001786")]
		[Address(RVA = "0x242E688", Offset = "0x242E688", VA = "0x242E688")]
		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x6001787")]
		[Address(RVA = "0x242ECFC", Offset = "0x242ECFC", VA = "0x242ECFC")]
		private void TNsFHmCGSRxKxAgWYaxXYcDGUIxvA()
		{
		}

		[Token(Token = "0x6001788")]
		[Address(RVA = "0x242F1EC", Offset = "0x242F1EC", VA = "0x242F1EC")]
		private void gGrGtoyINBNDSswRwWaVZCwMHTpC()
		{
		}

		[Token(Token = "0x6001789")]
		[Address(RVA = "0x242F32C", Offset = "0x242F32C", VA = "0x242F32C", Slot = "5")]
		public void OnVisibilityChanged(bool state)
		{
		}

		[Token(Token = "0x600178A")]
		[Address(RVA = "0x242EBBC", Offset = "0x242EBBC", VA = "0x242EBBC")]
		public void OnTouchJoystickStickPositionChanged(Vector2 value)
		{
		}

		[Token(Token = "0x600178B")]
		[Address(RVA = "0x242F334", Offset = "0x242F334", VA = "0x242F334", Slot = "4")]
		private void Rewired_002EComponentControls_002ETouchJoystick_002EIStickPositionChangedHandler_002EOnStickPositionChanged(Vector2 value)
		{
		}
	}
}
