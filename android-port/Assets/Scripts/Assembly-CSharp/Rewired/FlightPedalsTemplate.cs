using System;

namespace Rewired
{
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate
	{
		public static readonly Guid typeGuid;

		public FlightPedalsTemplate(object payload)
			: base(null)
		{
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int id) => GetElement(id);
	}
}
