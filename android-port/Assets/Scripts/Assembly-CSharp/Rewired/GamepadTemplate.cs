using System;

namespace Rewired
{
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate
	{
		public static readonly Guid typeGuid;

		public GamepadTemplate(object payload)
			: base(null)
		{
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int id) => GetElement(id);
	}
}
