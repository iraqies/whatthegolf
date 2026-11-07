using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20004EE")]
[Attribute(Name = "RequireComponent", RVA = "0x3FFA4", Offset = "0x3FFA4")]
[DisallowMultipleComponent]
public class TextMeshProLocalized : MonoBehaviour
{
	[Token(Token = "0x20004EF")]
	private enum HorizontalTextAlignment
	{
		[Token(Token = "0x40019AE")]
		Original = 0,
		[Token(Token = "0x40019AF")]
		FontBased = 10
	}

	[Token(Token = "0x40019A6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4D928", Offset = "0x4D928")]
	private string _textId;

	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0x20")]
	public LocalizationFontStyle style;

	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0x28")]
	public bool isCountdown;

	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private HorizontalTextAlignment HorizontalAlignment;

	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x30")]
	protected TMP_Text _tmp;

	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x38")]
	protected TextAlignmentOptions _originalAlignment;

	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent onTextChanged;

	[Token(Token = "0x1700027F")]
	public string TermId
	{
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x1710F18", Offset = "0x1710F18", VA = "0x1710F18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x1710D10", Offset = "0x1710D10", VA = "0x1710D10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x1710E10", Offset = "0x1710E10", VA = "0x1710E10")]
	public void NotifyLanguageChanged()
	{
	}

	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x1710ED0", Offset = "0x1710ED0", VA = "0x1710ED0")]
	[Attribute(Name = "ContextMenu", RVA = "0x628B0", Offset = "0x628B0")]
	private void Retranslate()
	{
	}

	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x1710DC4", Offset = "0x1710DC4", VA = "0x1710DC4")]
	public void ChangeText(string text)
	{
	}

	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x1710F20", Offset = "0x1710F20", VA = "0x1710F20")]
	private void CheckForComponent()
	{
	}

	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x1711054", Offset = "0x1711054", VA = "0x1711054")]
	private static bool TryTranslate(string textOrTerm, out string translated)
	{
		return default;
	}

	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x1711124", Offset = "0x1711124", VA = "0x1711124")]
	public void ClearText()
	{
	}

	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x17111E8", Offset = "0x17111E8", VA = "0x17111E8", Slot = "4")]
	public virtual void ChangeTextAfterTranslation(string textOrTerm)
	{
	}

	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x17112E4", Offset = "0x17112E4", VA = "0x17112E4")]
	public void UpdateAlignment()
	{
	}

	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x17114AC", Offset = "0x17114AC", VA = "0x17114AC")]
	public void UpdateFont()
	{
	}

	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x1711740", Offset = "0x1711740", VA = "0x1711740")]
	private bool IsUGUI()
	{
		return default;
	}

	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x1711684", Offset = "0x1711684", VA = "0x1711684")]
	private static TextAlignmentOptions GetOppositeAlignment(TextAlignmentOptions a)
	{
		return default;
	}

	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x17117DC", Offset = "0x17117DC", VA = "0x17117DC")]
	public TextMeshProLocalized()
	{
	}
}
