using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003A2")]
public class MovingCarAudio : MonoBehaviour
{
	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip[] clipAtEnd;

	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MovingCar movingCar;

	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0x30")]
	private float volume;

	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0x34")]
	private float pitch;

	[Token(Token = "0x6001142")]
	[Address(RVA = "0x157641C", Offset = "0x157641C", VA = "0x157641C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001143")]
	[Address(RVA = "0x157650C", Offset = "0x157650C", VA = "0x157650C")]
	private void OnDriveStart()
	{
	}

	[Token(Token = "0x6001144")]
	[Address(RVA = "0x15766AC", Offset = "0x15766AC", VA = "0x15766AC")]
	public MovingCarAudio()
	{
	}

	[Token(Token = "0x6001145")]
	[Address(RVA = "0x15766B4", Offset = "0x15766B4", VA = "0x15766B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6193C", Offset = "0x6193C")]
	private void _003COnDriveStart_003Eb__6_0(float s)
	{
	}

	[Token(Token = "0x6001146")]
	[Address(RVA = "0x1576738", Offset = "0x1576738", VA = "0x1576738")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6194C", Offset = "0x6194C")]
	private void _003COnDriveStart_003Eb__6_1()
	{
	}
}
