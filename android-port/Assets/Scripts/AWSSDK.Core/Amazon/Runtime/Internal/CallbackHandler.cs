using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000181")]
	public class CallbackHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D70", Offset = "0x25D70")]
		private struct _003CInvokeAsync_003Ed__9<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallbackHandler _003C_003E4__this;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C20")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C21")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27428", Offset = "0x27428")]
		private Action<IExecutionContext> OnPreInvoke__BackingField;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27438", Offset = "0x27438")]
		private Action<IExecutionContext> OnPostInvoke__BackingField;

		[Token(Token = "0x1700033B")]
		public Action<IExecutionContext> OnPreInvoke
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x11DC17C", Offset = "0x11DC17C", VA = "0x11DC17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A73C", Offset = "0x2A73C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x11DC184", Offset = "0x11DC184", VA = "0x11DC184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A74C", Offset = "0x2A74C")]
			set
			{
			}
		}

		[Token(Token = "0x1700033C")]
		public Action<IExecutionContext> OnPostInvoke
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x11DC18C", Offset = "0x11DC18C", VA = "0x11DC18C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A75C", Offset = "0x2A75C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x11DC194", Offset = "0x11DC194", VA = "0x11DC194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A76C", Offset = "0x2A76C")]
			set
			{
			}
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x11DC19C", Offset = "0x11DC19C", VA = "0x11DC19C", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C19")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x11DC250", Offset = "0x11DC250", VA = "0x11DC250")]
		protected void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x11DC2C0", Offset = "0x11DC2C0", VA = "0x11DC2C0")]
		protected void PostInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x11DC330", Offset = "0x11DC330", VA = "0x11DC330")]
		private void RaiseOnPreInvoke(IExecutionContext context)
		{
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x11DC3A0", Offset = "0x11DC3A0", VA = "0x11DC3A0")]
		private void RaiseOnPostInvoke(IExecutionContext context)
		{
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x11DC410", Offset = "0x11DC410", VA = "0x11DC410")]
		public CallbackHandler()
		{
		}

		[Token(Token = "0x6000C1F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A77C", Offset = "0x2A77C")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
