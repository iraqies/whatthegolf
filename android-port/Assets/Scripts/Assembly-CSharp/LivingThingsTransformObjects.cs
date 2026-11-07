using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAA")]
public class LivingThingsTransformObjects : MonoBehaviour
{
	[Token(Token = "0x4004A81")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _realThing;

	[Token(Token = "0x6004048")]
	[Address(RVA = "0x1538828", Offset = "0x1538828", VA = "0x1538828")]
	private void Start()
	{
	}

	[Token(Token = "0x6004049")]
	[Address(RVA = "0x1538848", Offset = "0x1538848", VA = "0x1538848")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600404A")]
	[Address(RVA = "0x1538988", Offset = "0x1538988", VA = "0x1538988")]
	public LivingThingsTransformObjects()
	{
	}
}
