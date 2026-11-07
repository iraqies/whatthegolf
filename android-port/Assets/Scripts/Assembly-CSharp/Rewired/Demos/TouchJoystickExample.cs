using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	[Token(Token = "0x2001163")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x47E04", Offset = "0x47E04")]
	public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x4005BE7")]
		[FieldOffset(Offset = "0x18")]
		public bool allowMouseControl;

		[Token(Token = "0x4005BE8")]
		[FieldOffset(Offset = "0x1C")]
		public int radius;

		[Token(Token = "0x4005BE9")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 origAnchoredPosition;

		[Token(Token = "0x4005BEA")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 origWorldPosition;

		[Token(Token = "0x4005BEB")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 origScreenResolution;

		[Token(Token = "0x4005BEC")]
		[FieldOffset(Offset = "0x3C")]
		private ScreenOrientation origScreenOrientation;

		[NonSerialized]
		[Token(Token = "0x4005BED")]
		[FieldOffset(Offset = "0x40")]
		private bool hasFinger;

		[NonSerialized]
		[Token(Token = "0x4005BEE")]
		[FieldOffset(Offset = "0x44")]
		private int lastFingerId;

		[Token(Token = "0x4005BEF")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x571EC", Offset = "0x571EC")]
		private Vector2 position__BackingField;

		[Token(Token = "0x1700088C")]
		public Vector2 position
		{
			[Token(Token = "0x6004F5C")]
			[Address(RVA = "0x171EF1C", Offset = "0x171EF1C", VA = "0x171EF1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x700A8", Offset = "0x700A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004F5D")]
			[Address(RVA = "0x171EF24", Offset = "0x171EF24", VA = "0x171EF24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x700B8", Offset = "0x700B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x171EF2C", Offset = "0x171EF2C", VA = "0x171EF2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0x171F020", Offset = "0x171F020", VA = "0x171F020")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F60")]
		[Address(RVA = "0x171F098", Offset = "0x171F098", VA = "0x171F098")]
		private void Restart()
		{
		}

		[Token(Token = "0x6004F61")]
		[Address(RVA = "0x171EF60", Offset = "0x171EF60", VA = "0x171EF60")]
		private void StoreOrigValues()
		{
		}

		[Token(Token = "0x6004F62")]
		[Address(RVA = "0x171F11C", Offset = "0x171F11C", VA = "0x171F11C")]
		private void UpdateValue(Vector3 value)
		{
		}

		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x171F148", Offset = "0x171F148", VA = "0x171F148", Slot = "4")]
		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F64")]
		[Address(RVA = "0x171F19C", Offset = "0x171F19C", VA = "0x171F19C", Slot = "5")]
		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F65")]
		[Address(RVA = "0x171F1D4", Offset = "0x171F1D4", VA = "0x171F1D4", Slot = "6")]
		private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F66")]
		[Address(RVA = "0x171F190", Offset = "0x171F190", VA = "0x171F190")]
		private static bool IsMousePointerId(int id)
		{
			return default;
		}

		[Token(Token = "0x6004F67")]
		[Address(RVA = "0x171F2C0", Offset = "0x171F2C0", VA = "0x171F2C0")]
		public TouchJoystickExample()
		{
		}
	}
}
