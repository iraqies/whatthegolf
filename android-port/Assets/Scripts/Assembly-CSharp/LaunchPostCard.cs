using System.Threading.Tasks;
using Core;
using UnityEngine;

public class LaunchPostCard : MonoBehaviour
{
	public MainMenu2Button exit;

	public MainMenu2Button toMenu;

	private MainMenu2Button selected;

	public GameObject PostCard;

	public Animator animator;

	private bool isOpen;

	private bool busyClosing;

	private void Awake()
	{
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnLastFlagExit -= OnLastFlagCompleted;
			OverworldManager2d.Instance.OnLastFlagExit += OnLastFlagCompleted;
		}
		if (exit != null)
		{
			exit.OnSelect -= SetSelectedButtonExit;
			exit.OnSelect += SetSelectedButtonExit;
		}
		if (toMenu != null)
		{
			toMenu.OnSelect -= SetSelectedButtonToMenu;
			toMenu.OnSelect += SetSelectedButtonToMenu;
		}
	}

	private void OnLastFlagCompleted(LevelData lastFlagLevelData)
	{
		if (lastFlagLevelData != null && lastFlagLevelData.CompletedChallenges != null && lastFlagLevelData.CompletedChallenges.Count <= 0)
		{
			LaunchCardAnimation();
		}
	}

	public void LaunchCardAnimation()
	{
		if (busyClosing)
			return;
		isOpen = true;
		if (PostCard != null)
			PostCard.SetActive(true);
		if (animator != null)
			animator.SetBool("Close", false);
		DisableUI();
		SetSelectedButtonExit();
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			if (OverworldBallManager.Instance.Ball.Controller != null)
				OverworldBallManager.Instance.Ball.Controller.enabled = false;
			OverworldBallManager.Instance.Ball.HideAndStop();
		}
	}

	private static void DisableUI()
	{
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null)
			OverworldManager2d.Instance.ui.DisableUI();
	}

	private static void EnableUI()
	{
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null)
			OverworldManager2d.Instance.ui.EnableUI();
	}

	public async void Close()
	{
		if (busyClosing)
			return;
		isOpen = false;
		busyClosing = true;
		if (animator != null)
			animator.SetBool("Close", true);
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			if (OverworldBallManager.Instance.Ball.Controller != null)
				OverworldBallManager.Instance.Ball.Controller.enabled = true;
			OverworldBallManager.Instance.Ball.ShowAndEnable();
		}
		EnableUI();
		await Task.Delay(1000);
		busyClosing = false;
	}

	public async void Exit()
	{
		if (busyClosing)
			return;
		busyClosing = true;
		if (HubSceneLoader.Instance != null)
			await HubSceneLoader.Instance.LoadSceneAsync(false, default, false);
		busyClosing = false;
	}

	private void SetSelectedButtonExit()
	{
		if (exit != null)
			exit.SetSelectedVisuals(true);
		if (toMenu != null)
			toMenu.SetSelectedVisuals(false);
		selected = exit;
	}

	private void SetSelectedButtonToMenu()
	{
		if (exit != null)
			exit.SetSelectedVisuals(false);
		if (toMenu != null)
			toMenu.SetSelectedVisuals(true);
		selected = toMenu;
	}

	private void Update()
	{
		if (!isOpen || busyClosing)
			return;
		if (InputHelper.GetAllPlayerButtonSubmit() && selected != null)
		{
			selected.Click();
		}
	}
}
