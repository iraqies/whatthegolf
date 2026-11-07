using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D6F")]
public class EventOnFlagComplete : MonoBehaviour
{
	[Token(Token = "0x400490D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OverworldGoal goals;

	[Token(Token = "0x400490E")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent _event;

	[Token(Token = "0x400490F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool requireAll;

	[Token(Token = "0x6003F30")]
	[Address(RVA = "0x1446ED4", Offset = "0x1446ED4", VA = "0x1446ED4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F31")]
	[Address(RVA = "0x1446F20", Offset = "0x1446F20", VA = "0x1446F20")]
	private bool IsComplete()
	{
		return default;
	}

	[Token(Token = "0x6003F32")]
	[Address(RVA = "0x1446F3C", Offset = "0x1446F3C", VA = "0x1446F3C")]
	public EventOnFlagComplete()
	{
	}
}
