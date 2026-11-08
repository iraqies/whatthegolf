using System.Collections.Generic;
using UnityEngine;

public class OverworldTeleportMenu : MonoBehaviour
{
	[SerializeField] private RectTransform _mainPanel;
	private List<AdventureButton> _teleportButtons = new List<AdventureButton>();
	private bool _initialized;
	private Coroutine closeCR;
	private int activeTeleportButton;

	private OverworldLevelData _campaignData => OverworldManager2d.HasInstance ? OverworldManager2d.Instance.overworldLevelData : null;

	private void InitializeIfNot()
	{
		if (_initialized) return;
		_initialized = true;
		_teleportButtons = new List<AdventureButton>(GetComponentsInChildren<AdventureButton>(true));
		PopulateMainCampaignSections();
	}

	private void PopulateMainCampaignSections()
	{
		var data = _campaignData;
		if (data == null || data.sections == null) return;
		for (int i = 0; i < _teleportButtons.Count && i < data.sections.Count; i++)
		{
			int idx = i;
			var sec = data.sections[i];
			var btn = _teleportButtons[i];
			if (btn == null) continue;
			btn.gameObject.SetActive(true);
			btn.number = (i + 1).ToString();
			btn.onClick.RemoveAllListeners();
			btn.onClick.AddListener(() => Teleport(sec, idx));
		}
	}

	private void Teleport(OverworldLevelSection section, int index)
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null && section != null)
		{
			var goals = OverworldManager2d.Instance.goals;
			if (goals != null && index >= 0 && index < goals.Count && goals[index] != null)
				OverworldManager2d.Instance.ball.transform.position = goals[index].transform.position + Vector3.down * 1.5f;
		}
		if (Menu.Menu.HasInstance) Menu.Menu.Instance.Close();
	}

	private void RefreshButtons() => InitializeIfNot();

	public void Show()
	{
		gameObject.SetActive(true);
		InitializeIfNot();
	}

	private void OnDisable() { }
}
