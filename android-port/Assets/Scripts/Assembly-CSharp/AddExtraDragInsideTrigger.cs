using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D59")]
public class AddExtraDragInsideTrigger : MonoBehaviour
{
	[Token(Token = "0x4004893")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody _rigidbodyOverride;

	[Token(Token = "0x4004894")]
	[FieldOffset(Offset = "0x20")]
	private float _orgDrag;

	[Token(Token = "0x4004895")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _drag;

	[Token(Token = "0x6003ECE")]
	[Address(RVA = "0x1405FE0", Offset = "0x1405FE0", VA = "0x1405FE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003ECF")]
	[Address(RVA = "0x14060E0", Offset = "0x14060E0", VA = "0x14060E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003ED0")]
	[Address(RVA = "0x1406258", Offset = "0x1406258", VA = "0x1406258")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6003ED1")]
	[Address(RVA = "0x14063D0", Offset = "0x14063D0", VA = "0x14063D0")]
	public AddExtraDragInsideTrigger()
	{
	}
}
