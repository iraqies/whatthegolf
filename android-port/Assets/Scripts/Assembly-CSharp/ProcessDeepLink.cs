using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ProcessDeepLink : WTGSingleton<ProcessDeepLink>
{
	private WTGNotification? _notification;

	public Action OnDeepLinkActivatedEvent;

	public bool HadEventThisSession;

	public List<WTGNotification> AllNotifications => null;

	private bool IsLoaded => false;

	public bool HasEvent => false;

	public bool HasChallengeEvent => false;

	protected override void OnInit()
	{
	}

	private void OnEnable()
	{
	}

	private void TestDeepLink_PlayTogetherChallenge()
	{
	}

	private void TestDeepLink_SpecialEvent()
	{
	}

	public void OnDeepLinkActivated(string url)
	{
	}

	private void GoToEvent()
	{
	}

	private void ShowCard()
	{
	}

	private WTGNotification? GetNotificationFromUrl(string url)
	{
		return null;
	}

	private void DismissNotification()
	{
	}

	public Task GoToHubFromAnywhereAsync(bool force = false)
	{
		return null;
	}

	public IEnumerator AbandonLevelIfAny()
	{
		return null;
	}

	private IEnumerator GoToHubFromAnywhere()
	{
		return null;
	}
}
