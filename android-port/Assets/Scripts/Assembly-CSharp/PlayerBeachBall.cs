using UnityEngine;

public class PlayerBeachBall : MonoBehaviour
{
	public BeachBallWithAvatarController Player;

	private Rigidbody rigid;

	private float nextPushTime;

	public bool debugThings;

	public float pushMultiplier;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void Push(Vector3 dir)
	{
	}
}
