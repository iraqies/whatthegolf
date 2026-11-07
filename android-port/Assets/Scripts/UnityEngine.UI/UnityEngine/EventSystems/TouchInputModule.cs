using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000AC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F6B20", Offset = "0x1F6B20")]
	public class TouchInputModule : PointerInputModule
	{
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_LastMousePosition;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_MousePosition;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x68")]
		private PointerEventData m_InputPointerEvent;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F86E0", Offset = "0x1F86E0")]
		[SerializeField]
		private bool m_ForceModuleActive;

		[Token(Token = "0x170001B1")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1F8F58", Offset = "0x1F8F58")]
		public bool allowActivationOnStandalone
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x2C42694", Offset = "0x2C42694", VA = "0x2C42694")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x2C4269C", Offset = "0x2C4269C", VA = "0x2C4269C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x2C426A4", Offset = "0x2C426A4", VA = "0x2C426A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x2C426AC", Offset = "0x2C426AC", VA = "0x2C426AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2C4268C", Offset = "0x2C4268C", VA = "0x2C4268C")]
		protected TouchInputModule()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2C426B4", Offset = "0x2C426B4", VA = "0x2C426B4", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2C42838", Offset = "0x2C42838", VA = "0x2C42838", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2C42878", Offset = "0x2C42878", VA = "0x2C42878", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2C42958", Offset = "0x2C42958", VA = "0x2C42958")]
		private bool UseFakeInput()
		{
			return default;
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2C4298C", Offset = "0x2C4298C", VA = "0x2C4298C", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2C429E0", Offset = "0x2C429E0", VA = "0x2C429E0")]
		private void FakeTouches()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2C42AF8", Offset = "0x2C42AF8", VA = "0x2C42AF8")]
		private void ProcessTouchEvents()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2C42C64", Offset = "0x2C42C64", VA = "0x2C42C64")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x2C433D4", Offset = "0x2C433D4", VA = "0x2C433D4", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x2C43400", Offset = "0x2C43400", VA = "0x2C43400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
