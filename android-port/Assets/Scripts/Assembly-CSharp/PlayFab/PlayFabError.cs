using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001183")]
	public class PlayFabError
	{
		[Token(Token = "0x4005EAC")]
		[FieldOffset(Offset = "0x10")]
		public string ApiEndpoint;

		[Token(Token = "0x4005EAD")]
		[FieldOffset(Offset = "0x18")]
		public int HttpCode;

		[Token(Token = "0x4005EAE")]
		[FieldOffset(Offset = "0x20")]
		public string HttpStatus;

		[Token(Token = "0x4005EAF")]
		[FieldOffset(Offset = "0x28")]
		public PlayFabErrorCode Error;

		[Token(Token = "0x4005EB0")]
		[FieldOffset(Offset = "0x30")]
		public string ErrorMessage;

		[Token(Token = "0x4005EB1")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, List<string>> ErrorDetails;

		[Token(Token = "0x4005EB2")]
		[FieldOffset(Offset = "0x40")]
		public object CustomData;

		[Token(Token = "0x4005EB3")]
		[ThreadStatic]
		private static StringBuilder _tempSb;

		[Token(Token = "0x6005016")]
		[Address(RVA = "0x15EAF2C", Offset = "0x15EAF2C", VA = "0x15EAF2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6005017")]
		[Address(RVA = "0x15EB3B8", Offset = "0x15EB3B8", VA = "0x15EB3B8")]
		public string GenerateErrorReport()
		{
			return null;
		}

		[Token(Token = "0x6005018")]
		[Address(RVA = "0x15EB91C", Offset = "0x15EB91C", VA = "0x15EB91C")]
		public PlayFabError()
		{
		}
	}
}
