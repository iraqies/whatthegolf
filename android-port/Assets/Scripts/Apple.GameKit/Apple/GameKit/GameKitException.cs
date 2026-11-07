using System;
using Il2CppDummyDll;

namespace Apple.GameKit
{
	[Token(Token = "0x2000002")]
	public class GameKitException : Exception
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x32A2C", Offset = "0x32A2C")]
		private int ErrorCode__BackingField;

		[Token(Token = "0x17000001")]
		public int ErrorCode
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x12E9D7C", Offset = "0x12E9D7C", VA = "0x12E9D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x32A3C", Offset = "0x32A3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x12E82EC", Offset = "0x12E82EC", VA = "0x12E82EC")]
		public GameKitException(int errorCode, string message)
		{
		}
	}
}
