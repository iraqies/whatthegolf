using UnityEngine;
using UnityEngine.Events;

public class GolfSnakeFollowForCarObstacle : MonoBehaviour
{
	public GameObject flatGolfBallPrefab;

	public UnityEvent OnCollision;

	private Vector3 flatBallScale;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
