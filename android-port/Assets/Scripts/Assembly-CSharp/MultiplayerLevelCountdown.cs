using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class MultiplayerLevelCountdown : MonoBehaviour
{
	[SerializeField]
	private MultiplayerLobby Lobby;

	[SerializeField]
	private Transform AnimatorsParent;

	public ClipSettingsCollection BlobPopInClip;

	public float OutroTime = 0.3f;

	public float CircleStartRadius = 150f;

	public float AnimationSpeed = 1f;

	private CountdownAnimator[] animators;

	private bool beepPlayed;

	private List<SphericalGrayscaleEffect> greyScale = new List<SphericalGrayscaleEffect>();

	private List<Camera> newCams = new List<Camera>();

	private TimeControl timeControl;

	private QuickMenu quickMenu;

	private List<MultiplayerConfiguration.PlayerInfo> players;

	private void Start()
	{
		if (AnimatorsParent != null)
		{
			animators = AnimatorsParent.GetComponentsInChildren<CountdownAnimator>(true);
			if (animators != null)
			{
				for (int i = 0; i < animators.Length; i++)
				{
					if (animators[i] != null)
					{
						animators[i].OnBeep += OnBeep;
						animators[i].OnLastBeep += OnLastBeep;
					}
				}
			}
		}
		if (Lobby != null)
		{
			Lobby.OnLevelStarted += OnLevelStarted;
		}
	}

	private void OnBeep()
	{
		beepPlayed = true;
	}

	private void OnLastBeep()
	{
		if (players != null)
		{
			for (int i = 0; i < players.Count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = players[i];
				if (p == null || p.Controllers == null)
				{
					continue;
				}
				for (int j = 0; j < p.Controllers.Count; j++)
				{
					if (p.Controllers[j] != null)
					{
						p.Controllers[j].BlockAiming = false;
					}
				}
			}
		}
		StartCoroutine(pTween.ToRealTime(OutroTime, 0f, 1f, t =>
		{
			Time.timeScale = TweenFunctions.EaseIn(t);
			if (greyScale != null)
			{
				for (int i = 0; i < greyScale.Count; i++)
				{
					SphericalGrayscaleEffect gs = greyScale[i];
					if (gs != null && gs.Radii != null)
					{
						for (int j = 0; j < gs.Radii.Count; j++)
						{
							gs.Radii[j] = Mathf.Lerp(CircleStartRadius, Screen.width, t);
						}
						gs.Intensity = Mathf.MoveTowards(gs.Intensity, 0f, Time.unscaledDeltaTime * 50f);
						gs.OutlineSize = Mathf.MoveTowards(gs.OutlineSize, 0f, Time.unscaledDeltaTime * 100f);
					}
				}
			}
		}).Then(() =>
		{
			if (greyScale != null)
			{
				for (int i = 0; i < greyScale.Count; i++)
				{
					if (greyScale[i] != null)
					{
						Object.Destroy(greyScale[i]);
					}
				}
				greyScale.Clear();
			}
			if (newCams != null)
			{
				for (int i = 0; i < newCams.Count; i++)
				{
					if (newCams[i] != null)
					{
						Object.Destroy(newCams[i].gameObject);
					}
				}
				newCams.Clear();
			}
			Time.timeScale = 1f;
			if (quickMenu != null)
			{
				quickMenu.RemoveBlocker(this);
			}
			if (timeControl != null)
			{
				timeControl.enabled = true;
			}
		}));
	}

	private void OnLevelStarted(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (Object.FindObjectOfType<TurnBasedMultiplayerController>() == null)
		{
			StartCoroutine(Countdown(players));
		}
	}

	private void SetupGreyScaleCameraForPlayer(MultiplayerConfiguration.PlayerInfo player, bool addOffset)
	{
		if (player == null || player.Cam == null || player.Cam.MainCamera == null)
		{
			return;
		}
		GameObject camGo = player.Cam.MainCamera.gameObject;
		if (!camGo.TryGetComponent<SphericalGrayscaleEffect>(out SphericalGrayscaleEffect gs))
		{
			gs = camGo.AddComponent<SphericalGrayscaleEffect>();
			greyScale.Add(gs);
		}
		if (gs.Positions == null)
		{
			gs.Positions = new List<MultiplayerConfiguration.PlayerInfo>();
		}
		if (gs.Radii == null)
		{
			gs.Radii = new List<float>();
		}
		gs.Positions.Add(player);
		gs.Radii.Add(0f);
		if (addOffset)
		{
			gs.AddOffset(100f);
		}
	}

	private IEnumerator Countdown(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		this.players = players;
		quickMenu = Object.FindObjectOfType<QuickMenu>();
		if (quickMenu != null)
		{
			quickMenu.AddBlocker(this);
		}
		timeControl = Object.FindObjectOfType<TimeControl>();
		if (timeControl != null)
		{
			timeControl.enabled = false;
		}
		Time.timeScale = 0f;
		if (players != null)
		{
			for (int i = 0; i < players.Count; i++)
			{
				SetupGreyScaleCameraForPlayer(players[i], i > 0);
				if (BlobPopInClip != null)
				{
					BlobPopInClip.Play(null, Vector3.zero, 1f, 1f);
				}
				yield return new WaitForSecondsRealtime(0.25f);
			}
		}
		if (animators != null && animators.Length > 0)
		{
			CountdownAnimator chosen = animators[Random.Range(0, animators.Length)];
			if (chosen != null)
			{
				chosen.gameObject.SetActive(true);
				if (chosen.Animator != null)
				{
					chosen.Animator.speed = AnimationSpeed;
				}
				yield return new WaitForSecondsRealtime(1.5f);
				chosen.gameObject.SetActive(false);
			}
		}
		OnLastBeep();
	}
}
