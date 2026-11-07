using System.Text;
using Core;
using UnityEngine;
using UnityEngine.UI;

internal sealed class DebugOverlay : MonoBehaviour
{
	private static DebugOverlay s_Instance;

	private Canvas m_Canvas;

	private CanvasScaler m_CanvasScaler;

	private Text m_Text;

	private RectTransform m_TextTransform;

	private StringBuilder m_Builder;

	private string m_Version;

	private LevelData m_LevelData;

	private string m_ChallengeID;

	private string m_Language;

	private int m_SaveSlot;

	public static DebugOverlay Instance => null;

	public Canvas canvas => null;

	public CanvasScaler canvasScaler => null;

	public void Initialize()
	{
	}

	private void InitializeCanvas()
	{
	}

	private void InitializeText()
	{
	}

	public void UpdateText()
	{
	}

	private void OnLevelLoaded(LevelData levelData)
	{
	}

	private void OnChallengeSelected(string challengeId)
	{
	}

	private void OnLevelWillUnload()
	{
	}

	private void OnSaveSlotChanged()
	{
	}

	private void OnLanguageChanged(string value)
	{
	}

	private void OnMusicStateChanged(uint state)
	{
	}
}
