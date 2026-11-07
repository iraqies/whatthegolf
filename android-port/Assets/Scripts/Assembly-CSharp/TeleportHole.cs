using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000322")]
public class TeleportHole : MonoBehaviour
{
	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x18")]
	public TeleportHole teleportConnection;

	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 UpModifier;

	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float force;

	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UnityEvent _onTeleportedToHere;

	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x16F7A14", Offset = "0x16F7A14", VA = "0x16F7A14")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x16F7C48", Offset = "0x16F7C48", VA = "0x16F7C48")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x16F7DE0", Offset = "0x16F7DE0", VA = "0x16F7DE0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x16F7F14", Offset = "0x16F7F14", VA = "0x16F7F14")]
	public TeleportHole()
	{
	}
}
