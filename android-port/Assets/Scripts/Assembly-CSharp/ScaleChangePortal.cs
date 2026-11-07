using UnityEngine;

public class ScaleChangePortal : SimplePortal
{
	public Vector3 MaxScaleAllowed;

	public float ScaleChange;

	protected override void RecieveObject(GameObject go)
	{
	}

	protected override void ObjectEnteredTrigger(GameObject other)
	{
	}
}
