using Core;
using UnityEngine;

public class ToggleControllerBasedOnAnotherController : MonoBehaviour
{
	public GolfBallController ThisController;

	public GolfBallController OtherController;

	private void Update()
	{
		if (ThisController == null || OtherController == null)
			return;
		ThisController.BlockShooting = OtherController.BlockShooting;
		ThisController.enabled = OtherController.enabled;
		ThisController.transform.position = OtherController.transform.position;
	}
}
