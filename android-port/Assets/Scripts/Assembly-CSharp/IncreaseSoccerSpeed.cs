using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F08")]
public class IncreaseSoccerSpeed : MonoBehaviour
{
	[Token(Token = "0x400511C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SoccerPlayer soccerPlayer;

	[Token(Token = "0x400511D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float endSpeed;

	[Token(Token = "0x400511E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float increaseSpeed;

	[Token(Token = "0x400511F")]
	[FieldOffset(Offset = "0x28")]
	private float startSpeed;

	[Token(Token = "0x6004642")]
	[Address(RVA = "0x14EC7FC", Offset = "0x14EC7FC", VA = "0x14EC7FC")]
	public void StartIncreaseSpeed()
	{
	}

	[Token(Token = "0x6004643")]
	[Address(RVA = "0x14EC8CC", Offset = "0x14EC8CC", VA = "0x14EC8CC")]
	public IncreaseSoccerSpeed()
	{
	}

	[Token(Token = "0x6004644")]
	[Address(RVA = "0x14EC8D4", Offset = "0x14EC8D4", VA = "0x14EC8D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E8C4", Offset = "0x6E8C4")]
	private void _003CStartIncreaseSpeed_003Eb__4_0(float t)
	{
	}
}
