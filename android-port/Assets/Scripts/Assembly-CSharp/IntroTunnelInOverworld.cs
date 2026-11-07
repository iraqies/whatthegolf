using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class IntroTunnelInOverworld : MonoBehaviour
{
	[CompilerGenerated]
	private Action m_OnAtLogo;

	[CompilerGenerated]
	private Action m_OnStartAtLogo;

	[CompilerGenerated]
	private Action m_OnAtEndOfTunnel;

	[CompilerGenerated]
	private Action m_OnPreAtLogo;

	public Transform ballBulge;

	public Transform cameraEndPosition;

	public ParticleSystem particlesOnShootOut;

	public List<IntroSinger> singers;

	public List<Transform> pathFromLogo;

	public List<Transform> pathToLogo;

	public Transform buttonPosition;

	public Transform logoBox;

	public AudioSource srcOnMove;

	public uint wwiseStateAfterIntro;

	public AudioClip sfxOnShootOut;

	public ClipSettingsCollection SFX_OnPipeTurn;

	public ClipSettingsCollection SFX_OnPopOut;

	public ClipSettingsCollection SFX_OnPopIn;

	public AudioClip sfxOnLogoPipeJump;

	public AudioClip sfxOnLogoPipeLand;

	public AudioMixerSnapshot introSnapshot;

	public AudioMixerSnapshot snapshotAfterIntro;

	public float tweenTime;

	public float tweenTimeAtLogo;

	public float tweenTimeToLogo;

	public float shootoutVelocity;

	public float moveLoopVolume;

	public bool ActivateColliderEarly;

	public bool IsSnowIntro;

	public bool RecoilFromHittingTarget;

	[SerializeField]
	private bool centerCameraOnBallDuringShootOut;

	public CBOrthographicFollow2D followCamera;

	private int lastPipeIndex;

	private OverworldBall2D ball;

	private bool startAtLogo;

	private bool startedMusic;

	private bool didListen;

	public UnityEvent OnLogoBreak;

	public event Action OnAtLogo
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

	public event Action OnStartAtLogo
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

	public event Action OnAtEndOfTunnel
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

	public event Action OnPreAtLogo
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

	public void Init(bool _startAtLogo = false)
	{
	}

	public OverworldBall2D GetBall()
	{
		return null;
	}

	private IEnumerator ListenForNewBalls()
	{
		return null;
	}

	public IEnumerator PlayAnimationRoutine(Action OnCompleted, Func<bool> OnReachedLogo, Func<bool> OnABitBeforeLogo)
	{
		return null;
	}

	private void Instance_OnNewBall1(Transmogrif.BALLSHAPES obj)
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES obj)
	{
	}

	private void SetPositionOnPath(List<Transform> path, float pct, Action<int> OnChangedIndex, bool lerpCameraX = false)
	{
	}

	private void SetCameraCenter(Vector3 target)
	{
	}
}
