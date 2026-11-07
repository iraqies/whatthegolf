using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A56")]
public class ShowSpeechBubble : MonoBehaviour
{
	[Token(Token = "0x4003922")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected GameObject SpeechBubblePrefab;

	[Token(Token = "0x4003923")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Animator anim;

	[Token(Token = "0x4003924")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected SpeechAudioBase speechAudio;

	[Token(Token = "0x4003925")]
	[FieldOffset(Offset = "0x30")]
	protected SpeechBubbleUI SpeechBubble;

	[Token(Token = "0x4003926")]
	[FieldOffset(Offset = "0x38")]
	public bool IsInterrupted;

	[Token(Token = "0x4003927")]
	[FieldOffset(Offset = "0x39")]
	protected bool IsHandlingHit;

	[Token(Token = "0x6003141")]
	[Address(RVA = "0x16A6254", Offset = "0x16A6254", VA = "0x16A6254", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6003142")]
	[Address(RVA = "0x16A6304", Offset = "0x16A6304", VA = "0x16A6304")]
	private void ListenForInterruption()
	{
	}

	[Token(Token = "0x6003143")]
	[Address(RVA = "0x16A64C8", Offset = "0x16A64C8", VA = "0x16A64C8")]
	protected void PoolSpeechBubble()
	{
	}

	[Token(Token = "0x6003144")]
	[Address(RVA = "0x16A651C", Offset = "0x16A651C", VA = "0x16A651C")]
	public ShowSpeechBubble()
	{
	}

	[Token(Token = "0x6003145")]
	[Address(RVA = "0x16A6524", Offset = "0x16A6524", VA = "0x16A6524")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x698B4", Offset = "0x698B4")]
	private void _003CListenForInterruption_003Eb__7_0()
	{
	}

	[Token(Token = "0x6003146")]
	[Address(RVA = "0x16A6530", Offset = "0x16A6530", VA = "0x16A6530")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x698C4", Offset = "0x698C4")]
	private void _003CListenForInterruption_003Eb__7_2(List<LevelData> lvls)
	{
	}

	[Token(Token = "0x6003147")]
	[Address(RVA = "0x16A653C", Offset = "0x16A653C", VA = "0x16A653C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x698D4", Offset = "0x698D4")]
	private void _003CListenForInterruption_003Eb__7_1(bool active)
	{
	}
}
