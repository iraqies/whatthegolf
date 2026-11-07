using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballRod : MonoBehaviour
	{
		public bool ModifyScaleWhenHit;

		private AudioSource source;

		[SerializeField]
		private float vel;

		private void Awake()
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}
	}
}
