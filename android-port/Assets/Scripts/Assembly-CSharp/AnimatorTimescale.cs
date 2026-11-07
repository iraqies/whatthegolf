using Chronos;
using Il2CppDummyDll;
using Puzzle;
using UnityEngine;

[Token(Token = "0x2000A34")]
[Attribute(Name = "RequireComponent", RVA = "0x42B18", Offset = "0x42B18")]
public class AnimatorTimescale : MonoBehaviour, ITimedPuzzleObject
{
	[Token(Token = "0x4003858")]
	[FieldOffset(Offset = "0x18")]
	private Animator animator;

	[Token(Token = "0x4003859")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x503B4", Offset = "0x503B4")]
	private LocalClock BallClock__BackingField;

	[Token(Token = "0x17000508")]
	public LocalClock BallClock
	{
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x1418364", Offset = "0x1418364", VA = "0x1418364", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6951C", Offset = "0x6951C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x141836C", Offset = "0x141836C", VA = "0x141836C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6952C", Offset = "0x6952C")]
		private set
		{
		}
	}

	[Token(Token = "0x6003096")]
	[Address(RVA = "0x1418374", Offset = "0x1418374", VA = "0x1418374", Slot = "6")]
	public float GetDeltaTime()
	{
		return default;
	}

	[Token(Token = "0x6003097")]
	[Address(RVA = "0x141841C", Offset = "0x141841C", VA = "0x141841C", Slot = "4")]
	public void SetClock(LocalClock clock)
	{
	}

	[Token(Token = "0x6003098")]
	[Address(RVA = "0x1418480", Offset = "0x1418480", VA = "0x1418480")]
	private void Update()
	{
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x1418568", Offset = "0x1418568", VA = "0x1418568")]
	public AnimatorTimescale()
	{
	}
}
