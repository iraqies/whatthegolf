using System.Collections;
using UnityEngine;

public class SnapToPositionOnGoalNoseJob : MonoBehaviour
{
	public Transform target;

	public float angleRotations;

	public float speed;

	private bool started;

	public AnimationCurve animationCurve;

	public void SnapToPosition()
	{
		if (!started)
		{
			StartCoroutine(Snap());
		}
		started = true;
	}

	private IEnumerator Snap()
	{
		Transform startTrans = base.transform;
		float elapsed = 0f;
		float progress = 0f;
		while (progress < 1f)
		{
			elapsed += Time.deltaTime;
			float num = ((animationCurve != null) ? animationCurve.Evaluate(elapsed) : 1f);
			progress += num * (speed / 1000f);
			if (target != null)
			{
				base.transform.position = Vector3.Lerp(startTrans.position, target.position, Mathf.Clamp01(progress));
				base.transform.rotation = Quaternion.Lerp(startTrans.rotation, target.rotation, progress);
			}
			yield return new WaitForFixedUpdate();
		}
		if (target != null)
		{
			base.transform.position = Vector3.Lerp(startTrans.position, target.position, 1f);
			base.transform.rotation = Quaternion.Lerp(startTrans.rotation, target.rotation, 1f);
		}
		yield return null;
	}

	public SnapToPositionOnGoalNoseJob()
	{
		angleRotations = 20f;
		speed = 1f;
		animationCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);
	}
}
