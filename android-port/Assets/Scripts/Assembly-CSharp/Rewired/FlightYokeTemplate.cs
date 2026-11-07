using System;

namespace Rewired
{
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public FlightYokeTemplate(object payload)
			: base(null)
		{
		}
	}
}
