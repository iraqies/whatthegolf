using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B7C20", Offset = "0x1B7C20")]
	public class TextDataProvider : ResourceProviderBase
	{
		[Token(Token = "0x2000062")]
		internal class InternalOp
		{
			[Token(Token = "0x40000F9")]
			[FieldOffset(Offset = "0x10")]
			private TextDataProvider m_Provider;

			[Token(Token = "0x40000FA")]
			[FieldOffset(Offset = "0x18")]
			private UnityWebRequestAsyncOperation m_RequestOperation;

			[Token(Token = "0x40000FB")]
			[FieldOffset(Offset = "0x20")]
			private WebRequestQueueOperation m_RequestQueueOperation;

			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x28")]
			private ProvideHandle m_PI;

			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x40")]
			private bool m_IgnoreFailures;

			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x41")]
			private bool m_Complete;

			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x44")]
			private int m_Timeout;

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2A792A8", Offset = "0x2A792A8", VA = "0x2A792A8")]
			private float GetPercentComplete()
			{
				return default;
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2A792C0", Offset = "0x2A792C0", VA = "0x2A792C0")]
			public void Start(ProvideHandle provideHandle, TextDataProvider rawProvider)
			{
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x2A79850", Offset = "0x2A79850", VA = "0x2A79850")]
			private bool WaitForCompletionHandler()
			{
				return default;
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2A798CC", Offset = "0x2A798CC", VA = "0x2A798CC")]
			private void RequestOperation_completed(AsyncOperation op)
			{
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x2A79B2C", Offset = "0x2A79B2C", VA = "0x2A79B2C")]
			protected void CompleteOperation(string text, Exception exception)
			{
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2A79720", Offset = "0x2A79720", VA = "0x2A79720")]
			private object ConvertText(string text)
			{
				return null;
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2A79BDC", Offset = "0x2A79BDC", VA = "0x2A79BDC", Slot = "4")]
			protected virtual void SendWebRequest(string path)
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2A79E9C", Offset = "0x2A79E9C", VA = "0x2A79E9C")]
			public InternalOp()
			{
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2A79EA4", Offset = "0x2A79EA4", VA = "0x2A79EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B85CC", Offset = "0x1B85CC")]
			private void _003CSendWebRequest_003Eb__13_0(UnityWebRequestAsyncOperation asyncOperation)
			{
			}
		}

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B81DC", Offset = "0x1B81DC")]
		private bool IgnoreFailures__BackingField;

		[Token(Token = "0x1700005E")]
		public bool IgnoreFailures
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2A71690", Offset = "0x2A71690", VA = "0x2A71690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B85AC", Offset = "0x1B85AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2A71698", Offset = "0x2A71698", VA = "0x2A71698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B85BC", Offset = "0x1B85BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2A716A0", Offset = "0x2A716A0", VA = "0x2A716A0", Slot = "19")]
		public virtual object Convert(Type type, string text)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2A716A8", Offset = "0x2A716A8", VA = "0x2A716A8", Slot = "17")]
		public override void Provide(ProvideHandle provideHandle)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2A68730", Offset = "0x2A68730", VA = "0x2A68730")]
		public TextDataProvider()
		{
		}
	}
}
