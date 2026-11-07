using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A5")]
public class KeepSomethingSelected : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF80", Offset = "0x3DF80")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Selectable, bool> _003C_003E9__6_0;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x17CCD40", Offset = "0x17CCD40", VA = "0x17CCD40")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x17CCD48", Offset = "0x17CCD48", VA = "0x17CCD48")]
		internal bool _003CKeepSelection_003Eb__6_0(Selectable s)
		{
			return default;
		}
	}

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Selectable[] _defaultSelectables;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public GameObject _lastSelected;

	[Token(Token = "0x170000FE")]
	public Selectable[] defaultSelectables
	{
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x14FD770", Offset = "0x14FD770", VA = "0x14FD770")]
		set
		{
		}
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x14FD778", Offset = "0x14FD778", VA = "0x14FD778")]
	private void Update()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x14FDB58", Offset = "0x14FDB58", VA = "0x14FDB58")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x14FD77C", Offset = "0x14FD77C", VA = "0x14FD77C")]
	private void KeepSelection()
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x14FDCD8", Offset = "0x14FDCD8", VA = "0x14FDCD8")]
	public KeepSomethingSelected()
	{
	}
}
