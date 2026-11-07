using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000014")]
public class SimpleGPUInstancingExample : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x18")]
	public Transform Prefab;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x20")]
	public Material InstancedMaterial;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x16AC8BC", Offset = "0x16AC8BC", VA = "0x16AC8BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x16ACB00", Offset = "0x16ACB00", VA = "0x16ACB00")]
	public SimpleGPUInstancingExample()
	{
	}
}
