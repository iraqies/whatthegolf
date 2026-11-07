using System.Collections.Generic;
using UnityEngine;

public class OverworldTeleportMenu : MonoBehaviour
{
	[SerializeField]
	private RectTransform _mainPanel;

	private List<AdventureButton> _teleportButtons;

	private bool _initialized;

	private Coroutine closeCR;

	private int activeTeleportButton;

	private OverworldLevelData _campaignData => null;

	private void InitializeIfNot()
	{
	}

	private void PopulateMainCampaignSections()
	{
	}

	private void Teleport(OverworldLevelSection section, int index)
	{
	}

	private void RefreshButtons()
	{
	}

	public void Show()
	{
	}

	private void OnDisable()
	{
	}
}
