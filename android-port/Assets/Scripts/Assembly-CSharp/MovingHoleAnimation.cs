using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E8")]
public class MovingHoleAnimation : MonoBehaviour
{
	[Token(Token = "0x4002A61")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationCurve movementCurve;

	[Token(Token = "0x4002A62")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float timeOffset;

	[Token(Token = "0x4002A63")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float speedRatio;

	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0x28")]
	private MovingHole hole;

	[Token(Token = "0x6002455")]
	[Address(RVA = "0x1577978", Offset = "0x1577978", VA = "0x1577978")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002456")]
	[Address(RVA = "0x15779D4", Offset = "0x15779D4", VA = "0x15779D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002457")]
	[Address(RVA = "0x1577A30", Offset = "0x1577A30", VA = "0x1577A30")]
	public MovingHoleAnimation()
	{
	}
}
