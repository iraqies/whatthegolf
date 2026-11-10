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
				if (OverworldManager2d.Instance.ball.shooter != null && OverworldManager2d.Instance.ball.rb != null)
				{
					OverworldManager2d.Instance.ball.rb.drag = 0.15f;
				}
			}
		}
	}
}
