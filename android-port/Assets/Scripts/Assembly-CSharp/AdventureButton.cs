using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureButton : MainMenu2Button
{
	[SerializeField] private RectTransform _progressRoot;
	[SerializeField] private RectTransform _progressFill;
	[SerializeField] private TMP_Text _progressText;
	[SerializeField] private GameObject _lockedImage;
	[SerializeField] private GameObject _numberPanel;
	[SerializeField] private TMP_Text _numberText;
	[SerializeField] private MaskableGraphic[] _adventureImages;
	[SerializeField] private TextMeshProLocalized _titleText;
	[SerializeField] private GameObject _playIcon;
	[SerializeField] private RectTransform _percentagePanel;
	[SerializeField] private Color _colorBad = Color.red;
	[SerializeField] private Color _colorMedium = Color.yellow;
	[SerializeField] private Color _colorGood = Color.green;
	[SerializeField] private Color _colorActive = Color.white;
	[SerializeField] private Color _colorNormal = Color.gray;
	[SerializeField] private GameObject _newGraphic;
	[SerializeField] private Material _grayscaleMaterial;
	[SerializeField] private CountdownTimer _countdown;
	[SerializeField] private MaskableGraphic _buttonOutline;

	public bool shouldAnimateSize;
	public float animationSpeed = 4f;
	public float animationSizeMax = 1.05f;
	public float animationSizeMin = 0.98f;
	public Transform button;
	private bool _locked;

	public ContentPackDef levelPackContainer { get; set; }
	public IPackWithData CurrentPack { get; private set; }

	public bool isNewVisible
	{
		set { if (_newGraphic != null) _newGraphic.SetActive(value); }
	}

	public string campaignTag { get; set; }

	public bool isLocked
	{
		get => _locked;
		set
		{
			_locked = value;
			if (_lockedImage != null) _lockedImage.SetActive(value);
		}
	}

	private bool isProgressVisible
	{
		set { if (_progressRoot != null) _progressRoot.gameObject.SetActive(value); }
	}

	public bool hasNumberPanel
	{
		set { if (_numberPanel != null) _numberPanel.SetActive(value); }
	}

	public string number
	{
		set { if (_numberText != null) _numberText.text = value; }
	}

	public Sprite adventureImage
	{
		set
		{
			if (_adventureImages != null)
			{
				foreach (var g in _adventureImages)
					if (g is Image img) img.sprite = value;
			}
		}
	}

	public string adventureTitleID
	{
		set { if (_titleText != null) _titleText.ChangeTextAfterTranslation(value); }
	}

	public float progress
	{
		set
		{
			int pct = Mathf.Clamp(Mathf.RoundToInt(value * 100f), 0, 100);
			if (_progressText != null) _progressText.text = pct + "%";
		}
	}

	public bool IsSpecial { get; private set; }

	public new bool IsActive
	{
		set { if (_playIcon != null) _playIcon.SetActive(value); }
	}

	public void UpdatePack(ContentPackDef container, IPackWithData pack)
	{
		levelPackContainer = container;
		CurrentPack = pack ?? container?.pack;
		if (CurrentPack != null)
		{
			adventureTitleID = CurrentPack.TitleID;
			isLocked = false;
			if (CurrentPack is ContentPack cp)
				progress = SaveGame.GetCompletedPercentage(cp.campaignType) / 100f;
		}
	}

	public void Update() { }
}
