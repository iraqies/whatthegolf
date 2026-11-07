using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005F4")]
public class WaterFlow : MonoBehaviour
{
	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speedRatio;

	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Bounds bounds;

	[Token(Token = "0x4001E71")]
	[FieldOffset(Offset = "0x38")]
	private WaterFlowParticle[] particles;

	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x17505C8", Offset = "0x17505C8", VA = "0x17505C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x1750624", Offset = "0x1750624", VA = "0x1750624")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x17507AC", Offset = "0x17507AC", VA = "0x17507AC")]
	public WaterFlow()
	{
	}
}
