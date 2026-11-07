using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000253")]
public class PuppetSpeedBoostPad : MonoBehaviour
{
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool useLocalPadDirection;

	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 direction;

	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float force;

	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection sfxOnJump;

	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x38")]
	private float lastSfxTime;

	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x162CE0C", Offset = "0x162CE0C", VA = "0x162CE0C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x162D420", Offset = "0x162D420", VA = "0x162D420")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x162D518", Offset = "0x162D518", VA = "0x162D518")]
	public PuppetSpeedBoostPad()
	{
	}
}
