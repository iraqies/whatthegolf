using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000170")]
	public static class AsyncRunner
	{
		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D20", Offset = "0x25D20")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action action;

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x12881FC", Offset = "0x12881FC", VA = "0x12881FC")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x1288204", Offset = "0x1288204", VA = "0x1288204")]
			internal object _003CRun_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D30", Offset = "0x25D30")]
		private sealed class _003C_003Ec__DisplayClass1_0<T>
		{
			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x2000173")]
			private struct _003C_003CRun_003Eb__0_003Ed : IAsyncStateMachine
			{
				[Token(Token = "0x4000596")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4000597")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

				[Token(Token = "0x4000598")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public _003C_003Ec__DisplayClass1_0<T> _003C_003E4__this;

				[Token(Token = "0x4000599")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private _003C_003Ec__DisplayClass1_1<T> _003C_003E8__1;

				[Token(Token = "0x400059A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Thread _003Cthread_003E5__2;

				[Token(Token = "0x400059B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

				[Token(Token = "0x6000BAE")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x6000BAF")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> action;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x6000BAC")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000BAD")]
			internal Task<T> _003CRun_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D40", Offset = "0x25D40")]
		private sealed class _003C_003Ec__DisplayClass1_1<T>
		{
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T result;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Exception exception;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SemaphoreSlim semaphore;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass1_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000BB0")]
			public _003C_003Ec__DisplayClass1_1()
			{
			}

			[Token(Token = "0x6000BB1")]
			internal void _003CRun_003Eb__1()
			{
			}
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x11D35A0", Offset = "0x11D35A0", VA = "0x11D35A0")]
		public static Task Run(Action action, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000BA9")]
		public static Task<T> Run<T>(Func<T> action, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
