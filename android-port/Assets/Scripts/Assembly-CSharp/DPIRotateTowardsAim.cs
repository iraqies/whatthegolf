using UnityEngine;

public class DPIRotateTowardsAim : BaseDailyPrizeInteractions
{
	[SerializeField]
	private Rigidbody _rb;

	[SerializeField]
	private bool useLocalUp;

	[SerializeField]
	private float LookInAimDirectionSpeed;

	public override void OnAimNotWrapped(Vector3 b)
	{
		base.OnAimNotWrapped(b);
		if (_rb == null)
			return;

		Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
		if (b == Vector3.zero)
			return;

		Quaternion targetRot = Quaternion.LookRotation(b, upVec);
		if (LookInAimDirectionSpeed != float.PositiveInfinity && LookInAimDirectionSpeed > 0f)
		{
			_rb.MoveRotation(Quaternion.RotateTowards(_rb.rotation, targetRot, LookInAimDirectionSpeed * Time.deltaTime));
		}
		else
		{
			_rb.MoveRotation(targetRot);
		}
	}
}
