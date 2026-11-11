using UnityEngine;

public class BubbleCharacter : MonoBehaviour
{
	public ShadowProjector2D shadowProjector;

	private Rigidbody2D rigidbody2D;

	private Collider2D[] colliders;

	private void Awake()
	{
		rigidbody2D = GetComponent<Rigidbody2D>();
		colliders = GetComponentsInChildren<Collider2D>();
	}

	public void Pickup()
	{
		if (rigidbody2D != null)
		{
			rigidbody2D.simulated = false;
		}
		if (colliders != null)
		{
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i] != null)
				{
					colliders[i].enabled = false;
				}
			}
		}
		if (shadowProjector != null)
		{
			shadowProjector.enabled = false;
		}
	}

	public void Release()
	{
		if (rigidbody2D != null)
		{
			rigidbody2D.simulated = true;
		}
		if (colliders != null)
		{
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i] != null)
				{
					colliders[i].enabled = true;
				}
			}
		}
		if (shadowProjector != null)
		{
			shadowProjector.enabled = true;
		}
	}
}
