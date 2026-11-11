using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class TurnBasedMultiplayerController : MonoBehaviour
{
	public float SwitchPlayersThreshold = 1f;

	public float CameraSpeed = 1f;

	public HorseJudge HorseJudge;

	public ClipSettingsCollection ExplosionClip;

	public ParticleSystem ExplosionParticles;

	public FinalLevel FinalLevel;

	private int currentPlayerIndex;

	private bool waitForPlayer;

	private List<GolfBallController> players = new List<GolfBallController>();

	private List<SuperGolfShooter> shooters = new List<SuperGolfShooter>();

	private List<Rigidbody> shooterRigidbodies = new List<Rigidbody>();

	private List<int> skipPlayers = new List<int>();

	private float timer;

	private GameObject cameraFollow;

	private CBFollow followCam;

	private bool somebodyDied;

	private void Awake()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += OnMultiplayerSetup;
		}
	}

	private void OnMultiplayerSetup(MultiplayerLevelInfo info)
	{
		skipPlayers = new List<int>();
		if (CameraManager.Instance != null)
		{
			followCam = CameraManager.Instance.CurrentCameraBehavior as CBFollow;
		}
		cameraFollow = new GameObject("TurnBasedCameraFollow");
		cameraFollow.transform.SetParent(transform);
		players = new List<GolfBallController>();
		shooters = new List<SuperGolfShooter>();
		shooterRigidbodies = new List<Rigidbody>();
		if (info != null)
		{
			List<GolfBallController> all = info.GetAllControllers();
			if (all != null)
			{
				for (int i = 0; i < all.Count; i++)
				{
					GolfBallController ctrl = all[i];
					if (ctrl == null)
					{
						continue;
					}
					GolfBallController captured = ctrl;
					ctrl.OnShoot += b => Controller_OnShoot(captured, b);
					players.Add(ctrl);
					shooterRigidbodies.Add(ctrl.gameObject.GetComponent<Rigidbody>());
					SuperGolfShooter shooter = ctrl.gameObject.GetComponent<SuperGolfShooter>();
					shooters.Add(shooter);
					if (shooter != null)
					{
						shooter.OnPlayerDied += OnDeath;
						if (FinalLevel != null)
						{
							shooter.OnPlayerHit += OnPlayerHit;
						}
					}
				}
			}
		}
		if (players.Count > 0)
		{
			StartCoroutine(SetPlayer(0));
		}
	}

	private void OnPlayerHit(SuperGolfShooter player)
	{
		if (player != null && FinalLevel != null)
		{
			FinalLevel.PlayerHit(player.GolfBallController);
		}
	}

	private void OnDeath(SuperGolfShooter obj)
	{
		if (somebodyDied)
		{
			return;
		}
		somebodyDied = true;
		MultiplayerConfiguration config = Level.Instance != null ? Level.Instance.GetMultiplayerConfiguration() : null;
		if (config != null && config.Players != null && obj != null)
		{
			for (int i = 0; i < config.Players.Count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = config.Players[i];
				if (p != null && p.Controllers != null && p.Controllers.Contains(obj.GolfBallController))
				{
					StartCoroutine(DeathRoutine(obj));
					for (int j = 0; j < p.Controllers.Count; j++)
					{
						if (p.Controllers[j] != null)
						{
							p.Controllers[j].enabled = false;
						}
					}
				}
			}
		}
		timer = 10f;
		waitForPlayer = true;
	}

	private IEnumerator DeathRoutine(SuperGolfShooter shooter)
	{
		if (ExplosionClip != null)
		{
			ExplosionClip.Play(null, Vector3.zero, 1f, 1f);
		}
		if (ExplosionParticles != null && shooter != null)
		{
			ExplosionParticles.transform.position = shooter.transform.position;
			ExplosionParticles.Play();
		}
		yield return new WaitForSeconds(1f);
	}

	private void Controller_OnShoot(GolfBallController controller, Vector3 boost)
	{
		int nextIdx = (currentPlayerIndex + 1) % Mathf.Max(1, players.Count);
		StartCoroutine(SetPlayer(nextIdx));
	}

	private IEnumerator SetPlayer(int activePlayer)
	{
		if (players == null || players.Count == 0)
		{
			yield break;
		}
		while (skipPlayers.Contains(activePlayer) && skipPlayers.Count < players.Count)
		{
			activePlayer = (activePlayer + 1) % players.Count;
		}
		if (currentPlayerIndex >= 0 && currentPlayerIndex < players.Count && players[currentPlayerIndex] != null)
		{
			players[currentPlayerIndex].enabled = false;
		}
		if (HorseJudge != null && HorseJudge.Animator != null)
		{
			HorseJudge.Animator.SetTrigger("Switch");
		}
		if (cameraFollow != null && currentPlayerIndex < players.Count && activePlayer < players.Count && players[currentPlayerIndex] != null && players[activePlayer] != null)
		{
			SetCameraTarget(cameraFollow.transform);
			Vector3 startPos = players[currentPlayerIndex].transform.position;
			Vector3 endPos = players[activePlayer].transform.position;
			float dist = Vector3.Distance(startPos, endPos);
			float duration = Mathf.Clamp(dist / Mathf.Max(1f, CameraSpeed * 20f), 0.15f, 1f);
			yield return StartCoroutine(pTween.To(duration, 0f, 1f, t =>
			{
				if (cameraFollow != null)
				{
					cameraFollow.transform.position = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0f, 1f, Mathf.Clamp01(t)));
				}
			}));
		}
		currentPlayerIndex = activePlayer;
		if (currentPlayerIndex >= 0 && currentPlayerIndex < players.Count && players[currentPlayerIndex] != null)
		{
			SetCameraTarget(players[currentPlayerIndex].transform);
			players[currentPlayerIndex].enabled = true;
		}
	}

	private bool SetCameraTarget(Transform follow)
	{
		if (followCam != null)
		{
			followCam.FollowTarget = follow;
			return true;
		}
		return false;
	}
}
