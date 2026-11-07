using UnityEngine;

public class HookDisconnectOnBallHit : MonoBehaviour
{
	public LayerMask layermask;

	public string[] tags;

	private GrapplingHookShooter2D shooter;

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D obj)
	{
	}
}
