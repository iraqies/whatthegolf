using UnityEngine;

namespace Hub
{
	public class ConveyorBelt : MonoBehaviour
	{
		[SerializeField]
		private bool isInHub;

		public void OnTriggerExit2D(Collider2D collision)
		{
			if (isInHub && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ball != null)
			{
				if (OverworldManager2d.Instance.ball.Controller != null && OverworldManager2d.Instance.ball.Controller.shooter != null && OverworldManager2d.Instance.ball.rigidBody != null)
				{
					OverworldManager2d.Instance.ball.rigidBody.drag = 0.15f;
				}
			}
		}
	}
}
