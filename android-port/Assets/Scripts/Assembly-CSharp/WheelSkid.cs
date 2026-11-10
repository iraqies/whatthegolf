using UnityEngine;

public class WheelSkid : MonoBehaviour
{
	[SerializeField]
	private Skidmarks skidmarksController;

	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private Vector2 skidMarkIntensityRange = new Vector2(0.6f, 0f);

	private Rigidbody rb;

	private const float SKID_FX_SPEED = 0f;

	private const float MAX_SKID_INTENSITY = 0f;

	private const float WHEEL_SLIP_MULTIPLIER = 5f;

	private int lastSkid = -1;

	private void Awake()
	{
		rb = GetComponentInParent<Rigidbody>();
	}

	protected void LateUpdate()
	{
		if (rb == null || skidmarksController == null)
		{
			return;
		}
		if (Physics.Raycast(base.transform.position, -base.transform.up, out var hitInfo, 1f, groundMask))
		{
			Vector3 localVel = base.transform.InverseTransformDirection(rb.velocity);
			float xSpeed = Mathf.Abs(localVel.x);
			float fwdSpeed = Vector3.Dot(rb.velocity, base.transform.forward);
			float wheelSlip = Mathf.Abs(fwdSpeed - fwdSpeed) * WHEEL_SLIP_MULTIPLIER * (10f - fwdSpeed);
			float totalSkid = xSpeed + Mathf.Max(0f, wheelSlip);
			if (totalSkid <= SKID_FX_SPEED)
			{
				lastSkid = -1;
			}
			else
			{
				float intensity = Mathf.Lerp(skidMarkIntensityRange.x, skidMarkIntensityRange.y, Mathf.Clamp01(totalSkid / MAX_SKID_INTENSITY));
				Vector3 skidPoint = hitInfo.point + rb.velocity * Time.fixedDeltaTime;
				lastSkid = skidmarksController.AddSkidMark(skidPoint, hitInfo.normal, intensity, lastSkid);
			}
		}
		else
		{
			lastSkid = -1;
		}
	}
}
