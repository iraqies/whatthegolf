using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001160")]
	public class CustomControllerDemo : MonoBehaviour
	{
		[Token(Token = "0x4005BD4")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005BD5")]
		[FieldOffset(Offset = "0x20")]
		public string controllerTag;

		[Token(Token = "0x4005BD6")]
		[FieldOffset(Offset = "0x28")]
		public bool useUpdateCallbacks;

		[Token(Token = "0x4005BD7")]
		[FieldOffset(Offset = "0x2C")]
		private int buttonCount;

		[Token(Token = "0x4005BD8")]
		[FieldOffset(Offset = "0x30")]
		private int axisCount;

		[Token(Token = "0x4005BD9")]
		[FieldOffset(Offset = "0x38")]
		private float[] axisValues;

		[Token(Token = "0x4005BDA")]
		[FieldOffset(Offset = "0x40")]
		private bool[] buttonValues;

		[Token(Token = "0x4005BDB")]
		[FieldOffset(Offset = "0x48")]
		private TouchJoystickExample[] joysticks;

		[Token(Token = "0x4005BDC")]
		[FieldOffset(Offset = "0x50")]
		private TouchButtonExample[] buttons;

		[Token(Token = "0x4005BDD")]
		[FieldOffset(Offset = "0x58")]
		private CustomController controller;

		[NonSerialized]
		[Token(Token = "0x4005BDE")]
		[FieldOffset(Offset = "0x60")]
		private bool initialized;

		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x18C628C", Offset = "0x18C628C", VA = "0x18C628C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x18C62D8", Offset = "0x18C62D8", VA = "0x18C62D8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x18C6680", Offset = "0x18C6680", VA = "0x18C6680")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x18C674C", Offset = "0x18C674C", VA = "0x18C674C")]
		private void OnInputSourceUpdate()
		{
		}

		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x18C6794", Offset = "0x18C6794", VA = "0x18C6794")]
		private void GetSourceAxisValues()
		{
		}

		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x18C684C", Offset = "0x18C684C", VA = "0x18C684C")]
		private void GetSourceButtonValues()
		{
		}

		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x18C68C8", Offset = "0x18C68C8", VA = "0x18C68C8")]
		private void SetControllerAxisValues()
		{
		}

		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x18C693C", Offset = "0x18C693C", VA = "0x18C693C")]
		private void SetControllerButtonValues()
		{
		}

		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x18C69B0", Offset = "0x18C69B0", VA = "0x18C69B0")]
		private float GetAxisValueCallback(int index)
		{
			return default;
		}

		[Token(Token = "0x6004F4E")]
		[Address(RVA = "0x18C69F4", Offset = "0x18C69F4", VA = "0x18C69F4")]
		private bool GetButtonValueCallback(int index)
		{
			return default;
		}

		[Token(Token = "0x6004F4F")]
		[Address(RVA = "0x18C6A40", Offset = "0x18C6A40", VA = "0x18C6A40")]
		public CustomControllerDemo()
		{
		}
	}
}
