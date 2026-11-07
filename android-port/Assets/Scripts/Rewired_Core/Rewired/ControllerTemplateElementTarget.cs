using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x200005D")]
	public struct ControllerTemplateElementTarget
	{
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x0")]
		private IControllerTemplateElement DxtFUupqUGmyUsjBAudqHmDVBidJ;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x8")]
		private AxisRange dnqcDaKuDzTeZpkjWrulGAfmNtHmA;

		[Token(Token = "0x170000FD")]
		public ControllerTemplateElementType elementType
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x236D8CC", Offset = "0x236D8CC", VA = "0x236D8CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FE")]
		public IControllerTemplateElement element
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x236D990", Offset = "0x236D990", VA = "0x236D990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x236D868", Offset = "0x236D868", VA = "0x236D868")]
		internal ControllerTemplateElementTarget(IControllerTemplateElement P_0, AxisRange P_1)
		{
		}
	}
}
