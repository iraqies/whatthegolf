using Il2CppDummyDll;
using UnityEngine;

namespace xmas
{
	[Token(Token = "0x20011EE")]
	[Attribute(Name = "RequireComponent", RVA = "0x4838C", Offset = "0x4838C")]
	public class StopRollingWhenAiming : MonoBehaviour
	{
		[Token(Token = "0x400607A")]
		[FieldOffset(Offset = "0x18")]
		public float brake;

		[Token(Token = "0x400607B")]
		[FieldOffset(Offset = "0x20")]
		private Rigidbody rigid;

		[Token(Token = "0x6005260")]
		[Address(RVA = "0x16E2484", Offset = "0x16E2484", VA = "0x16E2484")]
		private void Start()
		{
		}

		[Token(Token = "0x6005261")]
		[Address(RVA = "0x16E257C", Offset = "0x16E257C", VA = "0x16E257C")]
		private void Controller_OnAimUpdate(Vector3 boost, bool IsNotOrange)
		{
		}

		[Token(Token = "0x6005262")]
		[Address(RVA = "0x16E2640", Offset = "0x16E2640", VA = "0x16E2640")]
		public StopRollingWhenAiming()
		{
		}
	}
}
