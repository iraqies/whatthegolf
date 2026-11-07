using System.Collections.Generic;
using System.Threading.Tasks;

public abstract class ConsentPopupRequest
{
	private List<ConsentPopupRequest> _allRequests;

	private static List<ConsentRequestTypes> _priorityOrder;

	protected abstract bool CanBeSnoozed { get; }

	private bool HasBeenShownThisSession { get; set; }

	protected abstract ConsentRequestTypes RequestType { get; }

	public void Init(List<ConsentPopupRequest> allRequests)
	{
	}

	protected abstract void AddListeners();

	protected abstract void RemoveListeners();

	protected void OnActionReceived()
	{
	}

	private bool HasBeenDisabled()
	{
		return false;
	}

	protected abstract bool IsFeatureEnabled();

	protected abstract bool IsRequestValid();

	private Task ShowAndAwaitPopup()
	{
		return null;
	}

	private void Snooze()
	{
	}

	private bool IsSnoozed()
	{
		return false;
	}

	protected abstract Task<bool> ShowAndAwaitPopupInternal();

	private bool HasSeenConsentPopupThisSession()
	{
		return false;
	}

	protected bool LevelCompleteChecksPassed()
	{
		return false;
	}
}
