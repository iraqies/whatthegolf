using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000180")]
public class SimpleMenuAnimation : MonoBehaviour
{
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 _originalPosition;

	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion _originalRotation;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve _posXCurve;

	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve _posYCurve;

	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimationCurve _rotZCurve;

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x16ACC38", Offset = "0x16ACC38", VA = "0x16ACC38")]
	private void Start()
	{
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x16ACD08", Offset = "0x16ACD08", VA = "0x16ACD08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x16ACE98", Offset = "0x16ACE98", VA = "0x16ACE98")]
	public SimpleMenuAnimation()
	{
	}
}
