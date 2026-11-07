using System;

namespace Rewired
{
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate
	{
		public static readonly Guid typeGuid;

		public SixDofControllerTemplate(object payload)
			: base(null)
		{
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int id) => GetElement(id);
	}
}
