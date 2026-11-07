using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class TowerController : MonoBehaviour
{
	public List<float> PowerGoals;

	public List<Transform> Positions;

	public Transform FlagPosition;

	public Transform TowerRoot;

	public TowerPowerGoal TowerPower;

	public Animator Animator;

	public WhackHammerController Hammer;

	public float AcceptedErrorMargin;

	public ClipSettingsCollection BellRingClip;

	public ClipSettingsCollection HitPlatformClip;

	public ClipSettingsCollection TowerMovingClip;

	public ClipSettingsCollection HoleMovingClip;

	public ClipSettingsCollection IncorrectHitClip;

	private bool hasHitCorrectPower;

	private int currentIndex;

	private bool readyForHits;

	[SerializeField]
	private bool ShowFlag;

	[SerializeField]
	private bool HideOnDone;

	[SerializeField]
	private bool PlayHoleMoving;

	[SerializeField]
	private bool UseIncorrectAnimation;

	[SerializeField]
	private GameObject Sphere;

	[SerializeField]
	private GameObject RealSphere;

	[SerializeField]
	private UnityEvent OnHitDone;

	private void Start()
	{
	}

	private IEnumerator SetTower()
	{
		return null;
	}

	private void OnHit(float power)
	{
	}

	public void RingBell()
	{
	}

	public void HitPlatform()
	{
	}

	public void TowerMoving()
	{
	}

	public void HoleMoving()
	{
	}
}
