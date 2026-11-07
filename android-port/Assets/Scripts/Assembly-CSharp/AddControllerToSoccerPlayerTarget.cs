using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D57")]
public class AddControllerToSoccerPlayerTarget : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x448F8", Offset = "0x448F8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004891")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004892")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GolfBallController, Rigidbody> _003C_003E9__0_0;

		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x1768B30", Offset = "0x1768B30", VA = "0x1768B30")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x1768B38", Offset = "0x1768B38", VA = "0x1768B38")]
		internal Rigidbody _003CAwake_003Eb__0_0(GolfBallController g)
		{
			return null;
		}
	}

	[Token(Token = "0x4004890")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _findController;

	[Token(Token = "0x6003EC9")]
	[Address(RVA = "0x1405BB8", Offset = "0x1405BB8", VA = "0x1405BB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003ECA")]
	[Address(RVA = "0x1405DA8", Offset = "0x1405DA8", VA = "0x1405DA8")]
	public AddControllerToSoccerPlayerTarget()
	{
	}
}
