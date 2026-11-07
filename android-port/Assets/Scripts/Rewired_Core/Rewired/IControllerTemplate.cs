using System;
using System.Collections.Generic;

namespace Rewired
{
	public interface IControllerTemplate
	{
		string name { get; }

		Guid typeGuid { get; }

		IList<IControllerTemplateElement> elements { get; }

		int elementCount { get; }

		IControllerTemplateElement GetElement(int id);

		int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results);
	}
}
