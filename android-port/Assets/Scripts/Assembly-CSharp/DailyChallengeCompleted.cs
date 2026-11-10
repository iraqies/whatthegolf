using System.Collections;
using System.Threading.Tasks;
using Audio;
using Menu;
using TMPro;
using UnityEngine;

public class DailyChallengeCompleted : MonoBehaviour
{
	public TextMeshProUGUI StrokesText;

	public TextMeshProUGUI RankText;

	public bool closing;

	public ClipSettingsCollection completeSFX;

	public ParticleSystem completeParticles;

	public async void Show(int strokes, bool scoreOk)
	{
		closing = false;
		if (ProcessDeepLink.Instance != null)
		{
			ProcessDeepLink.Instance.OnDeepLinkActivatedEvent -= OnDeepLinkActivated;
			ProcessDeepLink.Instance.OnDeepLinkActivatedEvent += OnDeepLinkActivated;
		}
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null)
		{
			OverworldManager2d.Instance.ui.DisableUI();
		}

		await Task.Delay(500);
		if (this == null || gameObject == null) return;

		gameObject.SetActive(true);
		if (UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Register();

		StartCoroutine(pTween.To(0.3f, t =>
		{
			float s = Mathf.Clamp01(TweenFunctions.EaseOut(t));
			transform.localScale = Vector3.Lerp(Vector3.one * 0.05f, Vector3.one, s);
		}));

		if (StrokesText != null)
			StrokesText.SetLocalizedText(strokes.ToString());
		if (RankText != null)
		{
			RankText.text = "...";
			RankText.gameObject.SetActive(!scoreOk);
		}
		if (completeParticles != null)
			completeParticles.Play();
		if (completeSFX != null && AudioManager.Instance != null)
			completeSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0.7f);

		StartCoroutine(ShowParticles());
		StartCoroutine(WaitForClose());
	}

	private void OnDeepLinkActivated()
	{
		Close();
	}

	private IEnumerator ShowParticles()
	{
		if (completeParticles != null)
			completeParticles.Play();
		yield return new WaitForSeconds(3f);
		if (completeParticles != null)
			completeParticles.Stop();
	}

	public IEnumerator WaitForClose()
	{
		yield return new WaitForSeconds(1f);
		while (!closing)
		{
			if (InputHelper.GetAllPlayerButtonConfirm() || InputHelper.GetAllPlayerButtonCancel() || InputHelper.TouchedOrMouseClicked())
			{
				Close();
			}
			yield return null;
		}
		yield return StartCoroutine(pTween.To(0.3f, t =>
		{
			float s = Mathf.Clamp01(TweenFunctions.EaseIn(t));
			transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * 0.05f, s);
		}));
		if (UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Deregister();
		if (gameObject != null)
			gameObject.SetActive(false);
	}

	private void OnDisable()
	{
		if (gameObject != null && gameObject.activeSelf)
			gameObject.SetActive(false);
	}

	public void Close()
	{
		if (ProcessDeepLink.Instance != null)
		{
			ProcessDeepLink.Instance.OnDeepLinkActivatedEvent -= OnDeepLinkActivated;
		}
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
			if (OverworldManager2d.Instance.ui != null)
				OverworldManager2d.Instance.ui.EnableUI();
		}
		closing = true;
	}
}
