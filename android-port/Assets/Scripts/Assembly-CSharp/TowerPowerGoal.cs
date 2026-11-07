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
	}

	public void ChangeArrow(float duration, float power)
	{
	}

	private void ChangeLength(float power)
	{
	}

	private void ChangeColor(float power)
	{
	}
}
