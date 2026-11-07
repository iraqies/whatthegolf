using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class TurnBasedMultiplayerController : MonoBehaviour
{
	public float SwitchPlayersThreshold;

	public float CameraSpeed;

	public HorseJudge HorseJudge;

	public ClipSettingsCollection ExplosionClip;

	public ParticleSystem ExplosionParticles;

	public FinalLevel FinalLevel;

	private int currentPlayerIndex;

	private bool waitForPlayer;

	private List<GolfBallController> players;

	private List<SuperGolfShooter> shooters;

	private List<Rigidbody> shooterRigidbodies;

	private List<int> skipPlayers;

	private float timer;

	private GameObject cameraFollow;

	private CBFollow followCam;

	private bool somebodyDied;

	private void Awake()
	{
	}

	private void OnMultiplayerSetup(MultiplayerLevelInfo info)
	{
	}

	private void OnPlayerHit(SuperGolfShooter player)
	{
	}

	private void OnDeath(SuperGolfShooter obj)
	{
	}

	private void Controller_OnShoot(GolfBallController controller, Vector3 boost)
	{
	}

	private IEnumerator SetPlayer(int activePlayer)
	{
		return null;
	}

	private bool SetCameraTarget(Transform follow)
	{
		return false;
	}
}
