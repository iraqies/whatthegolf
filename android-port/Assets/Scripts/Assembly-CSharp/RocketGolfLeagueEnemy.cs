using UnityEngine;

public class RocketGolfLeagueEnemy : MonoBehaviour
{
	public Transform Target;

	public float MoveSpeed;

	public ForceMode ForceMode;

	public float MaxRotation;

	private Rigidbody rigid;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
