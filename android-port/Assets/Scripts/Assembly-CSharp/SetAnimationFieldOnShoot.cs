using UnityEngine;

public class SetAnimationFieldOnShoot : MonoBehaviour
{
	public enum TypeEnum
	{
		Bool = 0,
		Float = 1,
		Trigger = 2
	}

	public string FieldName;

	public TypeEnum FieldType;

	public string Value;

	public Vector2 FloatValueRange;

	private Animator animator;

	private void Start()
	{
	}

	private void BallOnOnShoot(Vector3 vector3)
	{
	}
}
