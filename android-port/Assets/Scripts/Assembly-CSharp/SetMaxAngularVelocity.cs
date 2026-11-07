using UnityEngine;

public class SetMaxAngularVelocity : MonoBehaviour
{
	[SerializeField] private float maxAngularVelocity = 50f;
	[SerializeField] private bool includeChildren;

	private void Awake()
	{
		if (includeChildren)
		{
			foreach (var rb in GetComponentsInChildren<Rigidbody>(true))
				rb.maxAngularVelocity = maxAngularVelocity;
		}
		else
		{
			var rb = GetComponent<Rigidbody>();
			if (rb != null) rb.maxAngularVelocity = maxAngularVelocity;
		}
	}
}
