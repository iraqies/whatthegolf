using System;

namespace Rewired
{
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public HOTASTemplate(object payload)
			: base(null)
		{
		}
	}
}
