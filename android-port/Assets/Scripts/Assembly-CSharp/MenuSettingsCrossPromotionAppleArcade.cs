using UnityEngine;

public class MenuSettingsCrossPromotionAppleArcade : MonoBehaviour
{
	private Texture2D generatedQRCodeTexture;

	private Sprite generatedQRCodeSprite;

	[SerializeField]
	private SettingsMenuCommon clashCrossPromotion;

	[SerializeField]
	private SettingsMenuCommon carCrossPromotion;

	private bool ShouldShowCrossPromotionSection => false;

	private bool ShouldShowClash => false;

	private bool DoesPlatformRequireQRCode => false;

	public void Init(SettingsMenu settingsMenu)
	{
	}

	public void UGUI_HandleWhatTheCarClicked()
	{
	}

	public void UGUI_HandleWhatTheClashClicked()
	{
	}

	private void HandleOpeningURL(string url, string textLocKey)
	{
	}

	private void Agree(string url)
	{
	}

	private void Disagree()
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

	public void RefreshDate()
	{
	}
}
