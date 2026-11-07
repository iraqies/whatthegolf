using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000319")]
public class ShrinkOnShoot : MonoBehaviour
{
	[Token(Token = "0x200031A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EF38", Offset = "0x3EF38")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x10")]
		public ShrinkOnShoot _003C_003E4__this;

		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 scale;

		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 newScale;

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x184D86C", Offset = "0x184D86C", VA = "0x184D86C")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x184D874", Offset = "0x184D874", VA = "0x184D874")]
		internal void _003CController_OnShoot_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x20")]
	public float shrinkFactor;

	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x16A8B34", Offset = "0x16A8B34", VA = "0x16A8B34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x16A8BE4", Offset = "0x16A8BE4", VA = "0x16A8BE4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x16A8C94", Offset = "0x16A8C94", VA = "0x16A8C94")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x16A8DC0", Offset = "0x16A8DC0", VA = "0x16A8DC0")]
	public ShrinkOnShoot()
	{
	}
}
