using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002BB")]
public class PostCardAnimationEvents : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EBFC", Offset = "0x3EBFC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__2_0;

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x182AF18", Offset = "0x182AF18", VA = "0x182AF18")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x182AF20", Offset = "0x182AF20", VA = "0x182AF20")]
		internal void _003CPlaySound_003Eb__2_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4000ECD")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip SFX;

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x161DAF4", Offset = "0x161DAF4", VA = "0x161DAF4")]
	public void OnAnimationEnd()
	{
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x161DC2C", Offset = "0x161DC2C", VA = "0x161DC2C")]
	public void PlaySound()
	{
	}

	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x161DD78", Offset = "0x161DD78", VA = "0x161DD78")]
	public PostCardAnimationEvents()
	{
	}
}
