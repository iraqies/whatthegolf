using System;

namespace Rewired
{
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public FlightPedalsTemplate(object payload)
			: base(null)
		{
		}
	}
}
