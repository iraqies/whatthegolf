public class GenericButtonPropRain : GenericButton
{
	public PropRain Rain;

	protected override void OnToggle()
	{
		if (Rain != null)
			Rain.Raining = isPressed;
	}
}
