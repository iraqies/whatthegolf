using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000222")]
[Attribute(Name = "RequireComponent", RVA = "0x3E538", Offset = "0x3E538")]
[Attribute(Name = "RequireComponent", RVA = "0x3E538", Offset = "0x3E538")]
public class VirtualCameraParticles : MonoBehaviour
{
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x18")]
	private CinemachineVirtualCamera camera;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem particles;

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x174B224", Offset = "0x174B224", VA = "0x174B224")]
	private void Start()
	{
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x174B2A4", Offset = "0x174B2A4", VA = "0x174B2A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600098D")]
	[Address(RVA = "0x174B3BC", Offset = "0x174B3BC", VA = "0x174B3BC")]
	public VirtualCameraParticles()
	{
	}
}
