using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OverworldTeleportMenu : MonoBehaviour
{
	[SerializeField] private RectTransform _mainPanel;
	private List<AdventureButton> _teleportButtons = new List<AdventureButton>();
	private bool _initialized;
	private Coroutine closeCR;
	private int activeTeleportButton = -1;

	private OverworldLevelData _campaignData => OverworldManager2d.HasInstance && OverworldManager2d.Instance != null ? OverworldManager2d.Instance.overworldLevelData : null;

	private void InitializeIfNot()
	{
		if (_initialized) return;
		PopulateMainCampaignSections();
		_initialized = true;
	}

	private void PopulateMainCampaignSections()
	{
		var data = _campaignData;
		if (data == null || data.Sections == null) return;
		data.CacheCurrentState();
		_teleportButtons = GetComponentsInChildren<AdventureButton>(true).ToList();
		var saveQuit = FindObjectOfType<SaveAndLoadPositionOnQuit>();
		HubSection curHubSection = OverworldManager2d.HasInstance && OverworldManager2d.Instance != null ? OverworldManager2d.Instance.FindCurrentHubSection() : null;
		bool hasCurSection = curHubSection != null;

		activeTeleportButton = -1;
		int firstAvailable = -1;

		for (int i = 0; i < data.Sections.Count && i < _teleportButtons.Count; i++)
		{
			int idx = i;
			var sec = data.Sections[i];
			var btn = _teleportButtons[i];
			if (sec == null || btn == null) continue;
			btn.gameObject.SetActive(true);
			btn.campaignTag = sec.name;
			btn.adventureImage = sec.image;
			btn.hasNumberPanel = false;
			btn.adventureTitleID = sec.name;
			btn.progress = sec.completionPercentage;
			btn.IsActive = false;
			btn.onClick.RemoveAllListeners();
			if (sec.isAvailable)
			{
				btn.isLocked = false;
				btn.onClick.AddListener(() => Teleport(sec, idx));
				if (firstAvailable < 0)
					firstAvailable = idx;
				if (hasCurSection && saveQuit != null)
				{
					var hsList = saveQuit.HubSectionFromLevelSection(sec);
					if (hsList != null && hsList.Contains(curHubSection))
						activeTeleportButton = idx;
				}
			}
			else
			{
				btn.isLocked = true;
			}
		}

		if (activeTeleportButton < 0)
			activeTeleportButton = firstAvailable;
		if (activeTeleportButton >= 0 && activeTeleportButton < _teleportButtons.Count && _teleportButtons[activeTeleportButton] != null)
			_teleportButtons[activeTeleportButton].IsActive = true;

		for (int i = data.Sections.Count; i < _teleportButtons.Count; i++)
		{
			if (_teleportButtons[i] != null)
				_teleportButtons[i].gameObject.SetActive(false);
		}
	}

	private void Teleport(OverworldLevelSection section, int index)
	{
		if (section == null) return;
		if (!string.IsNullOrEmpty(section.saveSpotId))
			SaveGame.SavePosition = section.saveSpotId;
		SaveGame.SavePositionShape = section.ballShape;
		var saveQuit = FindObjectOfType<SaveAndLoadPositionOnQuit>();
		if (saveQuit != null)
			saveQuit.TeleportBallToCurrentSpot();

		if (activeTeleportButton >= 0 && activeTeleportButton < _teleportButtons.Count && _teleportButtons[activeTeleportButton] != null)
			_teleportButtons[activeTeleportButton].IsActive = false;
		activeTeleportButton = index;
		if (activeTeleportButton >= 0 && activeTeleportButton < _teleportButtons.Count && _teleportButtons[activeTeleportButton] != null)
			_teleportButtons[activeTeleportButton].IsActive = true;

		if (Menu.Menu.Exists || Menu.Menu.Instance != null)
			_ = Menu.Menu.Instance.CloseAsync();

		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null)
		{
			var ui = OverworldManager2d.Instance.ui;
			if (ui.ExitOverworldButton != null)
				ui.ExitOverworldButton.gameObject.SetActive(true);
		}
	}

	private void RefreshButtons()
	{
		var data = _campaignData;
		if (data == null || data.Sections == null) return;
		data.CacheCurrentState();
		var saveQuit = FindObjectOfType<SaveAndLoadPositionOnQuit>();
		HubSection curHubSection = OverworldManager2d.HasInstance && OverworldManager2d.Instance != null ? OverworldManager2d.Instance.FindCurrentHubSection() : null;
		bool hasCurSection = curHubSection != null;
		int detectedActive = -1;

		for (int i = 0; i < data.Sections.Count && i < _teleportButtons.Count; i++)
		{
			int idx = i;
			var sec = data.Sections[i];
			var btn = _teleportButtons[i];
			if (sec == null || btn == null) continue;
			btn.number = sec.name;
			btn.progress = sec.completionPercentage;
			btn.onClick.RemoveAllListeners();
			btn.IsActive = false;
			if (sec.isAvailable)
			{
				btn.isLocked = false;
				btn.onClick.AddListener(() => Teleport(sec, idx));
				if (hasCurSection && saveQuit != null)
				{
					var hsList = saveQuit.HubSectionFromLevelSection(sec);
					if (hsList != null && hsList.Contains(curHubSection))
						detectedActive = idx;
				}
			}
			else
			{
				btn.isLocked = true;
			}
		}

		if (detectedActive >= 0)
			activeTeleportButton = detectedActive;
		if (activeTeleportButton >= 0 && activeTeleportButton < _teleportButtons.Count && _teleportButtons[activeTeleportButton] != null)
			_teleportButtons[activeTeleportButton].IsActive = true;
	}

	public void Show()
	{
		gameObject.SetActive(true);
		InitializeIfNot();
		RefreshButtons();
	}

	private void OnDisable() { }
}
