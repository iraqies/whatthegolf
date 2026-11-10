using UnityEngine;

public class AlwaysPointUpwards2D : MonoBehaviour
{
	public Vector3 OverrideRotation;

	public Vector3 OverrideLocalPosition;

	private void LateUpdate()
	{
		base.transform.rotation = Quaternion.Euler(OverrideRotation);
		if (OverrideLocalPosition != Vector3.zero)
		{
			base.transform.localPosition = OverrideLocalPosition;
		}
	}
}
