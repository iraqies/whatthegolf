using UnityEngine;

public class SetAnimationFieldOnAwake : MonoBehaviour
{
	public enum TypeEnum
	{
		Bool = 0,
		Float = 1,
		Trigger = 2
	}

	public bool onAwake = true;

	public string FieldName;

	public TypeEnum FieldType;

	public string Value;

	public Vector2 FloatValueRange;

	private void Awake()
	{
		if (onAwake)
		{
			SetValue();
		}
	}

	public void SetValue()
	{
		Animator anim = GetComponent<Animator>();
		if (anim == null)
		{
			return;
		}
		switch (FieldType)
		{
		case TypeEnum.Bool:
			if (bool.TryParse(Value, out var b))
			{
				anim.SetBool(FieldName, b);
			}
			break;
		case TypeEnum.Float:
			anim.SetFloat(FieldName, Random.Range(FloatValueRange.x, FloatValueRange.y));
			break;
		case TypeEnum.Trigger:
			anim.SetTrigger(FieldName);
			break;
		}
	}
}
