using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainCampaignStartManager : MonoBehaviour
{
	[SerializeField]
	private UserCriteria indicatorCriteria;

	[SerializeField]
	private GameObject indicator;

	[SerializeField]
	private GameObject _newBanner;

	[SerializeField]
	private GameObject _completeBanner;

	[SerializeField]
	private GameObject _nameBanner;

	[SerializeField]
	private GameObject _progressBanner;

	[SerializeField]
	private TMP_Text _progressText;

	[SerializeField]
	private Image _progressImg;

	[SerializeField]
	private TextMeshProLocalized _campaignNameText;

	private bool isNew;

	private bool packHasBeenEntered;

	[SerializeField]
	private string pack;

	[NonSerialized]
	private ContentPackDef packDef;

	private UnityAction<ContentPackDef> _startAction;

	public ContentPackDef PackDef => null;

	public string adventureTitleID
	{
		set
		{
		}
	}

	public void Start()
	{
	}

	public void UpdateProgress()
	{
	}

	private void OnEnable()
	{
	}

	private void SetProgressText(float value)
	{
	}

	public void StartPack()
	{
	}

	private void Exit()
	{
	}

	private Task PushAway()
	{
		return null;
	}
}
