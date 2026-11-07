using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200034A")]
public class LinkAnimtionFieldAndAimMagnitude : MonoBehaviour
{
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string animationField;

	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x1534498", Offset = "0x1534498", VA = "0x1534498")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x1534548", Offset = "0x1534548", VA = "0x1534548")]
	private void Aim(Vector3 boost, bool b)
	{
	}

	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x1534598", Offset = "0x1534598", VA = "0x1534598")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x1534648", Offset = "0x1534648", VA = "0x1534648")]
	public LinkAnimtionFieldAndAimMagnitude()
	{
	}
}
