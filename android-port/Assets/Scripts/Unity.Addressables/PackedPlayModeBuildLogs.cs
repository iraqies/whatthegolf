using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000007")]
public class PackedPlayModeBuildLogs
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public struct RuntimeBuildLog
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		public LogType Type;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x8")]
		public string Message;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A3D10C", Offset = "0x2A3D10C", VA = "0x2A3D10C")]
		public RuntimeBuildLog(LogType type, string message)
		{
		}
	}

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private List<RuntimeBuildLog> m_RuntimeBuildLogs;

	[Token(Token = "0x17000002")]
	public List<RuntimeBuildLog> RuntimeBuildLogs
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A36714", Offset = "0x2A36714", VA = "0x2A36714")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A3671C", Offset = "0x2A3671C", VA = "0x2A3671C")]
		set
		{
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2A36724", Offset = "0x2A36724", VA = "0x2A36724")]
	public PackedPlayModeBuildLogs()
	{
	}
}
