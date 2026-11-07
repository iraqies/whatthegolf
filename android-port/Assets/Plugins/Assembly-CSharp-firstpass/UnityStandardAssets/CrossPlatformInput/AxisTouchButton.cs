using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000068")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12F4FAC", Offset = "0x12F4FAC", VA = "0x12F4FAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x12F50B8", Offset = "0x12F50B8", VA = "0x12F50B8")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x12F5268", Offset = "0x12F5268", VA = "0x12F5268")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x12F5284", Offset = "0x12F5284", VA = "0x12F5284", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x12F5354", Offset = "0x12F5354", VA = "0x12F5354", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x12F53A8", Offset = "0x12F53A8", VA = "0x12F53A8")]
		public AxisTouchButton()
		{
		}
	}
}
