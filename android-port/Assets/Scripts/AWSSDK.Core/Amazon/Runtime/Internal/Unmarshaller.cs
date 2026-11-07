using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000190")]
	public class Unmarshaller : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000191")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25DD0", Offset = "0x25DD0")]
		private struct _003CInvokeAsync_003Ed__3<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Unmarshaller _003C_003E4__this;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6000C67")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C68")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000192")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25DE0", Offset = "0x25DE0")]
		private struct _003CUnmarshallAsync_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Unmarshaller _003C_003E4__this;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IRequestContext _003CrequestContext_003E5__2;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IResponseContext _003CresponseContext_003E5__3;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TimingEvent _003C_003E7__wrap3;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResponseUnmarshaller _003Cunmarshaller_003E5__5;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool _003CreadEntireResponse_003E5__6;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<System.IO.Stream>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x1298088", Offset = "0x1298088", VA = "0x1298088", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x1298EA8", Offset = "0x1298EA8", VA = "0x1298EA8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _supportsResponseLogging;

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x127EFF8", Offset = "0x127EFF8", VA = "0x127EFF8")]
		public Unmarshaller(bool supportsResponseLogging)
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x127F024", Offset = "0x127F024", VA = "0x127F024", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C61")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x127F218", Offset = "0x127F218", VA = "0x127F218")]
		private void Unmarshall(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x12804AC", Offset = "0x12804AC", VA = "0x12804AC")]
		private Task UnmarshallAsync(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x127FD08", Offset = "0x127FD08", VA = "0x127FD08")]
		private AmazonWebServiceResponse UnmarshallResponse(UnmarshallerContext context, IRequestContext requestContext)
		{
			return null;
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x1280614", Offset = "0x1280614", VA = "0x1280614")]
		private static bool ShouldLogResponseBody(bool supportsResponseLogging, IRequestContext requestContext)
		{
			return default;
		}

		[Token(Token = "0x6000C66")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A96C", Offset = "0x2A96C")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
