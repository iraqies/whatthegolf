using System;

namespace Rewired
{
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate
	{
		public static readonly Guid typeGuid;

		public FlightYokeTemplate(object payload)
			: base(null)
		{
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int id) => GetElement(id);
	}
}
