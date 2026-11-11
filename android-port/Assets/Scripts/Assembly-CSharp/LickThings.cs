using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class LickThings : MonoBehaviour
{
	public List<AudioClip> LickSFX;

	public float SpringForcePerKilo = 25f;

	public Collider StartLickedObject;

	public List<string> BlacklistTag;

	public Renderer TongueRenderer;

	private LineRope rope;

	private SpringJoint joint;

	private Rigidbody currentlyLicked;

	private GameObject tongueLineEnd;

	private void Awake()
	{
		rope = GetComponent<LineRope>();
		GetComponentInParent<GolfBallController>().OnReset += LickThings_OnReset;
	}

	private void LickThings_OnReset()
	{
		if (currentlyLicked != null)
		{
			Object.Destroy(joint);
			currentlyLicked = null;
			rope.LineEnd = null;
			TongueRenderer.enabled = true;
		}
	}

	private void Start()
	{
		tongueLineEnd = new GameObject("TongueEnd");
		if (StartLickedObject != null)
		{
			OnTriggerEnter(StartLickedObject);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!(other.attachedRigidbody != null) || BlacklistTag.Contains(other.tag) || other.transform.root == base.transform.root || (currentlyLicked != null && other.attachedRigidbody.transform.root == currentlyLicked.transform.root))
		{
			return;
		}
		if (joint == null)
		{
			joint = base.gameObject.AddComponent<SpringJoint>();
			joint.anchor = new Vector3(0f, 1.35f, 0f);
			joint.enablePreprocessing = false;
		}
		ToggleGenericRagdoll componentInParent = other.transform.GetComponentInParent<ToggleGenericRagdoll>();
		if (componentInParent != null)
		{
			componentInParent.RagdollOn();
			Debug.Log("sum: " + componentInParent.Rigidbodies.Sum((Rigidbody r) => r.mass));
			joint.spring = componentInParent.Rigidbodies.Sum((Rigidbody r) => r.mass) * SpringForcePerKilo;
		}
		else
		{
			joint.spring = other.attachedRigidbody.mass * SpringForcePerKilo;
		}
		rope.LineEnd = tongueLineEnd.transform;
		tongueLineEnd.transform.SetParent(other.transform);
		Vector3 vector = other.transform.InverseTransformPoint(other.ClosestPoint(base.transform.position));
		tongueLineEnd.transform.localPosition = vector;
		joint.connectedBody = other.attachedRigidbody;
		joint.connectedAnchor = vector;
		joint.autoConfigureConnectedAnchor = false;
		AudioManager.Instance.shortEffects.Play(LickSFX);
		currentlyLicked = other.attachedRigidbody;
		TongueRenderer.enabled = false;
	}
}
