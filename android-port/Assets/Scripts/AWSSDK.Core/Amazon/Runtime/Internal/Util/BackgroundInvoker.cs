using System;

namespace Amazon.Runtime.Internal.Util
{
	internal class BackgroundInvoker : BackgroundDispatcher<Action>
	{
		public BackgroundInvoker()
			: base((Action<Action>)null)
		{
		}
	}
}
