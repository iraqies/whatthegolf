using UnityEngine;

public abstract class SettingsMenuCommon : MonoBehaviour
{
	[SerializeField]
	private SettingsMenu.Location ValidLocations = SettingsMenu.Location.Hub | SettingsMenu.Location.Overworld | SettingsMenu.Location.Level;

	public bool isHighlighted;

	[SerializeField]
	private GameObject Parent;

	[SerializeField]
	private GameObject highlightPanel;

	public SettingsMenu settingsMenu;

	protected bool isInitialized;

	public bool IsEnabled { get; set; } = true;

	public virtual void Init(SettingsMenu settings)
	{
		settingsMenu = settings;
		if (settings != null && settings.allOrderUI != null && !settings.allOrderUI.Contains(this))
			settings.allOrderUI.Add(this);
		if (highlightPanel != null)
			highlightPanel.SetActive(false);
		isInitialized = true;
	}

	public void EnableByLocation(SettingsMenu.Location location)
	{
		var targetGo = Parent != null ? Parent : gameObject;
		bool valid = ValidLocations == 0 || (ValidLocations & location) != 0;
		if (targetGo != null)
			targetGo.SetActive(valid);
		IsEnabled = valid;
	}

	protected void TryDestroy(bool active)
	{
		var targetGo = Parent != null ? Parent : gameObject;
		if (!active)
		{
			IsEnabled = false;
			if (targetGo != null)
				targetGo.SetActive(false);
		}
		else
		{
			IsEnabled = true;
			if (targetGo != null)
				targetGo.SetActive(true);
		}
	}

	public virtual void SetIsHighlighted(bool active)
	{
		isHighlighted = active;
		if (highlightPanel != null)
			highlightPanel.SetActive(active);
	}

	public virtual void HandleController()
	{
	}

	public virtual void Refresh()
	{
	}

	public virtual void ResetValues()
	{
	}

	public float GetSiblingIndex()
	{
		var t = Parent != null ? Parent.transform : transform;
		return t.GetSiblingIndex();
	}
}
