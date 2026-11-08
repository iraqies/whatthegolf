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
		UpdateProgress();
	}

	private void SetProgressText(float value)
	{
		int pct = Mathf.FloorToInt(Mathf.Clamp01(value) * 100f);
		if (_progressText != null) _progressText.text = pct + "%";
		if (_progressImg != null) _progressImg.fillAmount = Mathf.Clamp01(value);
		if (_completeBanner != null) _completeBanner.SetActive(pct >= 100);
		if (_newBanner != null) _newBanner.SetActive(pct == 0);
	}

	public void StartPack()
	{
		var pd = PackDef;
		if (pd != null && pd.pack != null)
		{
			_ = PackStarterManager.StartPack(pd.pack, false);
		}
	}

	private void Exit() { }
	private Task PushAway() => Task.CompletedTask;
}
