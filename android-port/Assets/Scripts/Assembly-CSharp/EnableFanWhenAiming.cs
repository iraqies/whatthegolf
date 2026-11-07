using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FB")]
public class EnableFanWhenAiming : MonoBehaviour
{
	[Token(Token = "0x4002497")]
	[FieldOffset(Offset = "0x18")]
	public Fan Fan;

	[Token(Token = "0x4002498")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController Controller;

	[Token(Token = "0x4002499")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x400249A")]
	[FieldOffset(Offset = "0x30")]
	private float baseDrag;

	[Token(Token = "0x600202F")]
	[Address(RVA = "0x1442E90", Offset = "0x1442E90", VA = "0x1442E90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0x144308C", Offset = "0x144308C", VA = "0x144308C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0x14430AC", Offset = "0x14430AC", VA = "0x14430AC")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0x144315C", Offset = "0x144315C", VA = "0x144315C")]
	private void Controller_OnAimUpdate(Vector3 v, bool b)
	{
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x1443254", Offset = "0x1443254", VA = "0x1443254")]
	public EnableFanWhenAiming()
	{
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x144325C", Offset = "0x144325C", VA = "0x144325C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x658D8", Offset = "0x658D8")]
	private void _003CAwake_003Eb__4_0(Vector3 v)
	{
	}
}
