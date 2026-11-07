using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureButton : MainMenu2Button
{
	[SerializeField]
	private RectTransform _progressRoot;

	[SerializeField]
	private RectTransform _progressFill;

	[SerializeField]
	private TMP_Text _progressText;

	[SerializeField]
	private GameObject _lockedImage;

	[SerializeField]
	private GameObject _numberPanel;

	[SerializeField]
	private TMP_Text _numberText;

	[SerializeField]
	private MaskableGraphic[] _adventureImages;

	[SerializeField]
	private TextMeshProLocalized _titleText;

	[SerializeField]
	private GameObject _playIcon;

	[SerializeField]
	private RectTransform _percentagePanel;

	[SerializeField]
	private Color _colorBad;

	[SerializeField]
	private Color _colorMedium;

	[SerializeField]
	private Color _colorGood;

	[SerializeField]
	private Color _colorActive;

	[SerializeField]
	private Color _colorNormal;

	[SerializeField]
	private GameObject _newGraphic;

	[SerializeField]
	private Material _grayscaleMaterial;

	[SerializeField]
	private CountdownTimer _countdown;

	[SerializeField]
	private MaskableGraphic _buttonOutline;

	public bool shouldAnimateSize;

	public float animationSpeed;

	public float animationSizeMax;

	public float animationSizeMin;

	public Transform button;

	public ContentPackDef levelPackContainer { get; set; }

	public IPackWithData CurrentPack { get; private set; }

	public bool isNewVisible
	{
		set
		{
		}
	}

	public string campaignTag { get; set; }

	public bool isLocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool isProgressVisible
	{
		set
		{
		}
	}

	public bool hasNumberPanel
	{
		set
		{
		}
	}

	public string number
	{
		set
		{
		}
	}

	public Sprite adventureImage
	{
		set
		{
		}
	}

	public string adventureTitleID
	{
		set
		{
		}
	}

	public float progress
	{
		set
		{
		}
	}

	public bool IsSpecial { get; private set; }

	public new bool IsActive
	{
		set
		{
		}
	}

	public void UpdatePack(ContentPackDef container, IPackWithData pack)
	{
	}

	public void Update()
	{
	}
}
