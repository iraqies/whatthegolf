using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	[Token(Token = "0x2000011")]
	public class WebRequestQueueOperation
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_Completed;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		public UnityWebRequestAsyncOperation Result;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		public Action<UnityWebRequestAsyncOperation> OnComplete;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		internal UnityWebRequest m_WebRequest;

		[Token(Token = "0x1700001B")]
		public bool IsDone
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2A5FF40", Offset = "0x2A5FF40", VA = "0x2A5FF40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001C")]
		public UnityWebRequest WebRequest
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2A72670", Offset = "0x2A72670", VA = "0x2A72670")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2A72678", Offset = "0x2A72678", VA = "0x2A72678")]
			internal set
			{
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A72030", Offset = "0x2A72030", VA = "0x2A72030")]
		public WebRequestQueueOperation(UnityWebRequest request)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A72504", Offset = "0x2A72504", VA = "0x2A72504")]
		internal void Complete(UnityWebRequestAsyncOperation asyncOp)
		{
		}
	}
}
