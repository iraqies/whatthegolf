using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x20012E4")]
	public class EventCallback
	{
		[Token(Token = "0x40065B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x40065B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x60057A8")]
		[Address(RVA = "0x1446AB0", Offset = "0x1446AB0", VA = "0x1446AB0")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x60057A9")]
		[Address(RVA = "0x1446B8C", Offset = "0x1446B8C", VA = "0x1446B8C")]
		public bool HasCallback()
		{
			return default;
		}

		[Token(Token = "0x60057AA")]
		[Address(RVA = "0x1446C20", Offset = "0x1446C20", VA = "0x1446C20")]
		public EventCallback()
		{
		}
	}
}
