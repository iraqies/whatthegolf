using UnityEngine;

public class SleepOnAwake : MonoBehaviour
{
	private Rigidbody rb;

	private void Start()
	{
		rb = base.gameObject.GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.Sleep();
		}
	}
}
