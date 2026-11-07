using UnityEngine;

public class MainMenuInputIcon : MonoBehaviour
{
	public enum MainMenuInputType
	{
		Mouse = 0,
		Touch = 1,
		SiriRemote = 2,
		Controller = 3
	}

	[SerializeField]
	private MainMenuInputType inputType;

	public MainMenuInputType InputType => MainMenuInputType.Mouse;
}
