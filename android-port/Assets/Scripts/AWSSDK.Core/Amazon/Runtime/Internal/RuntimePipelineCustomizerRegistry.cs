using System;
using System.Collections.Generic;
using System.Threading;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RuntimePipelineCustomizerRegistry : IDisposable
	{
		private Logger _logger;

		private ReaderWriterLockSlim _rwlock;

		private IList<IRuntimePipelineCustomizer> _customizers;

		public static RuntimePipelineCustomizerRegistry Instance { get; }

		private RuntimePipelineCustomizerRegistry()
		{
		}

		public void Register(IRuntimePipelineCustomizer customizer)
		{
		}

		public void Deregister(IRuntimePipelineCustomizer customizer)
		{
		}

		public void Deregister(string uniqueName)
		{
		}

		internal void ApplyCustomizations(Type type, RuntimePipeline pipeline)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
