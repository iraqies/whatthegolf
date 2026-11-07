using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	[Token(Token = "0x2000008")]
	public class ThreadingCallbackHelper : MonoBehaviour
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		private List<Action> _actions;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		private List<Action> _currentActions;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2344CF8", Offset = "0x2344CF8", VA = "0x2344CF8")]
		public void addActionToQueue(Action action)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2344DF0", Offset = "0x2344DF0", VA = "0x2344DF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2344F88", Offset = "0x2344F88", VA = "0x2344F88")]
		public void disableIfEmpty()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2345084", Offset = "0x2345084", VA = "0x2345084")]
		public ThreadingCallbackHelper()
		{
		}
	}
}
