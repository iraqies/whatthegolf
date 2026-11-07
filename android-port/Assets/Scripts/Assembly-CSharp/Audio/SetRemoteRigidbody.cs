using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013C3")]
	public class SetRemoteRigidbody : MonoBehaviour
	{
		[Token(Token = "0x4006A51")]
		[FieldOffset(Offset = "0x18")]
		public bool canSetAutomatically;

		[Token(Token = "0x4006A52")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Root;

		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x168F2E4", Offset = "0x168F2E4", VA = "0x168F2E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x168F684", Offset = "0x168F684", VA = "0x168F684")]
		public SetRemoteRigidbody()
		{
		}
	}
}
