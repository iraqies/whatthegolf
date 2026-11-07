using UnityEngine;

namespace Audio
{
	public class AutoRunnerSFX : MonoBehaviour
	{
		public Runner runner;

		public PlayAudioClipsByFrequency player;

		private void Awake()
		{
		}

		private void OnRunnerChangeState(Runner.RunnerState state)
		{
		}
	}
}
