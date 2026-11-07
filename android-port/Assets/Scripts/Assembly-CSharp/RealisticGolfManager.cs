using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RealisticGolfManager : MonoBehaviour
{
	private enum RealisticGolfStates
	{
		AIM = 0,
		SHOT = 1,
		GOAL = 2
	}

	public enum ClubStates
	{
		MAIN = 0,
		SECONDARY = 1
	}

	[Serializable]
	public class Club
	{
		public string name;

		public Sprite clubImage;

		public Color clubColor;

		public float strength;

		public float pitch;

		public float arrowSize;

		public ClubEquipIcon iconInScene;

		public GameObject clubInScene;

		public UnityEvent OnShootEffect;
	}

	[SerializeField]
	private GolfBallController m_golfBall;

	[SerializeField]
	private Transform m_flag;

	[SerializeField]
	private GameObject m_goalPin;

	[SerializeField]
	private bool oneShotLevel;

	[SerializeField]
	private GameObject m_ballPrefab;

	[SerializeField]
	private bool m_useClubUI;

	[SerializeField]
	private GameObject m_golfer;

	[SerializeField]
	private Avatar m_golferAvatar;

	[SerializeField]
	private float m_shootDelayFromAnimation;

	[SerializeField]
	private Vector3 m_golferOffsetPos;

	[SerializeField]
	private float m_rotationOffset;

	private Animator m_golferAnimator;

	[SerializeField]
	private CinemachineBrain m_cameraBrain;

	[SerializeField]
	private CinemachineVirtualCamera m_aimCamera;

	[SerializeField]
	private CinemachineVirtualCamera m_followShotCamera;

	[SerializeField]
	private Image m_fadeToBlack;

	[SerializeField]
	private List<Club> m_clubs;

	private RealisticGolfStates currentState;

	private ClubStates currentClub;

	private Vector3 m_ballStartPos;

	private Rigidbody m_ballRb;

	private GolfBallShooterExperimental m_shooter;

	private CinemachineComposer aimCamComposer;

	private float nextShotVelocityMax;

	private ShootArrow m_shootArrow;

	private ConstantForce m_windForceOnBall;

	private void Start()
	{
	}

	private void GetGolfBallComponents()
	{
	}

	private void SetAllClubIcons()
	{
	}

	private void PlaceGolferNextToBall()
	{
	}

	private void AnimatedGolfer(Vector3 boost, bool unused)
	{
	}

	private void Update()
	{
	}

	private void AimUpdate()
	{
	}

	private void ShotUpdate()
	{
	}

	private void HasShot(Vector3 boost)
	{
	}

	private IEnumerator PlaceNewBallForOneShot()
	{
		return null;
	}

	private IEnumerator CustomShotRoutine(Vector3 boost)
	{
		return null;
	}

	private void SwitchCamPriority(int aimCam, int followCam)
	{
	}

	private void OnDestroy()
	{
	}

	private IEnumerator SwitchToFollowCamera()
	{
		return null;
	}

	private void SmallShotAndPutt()
	{
	}

	private IEnumerator SwitchToAimCamera()
	{
		return null;
	}

	private float GoalDistance()
	{
		return 0f;
	}

	private void SwitchControllerToEquippedClub()
	{
	}

	public void ButtonSwitchCurrentClub()
	{
	}

	public void SwitchClubOnTrigger(int newClubIndex)
	{
	}

	private IEnumerator FadeInOut(float endValue)
	{
		return null;
	}
}
