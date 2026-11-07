using UnityEngine;

public class AddExtraDragInsideTrigger : MonoBehaviour
{
	[SerializeField]
	private Rigidbody _rigidbodyOverride;

	private float _orgDrag;

	[SerializeField]
	private float _drag;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
