using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E21")]
public class OverworldDoorOnOpenOnce : MonoBehaviour
{
	[Token(Token = "0x4004CB5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OverworldButton2D door;

	[Token(Token = "0x4004CB6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject doorButton;

	[Token(Token = "0x4004CB7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent onDoorFirstTime;

	[Token(Token = "0x4004CB8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UnityEvent onDoorAlreadyOpened;

	[Token(Token = "0x4004CB9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool _useOnStartingToOpen;

	[Token(Token = "0x6004252")]
	[Address(RVA = "0x15B1BE8", Offset = "0x15B1BE8", VA = "0x15B1BE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6004253")]
	[Address(RVA = "0x15B1D94", Offset = "0x15B1D94", VA = "0x15B1D94")]
	private void FirstTime()
	{
	}

	[Token(Token = "0x6004254")]
	[Address(RVA = "0x15B1DB0", Offset = "0x15B1DB0", VA = "0x15B1DB0")]
	public OverworldDoorOnOpenOnce()
	{
	}
}
