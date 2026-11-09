using Core;
using UnityEngine;

namespace Audio
{
	public class AudioOnFirstShot : MonoBehaviour
	{
		[SerializeField]
		private ClipSettingsCollection clips;

		[SerializeField]
		private GolfBallController controller;

		private bool didShoot;

		private void Awake()
		{
			if (controller == null)
				controller = GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>();
			if (controller != null)
			{
				controller.OnShoot -= Controller_OnShoot;
				controller.OnShoot += Controller_OnShoot;
			}
		}

		private void Controller_OnShoot(Vector3 obj)
		{
			if (didShoot) return;
			didShoot = true;
			if (clips != null)
				clips.Play(transform.position);
		}
	}
}
