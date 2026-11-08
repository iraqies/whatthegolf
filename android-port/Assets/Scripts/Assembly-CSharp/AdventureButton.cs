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
	public float animationSpeed = 0.4f;
	public float animationSizeMax = 1.05f;
	public float animationSizeMin = 0.95f;
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
		get => _lockedImage != null ? _lockedImage.activeSelf : _locked;
		set
		{
			_locked = value;
			if (_lockedImage != null) _lockedImage.SetActive(value);
			if (_progressRoot != null) _progressRoot.gameObject.SetActive(!value);
			if (_playIcon != null) _playIcon.SetActive(!value);
			if (_adventureImages != null)
			{
				for (int i = 0; i < _adventureImages.Length; i++)
				{
					var g = _adventureImages[i];
					if (g != null)
						g.material = value ? _grayscaleMaterial : null;
				}
			}
		}
	}

	public bool isProgressVisible
	{
		set
		{
			if (_progressText != null) _progressText.gameObject.SetActive(value);
			if (_progressRoot != null) _progressRoot.gameObject.SetActive(value);
		}
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
			if (_adventureImages == null) return;
			for (int i = 0; i < _adventureImages.Length; i++)
			{
				var g = _adventureImages[i];
				if (g is Image img)
					img.sprite = value;
				else if (g is SVGImage svg)
					svg.sprite = value;
				if (g != null && value != null)
				{
					var arf = g.GetComponent<AspectRatioFitter>();
					if (arf != null && value.rect.height > 0.01f)
						arf.aspectRatio = value.rect.width / value.rect.height;
				}
			}
		}
	}

	public string adventureTitleID
	{
		set { if (_titleText != null) _titleText.ChangeText(value); }
	}

	public float progress
	{
		set
		{
			if (_progressText == null || _progressFill == null) return;
			float clamped = Mathf.Clamp01(value);
			int pct = Mathf.FloorToInt(clamped * 100f);
			_progressText.text = $"{pct}%";
			_progressFill.anchorMax = new Vector2(Mathf.Clamp(clamped, 0.05f, 1f), 1f);
			Color c = clamped < 0.2f ? _colorBad : (clamped < 0.8f ? _colorMedium : _colorGood);
			_progressText.color = c;
			var fillImg = _progressFill.GetComponent<Image>();
			if (fillImg != null)
				fillImg.color = c;
		}
	}

	public bool IsSpecial { get; private set; }

	public new bool IsActive
	{
		set
		{
			if (_buttonOutline != null)
				_buttonOutline.color = value ? _colorActive : _colorNormal;
		}
	}

	public void UpdatePack(ContentPackDef container, IPackWithData pack)
	{
		levelPackContainer = container;
		CurrentPack = pack ?? container?.pack;
		if (container != null)
		{
			bool avail = container.pack != null;
			isNewVisible = avail && container.accessible;
			isLocked = !container.accessible;
			if (container.pack != null && container.pack.campaignType != ECampaignType.None)
			{
				int pct = SaveGame.GetCompletedPercentage(container.pack.campaignType, null, true);
				progress = pct / 100f;
				isProgressVisible = pct > 0 && container.accessible;
			}
			else
			{
				isProgressVisible = false;
			}
		}
		if (CurrentPack != null)
		{
			adventureTitleID = CurrentPack.TitleID;
			IsSpecial = CurrentPack.PackID == "CP_DAILY_CHALLENGE";
		}
	}

	public void Update()
	{
		if (shouldAnimateSize && button != null)
		{
			float s = Mathf.Lerp(animationSizeMin, animationSizeMax, Mathf.PingPong(Time.time * animationSpeed, 1f));
			button.localScale = new Vector3(s, s, 1f);
		}
	}
}
