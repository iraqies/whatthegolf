using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B6A")]
public class CommandLineArguments : MonoBehaviour
{
	[Token(Token = "0x4003F53")]
	[FieldOffset(Offset = "0x0")]
	private static CommandLineArguments _instance;

	[Token(Token = "0x4003F54")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, string> arguments;

	[Token(Token = "0x170005BB")]
	public static CommandLineArguments Instance
	{
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x18A9204", Offset = "0x18A9204", VA = "0x18A9204")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60036CF")]
	[Address(RVA = "0x18A9344", Offset = "0x18A9344", VA = "0x18A9344")]
	private string[] GetCommandLineArgs()
	{
		return null;
	}

	[Token(Token = "0x60036D0")]
	[Address(RVA = "0x18A9754", Offset = "0x18A9754", VA = "0x18A9754")]
	private void ParseCommandlineArgs()
	{
	}

	[Token(Token = "0x60036D1")]
	[Address(RVA = "0x18A9C18", Offset = "0x18A9C18", VA = "0x18A9C18")]
	public string GetValue(string key, string ifNotFound)
	{
		return null;
	}

	[Token(Token = "0x60036D2")]
	[Address(RVA = "0x18A9CE4", Offset = "0x18A9CE4", VA = "0x18A9CE4")]
	public CommandLineArguments()
	{
	}
}
