using UnityEngine.EventSystems;

public class MainMenuGameCenterAccessPointButton : MainMenu2Button
{
	private bool _wasPresentingGameCenter;

	private EventSystem _eventSystem;

	private bool IsGameCenterPopupOpen => false;

	public void Show()
	{
	}

	private void Update()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void OnSubmit(BaseEventData eventData)
	{
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public override void OnDeselect(BaseEventData eventData)
	{
	}
}
