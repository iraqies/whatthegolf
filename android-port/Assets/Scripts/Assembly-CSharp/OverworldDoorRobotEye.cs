using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200097A")]
public class OverworldDoorRobotEye : MonoBehaviour
{
	[Token(Token = "0x4003421")]
	[FieldOffset(Offset = "0x18")]
	public OverworldMainDoorPlate plate;

	[Token(Token = "0x4003422")]
	[FieldOffset(Offset = "0x20")]
	public GameObject closed;

	[Token(Token = "0x4003423")]
	[FieldOffset(Offset = "0x28")]
	public GameObject open;

	[Token(Token = "0x4003424")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 basePosition;

	[Token(Token = "0x6002C4F")]
	[Address(RVA = "0x15B3788", Offset = "0x15B3788", VA = "0x15B3788")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C50")]
	[Address(RVA = "0x15B38AC", Offset = "0x15B38AC", VA = "0x15B38AC")]
	private void Plate_OnStateChange(bool isOn)
	{
	}

	[Token(Token = "0x6002C51")]
	[Address(RVA = "0x15B37C8", Offset = "0x15B37C8", VA = "0x15B37C8")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x6002C52")]
	[Address(RVA = "0x15B38B0", Offset = "0x15B38B0", VA = "0x15B38B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C53")]
	[Address(RVA = "0x15B3A60", Offset = "0x15B3A60", VA = "0x15B3A60")]
	public OverworldDoorRobotEye()
	{
	}
}
