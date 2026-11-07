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
		}

		private void Controller_OnShoot(Vector3 obj)
		{
		}
	}
}
