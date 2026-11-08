using UnityEngine;

public class RussianDollOutOfBoundsHandler : MonoBehaviour
{
	public RussianDollController Controller;

	private void OnTriggerEnter(Collider other)
	{
		if (Controller != null && other != null)
			Controller.NotifyChildTriggerEnter(other);
	}
}
