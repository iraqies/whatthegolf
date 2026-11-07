namespace Rewired.Interfaces
{
	internal interface IControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal
	{
		ControllerTemplateElementType elementType { get; }
	}
}
