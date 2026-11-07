using UnityEngine;

public class QuestItemBehaviour : MonoBehaviour
{
	public enum Collected
	{
		FOLLOWBALL = 0,
		BALLONTOP = 1,
		DISAPPEAR = 2,
		ACTIVATE = 3
	}

	public bool isCollected;

	public Collected collectedBehaviour;

	public float FollowDistance;

	public float FollowSpeed;

	public Vector3 ballOnTopOffset;

	private Rigidbody2D rigidbody2D;

	private OverworldBallManager ballManager;

	private Vector3 lastNonNullVelocity;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FollowBallBehaviour()
	{
	}

	private void SetupBallOnTop()
	{
	}

	public void DestroyAfterCompletion()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
