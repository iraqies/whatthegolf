using UnityEngine;

public class SetAnimationFieldOnAwake : MonoBehaviour
{
	public enum TypeEnum
	{
		Bool = 0,
		Float = 1,
		Trigger = 2
	}

	public bool onAwake;

	public string FieldName;

	public TypeEnum FieldType;

	public string Value;

	public Vector2 FloatValueRange;

	private void Awake()
	{
	}

	public void SetValue()
	{
	}
}
