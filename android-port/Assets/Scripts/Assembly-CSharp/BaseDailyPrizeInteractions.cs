using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F09")]
public class BaseDailyPrizeInteractions : MonoBehaviour
{
	[Token(Token = "0x4005120")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected DailyPrize dailyAnimalScript;

	[Token(Token = "0x4005121")]
	[FieldOffset(Offset = "0x20")]
	public bool ExecuteOnShoot;

	[Token(Token = "0x4005122")]
	[FieldOffset(Offset = "0x21")]
	public bool ExecuteOnAim;

	[Token(Token = "0x6004645")]
	[Address(RVA = "0x151B670", Offset = "0x151B670", VA = "0x151B670", Slot = "4")]
	public virtual void OnUnpack(Vector3 b)
	{
	}

	[Token(Token = "0x6004646")]
	[Address(RVA = "0x151B674", Offset = "0x151B674", VA = "0x151B674", Slot = "5")]
	public virtual void OnUnpackImmidiate(Vector3 b)
	{
	}

	[Token(Token = "0x6004647")]
	[Address(RVA = "0x151B678", Offset = "0x151B678", VA = "0x151B678", Slot = "6")]
	public virtual void OnAimNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004648")]
	[Address(RVA = "0x151B67C", Offset = "0x151B67C", VA = "0x151B67C", Slot = "7")]
	public virtual void OnAimWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004649")]
	[Address(RVA = "0x151B680", Offset = "0x151B680", VA = "0x151B680", Slot = "8")]
	public virtual void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x600464A")]
	[Address(RVA = "0x151B684", Offset = "0x151B684", VA = "0x151B684", Slot = "9")]
	public virtual void OnShootWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x600464B")]
	[Address(RVA = "0x151B688", Offset = "0x151B688", VA = "0x151B688", Slot = "10")]
	public virtual void OnLoseFocus()
	{
	}

	[Token(Token = "0x600464C")]
	[Address(RVA = "0x151B68C", Offset = "0x151B68C", VA = "0x151B68C", Slot = "11")]
	public virtual void OnGetFocus()
	{
	}

	[Token(Token = "0x600464D")]
	[Address(RVA = "0x151B690", Offset = "0x151B690", VA = "0x151B690")]
	private void Awake()
	{
	}

	[Token(Token = "0x600464E")]
	[Address(RVA = "0x151BA84", Offset = "0x151BA84", VA = "0x151BA84")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600464F")]
	[Address(RVA = "0x151BE54", Offset = "0x151BE54", VA = "0x151BE54")]
	public BaseDailyPrizeInteractions()
	{
	}
}
