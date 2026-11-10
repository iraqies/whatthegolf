using Core;
using UnityEngine;

public class ToggleControllerBasedOnAnotherController : MonoBehaviour
{
	public GolfBallController ThisController;

	public GolfBallController OtherController;

	private void Update()
	{
		if (ThisController != null && OtherController != null)
		{
			ThisController.enabled = OtherController.enabled;
		}
	}
}
