using Core;
using UnityEngine.Events;

public class AskForAnalyticsDialog : AddressableSingleton<AskForAnalyticsDialog>
{
	private UnityAction<bool> _onDone;

	public void AskForAnalytics(UnityAction<bool> onDone, UnityAction onCancel = null)
	{
	}

	private void DebugShow()
	{
	}

	private void ShowDialog(UnityAction<bool> onDone)
	{
	}

	private void Agree()
	{
	}

	private void Disagree()
	{
	}

	private void Closing(bool result)
	{
	}
}
