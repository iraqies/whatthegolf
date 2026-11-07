using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000621")]
public class BossCameraGroupComposer : MonoBehaviour
{
	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0x18")]
	public float xScale;

	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0x20")]
	private CinemachineVirtualCamera camera;

	[Token(Token = "0x4001FA4")]
	[FieldOffset(Offset = "0x28")]
	private CinemachineGroupComposer composer;

	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x16FBDBC", Offset = "0x16FBDBC", VA = "0x16FBDBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x16FBE40", Offset = "0x16FBE40", VA = "0x16FBE40")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x16FBED0", Offset = "0x16FBED0", VA = "0x16FBED0")]
	public BossCameraGroupComposer()
	{
	}
}
