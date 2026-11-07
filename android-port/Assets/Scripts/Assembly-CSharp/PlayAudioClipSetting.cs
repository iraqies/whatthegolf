using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000351")]
public class PlayAudioClipSetting : MonoBehaviour
{
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x18")]
	public ClipSettingsCollection clipCollection;

	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x20")]
	public Transform position;

	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x15E93FC", Offset = "0x15E93FC", VA = "0x15E93FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x15E9490", Offset = "0x15E9490", VA = "0x15E9490")]
	private void DefaultSetPos()
	{
	}

	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x15D7234", Offset = "0x15D7234", VA = "0x15D7234")]
	public void Play()
	{
	}

	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x15E9524", Offset = "0x15E9524", VA = "0x15E9524")]
	public PlayAudioClipSetting()
	{
	}
}
