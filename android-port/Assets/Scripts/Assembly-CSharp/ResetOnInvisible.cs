using UnityEngine;

public class ResetOnInvisible : MonoBehaviour
{
	public InvisibleCullingObject cullingObject;

	public bool isResettingOnLevelExit;

	private Vector2 startPosition;

	private Quaternion startRotation;

	private bool isMovingObjectVisible;

	private bool isStaticObjectVisible;

	private Rigidbody2D rigid;

	private bool didReset;

	public bool isDebug;

	private void Awake()
	{
	}

	private void TryReset()
	{
	}

	private void Reset()
	{
	}

	public void OnReturnToOverworld()
	{
	}
}
