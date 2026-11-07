using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CD")]
public class CameraLookAt : MonoBehaviour
{
	[Token(Token = "0x400239E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4E514", Offset = "0x4E514")]
	public float lookAtTarget;

	[Token(Token = "0x400239F")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x40023A0")]
	[FieldOffset(Offset = "0x28")]
	private CBFollow cam;

	[Token(Token = "0x40023A1")]
	[FieldOffset(Offset = "0x30")]
	private float dot;

	[Token(Token = "0x40023A2")]
	[FieldOffset(Offset = "0x34")]
	private float elev;

	[Token(Token = "0x6001F69")]
	[Address(RVA = "0x17E460C", Offset = "0x17E460C", VA = "0x17E460C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x17E4690", Offset = "0x17E4690", VA = "0x17E4690")]
	private void Update()
	{
	}

	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x17E4918", Offset = "0x17E4918", VA = "0x17E4918")]
	public CameraLookAt()
	{
	}
}
