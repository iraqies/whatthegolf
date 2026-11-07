using UnityEngine;
using UnityEngine.UI;

public class LeaderboardsTab : MonoBehaviour
{
	public HighscoreList highScoreList;

	public SVGImage PanelImage;

	public Image ScrollbarImage;

	public Color PanelColor;

	public Color EntryColor;

	public Color ScrollbarColor;

	public Color YourBestPanelColor;

	private Animator animator;

	public SVGImage YourBestPanelImage;

	public LeaderboardsTab[] OtherTabs;

	public bool SelectedOnStart;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerEnter()
	{
	}

	public void OnPointerExit()
	{
	}

	public void OnClick()
	{
	}

	public void Deselect()
	{
	}

	public void Select()
	{
	}
}
