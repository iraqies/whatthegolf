using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200018A")]
public class CountdownTimer : MonoBehaviour
{
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProLocalized localization;

	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string format;

	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text _text;

	[Token(Token = "0x170000EB")]
	private TMP_Text Text
	{
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x18BA854", Offset = "0x18BA854", VA = "0x18BA854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x18BA90C", Offset = "0x18BA90C", VA = "0x18BA90C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x18BA9C4", Offset = "0x18BA9C4", VA = "0x18BA9C4")]
	public CountdownTimer()
	{
	}
}
