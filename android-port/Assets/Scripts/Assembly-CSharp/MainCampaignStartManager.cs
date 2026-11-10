using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainCampaignStartManager : MonoBehaviour
{
	[SerializeField] private UserCriteria indicatorCriteria;
	[SerializeField] private GameObject indicator;
	[SerializeField] private GameObject _newBanner;
	[SerializeField] private GameObject _completeBanner;
	[SerializeField] private GameObject _nameBanner;
	[SerializeField] private GameObject _progressBanner;
	[SerializeField] private TMP_Text _progressText;
	[SerializeField] private Image _progressImg;
	[SerializeField] private TextMeshProLocalized _campaignNameText;

	private bool isNew;
	private bool packHasBeenEntered;
	[SerializeField] private string pack;
	[NonSerialized] private ContentPackDef packDef;
	private UnityAction<ContentPackDef> _startAction;

	public ContentPackDef PackDef => packDef ?? (packDef = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.TryGetContent(pack) : null);

	public string adventureTitleID
	{
		set
		{
			if (_campaignNameText != null)
				_campaignNameText.ChangeText(value);
		}
	}

	public void Start()
	{
		var pd = PackDef;
		if (pd != null && pd.pack != null)
		{
			adventureTitleID = pd.pack.TitleID;
			if (indicator != null && indicatorCriteria != null)
			{
				indicator.SetActive(indicatorCriteria.DoesUserFit());
			}
			UpdateProgress();
		}
	}

	public void UpdateProgress()
	{
		var pd = PackDef;
		if (pd != null && pd.pack != null)
		{
			float pct = SaveGame.GetCompletedPercentage(pd.pack.campaignType) / 100f;
			SetProgressText(pct);
		}
	}

	private void OnEnable()
	{
		packHasBeenEntered = false;
		UpdateProgress();
	}

	private void SetProgressText(float value)
	{
		var pd = PackDef;
		if (_newBanner != null && pd != null && pd.pack != null)
		{
			_newBanner.SetActive(pd.pack.IsConsideredNew());
		}
		float clamped = Mathf.Clamp01(value);
		bool isComplete = Mathf.Abs(clamped - 1f) < 0.01f;
		bool showProgress = clamped > 0f && !isComplete;
		if (_progressText != null)
		{
			_progressText.gameObject.SetActive(showProgress);
			int pct = Mathf.FloorToInt(clamped * 100f);
			_progressText.SetLocalizedText($"{pct}%");
		}
		if (_progressBanner != null)
		{
			_progressBanner.SetActive(showProgress);
		}
		if (_completeBanner != null)
		{
			_completeBanner.SetActive(isComplete);
		}
		if (_progressImg != null)
		{
			_progressImg.fillAmount = clamped;
		}
	}

	public async void StartPack()
	{
		if (packHasBeenEntered)
			return;
		packHasBeenEntered = true;
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.DisableInteraction(false);

		var cp = PackDef.GetPack();
		bool started = await PackStarterManager.StartPack(cp, false, Array.Empty<object>());
		if (started)
		{
			await Task.Delay(1000);
			packHasBeenEntered = false;
		}
		else
		{
			Exit();
		}
	}

	private async void Exit()
	{
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.EnableInteraction();
		await PushAway();
		packHasBeenEntered = false;
	}

	private async Task PushAway()
	{
		Rigidbody2D rb = OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null
			? OverworldBallManager.Instance.Ball.rigidBody
			: null;
		float timer = 0.15f;
		while (timer > 0f)
		{
			if (rb != null)
				rb.AddForce((Vector2)transform.up * -100f, ForceMode2D.Force);
			timer -= Time.fixedDeltaTime;
			await Task.Delay(Mathf.Max(1, Mathf.RoundToInt(Time.fixedDeltaTime * 1000f)));
		}
	}
}
