using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200024A")]
public class PickUpPropTrigger : MonoBehaviour
{
	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x18")]
	public PuppetMasterProp Prop;

	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x20")]
	private bool pickedUp;

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x15E1A78", Offset = "0x15E1A78", VA = "0x15E1A78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x15E1B6C", Offset = "0x15E1B6C", VA = "0x15E1B6C")]
	public PickUpPropTrigger()
	{
	}
}
