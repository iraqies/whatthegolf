using System;
using Rewired.Interfaces;

namespace Rewired.Data.Mapping
{
	internal interface IHardwareControllerTemplateMap_Internal
	{
		string name { get; }

		Guid typeGuid { get; }

		int GetElementIdentifierCount();

		IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);

		IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);

		IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);

		HxKJTjnYRTlXmgqyhXzejFNHdCai GetAxisTarget(Controller controller, int elementIdentifierId);

		HxKJTjnYRTlXmgqyhXzejFNHdCai GetButtonTarget(Controller controller, int elementIdentifierId);
	}
}
