using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	[Token(Token = "0x200030F")]
	[Attribute(Name = "RequireComponent", RVA = "0x191DF0", Offset = "0x191DF0")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public sealed class TouchJoystickRadialIndicator : MonoBehaviour, IRegistrar<TouchJoystickAngleIndicator>
	{
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x18")]
		public bool _scale;

		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x19")]
		public bool _preserveSpriteAspectRatio;

		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194C94", Offset = "0x194C94")]
		public float _scaleRatio;

		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194CB4", Offset = "0x194CB4")]
		public float _aspectRatioX;

		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194CD4", Offset = "0x194CD4")]
		public float _aspectRatioY;

		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x28")]
		public float _offset;

		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 OnJDFwaKnemQlOFCZcAnSvELCgXdA;

		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform QDYYpoeyByWqXkmYyeqJcfBaSimc;

		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x38")]
		private List<TouchJoystickAngleIndicator> QWZEhyhoBmPNRfpHipsHYaaZolwo;

		[Token(Token = "0x17000646")]
		public bool scale
		{
			[Token(Token = "0x600178C")]
			[Address(RVA = "0x242F338", Offset = "0x242F338", VA = "0x242F338")]
			get
			{
				return default;
			}
			[Token(Token = "0x600178D")]
			[Address(RVA = "0x242F340", Offset = "0x242F340", VA = "0x242F340")]
			set
			{
			}
		}

		[Token(Token = "0x17000647")]
		public bool preserveSpriteAspectRatio
		{
			[Token(Token = "0x600178E")]
			[Address(RVA = "0x242F35C", Offset = "0x242F35C", VA = "0x242F35C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600178F")]
			[Address(RVA = "0x242F364", Offset = "0x242F364", VA = "0x242F364")]
			set
			{
			}
		}

		[Token(Token = "0x17000648")]
		public float scaleRatio
		{
			[Token(Token = "0x6001790")]
			[Address(RVA = "0x242F37C", Offset = "0x242F37C", VA = "0x242F37C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001791")]
			[Address(RVA = "0x242F384", Offset = "0x242F384", VA = "0x242F384")]
			set
			{
			}
		}

		[Token(Token = "0x17000649")]
		public float aspectRatioX
		{
			[Token(Token = "0x6001792")]
			[Address(RVA = "0x242F3D8", Offset = "0x242F3D8", VA = "0x242F3D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001793")]
			[Address(RVA = "0x242F3E0", Offset = "0x242F3E0", VA = "0x242F3E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700064A")]
		public float aspectRatioY
		{
			[Token(Token = "0x6001794")]
			[Address(RVA = "0x242F434", Offset = "0x242F434", VA = "0x242F434")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x242F43C", Offset = "0x242F43C", VA = "0x242F43C")]
			set
			{
			}
		}

		[Token(Token = "0x1700064B")]
		public float offset
		{
			[Token(Token = "0x6001796")]
			[Address(RVA = "0x242F490", Offset = "0x242F490", VA = "0x242F490")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001797")]
			[Address(RVA = "0x242F498", Offset = "0x242F498", VA = "0x242F498")]
			set
			{
			}
		}

		[Token(Token = "0x1700064C")]
		private RectTransform dHBtGVwmKSUQYlNEBqhwMLJxhsUgA
		{
			[Token(Token = "0x6001798")]
			[Address(RVA = "0x242F4B0", Offset = "0x242F4B0", VA = "0x242F4B0")]
			get
			{
				return UQQILlGuuskLnOkXMjNkJJUXcqqP();
			}
		}

		[Token(Token = "0x6001798")]
		[Address(RVA = "0x242F4B0", Offset = "0x242F4B0", VA = "0x242F4B0")]
		private RectTransform UQQILlGuuskLnOkXMjNkJJUXcqqP()
		{
			return null;
		}

		[Token(Token = "0x6001799")]
		[Address(RVA = "0x242F50C", Offset = "0x242F50C", VA = "0x242F50C", Slot = "4")]
		private void Rewired_002EUtils_002EInterfaces_002EIRegistrar_003CRewired_002EComponentControls_002EEffects_002ETouchJoystickAngleIndicator_003E_002ERegister(TouchJoystickAngleIndicator registrant)
		{
		}

		[Token(Token = "0x600179A")]
		[Address(RVA = "0x242F9F8", Offset = "0x242F9F8", VA = "0x242F9F8", Slot = "5")]
		private void Rewired_002EUtils_002EInterfaces_002EIRegistrar_003CRewired_002EComponentControls_002EEffects_002ETouchJoystickAngleIndicator_003E_002EDeregister(TouchJoystickAngleIndicator registrant)
		{
		}

		[Token(Token = "0x600179B")]
		[Address(RVA = "0x242FAAC", Offset = "0x242FAAC", VA = "0x242FAAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600179C")]
		[Address(RVA = "0x242FBA8", Offset = "0x242FBA8", VA = "0x242FBA8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600179D")]
		[Address(RVA = "0x242FD38", Offset = "0x242FD38", VA = "0x242FD38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600179E")]
		[Address(RVA = "0x242FD3C", Offset = "0x242FD3C", VA = "0x242FD3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600179F")]
		[Address(RVA = "0x242FAB0", Offset = "0x242FAB0", VA = "0x242FAB0")]
		private void bGfIPFdtEnYcjjOWbUoyqbgJbTnS()
		{
		}

		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x242F5D8", Offset = "0x242F5D8", VA = "0x242F5D8")]
		private void pZzjNtjoEFhrCKbZMkXpacmYGzEhA(TouchJoystickAngleIndicator P_0)
		{
		}

		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x242F358", Offset = "0x242F358", VA = "0x242F358")]
		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x242FBE8", Offset = "0x242FBE8", VA = "0x242FBE8")]
		private void CmxxlkWPkryMeJQQeGDoblonfvJab()
		{
		}

		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x242FECC", Offset = "0x242FECC", VA = "0x242FECC")]
		public TouchJoystickRadialIndicator()
		{
		}
	}
}
