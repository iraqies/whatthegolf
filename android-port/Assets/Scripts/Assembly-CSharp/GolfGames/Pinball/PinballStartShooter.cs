using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinballStartShooter : MonoBehaviour
	{
		[SerializeField]
		private GameObject peg;

		[SerializeField]
		private Pinball ball;

		[SerializeField]
		private GameObject ballToSpawn;

		[SerializeField]
		private PinballShooter shooter;

		[SerializeField]
		private Transform arrowPositionTransform;

		[SerializeField]
		private Transform arrowPositionAfterShotTransform;

		private int balls;

		private void Start()
		{
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}

		private void OnTriggerStay2D(Collider2D other)
		{
		}

		private void CloseShooterPeg()
		{
		}
	}
}
