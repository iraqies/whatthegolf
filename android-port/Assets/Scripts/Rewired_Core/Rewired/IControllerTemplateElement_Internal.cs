using System.Collections.Generic;

namespace Rewired
{
	internal interface IControllerTemplateElement_Internal
	{
		int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
	}
}
