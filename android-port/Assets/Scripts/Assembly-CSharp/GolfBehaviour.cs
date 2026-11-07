using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004A7")]
public class GolfBehaviour : MonoBehaviour
{
	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected bool didInit;

	[Token(Token = "0x600156F")]
	[Address(RVA = "0x149A0A0", Offset = "0x149A0A0", VA = "0x149A0A0", Slot = "4")]
	public virtual void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6001570")]
	[Address(RVA = "0x149A0AC", Offset = "0x149A0AC", VA = "0x149A0AC")]
	public GolfBehaviour()
	{
	}
}
