using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000EF2")]
public class DailyCountdown : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000EF3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45590", Offset = "0x45590")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40050C6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40050C7")]
		[FieldOffset(Offset = "0x8")]
		public static Action<TextMeshPro> _003C_003E9__16_0;

		[Token(Token = "0x60045DB")]
		[Address(RVA = "0x17985E0", Offset = "0x17985E0", VA = "0x17985E0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60045DC")]
		[Address(RVA = "0x17985E8", Offset = "0x17985E8", VA = "0x17985E8")]
		internal void _003CUpdateTimer_003Eb__16_0(TextMeshPro tx)
		{
		}
	}

	[Token(Token = "0x40050B7")]
	[FieldOffset(Offset = "0x18")]
	private TextMeshPro text;

	[Token(Token = "0x40050B8")]
	[FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI textGUI;

	[Token(Token = "0x40050B9")]
	[FieldOffset(Offset = "0x28")]
	private DateTime EOD;

	[Token(Token = "0x40050BA")]
	[FieldOffset(Offset = "0x30")]
	private float time;

	[Token(Token = "0x40050BB")]
	[FieldOffset(Offset = "0x34")]
	private bool usingUGUI;

	[Token(Token = "0x40050BC")]
	[FieldOffset(Offset = "0x35")]
	public bool debug;

	[Token(Token = "0x40050BD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string appendString;

	[Token(Token = "0x40050BE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool showHours;

	[Token(Token = "0x40050BF")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool showMinutes;

	[Token(Token = "0x40050C0")]
	[FieldOffset(Offset = "0x42")]
	[SerializeField]
	private bool showSeconds;

	[Token(Token = "0x40050C1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string stringOnReachZero;

	[Token(Token = "0x40050C2")]
	[FieldOffset(Offset = "0x50")]
	public Action OnCountdownZero;

	[Token(Token = "0x40050C3")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TextMeshPro ToEnable;

	[Token(Token = "0x40050C4")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<TextMeshPro> ToDisable;

	[Token(Token = "0x40050C5")]
	[FieldOffset(Offset = "0x68")]
	private bool end;

	[Token(Token = "0x60045D6")]
	[Address(RVA = "0x18D11A8", Offset = "0x18D11A8", VA = "0x18D11A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60045D7")]
	[Address(RVA = "0x18D1314", Offset = "0x18D1314", VA = "0x18D1314")]
	private void UpdateTimer()
	{
	}

	[Token(Token = "0x60045D8")]
	[Address(RVA = "0x18D18C8", Offset = "0x18D18C8", VA = "0x18D18C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60045D9")]
	[Address(RVA = "0x18D1924", Offset = "0x18D1924", VA = "0x18D1924")]
	public DailyCountdown()
	{
	}
}
