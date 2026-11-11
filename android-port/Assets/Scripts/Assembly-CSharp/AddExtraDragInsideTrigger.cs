using Core;
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
		if (_rigidbodyOverride != null)
		{
			_orgDrag = _rigidbodyOverride.drag;
		}
		else
		{
			_orgDrag = Object.FindObjectOfType<GolfBallController>().GetComponent<Rigidbody>().drag;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (base.enabled && !(other.attachedRigidbody == null) && (other.attachedRigidbody == _rigidbodyOverride || !(other.GetComponentInParent<GolfBallController>() == null)))
		{
			other.attachedRigidbody.drag = _drag;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (base.enabled && !(other.attachedRigidbody == null) && (other.attachedRigidbody == _rigidbodyOverride || !(other.GetComponentInParent<GolfBallController>() == null)))
		{
			other.attachedRigidbody.drag = _orgDrag;
		}
	}
}
