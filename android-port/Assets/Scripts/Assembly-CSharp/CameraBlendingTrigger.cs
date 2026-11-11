using CameraStack;
using UnityEngine;

public class CameraBlendingTrigger : MonoBehaviour
{
	public CBBlend Blender;

	public float BlendSpeed = 1f;

	private float targetBlend;

	private float currentBlend;

	private void Update()
	{
		currentBlend = Mathf.MoveTowards(currentBlend, targetBlend, Time.unscaledDeltaTime * BlendSpeed);
		Blender.AtoBBlend = TweenFunctions.SmootherStep(currentBlend);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<GolfBallController>() != null)
		{
			targetBlend = 1f;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<GolfBallController>() != null)
		{
			targetBlend = 0f;
		}
	}
}
