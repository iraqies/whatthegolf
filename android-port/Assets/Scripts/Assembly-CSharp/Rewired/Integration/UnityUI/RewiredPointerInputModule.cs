using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Token(Token = "0x200114A")]
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		[Token(Token = "0x200114B")]
		protected class MouseState
		{
			[Token(Token = "0x4005B4A")]
			[FieldOffset(Offset = "0x10")]
			private List<ButtonState> m_TrackedButtons;

			[Token(Token = "0x6004E4D")]
			[Address(RVA = "0x1834AC8", Offset = "0x1834AC8", VA = "0x1834AC8")]
			public ButtonState GetButtonState(int button)
			{
				return null;
			}

			[Token(Token = "0x6004E4E")]
			[Address(RVA = "0x1834C38", Offset = "0x1834C38", VA = "0x1834C38")]
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
			}

			[Token(Token = "0x6004E4F")]
			[Address(RVA = "0x1834C74", Offset = "0x1834C74", VA = "0x1834C74")]
			public MouseState()
			{
			}
		}

		[Token(Token = "0x200114C")]
		public class MouseButtonEventData
		{
			[Token(Token = "0x4005B4B")]
			[FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			[Token(Token = "0x4005B4C")]
			[FieldOffset(Offset = "0x18")]
			public PlayerPointerEventData buttonData;

			[Token(Token = "0x6004E50")]
			[Address(RVA = "0x1834A9C", Offset = "0x1834A9C", VA = "0x1834A9C")]
			public bool PressedThisFrame()
			{
				return default;
			}

			[Token(Token = "0x6004E51")]
			[Address(RVA = "0x1834AAC", Offset = "0x1834AAC", VA = "0x1834AAC")]
			public bool ReleasedThisFrame()
			{
				return default;
			}

			[Token(Token = "0x6004E52")]
			[Address(RVA = "0x1834AC0", Offset = "0x1834AC0", VA = "0x1834AC0")]
			public MouseButtonEventData()
			{
			}
		}

		[Token(Token = "0x200114D")]
		protected class ButtonState
		{
			[Token(Token = "0x4005B4D")]
			[FieldOffset(Offset = "0x10")]
			private int m_Button;

			[Token(Token = "0x4005B4E")]
			[FieldOffset(Offset = "0x18")]
			private MouseButtonEventData m_EventData;

			[Token(Token = "0x1700084E")]
			public MouseButtonEventData eventData
			{
				[Token(Token = "0x6004E53")]
				[Address(RVA = "0x1834A74", Offset = "0x1834A74", VA = "0x1834A74")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004E54")]
				[Address(RVA = "0x1834A7C", Offset = "0x1834A7C", VA = "0x1834A7C")]
				set
				{
				}
			}

			[Token(Token = "0x1700084F")]
			public int button
			{
				[Token(Token = "0x6004E55")]
				[Address(RVA = "0x1834A84", Offset = "0x1834A84", VA = "0x1834A84")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004E56")]
				[Address(RVA = "0x1834A8C", Offset = "0x1834A8C", VA = "0x1834A8C")]
				set
				{
				}
			}

			[Token(Token = "0x6004E57")]
			[Address(RVA = "0x1834A94", Offset = "0x1834A94", VA = "0x1834A94")]
			public ButtonState()
			{
			}
		}

		[Token(Token = "0x200114E")]
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			[Token(Token = "0x4005B4F")]
			[FieldOffset(Offset = "0x10")]
			private Vector2 m_MousePosition;

			[Token(Token = "0x4005B50")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 m_MousePositionPrev;

			[Token(Token = "0x4005B51")]
			[FieldOffset(Offset = "0x20")]
			private int m_LastUpdatedFrame;

			[Token(Token = "0x17000850")]
			private int Rewired_002EUI_002EIMouseInputSource_002EplayerId
			{
				[Token(Token = "0x6004E58")]
				[Address(RVA = "0x1834CF4", Offset = "0x1834CF4", VA = "0x1834CF4", Slot = "4")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_playerId();
				}
			}

			[Token(Token = "0x17000851")]
			private bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
			{
				[Token(Token = "0x6004E59")]
				[Address(RVA = "0x1834D98", Offset = "0x1834D98", VA = "0x1834D98", Slot = "5")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_enabled();
				}
			}

			[Token(Token = "0x17000852")]
			private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
			{
				[Token(Token = "0x6004E5A")]
				[Address(RVA = "0x1834DEC", Offset = "0x1834DEC", VA = "0x1834DEC", Slot = "6")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_locked();
				}
			}

			[Token(Token = "0x17000853")]
			private int Rewired_002EUI_002EIMouseInputSource_002EbuttonCount
			{
				[Token(Token = "0x6004E5B")]
				[Address(RVA = "0x1834E4C", Offset = "0x1834E4C", VA = "0x1834E4C", Slot = "7")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_buttonCount();
				}
			}

			[Token(Token = "0x17000854")]
			private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
			{
				[Token(Token = "0x6004E5F")]
				[Address(RVA = "0x1834FB4", Offset = "0x1834FB4", VA = "0x1834FB4", Slot = "11")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_screenPosition();
				}
			}

			[Token(Token = "0x17000855")]
			private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
			{
				[Token(Token = "0x6004E60")]
				[Address(RVA = "0x1835008", Offset = "0x1835008", VA = "0x1835008", Slot = "12")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_screenPositionDelta();
				}
			}

			[Token(Token = "0x17000856")]
			private Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
			{
				[Token(Token = "0x6004E61")]
				[Address(RVA = "0x1835068", Offset = "0x1835068", VA = "0x1835068", Slot = "13")]
				get
				{
					return Rewired_002EUI_002EIMouseInputSource_002Eget_wheelDelta();
				}
			}

			[Token(Token = "0x17000857")]
			private bool Rewired_002EUI_002EITouchInputSource_002EtouchSupported
			{
				[Token(Token = "0x6004E62")]
				[Address(RVA = "0x18350BC", Offset = "0x18350BC", VA = "0x18350BC", Slot = "14")]
				get
				{
					return Rewired_002EUI_002EITouchInputSource_002Eget_touchSupported();
				}
			}

			[Token(Token = "0x17000858")]
			private int Rewired_002EUI_002EITouchInputSource_002EtouchCount
			{
				[Token(Token = "0x6004E63")]
				[Address(RVA = "0x1835110", Offset = "0x1835110", VA = "0x1835110", Slot = "15")]
				get
				{
					return Rewired_002EUI_002EITouchInputSource_002Eget_touchCount();
				}
			}

			[Token(Token = "0x6004E58")]
			[Address(RVA = "0x1834CF4", Offset = "0x1834CF4", VA = "0x1834CF4", Slot = "4")]
			private int Rewired_002EUI_002EIMouseInputSource_002Eget_playerId()
			{
				return default;
			}

			[Token(Token = "0x6004E59")]
			[Address(RVA = "0x1834D98", Offset = "0x1834D98", VA = "0x1834D98", Slot = "5")]
			private bool Rewired_002EUI_002EIMouseInputSource_002Eget_enabled()
			{
				return default;
			}

			[Token(Token = "0x6004E5A")]
			[Address(RVA = "0x1834DEC", Offset = "0x1834DEC", VA = "0x1834DEC", Slot = "6")]
			private bool Rewired_002EUI_002EIMouseInputSource_002Eget_locked()
			{
				return default;
			}

			[Token(Token = "0x6004E5B")]
			[Address(RVA = "0x1834E4C", Offset = "0x1834E4C", VA = "0x1834E4C", Slot = "7")]
			private int Rewired_002EUI_002EIMouseInputSource_002Eget_buttonCount()
			{
				return default;
			}

			[Token(Token = "0x6004E5C")]
			[Address(RVA = "0x1834EA0", Offset = "0x1834EA0", VA = "0x1834EA0", Slot = "8")]
			private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonDown(int button)
			{
				return default;
			}

			[Token(Token = "0x6004E5D")]
			[Address(RVA = "0x1834EFC", Offset = "0x1834EFC", VA = "0x1834EFC", Slot = "9")]
			private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
			{
				return default;
			}

			[Token(Token = "0x6004E5E")]
			[Address(RVA = "0x1834F58", Offset = "0x1834F58", VA = "0x1834F58", Slot = "10")]
			private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
			{
				return default;
			}

			[Token(Token = "0x6004E5F")]
			[Address(RVA = "0x1834FB4", Offset = "0x1834FB4", VA = "0x1834FB4", Slot = "11")]
			private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_screenPosition()
			{
				return default;
			}

			[Token(Token = "0x6004E60")]
			[Address(RVA = "0x1835008", Offset = "0x1835008", VA = "0x1835008", Slot = "12")]
			private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_screenPositionDelta()
			{
				return default;
			}

			[Token(Token = "0x6004E61")]
			[Address(RVA = "0x1835068", Offset = "0x1835068", VA = "0x1835068", Slot = "13")]
			private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_wheelDelta()
			{
				return default;
			}

			[Token(Token = "0x6004E62")]
			[Address(RVA = "0x18350BC", Offset = "0x18350BC", VA = "0x18350BC", Slot = "14")]
			private bool Rewired_002EUI_002EITouchInputSource_002Eget_touchSupported()
			{
				return default;
			}

			[Token(Token = "0x6004E63")]
			[Address(RVA = "0x1835110", Offset = "0x1835110", VA = "0x1835110", Slot = "15")]
			private int Rewired_002EUI_002EITouchInputSource_002Eget_touchCount()
			{
				return default;
			}

			[Token(Token = "0x6004E64")]
			[Address(RVA = "0x1835164", Offset = "0x1835164", VA = "0x1835164", Slot = "16")]
			private Touch Rewired_002EUI_002EITouchInputSource_002EGetTouch(int index)
			{
				return default;
			}

			[Token(Token = "0x6004E65")]
			[Address(RVA = "0x1834D48", Offset = "0x1834D48", VA = "0x1834D48")]
			private void TryUpdate()
			{
			}

			[Token(Token = "0x6004E66")]
			[Address(RVA = "0x18351D0", Offset = "0x18351D0", VA = "0x18351D0")]
			public UnityInputSource()
			{
			}
		}

		[Token(Token = "0x4005B3E")]
		public const int kMouseLeftId = -1;

		[Token(Token = "0x4005B3F")]
		public const int kMouseRightId = -2;

		[Token(Token = "0x4005B40")]
		public const int kMouseMiddleId = -3;

		[Token(Token = "0x4005B41")]
		public const int kFakeTouchesId = -4;

		[Token(Token = "0x4005B42")]
		private const int customButtonsStartingId = -2147483520;

		[Token(Token = "0x4005B43")]
		private const int customButtonsMaxCount = 128;

		[Token(Token = "0x4005B44")]
		private const int customButtonsLastId = -2147483392;

		[Token(Token = "0x4005B45")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<IMouseInputSource> m_MouseInputSourcesList;

		[Token(Token = "0x4005B46")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

		[Token(Token = "0x4005B47")]
		[FieldOffset(Offset = "0x58")]
		private ITouchInputSource m_UserDefaultTouchInputSource;

		[Token(Token = "0x4005B48")]
		[FieldOffset(Offset = "0x60")]
		private UnityInputSource __m_DefaultInputSource;

		[Token(Token = "0x4005B49")]
		[FieldOffset(Offset = "0x68")]
		private readonly MouseState m_MouseState;

		[Token(Token = "0x1700084A")]
		private UnityInputSource defaultInputSource
		{
			[Token(Token = "0x6004E2E")]
			[Address(RVA = "0x164DDB8", Offset = "0x164DDB8", VA = "0x164DDB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084B")]
		private IMouseInputSource defaultMouseInputSource
		{
			[Token(Token = "0x6004E2F")]
			[Address(RVA = "0x164DE20", Offset = "0x164DE20", VA = "0x164DE20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084C")]
		protected ITouchInputSource defaultTouchInputSource
		{
			[Token(Token = "0x6004E30")]
			[Address(RVA = "0x164DE88", Offset = "0x164DE88", VA = "0x164DE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700084D")]
		protected virtual bool isMouseSupported
		{
			[Token(Token = "0x6004E3B")]
			[Address(RVA = "0x164E810", Offset = "0x164E810", VA = "0x164E810", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x164DEF0", Offset = "0x164DEF0", VA = "0x164DEF0")]
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return default;
		}

		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x164DF68", Offset = "0x164DF68", VA = "0x164DF68")]
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			return null;
		}

		[Token(Token = "0x6004E33")]
		[Address(RVA = "0x164E1E4", Offset = "0x164E1E4", VA = "0x164E1E4")]
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
		}

		[Token(Token = "0x6004E34")]
		[Address(RVA = "0x164E294", Offset = "0x164E294", VA = "0x164E294")]
		public void AddMouseInputSource(IMouseInputSource source)
		{
		}

		[Token(Token = "0x6004E35")]
		[Address(RVA = "0x164E390", Offset = "0x164E390", VA = "0x164E390")]
		public int GetMouseInputSourceCount(int playerId)
		{
			return default;
		}

		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x164E56C", Offset = "0x164E56C", VA = "0x164E56C")]
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			return null;
		}

		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x164E654", Offset = "0x164E654", VA = "0x164E654")]
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
		}

		[Token(Token = "0x6004E38")]
		[Address(RVA = "0x164E6C4", Offset = "0x164E6C4", VA = "0x164E6C4")]
		public void AddTouchInputSource(ITouchInputSource source)
		{
		}

		[Token(Token = "0x6004E39")]
		[Address(RVA = "0x164E79C", Offset = "0x164E79C", VA = "0x164E79C")]
		public int GetTouchInputSourceCount(int playerId)
		{
			return default;
		}

		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x164E7BC", Offset = "0x164E7BC", VA = "0x164E7BC")]
		protected void ClearMouseInputSources()
		{
		}

		[Token(Token = "0x6004E3C")]
		protected abstract bool IsDefaultPlayer(int playerId);

		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x164EA28", Offset = "0x164EA28", VA = "0x164EA28")]
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			return default;
		}

		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x164EDD8", Offset = "0x164EDD8", VA = "0x164EDD8")]
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0x164EED4", Offset = "0x164EED4", VA = "0x164EED4")]
		protected void RemovePointerData(PlayerPointerEventData data)
		{
		}

		[Token(Token = "0x6004E40")]
		[Address(RVA = "0x164EF98", Offset = "0x164EF98", VA = "0x164EF98")]
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		[Token(Token = "0x6004E41")]
		[Address(RVA = "0x164F1B0", Offset = "0x164F1B0", VA = "0x164F1B0", Slot = "28")]
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			return null;
		}

		[Token(Token = "0x6004E42")]
		[Address(RVA = "0x164FB2C", Offset = "0x164FB2C", VA = "0x164FB2C")]
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		[Token(Token = "0x6004E43")]
		[Address(RVA = "0x164FD3C", Offset = "0x164FD3C", VA = "0x164FD3C")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default;
		}

		[Token(Token = "0x6004E44")]
		[Address(RVA = "0x164FD94", Offset = "0x164FD94", VA = "0x164FD94", Slot = "29")]
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x164FF40", Offset = "0x164FF40", VA = "0x164FF40", Slot = "30")]
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x165032C", Offset = "0x165032C", VA = "0x165032C", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			return default;
		}

		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x16505D4", Offset = "0x16505D4", VA = "0x16505D4")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x1650958", Offset = "0x1650958", VA = "0x1650958", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x1650E34", Offset = "0x1650E34", VA = "0x1650E34")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x164F934", Offset = "0x164F934", VA = "0x164F934")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x164F9A0", Offset = "0x164F9A0", VA = "0x164F9A0")]
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			return default;
		}

		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x1650F4C", Offset = "0x1650F4C", VA = "0x1650F4C")]
		protected RewiredPointerInputModule()
		{
		}
	}
}
