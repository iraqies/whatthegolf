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
		animator = GetComponent<Animator>();
	}

	private void OnEnable()
	{
		if (SelectedOnStart)
		{
			OnClick();
		}
	}

	private void OnDisable()
	{
		if (OtherTabs != null)
		{
			for (int i = 0; i < OtherTabs.Length; i++)
			{
				if (OtherTabs[i] != null)
				{
					OtherTabs[i].Deselect();
				}
			}
		}
		Deselect();
	}

	public void OnPointerEnter()
	{
		if (animator != null)
		{
			animator.SetBool("Hover", value: true);
		}
		if (OtherTabs == null)
		{
			return;
		}
		for (int i = 0; i < OtherTabs.Length; i++)
		{
			if (OtherTabs[i] != null && OtherTabs[i].animator != null)
			{
				OtherTabs[i].animator.SetBool("Hover", value: false);
			}
		}
	}

	public void OnPointerExit()
	{
		if (animator != null)
		{
			animator.SetBool("Hover", value: false);
		}
	}

	public void OnClick()
	{
		if (animator != null)
		{
			animator.SetTrigger("Clicked");
		}
		Select();
		if (OtherTabs != null)
		{
			for (int i = 0; i < OtherTabs.Length; i++)
			{
				if (OtherTabs[i] != null)
				{
					OtherTabs[i].Deselect();
				}
			}
		}
		if (PanelImage != null)
		{
			PanelImage.color = PanelColor;
		}
		if (YourBestPanelImage != null)
		{
			YourBestPanelImage.color = YourBestPanelColor;
		}
	}

	public void Deselect()
	{
		if (animator == null)
		{
			animator = GetComponent<Animator>();
		}
		if (animator != null)
		{
			animator.SetBool("Selected", value: false);
		}
	}

	public void Select()
	{
		if (animator != null)
		{
			animator.SetBool("Selected", value: true);
		}
		if (highScoreList != null)
		{
			highScoreList.RefreshEntryColors(EntryColor);
		}
		if (ScrollbarImage != null)
		{
			ScrollbarImage.color = ScrollbarColor;
		}
	}
}
