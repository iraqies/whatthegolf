using UnityEngine;

public class RollingTrainCrate : MonoBehaviour
{
	public Vector2 ForcePositionOffset;

	public Vector2 Force;

	public ForceMode2D ForceMode;

	public float ActivationThresholdRange;

	public Transform Activator;

	private Rigidbody2D rigid;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
