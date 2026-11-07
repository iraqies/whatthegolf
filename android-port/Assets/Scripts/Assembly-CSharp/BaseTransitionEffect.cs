using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B92")]
public abstract class BaseTransitionEffect : MonoBehaviour
{
	[Token(Token = "0x60037D6")]
	public abstract IEnumerator Begin();

	[Token(Token = "0x60037D7")]
	public abstract IEnumerator End(float overrideTransitionDuration = 0f);

	[Token(Token = "0x60037D8")]
	[Address(RVA = "0x16093C8", Offset = "0x16093C8", VA = "0x16093C8", Slot = "6")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60037D9")]
	[Address(RVA = "0x16093CC", Offset = "0x16093CC", VA = "0x16093CC", Slot = "7")]
	public virtual void PreBegin(Color? color)
	{
	}

	[Token(Token = "0x60037DA")]
	[Address(RVA = "0x16093D0", Offset = "0x16093D0", VA = "0x16093D0", Slot = "8")]
	public virtual void CleanUp()
	{
	}

	[Token(Token = "0x60037DB")]
	[Address(RVA = "0x16093D4", Offset = "0x16093D4", VA = "0x16093D4", Slot = "9")]
	public virtual void InstantTransitionCover(Color? color)
	{
	}

	[Token(Token = "0x60037DC")]
	[Address(RVA = "0x16093D8", Offset = "0x16093D8", VA = "0x16093D8")]
	protected BaseTransitionEffect()
	{
	}
}
