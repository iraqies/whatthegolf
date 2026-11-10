using UnityEngine;

public class ResetOnInvisible : MonoBehaviour
{
	public InvisibleCullingObject cullingObject;

	public bool isResettingOnLevelExit = true;

	private Vector2 startPosition;

	private Quaternion startRotation;

	private bool isMovingObjectVisible;

	private bool isStaticObjectVisible;

	private Rigidbody2D rigid;

	private bool didReset = true;

	public bool isDebug;

	private void Awake()
	{
		startPosition = transform.position;
		startRotation = transform.rotation;
		rigid = GetComponent<Rigidbody2D>();
		if (cullingObject == null)
		{
			cullingObject = GetComponent<InvisibleCullingObject>();
		}
	}

	private void TryReset()
	{
		if (!didReset && !isMovingObjectVisible && !isStaticObjectVisible)
		{
			Reset();
		}
	}

	private void Reset()
	{
		transform.position = startPosition;
		transform.rotation = startRotation;
		if (rigid != null)
		{
			rigid.velocity = Vector2.zero;
			rigid.angularVelocity = 0f;
			rigid.Sleep();
		}
		didReset = true;
	}

	public void OnReturnToOverworld()
	{
		if (isResettingOnLevelExit)
		{
			Reset();
		}
	}
}
