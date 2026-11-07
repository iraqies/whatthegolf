using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000F0C")]
public class DPIFireEvent : BaseDailyPrizeInteractions
{
	[Token(Token = "0x400512C")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent Event;

	[Token(Token = "0x400512D")]
	[FieldOffset(Offset = "0x30")]
	public float minThreshold;

	[Token(Token = "0x400512E")]
	[FieldOffset(Offset = "0x34")]
	public float maxThreshold;

	[Token(Token = "0x400512F")]
	[FieldOffset(Offset = "0x38")]
	public int maxShotOccurences;

	[Token(Token = "0x4005130")]
	[FieldOffset(Offset = "0x3C")]
	public int startAfterNumberOfOccurences;

	[Token(Token = "0x4005131")]
	[FieldOffset(Offset = "0x40")]
	public bool onUnpack;

	[Token(Token = "0x4005132")]
	[FieldOffset(Offset = "0x41")]
	public bool onShootWhileLocked;

	[Token(Token = "0x4005133")]
	[FieldOffset(Offset = "0x42")]
	public bool onUnpackImmidiate;

	[Token(Token = "0x4005134")]
	[FieldOffset(Offset = "0x44")]
	private int shotOccurences;

	[Token(Token = "0x6004657")]
	[Address(RVA = "0x18C7FD8", Offset = "0x18C7FD8", VA = "0x18C7FD8", Slot = "5")]
	public override void OnUnpackImmidiate(Vector3 b)
	{
	}

	[Token(Token = "0x6004658")]
	[Address(RVA = "0x18C8018", Offset = "0x18C8018", VA = "0x18C8018", Slot = "4")]
	public override void OnUnpack(Vector3 b)
	{
	}

	[Token(Token = "0x6004659")]
	[Address(RVA = "0x18C8128", Offset = "0x18C8128", VA = "0x18C8128", Slot = "9")]
	public override void OnShootWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x600465A")]
	[Address(RVA = "0x18C81D4", Offset = "0x18C81D4", VA = "0x18C81D4", Slot = "8")]
	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x600465B")]
	[Address(RVA = "0x18C82AC", Offset = "0x18C82AC", VA = "0x18C82AC", Slot = "6")]
	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x600465C")]
	[Address(RVA = "0x18C80C4", Offset = "0x18C80C4", VA = "0x18C80C4")]
	private bool isInRange(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x600465D")]
	[Address(RVA = "0x18C8358", Offset = "0x18C8358", VA = "0x18C8358")]
	public DPIFireEvent()
	{
	}
}
