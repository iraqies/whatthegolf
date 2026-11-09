using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
	public IntroTunnelInOverworld tunnel;

	public List<SpriteRenderer> backgrounds;

	public List<SpriteRenderer> darkOverlays;

	public Color bgnormalColor;

	public Color bgdarkColor;

	public SaveSpot save;

	public SpriteRenderer hallwayOverlay;

	public SpriteRenderer button;

	public SpriteRenderer buttonBase;

	public Color buttonOffColor;

	public Color buttonBaseOffColor;

	public SpriteRenderer darkScreen;

	public ShowSpeechbubbleOnHit speechbubble;

	public Animator face;

	public OverworldButton2D door;

	public ParticleSystem buttonParticles;

	public ParticleSystem topRightParticles;

	public ParticleSystem topLeftParticles;

	public Color DarknessDark;

	public Color DarknessLight;

	public SpriteRenderer DarknessRenderer;

	public IntroComputer introComputer;

	public AudioClipSettings TurnOnLightClip;

	public AudioClipSettings StaticNoiseClip;

	public float ComputerOnVolume;

	public AudioSource ComputerOnSource;

	private bool waitForEndOfTunnel;

	private bool waitForDoorOpen;

	private bool inIntroAnimation;

	private bool _buttonTriggered;

	private bool IsFirstDoorOpen()
	{
		if (door != null && door.openOrOpening)
			return true;
		var idComp = door != null ? door.GetComponent<OverworldID>() : null;
		if (idComp != null && !string.IsNullOrEmpty(idComp.ID))
			return SaveGame.GetIsDoorOpen(idComp.ID);
		return SaveGame.GetIsDoorOpen("ZNC37");
	}

	private void Awake()
	{
		if (DarknessRenderer != null)
			DarknessRenderer.enabled = false;

		if (SaveGame.IsIntroAnimationComplete && IsFirstDoorOpen())
		{
			if (button != null)
				button.color = buttonOffColor;
			if (buttonBase != null)
				buttonBase.color = buttonBaseOffColor;
			if (darkScreen != null)
				darkScreen.enabled = false;
			if (face != null)
				face.SetBool("On", true);
			if (introComputer != null)
				introComputer.enabled = true;
			gameObject.SetActive(false);
		}
		else if (tunnel != null)
		{
			tunnel.OnStartAtLogo += Tunnel_OnAtLogo;
		}
	}

	private void Start()
	{
		if (SaveGame.IsIntroAnimationComplete && !IsFirstDoorOpen() && !inIntroAnimation)
		{
			SetupDirectButtonTrigger();
		}
	}

	private void SetupDirectButtonTrigger()
	{
		if (button != null)
		{
			var col = button.GetComponent<CircleCollider2D>();
			if (col == null)
			{
				col = button.gameObject.AddComponent<CircleCollider2D>();
				col.radius = 0.7f;
				col.isTrigger = false;
			}
		}
		if (door != null)
		{
			door.canOpen = false;
			door.UpdateStatus();
		}
		if (introComputer != null)
			introComputer.enabled = false;
		if (save != null)
			save.gameObject.SetActive(false);
	}

	private void FixedUpdate()
	{
		if (inIntroAnimation || _buttonTriggered)
			return;
		if (IsFirstDoorOpen())
			return;
		if (button != null && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			float dist = Vector2.Distance(OverworldBallManager.Instance.Ball.transform.position, button.transform.position);
			if (dist < 1.1f)
			{
				_buttonTriggered = true;
				waitForEndOfTunnel = false;
				StartCoroutine(IntroRoutine(true));
			}
		}
	}

	private void Tunnel_OnAtLogo()
	{
		if (tunnel != null)
			tunnel.OnStartAtLogo -= Tunnel_OnAtLogo;
		_buttonTriggered = true;
		StartCoroutine(IntroRoutine(false));
	}

	private IEnumerator IntroRoutine()
	{
		return IntroRoutine(false);
	}

	private IEnumerator IntroRoutine(bool skipTunnelWait)
	{
		if (DarknessRenderer != null)
			DarknessRenderer.enabled = false;
		inIntroAnimation = true;
		if (introComputer != null)
			introComputer.enabled = false;
		if (face != null)
			face.SetInteger(" BlinkState", 0);
		if (door != null)
		{
			door.canOpen = false;
			door.UpdateStatus();
		}

		if (!skipTunnelWait && tunnel != null)
		{
			waitForEndOfTunnel = true;
			tunnel.OnAtEndOfTunnel += Tunnel_OnAtEndOfTunnel;
		}
		else
		{
			waitForEndOfTunnel = false;
		}

		if (save != null)
			save.gameObject.SetActive(false);

		while (waitForEndOfTunnel)
		{
			yield return null;
		}

		if (!skipTunnelWait)
			yield return new WaitForSeconds(0.8f);

		if (button != null)
			button.color = buttonOffColor;
		if (buttonBase != null)
			buttonBase.color = buttonBaseOffColor;
		if (buttonParticles != null)
			buttonParticles.Play();
		if (TurnOnLightClip != null && AudioManager.Instance != null)
			TurnOnLightClip.Play(AudioManager.Instance.sfx, transform.position, 0f);

		yield return new WaitForSeconds(1f);

		if (DarknessRenderer != null)
		{
			DarknessRenderer.color = DarknessDark;
			DarknessRenderer.enabled = true;
		}
		if (topRightParticles != null)
			topRightParticles.Play();
		if (StaticNoiseClip != null && AudioManager.Instance != null)
			StaticNoiseClip.Play(AudioManager.Instance.sfx, transform.position, 0f);

		yield return new WaitForSeconds(0.1f);

		if (DarknessRenderer != null)
			DarknessRenderer.enabled = false;

		yield return new WaitForSeconds(0.4f);

		if (DarknessRenderer != null)
			DarknessRenderer.enabled = true;
		if (topLeftParticles != null)
			topLeftParticles.Play();
		if (StaticNoiseClip != null && AudioManager.Instance != null)
			StaticNoiseClip.Play(AudioManager.Instance.sfx, transform.position, 0f);

		yield return new WaitForSeconds(0.05f);

		if (DarknessRenderer != null)
			DarknessRenderer.color = DarknessLight;

		yield return new WaitForSeconds(0.15f);

		if (DarknessRenderer != null)
			DarknessRenderer.enabled = false;

		yield return new WaitForSeconds(0.05f);

		if (DarknessRenderer != null)
			DarknessRenderer.enabled = true;
		if (StaticNoiseClip != null && AudioManager.Instance != null)
			StaticNoiseClip.Play(AudioManager.Instance.sfx, transform.position, 0f);
		if (ComputerOnSource != null)
		{
			ComputerOnSource.volume = 0f;
			ComputerOnSource.Play();
			StartCoroutine(pTween.To(0.25f, t =>
			{
				if (ComputerOnSource != null)
				{
					ComputerOnSource.volume = t * ComputerOnVolume;
					ComputerOnSource.pitch = Mathf.Lerp(0.5f, 1f, t);
				}
			}));
		}

		yield return new WaitForSeconds(0.1f);

		if (darkScreen != null)
			darkScreen.enabled = false;
		if (hallwayOverlay != null)
			hallwayOverlay.enabled = false;
		if (face != null)
			face.SetBool("On", true);

		yield return new WaitForSeconds(1.2f);

		if (face != null)
		{
			face.SetTrigger("Surprised");
			face.SetInteger(" BlinkState", 1);
		}

		if (speechbubble != null)
		{
			yield return StartCoroutine(speechbubble.HandleHit());
			yield return StartCoroutine(speechbubble.HandleHit());
		}

		if (ComputerOnSource != null)
		{
			StartCoroutine(pTween.To(0.25f, t =>
			{
				if (ComputerOnSource != null)
				{
					float inv = 1f - t;
					ComputerOnSource.volume = inv * ComputerOnVolume;
					ComputerOnSource.pitch = Mathf.Lerp(0.5f, 1f, inv);
				}
			}));
		}

		if (door != null)
		{
			door.canOpen = true;
			door.UpdateStatus();
			waitForDoorOpen = true;
			door.OnOpen += Door_OnOpen;
		}
		else
		{
			waitForDoorOpen = false;
		}

		if (introComputer != null)
			introComputer.enabled = true;
		if (hallwayOverlay != null)
			hallwayOverlay.enabled = true;

		while (waitForDoorOpen)
		{
			yield return null;
		}

		if (save != null)
			save.gameObject.SetActive(true);
		SaveGame.IsIntroAnimationComplete = true;
		SaveGame.Save(false);
		inIntroAnimation = false;
	}

	private void Door_OnOpen()
	{
		if (door != null)
			door.OnOpen -= Door_OnOpen;
		waitForDoorOpen = false;
	}

	private void Tunnel_OnAtEndOfTunnel()
	{
		if (tunnel != null)
			tunnel.OnAtEndOfTunnel -= Tunnel_OnAtEndOfTunnel;
		waitForEndOfTunnel = false;
	}
}
