using System.Collections;
using UnityEngine;

public class LeaderboardLoader : MonoBehaviour
{
	[SerializeField]
	private MainMenuLeaderboards _leaderboardsMenu;

	private bool interactionDisabled;

	private bool wantsToEnableInteraction;

	private bool InteractionDisabled => false;

	private void EnableInteraction()
	{
	}

	private void DisableInteraction()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	public void ShowLeaderboards()
	{
	}

	private IEnumerator ShowLeaderboardsCR()
	{
		return null;
	}

	private void HideLeaderboards()
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	public void ZoneEnter()
	{
	}

	public void ZoneExit()
	{
	}
}
