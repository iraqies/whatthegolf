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
	private Vector3 _initialBulgeScale = new Vector3(0.15410566f, 0.15410566f, 0.15410566f);
	private bool _capturedBulgeScale;
	private bool _preparedBulgeRenderer;
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

	private void EnsureBulgeRendererReady()
	{
		if (ballBulge == null)
			return;
		if (!_capturedBulgeScale && ballBulge.localScale.sqrMagnitude > 1e-6f)
		{
			_initialBulgeScale = ballBulge.localScale;
			_capturedBulgeScale = true;
		}
		ballBulge.gameObject.SetActive(true);
		var sr = ballBulge.GetComponentInChildren<SpriteRenderer>(true);
		if (sr != null)
		{
			sr.gameObject.SetActive(true);
			sr.enabled = true;
			if (!_preparedBulgeRenderer)
			{
				_preparedBulgeRenderer = true;
				if (sr.drawMode != SpriteDrawMode.Simple)
				{
					Vector2 targetSize = sr.size;
					sr.drawMode = SpriteDrawMode.Simple;
					float spriteWorldSize = (sr.sprite != null && sr.sprite.pixelsPerUnit > 0f && sr.sprite.rect.width > 0f)
						? (sr.sprite.rect.width / sr.sprite.pixelsPerUnit)
						: 0.5f;
					float factor = spriteWorldSize > 0.001f ? (targetSize.x / spriteWorldSize) : 20f;
					Vector3 ls = sr.transform.localScale;
					if (ls.sqrMagnitude < 1e-6f)
						ls = new Vector3(0.8633f, 0.8633f, 0.8633f);
					sr.transform.localScale = new Vector3(ls.x * factor, ls.y * factor, 1f);
				}
				Vector3 lp = sr.transform.localPosition;
				sr.transform.localPosition = new Vector3(lp.x, lp.y, 0f);
			}
		}
	}

	private void CaptureAndHideBulges()
	{
		EnsureBulgeRendererReady();
		if (ballBulge != null)
			ballBulge.localScale = Vector3.zero;
		foreach (var tr in GetComponentsInChildren<Transform>(true))
		{
			if (tr != null && tr.name == "MarioShortcutPipeEntryNorth (2)")
			{
				var sr = tr.GetComponent<SpriteRenderer>();
				if (sr != null && sr.sortingOrder < 200)
					sr.sortingOrder = 235;
			}
		}
	}

	private void Awake()
	{
		CaptureAndHideBulges();
	}

	public void Init(bool _startAtLogo = false)
	{
		startAtLogo = _startAtLogo;
		EnsureBulgeRendererReady();
		ball = GetBall();
		if (ball != null)
		{
			List<Transform> initialPath = startAtLogo ? pathFromLogo : pathToLogo;
			if (initialPath != null && initialPath.Count > 0 && initialPath[0] != null)
				ball.transform.position = initialPath[0].position;
			var col = ball.GetComponent<Collider2D>();
			if (col != null)
				col.isTrigger = true;
			ball.Hide();
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
		EnsureBulgeRendererReady();
		Vector3 bulgeStartScale = _initialBulgeScale;
		if (ballBulge != null)
			ballBulge.localScale = bulgeStartScale;

		if (followCamera != null)
			followCamera.isInPipeIntro = true;
		ball = GetBall();
		Collider2D ballCol = ball != null ? ball.GetComponent<Collider2D>() : null;
		if (ballCol != null)
			ballCol.isTrigger = true;
		if (ball != null)
		{
			if (ball.rigidBody != null)
				ball.rigidBody.simulated = false;
			ball.Hide();
		}
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

		lastPipeIndex = 0;
		if (!startAtLogo && pathToLogo != null && pathToLogo.Count > 0 && tweenTimeToLogo > 0f)
		{
			Animator logoAnim = GetComponentInChildren<Animator>(true);
			if (logoAnim != null)
				logoAnim.SetBool("QuickSplash", false);
			StartCoroutine(pTween.To(tweenTimeToLogo, t =>
			{
				SetPositionOnPath(pathToLogo, TweenFunctions.EaseIn(t), i =>
				{
					Vector3 curScale = ballBulge != null ? ballBulge.localScale : bulgeStartScale;
					if (i == 1)
					{
						if (ball != null)
							ball.Show();
						if (SFX_OnPopOut != null)
							SFX_OnPopOut.Play(null, Vector3.zero, 1f, 1f);
						StartCoroutine(pTween.ToRealTime(0.05f, pt =>
						{
							if (ballBulge != null)
								ballBulge.localScale = Vector3.Lerp(curScale, Vector3.zero, Mathf.Clamp01(pt));
						}));
					}
					else
					{
						if (ball != null)
							ball.Hide();
						StartCoroutine(pTween.ToRealTime(0.05f, pt =>
						{
							if (ballBulge != null)
								ballBulge.localScale = Vector3.Lerp(curScale, bulgeStartScale, Mathf.Clamp01(pt));
						}));
						if (i == 2 && SFX_OnPopIn != null)
						{
							SFX_OnPopIn.Play(null, Vector3.zero, 1f, 1f);
						}
						else if (i >= 2 && SFX_OnPipeTurn != null && AudioManager.Instance != null)
						{
							SFX_OnPipeTurn.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
						}
					}
				}, true);
			}));

			float waitBeforeLogo = Mathf.Max(0.1f, tweenTimeToLogo - 2.5f);
			yield return new WaitForSeconds(waitBeforeLogo);

			while (OnABitBeforeLogo != null && !OnABitBeforeLogo())
				yield return null;

			if (logoAnim != null)
				logoAnim.SetTrigger("Splash");

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

		EnsureBulgeRendererReady();
		if (ballBulge != null)
			ballBulge.localScale = bulgeStartScale;
		if (ball != null)
			ball.Hide();
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
			if (t > 0.1f && !startedMusic)
			{
				if (wwiseStateAfterIntro != 0 && AudioManager.Instance != null && AudioManager.Instance.music != null)
					AudioManager.Instance.music.SetState(wwiseStateAfterIntro, false, null, false);
				startedMusic = true;
			}
			SetPositionOnPath(pathFromLogo, TweenFunctions.EaseOut(t), i =>
			{
				Vector3 curScale = ballBulge != null ? ballBulge.localScale : bulgeStartScale;
				if (i == 2)
				{
					if (ball != null)
						ball.Show();
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
					if (ball != null)
						ball.Hide();
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

		if (srcOnMove != null)
			srcOnMove.Stop();
		if (OnCompleted != null)
			OnCompleted();
		yield return new WaitForSeconds(0.1f);

		Vector3 bulgeEndScale = ballBulge != null ? ballBulge.localScale : bulgeStartScale;
		StartCoroutine(pTween.ToRealTime(0.1f, t =>
		{
			if (ballBulge != null)
				ballBulge.localScale = Vector3.Lerp(bulgeEndScale, Vector3.zero, Mathf.Clamp01(t));
		}));
		m_OnAtEndOfTunnel?.Invoke();
		if (ball != null)
			ball.Show();
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
		if (followCamera != null)
			followCamera.isInPipeIntro = false;

		yield return StartCoroutine(pTween.ToRealTime(0.8f, t =>
		{
			float ct = Mathf.Clamp01(t);
			if (ball != null)
			{
				ball.transform.position = Vector3.Lerp(shootStart, shootEnd, ct);
				if (centerCameraOnBallDuringShootOut && cameraEndPosition != null)
				{
					Vector3 bpos = ball.transform.position;
					Vector3 cpos = cameraEndPosition.position;
					SetCameraCenter(new Vector3(cpos.x, bpos.y, bpos.z));
				}
			}
		}));

		if (RecoilFromHittingTarget)
		{
			yield return StartCoroutine(pTween.ToRealTime(0.6f, t =>
			{
				float ct = Mathf.Clamp01(TweenFunctions.EaseOut(t));
				if (ball != null)
					ball.transform.position = Vector3.Lerp(shootEnd, shootEnd + new Vector3(-0.3f, -1.8f, 0f), ct);
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
						ballBulge.position = new Vector3(pos.x, pos.y, 0f);
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
			Transform ft = followCamera.GetFollowTarget();
			if (ft != null)
			{
				Vector3 fcur = ft.position;
				ft.position = new Vector3(target.x, target.y, fcur.z);
			}
		}
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.cameraTarget != null)
		{
			Vector3 ct = OverworldManager2d.Instance.cameraTarget.position;
			OverworldManager2d.Instance.cameraTarget.position = new Vector3(target.x, target.y, ct.z);
		}
	}
}
