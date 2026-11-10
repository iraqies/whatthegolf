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
			if (ball != null)
			{
				ball.BallInStarterPosition = true;
			}
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			if (other == null)
				return;

			if (other.CompareTag("Ground"))
			{
				Pinball p = other.gameObject.GetComponent<Pinball>();
				if (p != null)
				{
					p.BallInStarterPosition = false;
				}
				CloseShooterPeg();
			}
		}

		private void OnTriggerStay2D(Collider2D other)
		{
			if (other != null && other.CompareTag("Ground") && peg != null)
			{
				peg.SetActive(false);
			}
		}

		private void CloseShooterPeg()
		{
			if (peg != null)
			{
				peg.SetActive(true);
			}
			if (arrowPositionTransform != null)
			{
				arrowPositionTransform.parent = null;
				if (arrowPositionAfterShotTransform != null)
				{
					arrowPositionTransform.position = arrowPositionAfterShotTransform.position;
				}
			}
		}
	}
}
