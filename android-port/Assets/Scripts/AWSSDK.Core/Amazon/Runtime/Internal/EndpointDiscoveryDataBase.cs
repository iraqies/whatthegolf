using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public abstract class EndpointDiscoveryDataBase
	{
		private bool _required;

		private SortedDictionary<string, string> _identifiers;

		public virtual bool Required
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual SortedDictionary<string, string> Identifiers
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected EndpointDiscoveryDataBase(bool required)
		{
		}
	}
}
