using System.Threading.Tasks;
using Core.UI;
using UnityEngine;

public class NewsletterPopup : MonoBehaviour
{
	public ExternalLinks linksList;

	public ExternalLinks.LinkType popupLinkType;

	public ModalWindowType modalWindowType;

	private TaskCompletionSource<bool> tcs;

	private bool _shouldEnableInteraction;

	public Task ShowAndAwait()
	{
		return null;
	}

	public void ShowPopup()
	{
	}

	private void ShowPopupWithLinks(Sprite QR, string link, string popupTextID)
	{
	}

	private void Agree(string link)
	{
	}

	private void Disagree()
	{
	}

	private void EnableInteraction()
	{
	}

	private void DisableInteraction()
	{
	}
}
