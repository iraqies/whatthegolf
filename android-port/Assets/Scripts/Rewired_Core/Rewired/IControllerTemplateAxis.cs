namespace Rewired
{
	public interface IControllerTemplateAxis : IControllerTemplateElement
	{
		float value { get; }

		float valuePrev { get; }

		new IControllerTemplateAxisSource source { get; }
	}
}
