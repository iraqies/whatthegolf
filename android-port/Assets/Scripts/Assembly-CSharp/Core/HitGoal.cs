using UnityEngine;

namespace Core
{
	public class HitGoal : MonoBehaviour
	{
		[SerializeField]
		private GolfBallController ball;

		private GolfGoal goal;

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
