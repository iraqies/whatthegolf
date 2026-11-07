using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200019E")]
	public class RuntimePipeline : IDisposable
	{
		[Token(Token = "0x200019F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E30", Offset = "0x25E30")]
		private sealed class _003CEnumerateHandlers_003Ed__21 : IEnumerable<IPipelineHandler>, IEnumerable, IEnumerator<IPipelineHandler>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000639")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400063A")]
			[FieldOffset(Offset = "0x18")]
			private IPipelineHandler _003C_003E2__current;

			[Token(Token = "0x400063B")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400063C")]
			[FieldOffset(Offset = "0x28")]
			public RuntimePipeline _003C_003E4__this;

			[Token(Token = "0x400063D")]
			[FieldOffset(Offset = "0x30")]
			private IPipelineHandler _003Chandler_003E5__2;

			[Token(Token = "0x1700034C")]
			private IPipelineHandler System_002ECollections_002EGeneric_002EIEnumerator_003CAmazon_002ERuntime_002EIPipelineHandler_003E_002ECurrent
			{
				[Token(Token = "0x6000CE6")]
				[Address(RVA = "0x129523C", Offset = "0x129523C", VA = "0x129523C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CAmazon_002ERuntime_002EIPipelineHandler_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700034D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000CE8")]
				[Address(RVA = "0x1295284", Offset = "0x1295284", VA = "0x1295284", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x12950EC", Offset = "0x12950EC", VA = "0x12950EC")]
			[DebuggerHidden]
			public _003CEnumerateHandlers_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x1295124", Offset = "0x1295124", VA = "0x1295124", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x1295128", Offset = "0x1295128", VA = "0x1295128", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x129523C", Offset = "0x129523C", VA = "0x129523C", Slot = "6")]
			[DebuggerHidden]
			private IPipelineHandler System_002ECollections_002EGeneric_002EIEnumerator_003CAmazon_002ERuntime_002EIPipelineHandler_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x1295244", Offset = "0x1295244", VA = "0x1295244", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x1295284", Offset = "0x1295284", VA = "0x1295284", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x129528C", Offset = "0x129528C", VA = "0x129528C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IPipelineHandler> System_002ECollections_002EGeneric_002EIEnumerable_003CAmazon_002ERuntime_002EIPipelineHandler_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x1295334", Offset = "0x1295334", VA = "0x1295334", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x18")]
		private ILogger _logger;

		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x20")]
		private IPipelineHandler _handler;

		[Token(Token = "0x1700034A")]
		public IPipelineHandler Handler
		{
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x1264468", Offset = "0x1264468", VA = "0x1264468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034B")]
		public List<IPipelineHandler> Handlers
		{
			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x1265488", Offset = "0x1265488", VA = "0x1265488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x1264470", Offset = "0x1264470", VA = "0x1264470")]
		public RuntimePipeline(IPipelineHandler handler)
		{
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x126462C", Offset = "0x126462C", VA = "0x126462C")]
		public RuntimePipeline(IList<IPipelineHandler> handlers)
		{
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x1264714", Offset = "0x1264714", VA = "0x1264714")]
		public RuntimePipeline(IList<IPipelineHandler> handlers, ILogger logger)
		{
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x1264CBC", Offset = "0x1264CBC", VA = "0x1264CBC")]
		public RuntimePipeline(IPipelineHandler handler, ILogger logger)
		{
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x1264E04", Offset = "0x1264E04", VA = "0x1264E04")]
		public IResponseContext InvokeSync(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000CD5")]
		public Task<T> InvokeAsync<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x1264B00", Offset = "0x1264B00", VA = "0x1264B00")]
		public void AddHandler(IPipelineHandler handler)
		{
		}

		[Token(Token = "0x6000CD7")]
		public void AddHandlerAfter<T>(IPipelineHandler handler) where T : IPipelineHandler
		{
		}

		[Token(Token = "0x6000CD8")]
		public void AddHandlerBefore<T>(IPipelineHandler handler) where T : IPipelineHandler
		{
		}

		[Token(Token = "0x6000CD9")]
		public void RemoveHandler<T>()
		{
		}

		[Token(Token = "0x6000CDA")]
		public void ReplaceHandler<T>(IPipelineHandler handler) where T : IPipelineHandler
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x12651DC", Offset = "0x12651DC", VA = "0x12651DC")]
		private static void InsertHandler(IPipelineHandler handler, IPipelineHandler current)
		{
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x1264FD0", Offset = "0x1264FD0", VA = "0x1264FD0")]
		private static IPipelineHandler GetInnermostHandler(IPipelineHandler handler)
		{
			return null;
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x126510C", Offset = "0x126510C", VA = "0x126510C")]
		private void SetHandlerProperties(IPipelineHandler handler)
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x1265528", Offset = "0x1265528", VA = "0x1265528")]
		public IEnumerable<IPipelineHandler> EnumerateHandlers()
		{
			return null;
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x126559C", Offset = "0x126559C", VA = "0x126559C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x126561C", Offset = "0x126561C", VA = "0x126561C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x1264F54", Offset = "0x1264F54", VA = "0x1264F54")]
		private void ThrowIfDisposed()
		{
		}
	}
}
