using UnityEngine;

namespace Hub
{
	public class ConveyorBelt : MonoBehaviour
	{
		[SerializeField]
		private bool isInHub;

		public void OnTriggerExit2D(Collider2D collision)
		{
		}
	}
}
