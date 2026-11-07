using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038A")]
public class AudioSourceMusicVolumeAttenuator : MonoBehaviour
{
	[Token(Token = "0x4001370")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource target;

	[Token(Token = "0x4001371")]
	[FieldOffset(Offset = "0x20")]
	private float initialMusicVolume;

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x150C124", Offset = "0x150C124", VA = "0x150C124")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x150C1CC", Offset = "0x150C1CC", VA = "0x150C1CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x150C464", Offset = "0x150C464", VA = "0x150C464")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x150C3D4", Offset = "0x150C3D4", VA = "0x150C3D4")]
	private void OnMusicVolumeChanged(float value)
	{
	}

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x150C58C", Offset = "0x150C58C", VA = "0x150C58C")]
	public AudioSourceMusicVolumeAttenuator()
	{
	}
}
