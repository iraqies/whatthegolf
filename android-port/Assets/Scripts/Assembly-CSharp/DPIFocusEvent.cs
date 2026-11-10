using UnityEngine.Events;

public class DPIFocusEvent : BaseDailyPrizeInteractions
{
	public UnityEvent GetFocusEvent;

	public UnityEvent LoseFocusEvent;

	public override void OnGetFocus()
	{
		GetFocusEvent?.Invoke();
	}

	public override void OnLoseFocus()
	{
		LoseFocusEvent?.Invoke();
	}
}
