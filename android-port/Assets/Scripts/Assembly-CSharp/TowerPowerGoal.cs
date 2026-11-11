using Audio;
using UnityEngine;

[ExecuteAlways]
public class TowerPowerGoal : MonoBehaviour
{
	public float TargetShotPower;

	public Color MinColor;

	public Color MaxColor;

	public AnimationCurve ColorCurve;

	public Transform ArrowHeadJoint;

	public Material ArrowMat;

	public ClipSettingsCollection PowerIncreaseClip;

	private float currentPower;

	private float audioTimer;

	private void Update()
	{
		if (!Application.isPlaying)
		{
			ChangeLength(TargetShotPower);
			ChangeColor(TargetShotPower);
		}
	}

	public void ChangeArrow(float duration, float power)
	{
		float startPower = currentPower;
		audioTimer = 0f;
		if (duration > 0f)
		{
			StartCoroutine(pTween.To(duration, delegate(float t)
			{
				currentPower = Mathf.Lerp(startPower, power, Mathf.SmoothStep(0f, 1f, t));
				ChangeLength(currentPower);
				ChangeColor(currentPower);
				if (t - audioTimer >= 0.1f)
				{
					if (PowerIncreaseClip != null)
					{
						PowerIncreaseClip.Play(null, base.transform.position, 1f, t / duration + 1f);
					}
					audioTimer = t;
				}
			}).Then(delegate
			{
				ChangeLength(power);
				ChangeColor(power);
			}));
		}
		else
		{
			currentPower = power;
			ChangeLength(power);
			ChangeColor(power);
		}
	}

	private void ChangeLength(float power)
	{
		if (ArrowHeadJoint != null)
		{
			ArrowHeadJoint.localPosition = new Vector3(0f, power * 0.12640001f, 0f);
		}
	}

	private void ChangeColor(float power)
	{
		if (ColorCurve != null)
		{
			Color color = Color.Lerp(MinColor, MaxColor, ColorCurve.Evaluate(power));
			if (ArrowMat != null)
			{
				ArrowMat.color = color;
			}
		}
	}
}
