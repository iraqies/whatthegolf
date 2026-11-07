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

	private bool allowExit;

	protected Action backAction;

	public void BackButtonClicked()
	{
	}

	private void Close()
	{
	}

	private void Update()
	{
	}

	private string GetCorrectText()
	{
		return null;
	}

	public void ShowCredits(Action closeAction)
	{
	}

	public IEnumerator HideCreditsMenu()
	{
		return null;
	}
}
