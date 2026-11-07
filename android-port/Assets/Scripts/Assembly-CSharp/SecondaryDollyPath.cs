using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000255")]
public class SecondaryDollyPath : MonoBehaviour
{
	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CinemachineSmoothPath path;

	[Token(Token = "0x17000149")]
	public CinemachineSmoothPath Path
	{
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1681328", Offset = "0x1681328", VA = "0x1681328")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x1681330", Offset = "0x1681330", VA = "0x1681330")]
	public SecondaryDollyPath()
	{
	}
}
