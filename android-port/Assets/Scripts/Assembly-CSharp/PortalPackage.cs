using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000806")]
public class PortalPackage
{
	[Token(Token = "0x4002B25")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F114", Offset = "0x4F114")]
	private readonly SimplePortal From__BackingField;

	[Token(Token = "0x4002B26")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F124", Offset = "0x4F124")]
	private readonly SimplePortal To__BackingField;

	[Token(Token = "0x4002B27")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F134", Offset = "0x4F134")]
	private readonly Vector3 EntryPoint__BackingField;

	[Token(Token = "0x17000402")]
	public SimplePortal From
	{
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x161C708", Offset = "0x161C708", VA = "0x161C708")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x666F0", Offset = "0x666F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000403")]
	public SimplePortal To
	{
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x161C710", Offset = "0x161C710", VA = "0x161C710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x66700", Offset = "0x66700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60024E5")]
	[Address(RVA = "0x161C718", Offset = "0x161C718", VA = "0x161C718")]
	public PortalPackage(SimplePortal from, SimplePortal to, Vector3 entryPoint)
	{
	}
}
