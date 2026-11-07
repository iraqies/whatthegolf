namespace Rewired.Data.Mapping
{
	internal interface IControllerTemplateMapSpecialElement_Internal
	{
		T GetMapping<T>() where T : ControllerTemplateSpecialElementMapping;
	}
}
