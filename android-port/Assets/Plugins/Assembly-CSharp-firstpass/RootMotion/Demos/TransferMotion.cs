using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000216")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x18")]
		public Transform to;

		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36D28", Offset = "0x36D28")]
		public float transferMotion;

		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x1323104", Offset = "0x1323104", VA = "0x1323104")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x1323140", Offset = "0x1323140", VA = "0x1323140")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x13231F4", Offset = "0x13231F4", VA = "0x13231F4")]
		public TransferMotion()
		{
		}
	}
}
