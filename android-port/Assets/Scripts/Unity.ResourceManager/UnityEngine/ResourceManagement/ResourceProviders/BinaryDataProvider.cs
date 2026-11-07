using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B7B20", Offset = "0x1B7B20")]
	internal class BinaryDataProvider : ResourceProviderBase
	{
		[Token(Token = "0x200004A")]
		internal class InternalOp
		{
			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x10")]
			private BinaryDataProvider m_Provider;

			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x18")]
			private UnityWebRequestAsyncOperation m_RequestOperation;

			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x20")]
			private WebRequestQueueOperation m_RequestQueueOperation;

			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x28")]
			private ProvideHandle m_PI;

			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x40")]
			private bool m_IgnoreFailures;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x41")]
			private bool m_Complete;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x44")]
			private int m_Timeout;

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2A72680", Offset = "0x2A72680", VA = "0x2A72680")]
			private float GetPercentComplete()
			{
				return default;
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2A628EC", Offset = "0x2A628EC", VA = "0x2A628EC")]
			public void Start(ProvideHandle provideHandle, BinaryDataProvider rawProvider)
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2A727C4", Offset = "0x2A727C4", VA = "0x2A727C4")]
			private bool WaitForCompletionHandler()
			{
				return default;
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2A72840", Offset = "0x2A72840", VA = "0x2A72840")]
			private void RequestOperation_completed(AsyncOperation op)
			{
			}

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2A72B20", Offset = "0x2A72B20", VA = "0x2A72B20")]
			protected void CompleteOperation(byte[] data, Exception exception)
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2A72698", Offset = "0x2A72698", VA = "0x2A72698")]
			private object ConvertBytes(byte[] data)
			{
				return null;
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2A72BD0", Offset = "0x2A72BD0", VA = "0x2A72BD0", Slot = "4")]
			protected virtual void SendWebRequest(string path)
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2A628E4", Offset = "0x2A628E4", VA = "0x2A628E4")]
			public InternalOp()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2A72E6C", Offset = "0x2A72E6C", VA = "0x2A72E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8544", Offset = "0x1B8544")]
			private void _003CSendWebRequest_003Eb__13_0(UnityWebRequestAsyncOperation asyncOperation)
			{
			}
		}

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B81BC", Offset = "0x1B81BC")]
		private bool IgnoreFailures__BackingField;

		[Token(Token = "0x17000048")]
		public bool IgnoreFailures
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2A62838", Offset = "0x2A62838", VA = "0x2A62838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8524", Offset = "0x1B8524")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x2A62840", Offset = "0x2A62840", VA = "0x2A62840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8534", Offset = "0x1B8534")]
			set
			{
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2A62848", Offset = "0x2A62848", VA = "0x2A62848", Slot = "19")]
		public virtual object Convert(Type type, byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2A62850", Offset = "0x2A62850", VA = "0x2A62850", Slot = "17")]
		public override void Provide(ProvideHandle provideHandle)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2A62E20", Offset = "0x2A62E20", VA = "0x2A62E20")]
		public BinaryDataProvider()
		{
		}
	}
}
