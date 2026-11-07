using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E34")]
public class StopLookAtCinemachineAtStart : MonoBehaviour
{
	[Token(Token = "0x4004D12")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool ignoreLandscape;

	[Token(Token = "0x4004D13")]
	[FieldOffset(Offset = "0x20")]
	private CinemachineVirtualCamera virtualCam;

	[Token(Token = "0x600429E")]
	[Address(RVA = "0x16E2278", Offset = "0x16E2278", VA = "0x16E2278")]
	private void Start()
	{
	}

	[Token(Token = "0x600429F")]
	[Address(RVA = "0x16E2324", Offset = "0x16E2324", VA = "0x16E2324")]
	public StopLookAtCinemachineAtStart()
	{
	}
}
