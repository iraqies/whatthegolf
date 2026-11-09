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
	public float FollowDistance = 1.5f;
	public float FollowSpeed = 8f;
	public Vector3 ballOnTopOffset = new Vector3(0f, 0.5f, 0f);
	private Rigidbody2D rigidbody2D;
	private OverworldBallManager ballManager;
	private Vector3 lastNonNullVelocity;

	private void Start()
	{
		rigidbody2D = GetComponent<Rigidbody2D>();
		ballManager = OverworldBallManager.Instance;
	}

	private void Update()
	{
		if (!isCollected) return;
		if (ballManager == null)
			ballManager = OverworldBallManager.Instance;
		if (collectedBehaviour == Collected.FOLLOWBALL)
			FollowBallBehaviour();
		else if (collectedBehaviour == Collected.BALLONTOP)
			SetupBallOnTop();
	}

	private void FollowBallBehaviour()
	{
		if (ballManager == null || ballManager.Ball == null) return;
		Vector3 target = ballManager.Ball.transform.position;
		float dist = Vector3.Distance(transform.position, target);
		if (dist > FollowDistance)
		{
			transform.position = Vector3.MoveTowards(transform.position, target, FollowSpeed * Time.deltaTime);
		}
	}

	private void SetupBallOnTop()
	{
		if (ballManager == null || ballManager.Ball == null) return;
		transform.position = ballManager.Ball.transform.position + ballOnTopOffset;
	}

	public void DestroyAfterCompletion()
	{
		Destroy(gameObject);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (isCollected || collision == null || collision.gameObject == null) return;
		if (collision.gameObject.GetComponent<OverworldBall2D>() != null)
		{
			isCollected = true;
			if (collectedBehaviour == Collected.DISAPPEAR)
				gameObject.SetActive(false);
		}
	}
}
