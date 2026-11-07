using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000181")]
public class AdventureButton : MainMenu2Button
{
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private RectTransform _progressRoot;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private RectTransform _progressFill;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private TMP_Text _progressText;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private GameObject _lockedImage;

	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private GameObject _numberPanel;

	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private TMP_Text _numberText;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private MaskableGraphic[] _adventureImages;

	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private TextMeshProLocalized _titleText;

	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private GameObject _playIcon;

	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private RectTransform _percentagePanel;

	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private Color _colorBad;

	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	private Color _colorMedium;

	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	private Color _colorGood;

	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	private Color _colorActive;

	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private Color _colorNormal;

	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private GameObject _newGraphic;

	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private Material _grayscaleMaterial;

	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private CountdownTimer _countdown;

	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private MaskableGraphic _buttonOutline;

	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x1D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x49E10", Offset = "0x49E10")]
	private ContentPackDef levelPackContainer__BackingField;

	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x1D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x49E20", Offset = "0x49E20")]
	private IPackWithData CurrentPack__BackingField;

	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x1E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x49E30", Offset = "0x49E30")]
	private string campaignTag__BackingField;

	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x1E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x49E40", Offset = "0x49E40")]
	private bool IsSpecial__BackingField;

	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x1E9")]
	public bool shouldAnimateSize;

	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x1EC")]
	public float animationSpeed;

	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x1F0")]
	public float animationSizeMax;

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x1F4")]
	public float animationSizeMin;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x1F8")]
	public Transform button;

	[Token(Token = "0x170000D9")]
	public ContentPackDef levelPackContainer
	{
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1409580", Offset = "0x1409580", VA = "0x1409580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED10", Offset = "0x5ED10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1409588", Offset = "0x1409588", VA = "0x1409588")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED20", Offset = "0x5ED20")]
		set
		{
		}
	}

	[Token(Token = "0x170000DA")]
	public IPackWithData CurrentPack
	{
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1409590", Offset = "0x1409590", VA = "0x1409590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED30", Offset = "0x5ED30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1409598", Offset = "0x1409598", VA = "0x1409598")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED40", Offset = "0x5ED40")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DB")]
	public bool isNewVisible
	{
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1409864", Offset = "0x1409864", VA = "0x1409864")]
		set
		{
		}
	}

	[Token(Token = "0x170000DC")]
	public string campaignTag
	{
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x140A168", Offset = "0x140A168", VA = "0x140A168")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED50", Offset = "0x5ED50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x140A170", Offset = "0x140A170", VA = "0x140A170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED60", Offset = "0x5ED60")]
		set
		{
		}
	}

	[Token(Token = "0x170000DD")]
	public bool isLocked
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x140A178", Offset = "0x140A178", VA = "0x140A178")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1409910", Offset = "0x1409910", VA = "0x1409910")]
		set
		{
		}
	}

	[Token(Token = "0x170000DE")]
	private bool isProgressVisible
	{
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1409D6C", Offset = "0x1409D6C", VA = "0x1409D6C")]
		set
		{
		}
	}

	[Token(Token = "0x170000DF")]
	public bool hasNumberPanel
	{
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x140A228", Offset = "0x140A228", VA = "0x140A228")]
		set
		{
		}
	}

	[Token(Token = "0x170000E0")]
	public string number
	{
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x140A2E0", Offset = "0x140A2E0", VA = "0x140A2E0")]
		set
		{
		}
	}

	[Token(Token = "0x170000E1")]
	public Sprite adventureImage
	{
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1409E7C", Offset = "0x1409E7C", VA = "0x1409E7C")]
		set
		{
		}
	}

	[Token(Token = "0x170000E2")]
	public string adventureTitleID
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x140A0BC", Offset = "0x140A0BC", VA = "0x140A0BC")]
		set
		{
		}
	}

	[Token(Token = "0x170000E3")]
	public float progress
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1409AE4", Offset = "0x1409AE4", VA = "0x1409AE4")]
		set
		{
		}
	}

	[Token(Token = "0x170000E4")]
	public bool IsSpecial
	{
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x140A394", Offset = "0x140A394", VA = "0x140A394")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED70", Offset = "0x5ED70")]
		get
		{
			return default;
		}
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x140A39C", Offset = "0x140A39C", VA = "0x140A39C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5ED80", Offset = "0x5ED80")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E5")]
	public new bool IsActive
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x140A3A4", Offset = "0x140A3A4", VA = "0x140A3A4")]
		set
		{
		}
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x14095A0", Offset = "0x14095A0", VA = "0x14095A0")]
	public void UpdatePack(ContentPackDef container, IPackWithData pack)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x140A498", Offset = "0x140A498", VA = "0x140A498")]
	public void Update()
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x140A528", Offset = "0x140A528", VA = "0x140A528")]
	public AdventureButton()
	{
	}
}
