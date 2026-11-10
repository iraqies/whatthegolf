using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class WireSnappingBehaviour : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	[SerializeField]
	private float snapTime;

	[SerializeField]
	private string wireColor;

	[SerializeField]
	private UnityEvent OnSnapped;

	private bool jointMade;

	public AnimationCurve animationCurve;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
		{
			return;
		}
		AmongUsWireType component = collision.gameObject.GetComponent<AmongUsWireType>();
		if (component != null && component.wireColorType == wireColor)
		{
			target = collision.transform;
			GolfBallController component2 = GetComponent<GolfBallController>();
			if (component2 != null)
			{
				component2.enabled = false;
				component2.StopAiming();
			}
			StartCoroutine(SnapRoutine(collision.transform));
			TreeCounter component3 = GetComponent<TreeCounter>();
			if (component3 != null)
			{
				component3.AddOneCount();
			}
			OnSnapped?.Invoke();
		}
	}

	public void StartSnapping(Transform trans)
	{
		StartCoroutine(SnapRoutine(trans));
	}

	private IEnumerator SnapRoutine(Transform trans)
	{
		Vector3 startPos = ((trans != null) ? trans.position : base.transform.position);
		float elapsed = 0f;
		float progress = 0f;
		Rigidbody component = GetComponent<Rigidbody>();
		if (component != null)
		{
			component.isKinematic = true;
		}
		while (progress < 1f)
		{
			elapsed += Time.deltaTime;
			float num = ((animationCurve != null) ? animationCurve.Evaluate(elapsed) : 1f);
			progress += num * (snapTime / 1000f);
			if (target != null)
			{
				base.transform.position = Vector3.Lerp(startPos, target.position, Mathf.Clamp01(progress));
			}
			base.transform.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.down);
			yield return new WaitForFixedUpdate();
		}
		if (target != null)
		{
			base.transform.position = Vector3.Lerp(startPos, target.position, 1f);
		}
		if (!jointMade && target != null)
		{
			FixedJoint fixedJoint = base.gameObject.AddComponent<FixedJoint>();
			fixedJoint.anchor = target.position;
			fixedJoint.connectedBody = target.GetComponent<Rigidbody>();
			fixedJoint.enablePreprocessing = false;
			Rigidbody componentInParent = GetComponentInParent<Rigidbody>();
			if (componentInParent != null)
			{
				componentInParent.isKinematic = true;
			}
			jointMade = true;
		}
		yield return null;
	}

	public WireSnappingBehaviour()
	{
		snapTime = 1f;
		animationCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);
	}
}
