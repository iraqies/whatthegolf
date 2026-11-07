using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x2000206")]
	public static class AsyncHelpers
	{
		[Token(Token = "0x2000207")]
		private class ExclusiveSynchronizationContext : SynchronizationContext
		{
			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool done;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B58", Offset = "0x27B58")]
			private Exception ObjectException__BackingField;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly AutoResetEvent pendingObjects;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly Queue<Tuple<SendOrPostCallback, object>> objects;

			[Token(Token = "0x17000400")]
			public Exception ObjectException
			{
				[Token(Token = "0x6000FE8")]
				[Address(RVA = "0x1287D14", Offset = "0x1287D14", VA = "0x1287D14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC60", Offset = "0x2BC60")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FE9")]
				[Address(RVA = "0x1287D1C", Offset = "0x1287D1C", VA = "0x1287D1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC70", Offset = "0x2BC70")]
				set
				{
				}
			}

			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x1287D24", Offset = "0x1287D24", VA = "0x1287D24", Slot = "4")]
			public override void Send(SendOrPostCallback d, object state)
			{
			}

			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x1287D78", Offset = "0x1287D78", VA = "0x1287D78", Slot = "5")]
			public override void Post(SendOrPostCallback d, object state)
			{
			}

			[Token(Token = "0x6000FEC")]
			[Address(RVA = "0x1287ED0", Offset = "0x1287ED0", VA = "0x1287ED0")]
			public void EndMessageLoop()
			{
			}

			[Token(Token = "0x6000FED")]
			[Address(RVA = "0x1287F60", Offset = "0x1287F60", VA = "0x1287F60")]
			public void BeginMessageLoop()
			{
			}

			[Token(Token = "0x6000FEE")]
			[Address(RVA = "0x1288134", Offset = "0x1288134", VA = "0x1288134", Slot = "8")]
			public override SynchronizationContext CreateCopy()
			{
				return null;
			}

			[Token(Token = "0x6000FEF")]
			[Address(RVA = "0x1288138", Offset = "0x1288138", VA = "0x1288138")]
			public ExclusiveSynchronizationContext()
			{
			}

			[Token(Token = "0x6000FF0")]
			[Address(RVA = "0x12881F0", Offset = "0x12881F0", VA = "0x12881F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC80", Offset = "0x2BC80")]
			private void _003CEndMessageLoop_003Eb__9_0(object _)
			{
			}
		}

		[Token(Token = "0x2000208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F80", Offset = "0x25F80")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x2000209")]
			private struct _003C_003CRunSync_003Eb__0_003Ed : IAsyncStateMachine
			{
				[Token(Token = "0x40007A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x40007AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x40007AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public _003C_003Ec__DisplayClass0_0 _003C_003E4__this;

				[Token(Token = "0x40007AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

				[Token(Token = "0x6000FF3")]
				[Address(RVA = "0x1298EB4", Offset = "0x1298EB4", VA = "0x1298EB4", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x6000FF4")]
				[Address(RVA = "0x12992A4", Offset = "0x12992A4", VA = "0x12992A4", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<Task> workItem;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExclusiveSynchronizationContext synch;

			[Token(Token = "0x6000FF1")]
			[Address(RVA = "0x1287C74", Offset = "0x1287C74", VA = "0x1287C74")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000FF2")]
			[Address(RVA = "0x1287C7C", Offset = "0x1287C7C", VA = "0x1287C7C")]
			internal void _003CRunSync_003Eb__0(object _)
			{
			}
		}

		[Token(Token = "0x200020A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F90", Offset = "0x25F90")]
		private sealed class _003C_003Ec__DisplayClass1_0<T>
		{
			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x200020B")]
			private struct _003C_003CRunSync_003Eb__0_003Ed : IAsyncStateMachine
			{
				[Token(Token = "0x40007B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x40007B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public AsyncVoidMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x40007B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public _003C_003Ec__DisplayClass1_0<T> _003C_003E4__this;

				[Token(Token = "0x40007B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

				[Token(Token = "0x6000FF7")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x6000FF8")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<Task<T>> workItem;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T ret;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExclusiveSynchronizationContext synch;

			[Token(Token = "0x6000FF5")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000FF6")]
			internal void _003CRunSync_003Eb__0(object _)
			{
			}
		}

		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x11D33C4", Offset = "0x11D33C4", VA = "0x11D33C4")]
		public static void RunSync(Func<Task> workItem)
		{
		}

		[Token(Token = "0x6000FE7")]
		public static T RunSync<T>(Func<Task<T>> workItem)
		{
			return (T)null;
		}
	}
}
