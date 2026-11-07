using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E9")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170001B9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x13AC454", Offset = "0x13AC454", VA = "0x13AC454")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x13AC4E0", Offset = "0x13AC4E0", VA = "0x13AC4E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x13AC76C", Offset = "0x13AC76C", VA = "0x13AC76C")]
		public MechSpiderController()
		{
		}
	}
}
