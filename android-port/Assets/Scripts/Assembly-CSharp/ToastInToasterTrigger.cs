using System.Collections;
using Audio;
using GolfCourse;
using UnityEngine;

public class ToastInToasterTrigger : MonoBehaviour
{
	public Animator ToasterAnimator;

	public HammerThrowingCamera HammerCamera;

	public Transform AnimationTarget;

	public GolfCoursePinGoal Goal;

	public float sfxDelay;

	public ClipSettingsCollection sfxOnToast;

	public float[] whooshSfxTimes;

	public ClipSettingsCollection whooshSfx;

	private bool hasHit;

	private Vector3 velRef;

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator FollowAnimatorRoutine(Rigidbody rigid)
	{
		return null;
	}
}
