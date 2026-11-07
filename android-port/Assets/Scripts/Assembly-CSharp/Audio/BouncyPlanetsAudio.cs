using SpaceGolf;
using UnityEngine;

namespace Audio
{
	public class BouncyPlanetsAudio : MonoBehaviour
	{
		public RandomAudioClips planetToBoundsClips;

		public RandomAudioClips planetToPlanetClips;

		public float minVelocity;

		public float maxVelocity;

		public float minPlanetSize;

		public float maxPlanetSize;

		public float cooldown;

		private Planet[] planets;

		private float nextSoundTime;

		private void Start()
		{
		}

		private void OnPlanetCollision(HitInfo info)
		{
		}
	}
}
