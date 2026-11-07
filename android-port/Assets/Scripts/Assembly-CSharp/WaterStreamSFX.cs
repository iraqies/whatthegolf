using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003EF")]
public class WaterStreamSFX : MonoBehaviour
{
	[Token(Token = "0x4001578")]
	[FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0x20")]
	public float minVolume;

	[Token(Token = "0x400157A")]
	[FieldOffset(Offset = "0x24")]
	public float maxVolume;

	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0x2C")]
	public int minParticleAmount;

	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0x30")]
	public int maxPartcielAmount;

	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x34")]
	public float decay;

	[Token(Token = "0x400157F")]
	[FieldOffset(Offset = "0x38")]
	private float _timer;

	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0x3C")]
	private float volumeVelocity;

	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 _posVelocity;

	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _position;

	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x58")]
	private bool firstCollision;

	[Token(Token = "0x6001278")]
	[Address(RVA = "0x1750CFC", Offset = "0x1750CFC", VA = "0x1750CFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001279")]
	[Address(RVA = "0x1750E50", Offset = "0x1750E50", VA = "0x1750E50")]
	public void OnTrigger(Vector3 position)
	{
	}

	[Token(Token = "0x600127A")]
	[Address(RVA = "0x1750ED0", Offset = "0x1750ED0", VA = "0x1750ED0")]
	public WaterStreamSFX()
	{
	}
}
