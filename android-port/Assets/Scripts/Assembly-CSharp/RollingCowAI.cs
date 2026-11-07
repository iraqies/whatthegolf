using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024C")]
public class RollingCowAI : MonoBehaviour
{
	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x18")]
	public RollingCowShooter Cow;

	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x20")]
	public Transform Player;

	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0x28")]
	public float FleeDistance;

	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection FleeClips;

	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 currentFleeGoal;

	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x44")]
	private float clipDelayTimer;

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x165CF78", Offset = "0x165CF78", VA = "0x165CF78")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x165D22C", Offset = "0x165D22C", VA = "0x165D22C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x165D268", Offset = "0x165D268", VA = "0x165D268")]
	public RollingCowAI()
	{
	}
}
