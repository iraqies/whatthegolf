using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009BA")]
public class GravityLampCable : MonoBehaviour
{
	[Token(Token = "0x4003561")]
	[FieldOffset(Offset = "0x18")]
	public Transform TransformOrigin;

	[Token(Token = "0x4003562")]
	[FieldOffset(Offset = "0x20")]
	public Transform TransformLamp;

	[Token(Token = "0x4003563")]
	[FieldOffset(Offset = "0x28")]
	private LineRenderer CableRenderer;

	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x14B8DC0", Offset = "0x14B8DC0", VA = "0x14B8DC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x14B8E1C", Offset = "0x14B8E1C", VA = "0x14B8E1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x14B8E74", Offset = "0x14B8E74", VA = "0x14B8E74")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x14B8EB8", Offset = "0x14B8EB8", VA = "0x14B8EB8")]
	public GravityLampCable()
	{
	}
}
