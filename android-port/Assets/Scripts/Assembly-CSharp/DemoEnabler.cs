using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000058")]
public class DemoEnabler : MonoBehaviour
{
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _switchOnly;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool _steamOnly;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool _inverse;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool _applyOnThisObject;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x18D9C44", Offset = "0x18D9C44", VA = "0x18D9C44")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x18D9F78", Offset = "0x18D9F78", VA = "0x18D9F78")]
	public DemoEnabler()
	{
	}
}
