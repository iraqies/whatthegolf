using UnityEngine;
using UnityEngine.Events;

public class ChallengeTriggerGeneric : ChallengeTriggerBase
{
	public bool CheckLayerMask;

	public LayerMask LayerMask;

	public bool CheckTags;

	public string[] Tags;

	public UnityEvent TriggerEnter;

	private void OnTriggerEnter(Collider other)
	{
		if (!base.enabled || other == null)
		{
			return;
		}
		GameObject obj = ((other.attachedRigidbody != null) ? other.attachedRigidbody.gameObject : other.gameObject);
		if (ValidIncomingObject(obj))
		{
			OnTrigger?.Invoke(this);
			TriggerEnter?.Invoke();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!base.enabled || collision == null)
		{
			return;
		}
		GameObject obj = ((collision.rigidbody != null) ? collision.rigidbody.gameObject : collision.gameObject);
		if (ValidIncomingObject(obj))
		{
			OnTrigger?.Invoke(this);
			TriggerEnter?.Invoke();
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!base.enabled || other == null)
		{
			return;
		}
		GameObject obj = ((other.attachedRigidbody != null) ? other.attachedRigidbody.gameObject : other.gameObject);
		if (ValidIncomingObject(obj))
		{
			OnTrigger?.Invoke(this);
			TriggerEnter?.Invoke();
		}
	}

	private bool ValidIncomingObject(GameObject obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (CheckLayerMask)
		{
			int mask = LayerMask;
			if (mask != (mask | (1 << obj.layer)))
			{
				return false;
			}
		}
		if (CheckTags)
		{
			if (Tags == null)
			{
				return false;
			}
			bool matched = false;
			for (int i = 0; i < Tags.Length; i++)
			{
				matched |= obj.CompareTag(Tags[i]);
			}
			if (!matched)
			{
				return false;
			}
		}
		return true;
	}
}
