using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenu2Button : Button
{
	private UINavigationHelper _navigationHelper;
	public UnityEvent onSelected = new UnityEvent();

	protected override void Start()
	{
		base.Start();
		_navigationHelper = GetComponent<UINavigationHelper>();
	}

	public override void OnSelect(BaseEventData eventData)
	{
		base.OnSelect(eventData);
		onSelected?.Invoke();
	}

	public override Selectable FindSelectableOnLeft()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnLeft() ?? base.FindSelectableOnLeft()) : base.FindSelectableOnLeft();
	}

	public override Selectable FindSelectableOnRight()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnRight() ?? base.FindSelectableOnRight()) : base.FindSelectableOnRight();
	}

	public override Selectable FindSelectableOnUp()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnTop() ?? base.FindSelectableOnUp()) : base.FindSelectableOnUp();
	}

	public override Selectable FindSelectableOnDown()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnBottom() ?? base.FindSelectableOnDown()) : base.FindSelectableOnDown();
	}
}
