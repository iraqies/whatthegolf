using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200006E")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200006F")]
		public enum AxisOption
		{
			[Token(Token = "0x40001CB")]
			Both = 0,
			[Token(Token = "0x40001CC")]
			OnlyHorizontal = 1,
			[Token(Token = "0x40001CD")]
			OnlyVertical = 2
		}

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x13A7820", Offset = "0x13A7820", VA = "0x13A7820")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x13A7968", Offset = "0x13A7968", VA = "0x13A7968")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x13A79A4", Offset = "0x13A79A4", VA = "0x13A79A4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x13A7824", Offset = "0x13A7824", VA = "0x13A7824")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x13A7A10", Offset = "0x13A7A10", VA = "0x13A7A10", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x13A7B80", Offset = "0x13A7B80", VA = "0x13A7B80", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x13A7C14", Offset = "0x13A7C14", VA = "0x13A7C14", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x13A7C18", Offset = "0x13A7C18", VA = "0x13A7C18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x13A7C78", Offset = "0x13A7C78", VA = "0x13A7C78")]
		public Joystick()
		{
		}
	}
}
