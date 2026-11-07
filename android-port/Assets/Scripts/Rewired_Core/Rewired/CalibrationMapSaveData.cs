using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000DB")]
	public class CalibrationMapSaveData
	{
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x10")]
		private CalibrationMap aFIcvsDQELsrYkhERVVKWxCOLBhy;

		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x18")]
		private ControllerType KHkewZTAeuvHVDDJaWvnQRRxxDiF;

		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x20")]
		private string xBrcfixGFlRWLdALITGLqMbVvAXW;

		[Token(Token = "0x170001DF")]
		public CalibrationMap map
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x2351254", Offset = "0x2351254", VA = "0x2351254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x235125C", Offset = "0x235125C", VA = "0x235125C")]
		public CalibrationMapSaveData(CalibrationMap P_0, ControllerType P_1, string P_2)
		{
		}
	}
}
