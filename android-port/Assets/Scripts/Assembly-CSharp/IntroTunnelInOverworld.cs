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
	public uint wwiseStateAfterIntro = 1462071333u;
	public AudioClip sfxOnShootOut;
	public ClipSettingsCollection SFX_OnPipeTurn;
	public ClipSettingsCollection SFX_OnPopOut;
	public ClipSettingsCollection SFX_OnPopIn;
	public AudioClip sfxOnLogoPipeJump;
	public AudioClip sfxOnLogoPipeLand;
	public AudioMixerSnapshot introSnapshot;
	public AudioMixerSnapshot snapshotAfterIntro;
	public float tweenTime = 2f;
	public float tweenTimeAtLogo;
	public float tweenTimeToLogo = 2f;
	public float shootoutVelocity = 100f;
	public float moveLoopVolume = 0.5f;
	public bool ActivateColliderEarly;
	public bool IsSnowIntro;
	public bool RecoilFromHittingTarget = true;
	[SerializeField]
	private bool centerCameraOnBallDuringShootOut = true;
	public CBOrthographicFollow2D followCamera;
	private int lastPipeIndex;
	private OverworldBall2D ball;
	private bool startAtLogo;
	private bool startedMusic;
	private bool didListen;
	public UnityEvent OnLogoBreak = new UnityEvent();

	public event Action OnAtLogo
	{
		[CompilerGenerated]
		add => m_OnAtLogo = (Action)Delegate.Combine(m_OnAtLogo, value);
		[CompilerGenerated]
		remove => m_OnAtLogo = (Action)Delegate.Remove(m_OnAtLogo, value);
	}

	public event Action OnStartAtLogo
	{
		[CompilerGenerated]
		add => m_OnStartAtLogo = (Action)Delegate.Combine(m_OnStartAtLogo, value);
		[CompilerGenerated]
		remove => m_OnStartAtLogo = (Action)Delegate.Remove(m_OnStartAtLogo, value);
	}

	public event Action OnAtEndOfTunnel
	{
		[CompilerGenerated]
		add => m_OnAtEndOfTunnel = (Action)Delegate.Combine(m_OnAtEndOfTunnel, value);
		[CompilerGenerated]
		remove => m_OnAtEndOfTunnel = (Action)Delegate.Remove(m_OnAtEndOfTunnel, value);
	}

	public event Action OnPreAtLogo
	{
		[CompilerGenerated]
		add => m_OnPreAtLogo = (Action)Delegate.Combine(m_OnPreAtLogo, value);
		[CompilerGenerated]
		remove => m_OnPreAtLogo = (Action)Delegate.Remove(m_OnPreAtLogo, value);
	}

	public void Init(bool _startAtLogo = false)
	{
		startAtLogo = _startAtLogo || tweenTimeToLogo <= 0.01f;
		if (followCamera != null)
			followCamera.isInPipeIntro = true;
		ball = GetBall();
		if (ball != null)
		{
			List<Transform> initialPath = startAtLogo ? pathFromLogo : pathToLogo;
			if (initialPath == null || initialPath.Count == 0)
				initialPath = pathFromLogo != null && pathFromLogo.Count > 0 ? pathFromLogo : pathToLogo;
			if (initialPath != null && initialPath.Count > 0 && initialPath[0] != null)
				ball.transform.position = initialPath[0].position;
			var col = ball.GetComponent<Collider2D>();
			if (col != null)
				col.isTrigger = true;
			SetCameraCenter(ball.transform.position);
		}
		StartCoroutine(ListenForNewBalls());
	}

	private OverworldBall2D GetBall()
	{
		if (ball == null || !ball.gameObject.scene.IsValid())
		{
			if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.gameObject.scene.IsValid())
				ball = OverworldBallManager.Instance.Ball;
			else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ball != null && OverworldManager2d.Instance.ball.gameObject.scene.IsValid())
				ball = OverworldManager2d.Instance.ball;
			else
				ball = FindObjectOfType<OverworldBall2D>();
		}
		return ball;
	}

	private IEnumerator ListenForNewBalls()
	{
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall1;
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall1;
		}
		yield break;
	}

	public IEnumerator PlayAnimationRoutine(Action OnCompleted, Func<bool> OnReachedLogo, Func<bool> OnABitBeforeLogo)
	{
		yield return null;

		if (followCamera != null)
			followCamera.isInPipeIntro = true;
		ball = GetBall();
		Collider2D ballCol = ball != null ? ball.GetComponent<Collider2D>() : null;
		if (ballCol != null)
			ballCol.isTrigger = true;
		if (ball != null && ball.rigidBody != null)
			ball.rigidBody.simulated = false;

		if (introSnapshot != null)
			introSnapshot.TransitionTo(0.1f);
		if (srcOnMove != null)
		{
			srcOnMove.volume = 0f;
			srcOnMove.loop = true;
			srcOnMove.Play();
		}
		gameObject.SetActive(true);
		StartCoroutine(pTween.To(0.2f, t =>
		{
			if (srcOnMove != null)
				srcOnMove.volume = t * moveLoopVolume;
		}));

		Vector3 bulgeStartScale = (ballBulge != null && ballBulge.localScale.sqrMagnitude > 1e-6f)
			? ballBulge.localScale
			: new Vector3(0.15410566f, 0.15410566f, 0.15410566f);
		if (ballBulge != null)
			ballBulge.localScale = bulgeStartScale;

		lastPipeIndex = 0;
		if (!startAtLogo && pathToLogo != null && pathToLogo.Count > 0 && tweenTimeToLogo > 0f)
		{
			float currentToLogoTime = 0f;
			StartCoroutine(pTween.To(tweenTimeToLogo, t =>
			{
				currentToLogoTime = t * tweenTimeToLogo;
				if (t > 0.1f && !startedMusic)
				{
					if (wwiseStateAfterIntro != 0 && AudioManager.Instance != null && AudioManager.Instance.music != null)
						AudioManager.Instance.music.SetState(wwiseStateAfterIntro, false, null, false);
					startedMusic = true;
				}
				SetPositionOnPath(pathToLogo, TweenFunctions.EaseOut(t), i =>
				{
					Vector3 curScale = ballBulge != null ? ballBulge.localScale : bulgeStartScale;
					if (i == 2)
					{
						if (SFX_OnPopOut != null)
							SFX_OnPopOut.Play(null, Vector3.zero, 1f, 1f);
						if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && AudioManager.Instance.rumbleManager.Explosion != null)
							AudioManager.Instance.rumbleManager.Explosion.Play(0, 1f);
						if (srcOnMove != null && srcOnMove.isPlaying)
							srcOnMove.Stop();
						if (particlesOnShootOut != null)
							particlesOnShootOut.Play();
						StartCoroutine(pTween.ToRealTime(0.05f, pt =>
						{
							if (ballBulge != null)
								ballBulge.localScale = Vector3.Lerp(curScale, Vector3.zero, Mathf.Clamp01(pt));
						}));
					}
					else
					{
						StartCoroutine(pTween.ToRealTime(0.05f, pt =>
						{
							if (ballBulge != null)
								ballBulge.localScale = Vector3.Lerp(curScale, bulgeStartScale, Mathf.Clamp01(pt));
						}));
						if (i == 3)
						{
							if (SFX_OnPopIn != null)
								SFX_OnPopIn.Play(null, Vector3.zero, 1f, 1f);
							if (srcOnMove != null && !srcOnMove.isPlaying)
								srcOnMove.Play();
						}
						else if (SFX_OnPipeTurn != null && AudioManager.Instance != null)
						{
							SFX_OnPipeTurn.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
						}
					}
				}, false);
			}));

			float targetWaitTime = Mathf.Max(0.1f, tweenTimeToLogo - 2.5f);
			while (currentToLogoTime < targetWaitTime)
				yield return null;

			while (OnABitBeforeLogo != null && !OnABitBeforeLogo())
				yield return null;

			yield return new WaitForSeconds(IsSnowIntro ? 0.1f : 1.5f);

			StartCoroutine(pTween.To(0.2f, t =>
			{
				if (ballBulge != null)
					ballBulge.localScale = Vector3.Lerp(bulgeStartScale, Vector3.zero, Mathf.Clamp01(t));
			}));
			OnLogoBreak?.Invoke();
			yield return new WaitForSeconds(1f);

			m_OnPreAtLogo?.Invoke();
			yield return null;

			while (OnReachedLogo != null && !OnReachedLogo())
			{
				SetPositionOnPath(pathToLogo, 1f, null, false);
				yield return null;
			}

			m_OnAtLogo?.Invoke();
			if (tweenTimeAtLogo > 0f)
				yield return new WaitForSeconds(tweenTimeAtLogo);

			StartCoroutine(pTween.To(0.2f, t =>
			{
				if (srcOnMove != null)
					srcOnMove.volume = (1f - t) * moveLoopVolume;
			}));
		}

		if (ballBulge != null)
			ballBulge.localScale = bulgeStartScale;
		if (srcOnMove != null)
		{
			if (!srcOnMove.isPlaying)
				srcOnMove.Play();
			StartCoroutine(pTween.To(0.2f, t =>
			{
				if (srcOnMove != null)
					srcOnMove.volume = t * moveLoopVolume;
			}));
		}

		m_OnStartAtLogo?.Invoke();
		lastPipeIndex = 0;
		yield return StartCoroutine(pTween.To(tweenTime, t =>
		{
			SetPositionOnPath(pathFromLogo, TweenFunctions.EaseIn(t), i =>
			{
				if (i >= 2)
				{
					if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && AudioManager.Instance.rumbleManager.SubtleBump != null)
						AudioManager.Instance.rumbleManager.SubtleBump.Play(0, 1f);
					if (SFX_OnPipeTurn != null && AudioManager.Instance != null)
						SFX_OnPipeTurn.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
				}
			}, true);
		}));

		if (srcOnMove != null)
			srcOnMove.Stop();
		yield return new WaitForSeconds(0.1f);

		Vector3 bulgeEndScale = ballBulge != null ? ballBulge.localScale : bulgeStartScale;
		StartCoroutine(pTween.ToRealTime(0.05f, t =>
		{
			if (ballBulge != null)
				ballBulge.localScale = Vector3.Lerp(bulgeEndScale, Vector3.zero, Mathf.Clamp01(t));
		}));
		m_OnAtEndOfTunnel?.Invoke();
		if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && AudioManager.Instance.rumbleManager.Explosion != null)
			AudioManager.Instance.rumbleManager.Explosion.Play(0, 1f);
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && sfxOnShootOut != null)
			AudioManager.Instance.sfx.PlaySimple(sfxOnShootOut, 1f, 1f, Vector3.zero);
		else if (SFX_OnPopOut != null)
			SFX_OnPopOut.Play(null, Vector3.zero, 1f, 1f);

		StartCoroutine(pTween.To(0.1f, t =>
		{
			if (srcOnMove != null)
				srcOnMove.volume = (1f - t) * moveLoopVolume;
		}));

		Vector3 shootStart = ball != null ? ball.transform.position : transform.position;
		Vector3 shootEnd = buttonPosition != null ? buttonPosition.position : shootStart;
		shootEnd.z = shootStart.z;

		if (ActivateColliderEarly && ball != null)
		{
			if (ball.rigidBody != null)
				ball.rigidBody.simulated = true;
			if (ballCol != null)
				ballCol.isTrigger = false;
			ball.SetColliders(true);
		}

		yield return StartCoroutine(pTween.ToRealTime(0.8f, t =>
		{
			float ct = Mathf.Clamp01(TweenFunctions.Linear(t));
			if (ball != null)
			{
				ball.transform.position = Vector3.Lerp(shootStart, shootEnd, ct);
				if (centerCameraOnBallDuringShootOut && cameraEndPosition != null)
				{
					Vector3 bpos = ball.transform.position;
					Vector3 cpos = cameraEndPosition.position;
					SetCameraCenter(new Vector3(cpos.x, bpos.y, bpos.z));
				}
				else
				{
					SetCameraCenter(ball.transform.position);
				}
			}
		}));

		if (RecoilFromHittingTarget)
		{
			yield return StartCoroutine(pTween.ToRealTime(0.6f, t =>
			{
				float ct = Mathf.Clamp01(TweenFunctions.EaseOut(t));
				if (ball != null)
				{
					ball.transform.position = Vector3.Lerp(shootEnd, shootEnd + new Vector3(-0.3f, -1.8f, 0f), ct);
					if (centerCameraOnBallDuringShootOut && cameraEndPosition != null)
					{
						Vector3 bpos = ball.transform.position;
						Vector3 cpos = cameraEndPosition.position;
						SetCameraCenter(new Vector3(cpos.x, bpos.y, bpos.z));
					}
				}
			}));
		}

		if (ballBulge != null)
			ballBulge.localScale = Vector3.zero;
		if (ball != null)
		{
			if (ball.rigidBody != null)
			{
				ball.rigidBody.isKinematic = false;
				ball.rigidBody.simulated = true;
				ball.rigidBody.velocity = Vector2.zero;
				ball.rigidBody.angularVelocity = 0f;
			}
			if (ballCol != null)
				ballCol.isTrigger = false;
			ball.SetColliders(true);
			ball.Show();
		}
		if (followCamera != null)
			followCamera.isInPipeIntro = false;
		if (OnCompleted != null)
			OnCompleted();
		yield return null;

		if (snapshotAfterIntro != null)
			snapshotAfterIntro.TransitionTo(1.5f);
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall1;
	}

	private void Instance_OnNewBall1(Transmogrif.BALLSHAPES obj)
	{
		if (OverworldBallManager.Instance != null)
			ball = OverworldBallManager.Instance.Ball;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES obj)
	{
		Instance_OnNewBall1(obj);
	}

	private void SetPositionOnPath(List<Transform> path, float pct, Action<int> OnChangedIndex, bool lerpCameraX = false)
	{
		if (path == null || path.Count == 0 || path[path.Count - 1] == null)
			return;
		Vector3 pos = path[path.Count - 1].position;
		float totalDist = 0f;
		for (int i = 0; i < path.Count - 1; i++)
		{
			if (path[i] != null && path[i + 1] != null)
				totalDist += Vector3.Distance(path[i + 1].position, path[i].position);
		}
		if (path.Count >= 2 && totalDist > 0.0001f)
		{
			float targetDist = pct * totalDist;
			float accum = 0f;
			for (int i = 0; i < path.Count - 1; i++)
			{
				if (path[i] == null || path[i + 1] == null)
					continue;
				float segDist = Vector3.Distance(path[i + 1].position, path[i].position);
				if (accum + segDist > targetDist)
				{
					int nextIdx = i + 1;
					float segPct = segDist > 0.0001f ? Mathf.Clamp01((targetDist - accum) / segDist) : 0f;
					pos = Vector3.Lerp(path[i].position, path[nextIdx].position, segPct);
					if (ballBulge != null)
						ballBulge.position = pos;
					if (OnChangedIndex != null && lastPipeIndex != nextIdx)
						OnChangedIndex(nextIdx);
					lastPipeIndex = nextIdx;
					break;
				}
				accum += segDist;
			}
		}
		if (ball != null)
			ball.transform.position = pos;
		if (lerpCameraX && cameraEndPosition != null)
		{
			float camT = TweenFunctions.SmootherStep(Mathf.Clamp01(pct * 3f - 0.5f));
			pos.x = Mathf.Lerp(pos.x, cameraEndPosition.position.x, camT);
		}
		SetCameraCenter(pos);
	}

	private void SetCameraCenter(Vector3 target)
	{
		if (followCamera != null)
		{
			Vector3 cur = followCamera.transform.position;
			followCamera.transform.position = new Vector3(target.x, target.y, cur.z);
			Transform followTarget = followCamera.GetFollowTarget();
			if (followTarget != null)
				followTarget.position = new Vector3(target.x, target.y, followTarget.position.z);
		}
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.cameraTarget != null)
		{
			Vector3 ct = OverworldManager2d.Instance.cameraTarget.position;
			OverworldManager2d.Instance.cameraTarget.position = new Vector3(target.x, target.y, ct.z);
		}
	}
}
