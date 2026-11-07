using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E26")]
public class PropDeactivatedWithOpenDoor : MonoBehaviour
{
	[Token(Token = "0x4004CC9")]
	[FieldOffset(Offset = "0x18")]
	public OverworldButton2D door;

	[Token(Token = "0x4004CCA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject doorButton;

	[Token(Token = "0x6004264")]
	[Address(RVA = "0x16279A8", Offset = "0x16279A8", VA = "0x16279A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6004265")]
	[Address(RVA = "0x1627A78", Offset = "0x1627A78", VA = "0x1627A78")]
	private void DisableThisWhenOpened()
	{
	}

	[Token(Token = "0x6004266")]
	[Address(RVA = "0x1627AA0", Offset = "0x1627AA0", VA = "0x1627AA0")]
	public PropDeactivatedWithOpenDoor()
	{
	}
}
