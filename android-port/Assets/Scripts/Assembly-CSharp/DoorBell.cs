using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D4")]
public class DoorBell : MonoBehaviour
{
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x18")]
	public HingeJoint LeftDoor;

	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x20")]
	public HingeJoint RightDoor;

	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x28")]
	public string PoleTag;

	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection RingClip;

	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection OpenClip;

	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x40")]
	private bool hasRung;

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x1432398", Offset = "0x1432398", VA = "0x1432398")]
	private void Start()
	{
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x1432434", Offset = "0x1432434", VA = "0x1432434")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x1432644", Offset = "0x1432644", VA = "0x1432644")]
	public DoorBell()
	{
	}
}
