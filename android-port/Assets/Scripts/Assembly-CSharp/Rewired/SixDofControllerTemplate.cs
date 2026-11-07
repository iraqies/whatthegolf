using System;

namespace Rewired
{
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public SixDofControllerTemplate(object payload)
			: base(null)
		{
		}
	}
}
