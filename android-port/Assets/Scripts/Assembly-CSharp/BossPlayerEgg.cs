using System.Collections;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class BossPlayerEgg : MonoBehaviour
{
	public GolfBallController PlayerController;

	public float FinalSize;

	public float HatchTime;

	public float ShakeDuration;

	public float ShakeSpeed;

	public float ShakeAmount;

	public GameObject CrackedEgg;

	public UnityEvent OnHatchEvent;

	public bool UseEggHeightOnHatch;

	public float OverrideHatchHeight;

	public AudioClipSettings HatchSound;

	public AudioSource ShakeSound;

	public AudioSource GrowSound;

	public Animator RobotFaceAnimator;

	private IEnumerator Start()
	{
		return null;
	}
}
