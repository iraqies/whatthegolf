using System;
using System.Threading.Tasks;
using UnityEngine;

public class CrossPromotionManager : MonoBehaviour
{
	public static readonly DateTimeOffset ClashLaunchDateLocalTime;

	private static readonly bool DebugEnabled;

	private static readonly bool DebugAlwaysForgetPopupShownState;

	[SerializeField]
	private UserCriteria userCriteria;

	[SerializeField]
	private Sprite clashLaunchPopupBannerSprite;

	[SerializeField]
	private Sprite carPopupBannerSprite;

	private Texture2D generatedQRCodeTexture;

	private Sprite generatedQRCodeSprite;

	public static bool HasPassedClashLaunchDate => false;

	private bool DoesPlatformRequireQRCode => false;

	private void Start()
	{
	}

	private bool IsInHub()
	{
		return false;
	}

	private bool ShouldShowClashReleasePopup()
	{
		return false;
	}

	private static bool IsOtherMenuOpen()
	{
		return false;
	}

	public void ShowClashPopup()
	{
	}

	public void ShowCarPopup()
	{
	}

	private Task ShowPopupAsync(string url, string textLocKey, Sprite popupBannerSprite)
	{
		return null;
	}

	private void MarkPopupAsSeen()
	{
	}

	private void EnableOverworldInteraction()
	{
	}

	private void DisableOverworldInteraction()
	{
	}

	private void CleanupGeneratedQRCodeAssets()
	{
	}

	private Sprite GenerateQRCodeSprite(string url)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
