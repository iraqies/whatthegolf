using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x20003A0")]
public class SwitchSceneSnapshot : MonoBehaviour
{
	[Token(Token = "0x400140E")]
	[FieldOffset(Offset = "0x18")]
	public bool setOnEnable;

	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x20")]
	public AudioMixerSnapshot snapshot;

	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x28")]
	public float timeToReach;

	[Token(Token = "0x600113E")]
	[Address(RVA = "0x16F53D8", Offset = "0x16F53D8", VA = "0x16F53D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600113F")]
	[Address(RVA = "0x16F548C", Offset = "0x16F548C", VA = "0x16F548C")]
	public SwitchSceneSnapshot()
	{
	}
}
