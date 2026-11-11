using UnityEngine;

public class FailChallengeOnTouch : MonoBehaviour
{
	public bool CheckLayerMask;

	public LayerMask LayerMask;

	public bool CheckTags;

	public string[] Tags;

	public Challenge challenge;

	private void Awake()
	{
		if (challenge == null)
		{
			challenge = GetComponentInParent<Challenge>();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (base.enabled && !(challenge == null) && collision != null)
		{
			GameObject obj = ((collision.rigidbody != null) ? collision.rigidbody.gameObject : collision.gameObject);
			if (ValidIncomingObject(obj))
			{
				challenge.Fail();
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (base.enabled && !(challenge == null) && collision != null)
		{
			GameObject obj = ((collision.rigidbody != null) ? collision.rigidbody.gameObject : collision.gameObject);
			if (ValidIncomingObject(obj))
			{
				challenge.Fail();
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (base.enabled && !(challenge == null) && other != null)
		{
			Component component = ((other.attachedRigidbody != null) ? ((Component)other.attachedRigidbody) : ((Component)other));
			if (ValidIncomingObject(component.gameObject))
			{
				challenge.Fail();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (base.enabled && !(challenge == null) && other != null)
		{
			Component component = ((other.attachedRigidbody != null) ? ((Component)other.attachedRigidbody) : ((Component)other));
			if (ValidIncomingObject(component.gameObject))
			{
				challenge.Fail();
			}
		}
	}

	private bool ValidIncomingObject(GameObject obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (CheckLayerMask && (int)LayerMask != ((int)LayerMask | (1 << obj.layer)))
		{
			return false;
		}
		if (CheckTags)
		{
			if (Tags == null)
			{
				return false;
			}
			bool flag = false;
			for (int i = 0; i < Tags.Length; i++)
			{
				flag |= obj.CompareTag(Tags[i]);
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}
}
