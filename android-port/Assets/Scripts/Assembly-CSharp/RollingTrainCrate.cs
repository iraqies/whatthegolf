using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008AF")]
public class RollingTrainCrate : MonoBehaviour
{
	[Token(Token = "0x4002FA8")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 ForcePositionOffset;

	[Token(Token = "0x4002FA9")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 Force;

	[Token(Token = "0x4002FAA")]
	[FieldOffset(Offset = "0x28")]
	public ForceMode2D ForceMode;

	[Token(Token = "0x4002FAB")]
	[FieldOffset(Offset = "0x2C")]
	public float ActivationThresholdRange;

	[Token(Token = "0x4002FAC")]
	[FieldOffset(Offset = "0x30")]
	public Transform Activator;

	[Token(Token = "0x4002FAD")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D rigid;

	[Token(Token = "0x6002815")]
	[Address(RVA = "0x165DEF4", Offset = "0x165DEF4", VA = "0x165DEF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002816")]
	[Address(RVA = "0x165DF7C", Offset = "0x165DF7C", VA = "0x165DF7C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002817")]
	[Address(RVA = "0x165E078", Offset = "0x165E078", VA = "0x165E078")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002818")]
	[Address(RVA = "0x165E0CC", Offset = "0x165E0CC", VA = "0x165E0CC")]
	public RollingTrainCrate()
	{
	}
}
