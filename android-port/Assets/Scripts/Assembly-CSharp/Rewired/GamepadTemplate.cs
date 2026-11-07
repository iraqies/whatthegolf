using System;

namespace Rewired
{
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		public static readonly Guid typeGuid;

		public GamepadTemplate(object payload)
			: base(null)
		{
		}
	}
}
