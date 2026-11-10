using System;
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

	public float ComputerOnVolume = 0.5f;

	public AudioSource ComputerOnSource;

	private void SetDarknessMaterialColor(Color c)
	{
		if (DarknessRenderer == null)
			return;
		DarknessRenderer.color = new Color(0f, 0f, 0f, 1f);
		if (DarknessRenderer.material != null)
			DarknessRenderer.material.color = c;
	}

	private void Awake()
	{
		if (DarknessRenderer != null)
		{
			SetDarknessMaterialColor(DarknessLight);
			DarknessRenderer.enabled = false;
		}

		if (SaveGame.IsIntroAnimationComplete)
		{
			if (button != null)
				button.color = buttonOffColor;
			if (buttonBase != null)
				buttonBase.color = buttonBaseOffColor;
			if (darkScreen != null)
				darkScreen.enabled = true;
			if (face != null)
				face.SetBool("On", true);
			if (introComputer != null)
				introComputer.enabled = true;
			gameObject.SetActive(false);
		}
		else if (tunnel != null)
		{
			tunnel.OnStartAtLogo -= Tunnel_OnAtLogo;
			tunnel.OnStartAtLogo += Tunnel_OnAtLogo;
		}
	}

	private void Tunnel_OnAtLogo()
	{
		if (tunnel != null)
			tunnel.OnStartAtLogo -= Tunnel_OnAtLogo;
		StartCoroutine(IntroRoutine());
	}

	private IEnumerator IntroRoutine()
	{
		if (DarknessRenderer != null)
		{
			SetDarknessMaterialColor(DarknessLight);
			DarknessRenderer.enabled = false;
		}
		if (introComputer != null)
			introComputer.enabled = false;
		if (face != null)
			face.SetInteger("BlinkState", 0);
		if (door != null)
		{
			door.canOpen = false;
			door.UpdateStatus();
		}

		bool isWaitingForDoor = true;
		if (door != null && door.openOrOpening)
		{
			isWaitingForDoor = false;
		}
		else
		{
			bool atEndOfTunnel = tunnel == null;
			Action onEndOfTunnel = () => atEndOfTunnel = true;
			if (!atEndOfTunnel && tunnel != null)
				tunnel.OnAtEndOfTunnel += onEndOfTunnel;
			if (save != null)
				save.gameObject.SetActive(false);

			yield return new WaitForSeconds(5f);

			if (DarknessRenderer != null)
			{
				SetDarknessMaterialColor(DarknessLight);
				DarknessRenderer.enabled = true;
				StartCoroutine(pTween.To(1.5f, t =>
				{
					SetDarknessMaterialColor(Color.Lerp(DarknessLight, DarknessDark, t));
				}));
			}

			while (!atEndOfTunnel)
			{
				yield return null;
			}
			if (tunnel != null)
				tunnel.OnAtEndOfTunnel -= onEndOfTunnel;

			yield return new WaitForSeconds(0.8f);

			if (button != null)
				button.color = buttonOffColor;
			if (buttonBase != null)
				buttonBase.color = buttonBaseOffColor;
			if (buttonParticles != null)
				buttonParticles.Play();
			if (TurnOnLightClip != null)
				TurnOnLightClip.Play(transform.position, 0f);

			yield return new WaitForSeconds(0.05f);

			if (topRightParticles != null)
				topRightParticles.Play();
			if (buttonParticles != null)
				buttonParticles.Play();

			yield return new WaitForSeconds(0.05f);

			if (ComputerOnSource != null)
			{
				ComputerOnSource.volume = 0f;
				ComputerOnSource.Play();
				StartCoroutine(pTween.To(0.5f, v =>
				{
					if (ComputerOnSource != null)
					{
						ComputerOnSource.volume = Mathf.Lerp(0f, ComputerOnVolume, v);
						ComputerOnSource.pitch = Mathf.Lerp(0.5f, 1f, v);
					}
				}));
			}
			if (topLeftParticles != null)
				topLeftParticles.Play();
			if (buttonParticles != null)
				buttonParticles.Play();

			if (DarknessRenderer != null)
			{
				DarknessRenderer.enabled = true;
				StartCoroutine(pTween.To(0.0475f, t =>
				{
					SetDarknessMaterialColor(Color.Lerp(DarknessDark, DarknessLight, t));
				}));
			}

			yield return new WaitForSeconds(0.25f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessLight, DarknessDark, t));
			}));
			yield return new WaitForSeconds(0.1f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessDark, DarknessLight, t));
			}));
			yield return new WaitForSeconds(0.1f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessLight, DarknessDark, t));
			}));
			yield return new WaitForSeconds(0.05f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessDark, DarknessLight, t));
			}));
			yield return new WaitForSeconds(0.05f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessLight, DarknessDark, t));
			}));
			yield return new WaitForSeconds(0.05f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessDark, DarknessLight, t));
			}));
			yield return new WaitForSeconds(0.3f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessLight, DarknessDark, t));
			}));
			yield return new WaitForSeconds(0.05f);

			StartCoroutine(pTween.To(0.0475f, t =>
			{
				SetDarknessMaterialColor(Color.Lerp(DarknessDark, DarknessLight, t));
			}));
			yield return new WaitForSeconds(0.15f);

			if (topRightParticles != null)
				topRightParticles.Play();
			if (topLeftParticles != null)
				topLeftParticles.Play();

			yield return new WaitForSeconds(0.5f);

			if (DarknessRenderer != null)
			{
				SetDarknessMaterialColor(DarknessLight);
				DarknessRenderer.enabled = false;
			}
			if (darkScreen != null)
				darkScreen.enabled = false;
			if (face != null)
				face.SetBool("On", true);
			if (StaticNoiseClip != null)
				StaticNoiseClip.Play(transform.position, 0f);

			yield return new WaitForSeconds(0.1f);

			if (face != null)
			{
				face.SetBool("On", false);
				face.SetInteger("BlinkState", 0);
			}
			yield return new WaitForSeconds(0.6f);
			if (face != null)
			{
				face.SetBool("On", true);
				face.SetInteger("BlinkState", 1);
			}

			if (speechbubble != null)
			{
				bool didInterrupt = false;
				bool isWaitingForSpeech = true;
				StartCoroutine(speechbubble.HandleHit(
					() => didInterrupt = true,
					() => isWaitingForSpeech = false,
					null));
				yield return new WaitUntil(() => !isWaitingForSpeech);

				float maxWait = Time.time + 2f;
				yield return new WaitUntil(() => Time.time > maxWait || didInterrupt);

				if (!didInterrupt)
				{
					speechbubble.Interrupt();
					yield return new WaitForSeconds(0.4f);
				}

				bool isWaitingForInterrupt = true;
				isWaitingForSpeech = true;
				StartCoroutine(speechbubble.HandleHit(
					() => isWaitingForInterrupt = false,
					() => isWaitingForSpeech = false,
					null));
				yield return new WaitForSeconds(0.2f);
				yield return new WaitUntil(() => !isWaitingForSpeech);
			}

			if (ComputerOnSource != null)
			{
				StartCoroutine(pTween.To(0.5f, v =>
				{
					if (ComputerOnSource != null)
					{
						ComputerOnSource.volume = Mathf.Lerp(ComputerOnVolume, 0f, v);
						ComputerOnSource.pitch = Mathf.Lerp(1f, 0.5f, v);
					}
				}).Then(() =>
				{
					if (ComputerOnSource != null)
						ComputerOnSource.Stop();
				}));
			}

			if (door != null)
			{
				door.OnOpen += () => isWaitingForDoor = false;
				door.canOpen = true;
				door.UpdateStatus();
			}
			else
			{
				isWaitingForDoor = false;
			}
		}

		if (introComputer != null)
			introComputer.enabled = true;
		if (darkScreen != null)
			darkScreen.enabled = true;
		if (DarknessRenderer != null)
		{
			SetDarknessMaterialColor(DarknessLight);
			DarknessRenderer.enabled = false;
		}

		while (isWaitingForDoor)
		{
			yield return null;
		}

		if (save != null)
			save.gameObject.SetActive(true);
		SaveGame.IsIntroAnimationComplete = true;
		yield return new WaitForSeconds(0.3f);
		SaveGame.Save(false);
	}
}
