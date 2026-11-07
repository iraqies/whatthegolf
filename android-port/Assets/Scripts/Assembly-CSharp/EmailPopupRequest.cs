using System.Threading.Tasks;

public abstract class EmailPopupRequest : ConsentPopupRequest
{
	private string description;

	protected override ConsentRequestTypes RequestType => ConsentRequestTypes.Notifications;

	protected override bool IsFeatureEnabled()
	{
		return false;
	}

	protected Task ShowPopup()
	{
		return null;
	}

	private void Disagree()
	{
	}

	private void Agree()
	{
	}

	protected void MarkAsSeen()
	{
	}
}
