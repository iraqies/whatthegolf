using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AF")]
public class MainMenuInputIcon : MonoBehaviour
{
	[Token(Token = "0x20001B0")]
	public enum MainMenuInputType
	{
		[Token(Token = "0x400079B")]
		Mouse = 0,
		[Token(Token = "0x400079C")]
		Touch = 1,
		[Token(Token = "0x400079D")]
		SiriRemote = 2,
		[Token(Token = "0x400079E")]
		Controller = 3
	}

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MainMenuInputType inputType;

	[Token(Token = "0x17000102")]
	public MainMenuInputType InputType
	{
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x15591F0", Offset = "0x15591F0", VA = "0x15591F0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x15591F8", Offset = "0x15591F8", VA = "0x15591F8")]
	public MainMenuInputIcon()
	{
	}
}
