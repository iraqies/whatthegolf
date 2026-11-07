using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C5B")]
public class ToggleBehaviourBasedOnPlatform : MonoBehaviour
{
	[Token(Token = "0x2000C5C")]
	public enum WhenToToggleEnum
	{
		[Token(Token = "0x40043E3")]
		Awake = 0,
		[Token(Token = "0x40043E4")]
		OnEnable = 1,
		[Token(Token = "0x40043E5")]
		Start = 2
	}

	[Token(Token = "0x40043DE")]
	[FieldOffset(Offset = "0x18")]
	public bool StateOnMobile;

	[Token(Token = "0x40043DF")]
	[FieldOffset(Offset = "0x20")]
	public Behaviour[] BehavioursToToggle;

	[Token(Token = "0x40043E0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] GameObjectsToToggle;

	[Token(Token = "0x40043E1")]
	[FieldOffset(Offset = "0x30")]
	public WhenToToggleEnum WhenToToggle;

	[Token(Token = "0x6003AC0")]
	[Address(RVA = "0x1719F8C", Offset = "0x1719F8C", VA = "0x1719F8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003AC1")]
	[Address(RVA = "0x171A0B0", Offset = "0x171A0B0", VA = "0x171A0B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AC2")]
	[Address(RVA = "0x171A0C4", Offset = "0x171A0C4", VA = "0x171A0C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AC3")]
	[Address(RVA = "0x1719FA0", Offset = "0x1719FA0", VA = "0x1719FA0")]
	private void Toggle()
	{
	}

	[Token(Token = "0x6003AC4")]
	[Address(RVA = "0x171A0D4", Offset = "0x171A0D4", VA = "0x171A0D4")]
	public ToggleBehaviourBasedOnPlatform()
	{
	}
}
