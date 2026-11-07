using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200088B")]
public class TriggerEvent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200088C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B50", Offset = "0x41B50")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002EF0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002EF1")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__19_0;

		[Token(Token = "0x600277B")]
		[Address(RVA = "0x186D4AC", Offset = "0x186D4AC", VA = "0x186D4AC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600277C")]
		[Address(RVA = "0x186D4B4", Offset = "0x186D4B4", VA = "0x186D4B4")]
		internal void _003CEnterInvoke_003Eb__19_0(AudioSource m)
		{
		}
	}

	[Token(Token = "0x4002EE3")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnEnter;

	[Token(Token = "0x4002EE4")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnExit;

	[Token(Token = "0x4002EE5")]
	[FieldOffset(Offset = "0x28")]
	public List<string> Tags;

	[Token(Token = "0x4002EE6")]
	[FieldOffset(Offset = "0x30")]
	public Color OnColor;

	[Token(Token = "0x4002EE7")]
	[FieldOffset(Offset = "0x40")]
	public Color OffColor;

	[Token(Token = "0x4002EE8")]
	[FieldOffset(Offset = "0x50")]
	public int PlayersOnButton;

	[Token(Token = "0x4002EE9")]
	[FieldOffset(Offset = "0x54")]
	public float Delay;

	[Token(Token = "0x4002EEA")]
	[FieldOffset(Offset = "0x58")]
	public List<AudioClip> OnTriggeredClips;

	[Token(Token = "0x4002EEB")]
	[FieldOffset(Offset = "0x60")]
	public Animator ButtonAnimator;

	[Token(Token = "0x4002EEC")]
	[FieldOffset(Offset = "0x68")]
	public List<MeshRenderer> MeshesToUpdate;

	[Token(Token = "0x4002EED")]
	[FieldOffset(Offset = "0x70")]
	private Light light;

	[Token(Token = "0x4002EEE")]
	[FieldOffset(Offset = "0x78")]
	private float delayTime;

	[Token(Token = "0x4002EEF")]
	[FieldOffset(Offset = "0x7C")]
	private bool delayIsEnterInvoke;

	[Token(Token = "0x6002771")]
	[Address(RVA = "0x172DDF0", Offset = "0x172DDF0", VA = "0x172DDF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002772")]
	[Address(RVA = "0x172DF88", Offset = "0x172DF88", VA = "0x172DF88")]
	private void Update()
	{
	}

	[Token(Token = "0x6002773")]
	[Address(RVA = "0x172E5E0", Offset = "0x172E5E0", VA = "0x172E5E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002774")]
	[Address(RVA = "0x172E6AC", Offset = "0x172E6AC", VA = "0x172E6AC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002775")]
	[Address(RVA = "0x172E778", Offset = "0x172E778", VA = "0x172E778")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x172E840", Offset = "0x172E840", VA = "0x172E840")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x172E000", Offset = "0x172E000", VA = "0x172E000")]
	private void EnterInvoke()
	{
	}

	[Token(Token = "0x6002778")]
	[Address(RVA = "0x172E37C", Offset = "0x172E37C", VA = "0x172E37C")]
	private void ExitInvoke()
	{
	}

	[Token(Token = "0x6002779")]
	[Address(RVA = "0x172E908", Offset = "0x172E908", VA = "0x172E908")]
	public TriggerEvent()
	{
	}
}
