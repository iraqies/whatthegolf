using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D52")]
public class WwiseTriggerParser : MonoBehaviour
{
	[Token(Token = "0x2000D53")]
	public class WwwiseTrigger : MonoBehaviour
	{
		[Token(Token = "0x400487F")]
		[FieldOffset(Offset = "0x18")]
		public string dataName;

		[Token(Token = "0x4004880")]
		[FieldOffset(Offset = "0x20")]
		public uint shortID;

		[Token(Token = "0x4004881")]
		[FieldOffset(Offset = "0x28")]
		public string longID;

		[Token(Token = "0x6003EBE")]
		[Address(RVA = "0x187D508", Offset = "0x187D508", VA = "0x187D508")]
		public void Init(string id, string name)
		{
		}

		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x187D6FC", Offset = "0x187D6FC", VA = "0x187D6FC")]
		public WwwiseTrigger()
		{
		}
	}

	[Token(Token = "0x400487C")]
	[FieldOffset(Offset = "0x18")]
	public TextAsset file;

	[Token(Token = "0x400487D")]
	[FieldOffset(Offset = "0x20")]
	public TextAsset bigFile;

	[Token(Token = "0x400487E")]
	[FieldOffset(Offset = "0x28")]
	public List<WwwiseTrigger> triggers;

	[Token(Token = "0x6003EBD")]
	[Address(RVA = "0x1761100", Offset = "0x1761100", VA = "0x1761100")]
	public WwiseTriggerParser()
	{
	}
}
