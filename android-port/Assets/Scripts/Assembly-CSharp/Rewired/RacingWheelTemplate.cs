using System;

namespace Rewired
{
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate
	{
		public static readonly Guid typeGuid;

		public RacingWheelTemplate(object payload)
			: base(null)
		{
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int id) => GetElement(id);
	}
}
