using UnityEngine;

namespace MonitorComponents
{
	[ExecuteInEditMode]
	public class MonitorAudioSource : MonoBehaviour
	{
		public bool showVolume;

		public Monitor monitor_volume;

		private MonitorInput monitorInput_volume;

		public bool showPitch;

		public ValueAxisMode pitchMode;

		public float pitchMin;

		public float pitchMax;

		public Monitor monitor_pitch;

		private MonitorInput monitorInput_pitch;

		public bool showIsPlaying;

		public Monitor monitor_isPlaying;

		private MonitorInput monitorInput_isPlaying;

		private AudioSource audioSource;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateMonitors()
		{
		}

		private void UpdateVolumeMonitor(bool componentIsActive)
		{
		}

		private void UpdatePitchMonitor(bool componentIsActive)
		{
		}

		private void UpdateIsPlayingMonitor(bool componentIsActive)
		{
		}

		public void Update()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		public void RemoveMonitors()
		{
		}
	}
}
