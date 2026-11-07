using UnityEngine;

namespace Audio
{
	public class TrafficCarAudio : MonoBehaviour
	{
		public CarAgent carAgent;

		public RandomAudioClips clipOnSpeedUp;

		public RandomAudioClips clipsOnFallingOffSide;

		public AudioSource audioSource;

		private bool isInitialSpawn;

		private TrafficController trafficController;

		private bool hasCarFallen;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void CarAgent_OnCarSpeeding()
		{
		}

		private void CarAgent__OnCarFallingOffSide()
		{
		}

		private void CarAgent_onOutOfBounds()
		{
		}
	}
}
