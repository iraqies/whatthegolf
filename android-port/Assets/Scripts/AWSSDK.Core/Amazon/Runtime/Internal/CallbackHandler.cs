using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class CallbackHandler : PipelineHandler
	{
		public Action<IExecutionContext> OnPreInvoke { get; set; }

		public Action<IExecutionContext> OnPostInvoke { get; set; }

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		protected void PreInvoke(IExecutionContext executionContext)
		{
		}

		protected void PostInvoke(IExecutionContext executionContext)
		{
		}

		private void RaiseOnPreInvoke(IExecutionContext context)
		{
		}

		private void RaiseOnPostInvoke(IExecutionContext context)
		{
		}
	}
}
