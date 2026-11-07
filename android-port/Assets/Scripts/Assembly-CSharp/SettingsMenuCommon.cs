using UnityEngine;

public abstract class SettingsMenuCommon : MonoBehaviour
{
	[SerializeField]
	private SettingsMenu.Location ValidLocations;

	public bool isHighlighted;

	[SerializeField]
	private GameObject Parent;

	[SerializeField]
	private GameObject highlightPanel;

	public SettingsMenu settingsMenu;

	protected bool isInitialized;

	public bool IsEnabled { get; set; }

	public virtual void Init(SettingsMenu settings)
	{
	}

	public void EnableByLocation(SettingsMenu.Location location)
	{
	}

	protected void TryDestroy(bool active)
	{
	}

	public virtual void SetIsHighlighted(bool active)
	{
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
		return 0f;
	}
}
