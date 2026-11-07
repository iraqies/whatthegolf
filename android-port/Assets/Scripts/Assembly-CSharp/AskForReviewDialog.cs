using Core;
using UnityEngine.Events;

public class AskForReviewDialog : AddressableSingleton<AskForReviewDialog>
{
	public static AskForReviewDialog s_instance;

	private const string REVIEW_LINK = "itms-apps://itunes.apple.com/app/id1415190483?action=write-review";

	private UnityAction<bool> _onDone;

	private void Awake()
	{
	}

	public void AskForReview(UnityAction<bool> onDone)
	{
	}

	private void DebugShow()
	{
	}

	private void AskForReviewInternal(UnityAction<bool> onDone)
	{
	}

	private void Show()
	{
	}

	private void RedirectToReview()
	{
	}

	public void Close(bool positiveAnswer)
	{
	}

	private void Closing(bool accepted)
	{
	}
}
