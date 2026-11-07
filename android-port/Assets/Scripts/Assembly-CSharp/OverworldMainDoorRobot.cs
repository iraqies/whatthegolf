using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldMainDoorRobot : MonoBehaviour
{
	public enum State
	{
		Closed = 0,
		Open = 1,
		Completed = 2
	}

	public LevelData bossLevel;

	public string bossLevelID;

	public string bossLevelName;

	public bool hasLevels;

	public Action OnCompleted;

	[CompilerGenerated]
	private Action m_OnIsReady;

	[CompilerGenerated]
	private Action m_OnPlateChanged;

	[CompilerGenerated]
	private Action<OverworldMainDoorRobot> m_OnBallExitedAndIsExploding;

	[CompilerGenerated]
	private Action m_OnOpen;

	public Transmogrif transmogrif;

	public ShowSpeechbubbleOnHit speech;

	public List<OverworldMainDoorPlate> plates;

	public OverworldMainDoorButton button;

	public GameObject hintArrow;

	public Transform ballStartPosition;

	public GameObject normalBase;

	public GameObject normalColliders;

	public GameObject destroyedBase;

	public GameObject destroyedColliders;

	public List<ParticleSystem> particlesBeforeTakingOff;

	public Transform screenCenterTransform;

	public AudioSource srcBootingUp;

	public ClipSettingsCollection sfxShootOutBall;

	public ClipSettingsCollection sfxFirstButtonOn;

	public ClipSettingsCollection sfxFinalButtonOn;

	public ClipSettingsCollection explosionBuildupSFX;

	private readonly string saveFormatUnlockedPlate;

	private readonly string saveFormatCompleted;

	[CompilerGenerated]
	private Action<OverworldMainDoorRobot> m_OnExitedCable;

	public string notificationId;

	private Tilemap tileMap;

	private OverworldCamera overworldCamera;

	private OverworldBall2D currentBall;

	public Animator AnimatorFace;

	public Animator AnimatorDoor;

	public Explosion2D Explosion;

	public Explosion2D[] ExplosionsSmall;

	public State state;

	private OverworldManager2d overworldManager;

	private OverworldID overworldID;

	private float lastActivationTime;

	private float activationCooldown;

	private UnlockAchievement achievement;

	private bool currentlyCheating;

	private float cheatUnlockTimer;

	public bool IsInitialized { get; private set; }

	public event Action OnIsReady
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnPlateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<OverworldMainDoorRobot> OnBallExitedAndIsExploding
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnOpen
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<OverworldMainDoorRobot> OnExitedCable
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnValidate()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public void Initialize(OverworldManager2d overworldManager, Tilemap tilemap)
	{
	}

	private bool CanBeOpened()
	{
		return false;
	}

	private IEnumerator ButtonRoutine(OverworldMainDoorPlate plate, bool isLastPlate)
	{
		return null;
	}

	private void OnHitActiveButton(OverworldBall2D ball)
	{
	}

	private void Change(State newState, bool forceChange = false)
	{
	}

	private IEnumerator StartLevelRoutine()
	{
		return null;
	}

	private void FadeOut(AudioSource audioSource, float duration)
	{
	}

	public bool IsCompleted()
	{
		return false;
	}

	public void OpenDoor()
	{
	}

	public IEnumerator Explode(bool didComplete, float delayBeforeShake = 1.8f, float delayBeforeExplosion = 2.2f)
	{
		return null;
	}

	public void SetCompleted()
	{
	}

	private IEnumerator CheatingRoutine()
	{
		return null;
	}

	public void OnMouseDown()
	{
	}

	public void OnMouseExit()
	{
	}

	public void OnMouseUp()
	{
	}
}
