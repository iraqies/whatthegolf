using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000A6")]
	public abstract class PointerInputModule : BaseInputModule
	{
		[Token(Token = "0x20000A7")]
		protected class ButtonState
		{
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			private PointerEventData.InputButton m_Button;

			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x18")]
			private MouseButtonEventData m_EventData;

			[Token(Token = "0x170001A6")]
			public MouseButtonEventData eventData
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x2C468EC", Offset = "0x2C468EC", VA = "0x2C468EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x2C468F4", Offset = "0x2C468F4", VA = "0x2C468F4")]
				set
				{
				}
			}

			[Token(Token = "0x170001A7")]
			public PointerEventData.InputButton button
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x2C468FC", Offset = "0x2C468FC", VA = "0x2C468FC")]
				get
				{
					return default;
				}
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x2C46904", Offset = "0x2C46904", VA = "0x2C46904")]
				set
				{
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x2C4690C", Offset = "0x2C4690C", VA = "0x2C4690C")]
			public ButtonState()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		protected class MouseState
		{
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x10")]
			private List<ButtonState> m_TrackedButtons;

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x2C46940", Offset = "0x2C46940", VA = "0x2C46940")]
			public ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				return null;
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x2C46AC0", Offset = "0x2C46AC0", VA = "0x2C46AC0")]
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x2C46AFC", Offset = "0x2C46AFC", VA = "0x2C46AFC")]
			public MouseState()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		public class MouseButtonEventData
		{
			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x18")]
			public PointerEventData buttonData;

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x2C46914", Offset = "0x2C46914", VA = "0x2C46914")]
			public bool PressedThisFrame()
			{
				return default;
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x2C46924", Offset = "0x2C46924", VA = "0x2C46924")]
			public bool ReleasedThisFrame()
			{
				return default;
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x2C46938", Offset = "0x2C46938", VA = "0x2C46938")]
			public MouseButtonEventData()
			{
			}
		}

		[Token(Token = "0x40002BF")]
		public const int kMouseLeftId = -1;

		[Token(Token = "0x40002C0")]
		public const int kMouseRightId = -2;

		[Token(Token = "0x40002C1")]
		public const int kMouseMiddleId = -3;

		[Token(Token = "0x40002C2")]
		public const int kFakeTouchesId = -4;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x48")]
		protected Dictionary<int, PointerEventData> m_PointerData;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x50")]
		private readonly MouseState m_MouseState;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2C2CE64", Offset = "0x2C2CE64", VA = "0x2C2CE64")]
		protected bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			return default;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2C2CF58", Offset = "0x2C2CF58", VA = "0x2C2CF58")]
		protected void RemovePointerData(PointerEventData data)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2C2CFC0", Offset = "0x2C2CFC0", VA = "0x2C2CFC0")]
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2C2D1F0", Offset = "0x2C2D1F0", VA = "0x2C2D1F0")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2C2D25C", Offset = "0x2C2D25C", VA = "0x2C2D25C")]
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			return default;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2C2D2EC", Offset = "0x2C2D2EC", VA = "0x2C2D2EC", Slot = "26")]
		protected virtual MouseState GetMousePointerEventData()
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2C2D300", Offset = "0x2C2D300", VA = "0x2C2D300", Slot = "27")]
		protected virtual MouseState GetMousePointerEventData(int id)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2C2D794", Offset = "0x2C2D794", VA = "0x2C2D794")]
		protected PointerEventData GetLastPointerEventData(int id)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x2C2D828", Offset = "0x2C2D828", VA = "0x2C2D828")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2C2D880", Offset = "0x2C2D880", VA = "0x2C2D880", Slot = "28")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2C2D8CC", Offset = "0x2C2D8CC", VA = "0x2C2D8CC", Slot = "29")]
		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2C2DC70", Offset = "0x2C2DC70", VA = "0x2C2DC70", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerId)
		{
			return default;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2C2DD6C", Offset = "0x2C2DD6C", VA = "0x2C2DD6C")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2C2DF38", Offset = "0x2C2DF38", VA = "0x2C2DF38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2C2E1AC", Offset = "0x2C2E1AC", VA = "0x2C2E1AC")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2C2E2C4", Offset = "0x2C2E2C4", VA = "0x2C2E2C4")]
		protected PointerInputModule()
		{
		}
	}
}
