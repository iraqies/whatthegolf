using System;

namespace Amazon.Runtime
{
	public interface IAsyncRequestContext : IRequestContext
	{
		AsyncCallback Callback { get; }

		object State { get; }
	}
}
