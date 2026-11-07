using Core;
using UnityEngine;

namespace Audio
{
	public class PlayAudioSourceOnPull : MonoBehaviour
	{
		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private GolfBallController controller;

		[SerializeField]
		private bool pauseOnStopAim;

		private int lastSampleTime;

		private void Awake()
		{
		}

		private void Controller_OnCancel()
		{
		}

		private void Controller_OnPreShoot(Vector3 obj)
		{
		}

		private void Controller_OnAimStart()
		{
		}
	}
}
