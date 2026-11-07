using UnityEngine.Events;

public class DPIFocusEvent : BaseDailyPrizeInteractions
{
	public UnityEvent GetFocusEvent;

	public UnityEvent LoseFocusEvent;

	public override void OnGetFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}
}
