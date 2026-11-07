using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C71")]
public class pLogger
{
	[Token(Token = "0x400441F")]
	[FieldOffset(Offset = "0x10")]
	public bool logEnabled;

	[Token(Token = "0x4004420")]
	[FieldOffset(Offset = "0x18")]
	private ILogHandler logHandler;

	[Token(Token = "0x6003B0A")]
	[Address(RVA = "0x17655F0", Offset = "0x17655F0", VA = "0x17655F0")]
	public pLogger(ILogHandler logHandler)
	{
	}

	[Token(Token = "0x6003B0B")]
	[Address(RVA = "0x1765740", Offset = "0x1765740", VA = "0x1765740")]
	public void Log(string tag, Func<string> messageFunc)
	{
	}

	[Token(Token = "0x6003B0C")]
	[Address(RVA = "0x176591C", Offset = "0x176591C", VA = "0x176591C")]
	public void LogWarning(string tag, Func<string> messageFunc)
	{
	}

	[Token(Token = "0x6003B0D")]
	[Address(RVA = "0x1765750", Offset = "0x1765750", VA = "0x1765750")]
	private void Log(LogType logType, string tag, Func<string> messageFunc)
	{
	}
}
