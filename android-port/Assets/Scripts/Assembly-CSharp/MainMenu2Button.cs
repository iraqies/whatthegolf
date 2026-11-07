using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenu2Button : Button
{
	private UINavigationHelper _navigationHelper;

	public UnityEvent onSelected;

	protected override void Start()
	{
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	public override Selectable FindSelectableOnDown()
	{
		return null;
	}
}
