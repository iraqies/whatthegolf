using System;
using System.Collections;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : AddressableSingleton<CreditsMenu>
{
	public RectTransform ContainerTransform;

	public CanvasGroup CanvasGroup;

	public Animator CloseButtonAnimator;

	public ScrollRect CreditScrollRect;

	public TMP_Text CreditsLabel;

	public TextAsset Credits_Apple;

	public TextAsset Credits_Switch;

	public TextAsset Credits_Default;

	public TextAsset Credits_Playstation;

	private bool allowExit = true;

	protected Action backAction;

	public override void Initialize()
	{
		if (gameObject != null)
			gameObject.SetActive(false);
	}

	public void BackButtonClicked()
	{
		if (allowExit)
			Close();
	}

	private void Close()
	{
		if (gameObject != null && gameObject.activeInHierarchy)
			StartCoroutine(HideCreditsMenu());
		else
		{
			if (gameObject != null) gameObject.SetActive(false);
			backAction?.Invoke();
		}
	}

	private void Update()
	{
		if (allowExit && InputHelper.GetAllPlayerButtonCancel())
			Close();
	}

	private string GetCorrectText()
	{
		if (Credits_Default != null && !string.IsNullOrEmpty(Credits_Default.text))
			return Credits_Default.text;
		if (Credits_Apple != null && !string.IsNullOrEmpty(Credits_Apple.text))
			return Credits_Apple.text;
		if (Credits_Switch != null && !string.IsNullOrEmpty(Credits_Switch.text))
			return Credits_Switch.text;
		if (Credits_Playstation != null && !string.IsNullOrEmpty(Credits_Playstation.text))
			return Credits_Playstation.text;
		return "WHAT THE GOLF?\nBy Triband";
	}

	public void ShowCredits(Action closeAction)
	{
		backAction = closeAction;
		allowExit = true;
		gameObject.SetActive(true);
		if (CreditsLabel != null)
			CreditsLabel.text = GetCorrectText();
		if (CreditScrollRect != null)
			CreditScrollRect.verticalNormalizedPosition = 1f;
		if (CanvasGroup != null)
		{
			CanvasGroup.alpha = 1f;
			CanvasGroup.interactable = true;
			CanvasGroup.blocksRaycasts = true;
		}
	}

	public IEnumerator HideCreditsMenu()
	{
		allowExit = false;
		if (CanvasGroup != null)
		{
			CanvasGroup.interactable = false;
			CanvasGroup.blocksRaycasts = false;
		}
		yield return new WaitForSecondsRealtime(0.15f);
		gameObject.SetActive(false);
		backAction?.Invoke();
	}
}
