using UnityEngine;

public class WheelSkid : MonoBehaviour
{
	[SerializeField]
	private Skidmarks skidmarksController;

	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private Vector2 skidMarkIntensityRange;

	private Rigidbody rb;

	private const float SKID_FX_SPEED = 0f;

	private const float MAX_SKID_INTENSITY = 0f;

	private const float WHEEL_SLIP_MULTIPLIER = 5f;

	private int lastSkid;

	private void Awake()
	{
	}

	protected void LateUpdate()
	{
	}
}
