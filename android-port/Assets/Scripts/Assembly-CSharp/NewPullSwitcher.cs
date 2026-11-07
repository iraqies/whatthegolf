using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B9")]
public class NewPullSwitcher : MonoBehaviour
{
	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController ball;

	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x20")]
	private GolfPullAudioHandler[] pulls;

	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x158C760", Offset = "0x158C760", VA = "0x158C760")]
	private void Start()
	{
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x158C960", Offset = "0x158C960", VA = "0x158C960")]
	private void Update()
	{
	}

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x158C828", Offset = "0x158C828", VA = "0x158C828")]
	private void NextSound(int indexIncrement)
	{
	}

	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x158C9E4", Offset = "0x158C9E4", VA = "0x158C9E4")]
	public NewPullSwitcher()
	{
	}
}
