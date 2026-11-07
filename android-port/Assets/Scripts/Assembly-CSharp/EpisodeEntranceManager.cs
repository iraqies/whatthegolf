using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EpisodeEntranceManager : MonoBehaviour
{
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
	private Animator _curtainsAnimator;

	[SerializeField]
	private GameObject _animatedIllustrationPrefab;

	[SerializeField]
	private Transform _animatedIllustrationContainer;

	[SerializeField]
	private TextMeshProLocalized _campaignNameText;

	[SerializeField]
	private TextMeshProLocalized _episodeText;

	[SerializeField]
	private Color _bannerColor;

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

	private void UpdateProgress()
	{
	}

	private void OnEnable()
	{
	}

	public void OpenTheCurtains()
	{
	}

	private void SetArtwork()
	{
	}

	private void SetUpBannerColor()
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
