using System;

namespace Rewired
{
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public RacingWheelTemplate(object payload)
			: base(null)
		{
		}
	}
}
