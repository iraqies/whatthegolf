using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000075")]
	[Attribute(Name = "RequireComponent", RVA = "0x332DC", Offset = "0x332DC")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000076")]
		public enum AxisOption
		{
			[Token(Token = "0x40001ED")]
			Both = 0,
			[Token(Token = "0x40001EE")]
			OnlyHorizontal = 1,
			[Token(Token = "0x40001EF")]
			OnlyVertical = 2
		}

		[Token(Token = "0x2000077")]
		public enum ControlStyle
		{
			[Token(Token = "0x40001F1")]
			Absolute = 0,
			[Token(Token = "0x40001F2")]
			Relative = 1,
			[Token(Token = "0x40001F3")]
			Swipe = 2
		}

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x38")]
		private bool m_UseX;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x39")]
		private bool m_UseY;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Dragging;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x54")]
		private int m_Id;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_PreviousTouchPos;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 m_Center;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x70")]
		private Image m_Image;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x132284C", Offset = "0x132284C", VA = "0x132284C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1322994", Offset = "0x1322994", VA = "0x1322994")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1322850", Offset = "0x1322850", VA = "0x1322850")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1322A14", Offset = "0x1322A14", VA = "0x1322A14")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1322A8C", Offset = "0x1322A8C", VA = "0x1322A8C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1322AC8", Offset = "0x1322AC8", VA = "0x1322AC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1322C64", Offset = "0x1322C64", VA = "0x1322C64", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1322CF0", Offset = "0x1322CF0", VA = "0x1322CF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1322E10", Offset = "0x1322E10", VA = "0x1322E10")]
		public TouchPad()
		{
		}
	}
}
