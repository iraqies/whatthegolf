using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C5D")]
public class ToggleBehaviourOnStart : MonoBehaviour
{
	[Token(Token = "0x40043E6")]
	[FieldOffset(Offset = "0x18")]
	public List<Behaviour> BehavioursToToggle;

	[Token(Token = "0x6003AC5")]
	[Address(RVA = "0x171A0DC", Offset = "0x171A0DC", VA = "0x171A0DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AC6")]
	[Address(RVA = "0x171A240", Offset = "0x171A240", VA = "0x171A240")]
	public ToggleBehaviourOnStart()
	{
	}
}
