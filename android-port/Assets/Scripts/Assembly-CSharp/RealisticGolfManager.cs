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
		GetGolfBallComponents();
		if (m_aimCamera != null)
		{
			aimCamComposer = m_aimCamera.GetCinemachineComponent<CinemachineComposer>();
		}
		if (m_golfer != null)
		{
			m_golferAnimator = m_golfer.GetComponentInChildren<Animator>();
		}
		if (m_golfBall != null)
		{
			m_ballStartPos = m_golfBall.transform.position;
		}
		SetAllClubIcons();
		SwitchControllerToEquippedClub();
		PlaceGolferNextToBall();
	}

	private void GetGolfBallComponents()
	{
		if (m_golfBall != null)
		{
			m_golfBall.OnPreShoot += HasShot;
			m_golfBall.OnAimUpdate += AnimatedGolfer;
			m_windForceOnBall = m_golfBall.GetComponent<ConstantForce>();
			m_ballRb = m_golfBall.GetComponent<Rigidbody>();
			m_shooter = m_golfBall.GetComponent<GolfBallShooterExperimental>();
		}
	}

	private void SetAllClubIcons()
	{
		if (m_clubs == null)
		{
			return;
		}
		foreach (Club club in m_clubs)
		{
			if (club != null && club.iconInScene != null)
			{
				club.iconInScene.SetIcon(club.clubImage, club.clubColor);
			}
		}
	}

	private void PlaceGolferNextToBall()
	{
		if (m_golfer != null && m_golfBall != null)
		{
			m_golfer.transform.position = m_golfBall.transform.position + m_golferOffsetPos;
		}
	}

	private void AnimatedGolfer(Vector3 boost, bool unused)
	{
		if (m_golferAnimator != null)
		{
			m_golferAnimator.SetFloat("Power", boost.sqrMagnitude);
		}
	}

	private void Update()
	{
		if (currentState == RealisticGolfStates.SHOT)
		{
			ShotUpdate();
		}
		if (!oneShotLevel)
		{
			nextShotVelocityMax = ((GoalDistance() < 20f) ? 0f : 0.2f);
		}
		if (m_shootArrow == null)
		{
			m_shootArrow = UnityEngine.Object.FindObjectOfType<ShootArrow>();
			if (m_shootArrow != null && m_clubs != null && (int)currentClub < m_clubs.Count)
			{
				Club club = m_clubs[(int)currentClub];
				if (club != null)
				{
					m_shootArrow.colorMax = club.clubColor;
					m_shootArrow.colorMin = Color.Lerp(club.clubColor, Color.white, 0.5f);
				}
			}
		}
	}

	private void AimUpdate()
	{
	}

	private void ShotUpdate()
	{
		if (m_ballRb == null)
		{
			return;
		}
		if (m_ballRb.velocity.sqrMagnitude < 0.5f)
		{
			if (!oneShotLevel)
			{
				StartCoroutine(FadeInOut(1f));
				StartCoroutine(SwitchToAimCamera());
			}
			if (m_golferAnimator != null)
			{
				m_golferAnimator.avatar = m_golferAvatar;
			}
		}
		if (m_ballRb.velocity.sqrMagnitude < 10f && m_windForceOnBall != null)
		{
			m_windForceOnBall.enabled = false;
		}
	}

	private void HasShot(Vector3 boost)
	{
		StartCoroutine(CustomShotRoutine(boost));
		if (oneShotLevel)
		{
			if (m_golfBall != null)
			{
				m_golfBall.OnShoot -= HasShot;
				m_golfBall.OnAimUpdate -= AnimatedGolfer;
				UnityEngine.Object.Destroy(m_golfBall);
			}
			if (m_shooter != null)
			{
				UnityEngine.Object.Destroy(m_shooter);
			}
			StartCoroutine(PlaceNewBallForOneShot());
		}
	}

	private IEnumerator PlaceNewBallForOneShot()
	{
		yield return new WaitForSeconds(0.8f);
		if (m_ballPrefab != null)
		{
			m_golfBall = UnityEngine.Object.Instantiate(m_ballPrefab, m_ballStartPos, Quaternion.identity).GetComponentInChildren<GolfBallController>();
			GetGolfBallComponents();
			SwitchControllerToEquippedClub();
			if (m_golferAnimator != null)
			{
				m_golferAnimator.avatar = m_golferAvatar;
				m_golferAnimator.SetBool("Idle", value: true);
			}
		}
	}

	private IEnumerator CustomShotRoutine(Vector3 boost)
	{
		if (m_windForceOnBall != null)
		{
			m_windForceOnBall.enabled = true;
		}
		if (m_ballRb != null)
		{
			m_ballRb.isKinematic = true;
		}
		if (m_golferAnimator != null)
		{
			m_golferAnimator.avatar = null;
			m_golferAnimator.SetBool("Idle", value: false);
		}
		yield return new WaitForSeconds(m_shootDelayFromAnimation);
		if (m_ballRb != null)
		{
			m_ballRb.isKinematic = false;
		}
		if (m_shooter != null)
		{
			m_shooter.OnShoot(boost);
		}
		if (m_clubs != null && (int)currentClub < m_clubs.Count && m_clubs[(int)currentClub] != null)
		{
			m_clubs[(int)currentClub].OnShootEffect?.Invoke();
		}
		currentState = RealisticGolfStates.SHOT;
		if (!oneShotLevel)
		{
			if (GoalDistance() > 20f)
			{
				StartCoroutine(SwitchToFollowCamera());
			}
			else
			{
				SmallShotAndPutt();
			}
		}
	}

	private void SwitchCamPriority(int aimCam, int followCam)
	{
		if (m_aimCamera != null)
		{
			m_aimCamera.Priority = aimCam;
		}
		if (m_followShotCamera != null)
		{
			m_followShotCamera.Priority = followCam;
		}
	}

	private void OnDestroy()
	{
		if (m_golfBall != null)
		{
			m_golfBall.OnShoot -= HasShot;
			m_golfBall.OnAimUpdate -= AnimatedGolfer;
		}
	}

	private IEnumerator SwitchToFollowCamera()
	{
		if (aimCamComposer != null)
		{
			aimCamComposer.m_DeadZoneHeight = 1f;
		}
		if (m_aimCamera != null)
		{
			m_aimCamera.m_LookAt = null;
		}
		yield return new WaitForSeconds(1.5f);
		SwitchCamPriority(1, 10);
	}

	private void SmallShotAndPutt()
	{
		if (aimCamComposer != null)
		{
			aimCamComposer.m_DeadZoneHeight = 1f;
		}
		if (m_aimCamera != null)
		{
			m_aimCamera.m_Follow = null;
		}
	}

	private IEnumerator SwitchToAimCamera()
	{
		if (m_aimCamera != null)
		{
			m_aimCamera.m_Follow = null;
			m_aimCamera.m_LookAt = null;
		}
		yield return new WaitForSeconds(0.3f);
		PlaceGolferNextToBall();
		if (m_golfBall != null && m_flag != null)
		{
			m_golfBall.transform.LookAt(new Vector3(m_flag.position.x, m_golfBall.transform.position.y, m_flag.position.z));
			if (m_aimCamera != null)
			{
				m_aimCamera.m_LookAt = m_golfBall.transform;
				m_aimCamera.m_Follow = m_golfBall.transform;
			}
		}
		SwitchCamPriority(10, 1);
		currentState = RealisticGolfStates.AIM;
		if (GoalDistance() < 20f && m_goalPin != null)
		{
			m_goalPin.SetActive(value: false);
		}
		if (aimCamComposer != null)
		{
			aimCamComposer.m_DeadZoneHeight = 0f;
		}
		StartCoroutine(FadeInOut(0f));
	}

	private float GoalDistance()
	{
		if (m_golfBall != null && m_flag != null)
		{
			return Vector3.Distance(m_golfBall.transform.position, m_flag.transform.position);
		}
		return 0f;
	}

	private void SwitchControllerToEquippedClub()
	{
		if (m_clubs == null || (int)currentClub >= m_clubs.Count || m_clubs[(int)currentClub] == null)
		{
			return;
		}
		Club club = m_clubs[(int)currentClub];
		if (m_shooter != null)
		{
			m_shooter.fullShootVelocity = club.strength;
			m_shooter.pitch = club.pitch;
		}
		if (m_golfBall != null)
		{
			m_golfBall.Scale = club.arrowSize;
		}
		if (m_useClubUI)
		{
			for (int i = 0; i < m_clubs.Count; i++)
			{
				if (m_clubs[i] == null)
				{
					continue;
				}
				if (i == (int)currentClub)
				{
					if (m_clubs[i].iconInScene != null)
					{
						m_clubs[i].iconInScene.SetAsEquipped();
					}
					if (m_clubs[i].clubInScene != null)
					{
						m_clubs[i].clubInScene.SetActive(value: true);
					}
				}
				else
				{
					if (m_clubs[i].iconInScene != null)
					{
						m_clubs[i].iconInScene.SetAsUnequipped();
					}
					if (m_clubs[i].clubInScene != null)
					{
						m_clubs[i].clubInScene.SetActive(value: false);
					}
				}
			}
		}
		if (m_shootArrow != null)
		{
			m_shootArrow.colorMax = club.clubColor;
			m_shootArrow.colorMin = Color.Lerp(club.clubColor, Color.white, 0.5f);
		}
	}

	public void ButtonSwitchCurrentClub()
	{
		if (currentClub == ClubStates.MAIN)
		{
			currentClub = ClubStates.SECONDARY;
		}
		else if (currentClub == ClubStates.SECONDARY)
		{
			currentClub = ClubStates.MAIN;
		}
		SwitchControllerToEquippedClub();
	}

	public void SwitchClubOnTrigger(int newClubIndex)
	{
		if (m_clubs == null || newClubIndex < 0 || newClubIndex >= m_clubs.Count || m_clubs[newClubIndex] == null)
		{
			return;
		}
		Club club = m_clubs[newClubIndex];
		if (m_shooter != null)
		{
			m_shooter.fullShootVelocity = club.strength;
			m_shooter.pitch = club.pitch;
		}
		if (m_golfBall != null)
		{
			m_golfBall.Scale = club.arrowSize;
		}
		if (m_clubs.Count > 0 && m_clubs[0] != null && m_clubs[0].iconInScene != null)
		{
			m_clubs[0].iconInScene.SetIcon(club.clubImage, club.clubColor);
		}
		if (club.clubInScene != null)
		{
			club.clubInScene.SetActive(value: true);
		}
		if (m_shootArrow != null)
		{
			m_shootArrow.colorMax = club.clubColor;
			m_shootArrow.colorMin = Color.Lerp(club.clubColor, Color.white, 0.5f);
		}
	}

	private IEnumerator FadeInOut(float endValue)
	{
		if (m_fadeToBlack == null)
		{
			yield break;
		}
		float startAlpha = m_fadeToBlack.color.a;
		float t = 0f;
		while (m_fadeToBlack.color.a != endValue)
		{
			Color color = m_fadeToBlack.color;
			m_fadeToBlack.color = new Color(color.r, color.g, color.b, Mathf.Lerp(startAlpha, endValue, t));
			t += Time.deltaTime * 8f;
			yield return new WaitForEndOfFrame();
		}
	}

	public RealisticGolfManager()
	{
		m_useClubUI = true;
		m_shootDelayFromAnimation = 0.4f;
		m_rotationOffset = 90f;
		nextShotVelocityMax = 0.2f;
	}
}
