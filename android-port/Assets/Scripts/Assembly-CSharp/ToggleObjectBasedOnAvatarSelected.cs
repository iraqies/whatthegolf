using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200014E")]
public class ToggleObjectBasedOnAvatarSelected : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC50", Offset = "0x3DC50")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Renderer> _003C_003E9__2_0;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1869058", Offset = "0x1869058", VA = "0x1869058")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1869060", Offset = "0x1869060", VA = "0x1869060")]
		internal void _003CUpdateBasedOnAvatar_003Eb__2_0(Renderer b)
		{
		}
	}

	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x18")]
	public PlayerColors.AvatarIDs AvatarIDThatEnablesObject;

	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x20")]
	public List<Renderer> RenderersToDisableIfSeleceted;

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x171B7AC", Offset = "0x171B7AC", VA = "0x171B7AC")]
	public void UpdateBasedOnAvatar(MultiplayerConfiguration.PlayerInfo player)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x171B918", Offset = "0x171B918", VA = "0x171B918")]
	public ToggleObjectBasedOnAvatarSelected()
	{
	}
}
