using UnityEngine;

public class Crab : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		if (collision != null && collision.rigidbody != null)
		{
			BeachBall ball = collision.rigidbody.GetComponent<BeachBall>();
			if (ball != null)
			{
				ball.Bang();
			}
		}
	}
}
