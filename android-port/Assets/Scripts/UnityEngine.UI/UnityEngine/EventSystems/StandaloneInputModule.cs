using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000AA")]
	public class StandaloneInputModule : PointerInputModule
	{
		[Token(Token = "0x20000AB")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F6AE4", Offset = "0x1F6AE4")]
		public enum InputMode
		{
			[Token(Token = "0x40002D9")]
			Mouse = 0,
			[Token(Token = "0x40002DA")]
			Buttons = 1
		}

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x58")]
		private float m_PrevActionTime;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 m_LastMoveVector;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x64")]
		private int m_ConsecutiveMoveCount;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_LastMousePosition;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_MousePosition;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_CurrentFocusedGameObject;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x80")]
		private PointerEventData m_InputPointerEvent;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string m_HorizontalAxis;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string m_VerticalAxis;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string m_SubmitButton;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string m_CancelButton;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float m_InputActionsPerSecond;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float m_RepeatDelay;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F8694", Offset = "0x1F8694")]
		private bool m_ForceModuleActive;

		[Token(Token = "0x170001A8")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8EE4", Offset = "0x1F8EE4")]
		public InputMode inputMode
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x2C3C79C", Offset = "0x2C3C79C", VA = "0x2C3C79C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A9")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8F20", Offset = "0x1F8F20")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x2C3C7A4", Offset = "0x2C3C7A4", VA = "0x2C3C7A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x2C3C7AC", Offset = "0x2C3C7AC", VA = "0x2C3C7AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public bool forceModuleActive
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x2C3C7B4", Offset = "0x2C3C7B4", VA = "0x2C3C7B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2C3C7BC", Offset = "0x2C3C7BC", VA = "0x2C3C7BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2C3C7C4", Offset = "0x2C3C7C4", VA = "0x2C3C7C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x2C3C7CC", Offset = "0x2C3C7CC", VA = "0x2C3C7CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public float repeatDelay
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2C3C7D4", Offset = "0x2C3C7D4", VA = "0x2C3C7D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x2C3C7DC", Offset = "0x2C3C7DC", VA = "0x2C3C7DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public string horizontalAxis
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2C3C7E4", Offset = "0x2C3C7E4", VA = "0x2C3C7E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x2C3C7EC", Offset = "0x2C3C7EC", VA = "0x2C3C7EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public string verticalAxis
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x2C3C7F4", Offset = "0x2C3C7F4", VA = "0x2C3C7F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x2C3C7FC", Offset = "0x2C3C7FC", VA = "0x2C3C7FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		public string submitButton
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x2C3C804", Offset = "0x2C3C804", VA = "0x2C3C804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x2C3C80C", Offset = "0x2C3C80C", VA = "0x2C3C80C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public string cancelButton
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2C3C814", Offset = "0x2C3C814", VA = "0x2C3C814")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x2C3C81C", Offset = "0x2C3C81C", VA = "0x2C3C81C")]
			set
			{
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2C3C6D8", Offset = "0x2C3C6D8", VA = "0x2C3C6D8")]
		protected StandaloneInputModule()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2C3C824", Offset = "0x2C3C824", VA = "0x2C3C824")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2C3C82C", Offset = "0x2C3C82C", VA = "0x2C3C82C", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2C3C918", Offset = "0x2C3C918", VA = "0x2C3C918")]
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2C3CD18", Offset = "0x2C3CD18", VA = "0x2C3CD18", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2C3CD8C", Offset = "0x2C3CD8C", VA = "0x2C3CD8C", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2C3CF44", Offset = "0x2C3CF44", VA = "0x2C3CF44", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2C3D07C", Offset = "0x2C3D07C", VA = "0x2C3D07C", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2C3D0A8", Offset = "0x2C3D0A8", VA = "0x2C3D0A8", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2C3D2BC", Offset = "0x2C3D2BC", VA = "0x2C3D2BC")]
		private bool ProcessTouchEvents()
		{
			return default;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2C3D8C4", Offset = "0x2C3D8C4", VA = "0x2C3D8C4")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2C3D668", Offset = "0x2C3D668", VA = "0x2C3D668")]
		protected bool SendSubmitEventToSelectedObject()
		{
			return default;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2C3E028", Offset = "0x2C3E028", VA = "0x2C3E028")]
		private Vector2 GetRawMoveVector()
		{
			return default;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2C3D450", Offset = "0x2C3D450", VA = "0x2C3D450")]
		protected bool SendMoveEventToSelectedObject()
		{
			return default;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2C3D448", Offset = "0x2C3D448", VA = "0x2C3D448")]
		protected void ProcessMouseEvent()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2C3E3B8", Offset = "0x2C3E3B8", VA = "0x2C3E3B8", Slot = "30")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8D64", Offset = "0x1F8D64")]
		protected virtual bool ForceAutoSelect()
		{
			return default;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2C3E130", Offset = "0x2C3E130", VA = "0x2C3E130")]
		protected void ProcessMouseEvent(int id)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2C3D150", Offset = "0x2C3D150", VA = "0x2C3D150")]
		protected bool SendUpdateEventToSelectedObject()
		{
			return default;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2C3E3C0", Offset = "0x2C3E3C0", VA = "0x2C3E3C0")]
		protected void ProcessMousePress(MouseButtonEventData data)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2C3E76C", Offset = "0x2C3E76C", VA = "0x2C3E76C")]
		protected GameObject GetCurrentFocusedGameObject()
		{
			return null;
		}
	}
}
