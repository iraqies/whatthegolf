using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000BF")]
public class DelayedAnimationStart : MonoBehaviour
{
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x18")]
	public float DelayTimeMin;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x1C")]
	public float DelayTimeMax;

	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x20")]
	private float delayTime;

	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x28")]
	private Animator anim;

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x18D92C4", Offset = "0x18D92C4", VA = "0x18D92C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x18D9344", Offset = "0x18D9344", VA = "0x18D9344")]
	private void Update()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x18D93B8", Offset = "0x18D93B8", VA = "0x18D93B8")]
	public DelayedAnimationStart()
	{
	}
}
