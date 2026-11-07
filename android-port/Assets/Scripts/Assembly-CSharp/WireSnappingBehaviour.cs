using System.Collections;
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
	}

	public void StartSnapping(Transform trans)
	{
	}

	private IEnumerator SnapRoutine(Transform trans)
	{
		return null;
	}
}
