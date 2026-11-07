using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013A7")]
	public class SFXOnFacingCollision : MonoBehaviour
	{
		[Token(Token = "0x40069CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody rigidbody;

		[Token(Token = "0x40069CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float sleepThreshold;

		[Token(Token = "0x40069CC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 localFacingDirection;

		[Token(Token = "0x40069CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 checkForWorldDirection;

		[Token(Token = "0x40069CE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float directionThreshold;

		[Token(Token = "0x40069CF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float checkTime;

		[Token(Token = "0x40069D0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClipSettingsCollection sfx;

		[Token(Token = "0x40069D1")]
		[FieldOffset(Offset = "0x50")]
		private float _timer;

		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x1666EA4", Offset = "0x1666EA4", VA = "0x1666EA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x166700C", Offset = "0x166700C", VA = "0x166700C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x1667018", Offset = "0x1667018", VA = "0x1667018")]
		public SFXOnFacingCollision()
		{
		}
	}
}
