using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DA9")]
public class LivingThingsLampController : MonoBehaviour
{
	[Token(Token = "0x4004A7F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject cone;

	[Token(Token = "0x4004A80")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator _a;

	[Token(Token = "0x6004043")]
	[Address(RVA = "0x1538620", Offset = "0x1538620", VA = "0x1538620")]
	private void Start()
	{
	}

	[Token(Token = "0x6004044")]
	[Address(RVA = "0x15387DC", Offset = "0x15387DC", VA = "0x15387DC")]
	private void OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	[Token(Token = "0x6004045")]
	[Address(RVA = "0x15387E0", Offset = "0x15387E0", VA = "0x15387E0")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6004046")]
	[Address(RVA = "0x1538800", Offset = "0x1538800", VA = "0x1538800")]
	private void OnAimStart()
	{
	}

	[Token(Token = "0x6004047")]
	[Address(RVA = "0x1538820", Offset = "0x1538820", VA = "0x1538820")]
	public LivingThingsLampController()
	{
	}
}
