using UnityEngine;

public class SetAnimationFieldActions : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private string floatName;

	private void Start()
	{
		if (animator == null)
		{
			animator = GetComponent<Animator>();
		}
		if (animator == null)
		{
			Object.Destroy(this);
		}
	}

	public void SetBoolTrue(string b)
	{
		if (animator != null)
		{
			animator.SetBool(b, true);
		}
	}

	public void SetBoolFalse(string b)
	{
		if (animator != null)
		{
			animator.SetBool(b, false);
		}
	}

	public void SetTrigger(string b)
	{
		if (animator != null)
		{
			animator.SetTrigger(b);
		}
	}

	public void SetFloat(float f)
	{
		if (animator != null && !string.IsNullOrEmpty(floatName))
		{
			animator.SetFloat(floatName, f);
		}
	}
}
