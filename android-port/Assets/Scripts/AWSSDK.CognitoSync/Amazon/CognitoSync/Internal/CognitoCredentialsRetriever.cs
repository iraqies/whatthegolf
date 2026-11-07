using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.CognitoIdentity;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Internal
{
	[Token(Token = "0x2000079")]
	public class CognitoCredentialsRetriever : CredentialsRetriever
	{
		[Token(Token = "0x200007A")]
		private static class CSRequestCache
		{
			[Token(Token = "0x200007B")]
			private class CSRequest
			{
				[Token(Token = "0x40000BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private ITypeInfo requestType;

				[Token(Token = "0x40000BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private PropertyInfo identityPoolIdProperty;

				[Token(Token = "0x40000C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private PropertyInfo identityIdProperty;

				[Token(Token = "0x40000C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static ITypeInfo SyncRequestType;

				[Token(Token = "0x6000369")]
				[Address(RVA = "0x11AEFFC", Offset = "0x11AEFFC", VA = "0x11AEFFC")]
				public CSRequest(Type requestType)
				{
				}

				[Token(Token = "0x600036A")]
				[Address(RVA = "0x11AF3B4", Offset = "0x11AF3B4", VA = "0x11AF3B4")]
				public void SetFields(AmazonCognitoSyncRequest request, string identityPoolId, string identityId)
				{
				}
			}

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Dictionary<Type, CSRequest> requestCache;

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x11AEC74", Offset = "0x11AEC74", VA = "0x11AEC74")]
			static CSRequestCache()
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x11AED04", Offset = "0x11AED04", VA = "0x11AED04")]
			private static void PopulateCache()
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1192404", Offset = "0x1192404", VA = "0x1192404")]
			public static void SetFields(AmazonCognitoSyncRequest request, string identityPoolId, string identityId)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x24214", Offset = "0x24214")]
		private struct _003CInvokeAsync_003Ed__1<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CognitoCredentialsRetriever _003C_003E4__this;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T _003Cresult_003E5__2;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private CognitoAWSCredentials _003CcognitoCredentials_003E5__3;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x600036C")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600036D")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x118CCB8", Offset = "0x118CCB8", VA = "0x118CCB8")]
		public CognitoCredentialsRetriever(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x6000363")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x119221C", Offset = "0x119221C", VA = "0x119221C")]
		private static void SetIdentity(IExecutionContext executionContext, string identityId, string identityPoolId)
		{
		}

		[Token(Token = "0x6000365")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x24224", Offset = "0x24224")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
