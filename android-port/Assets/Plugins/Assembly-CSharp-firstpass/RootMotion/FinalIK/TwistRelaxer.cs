using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200018F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x20")]
		public Transform parent;

		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x28")]
		public Transform child;

		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RangeAttribute", RVA = "0x366A4", Offset = "0x366A4")]
		public float weight;

		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "RangeAttribute", RVA = "0x366BC", Offset = "0x366BC")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x366D4", Offset = "0x366D4")]
		public float twistAngleOffset;

		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x13237D8", Offset = "0x13237D8", VA = "0x13237D8")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x1323AFC", Offset = "0x1323AFC", VA = "0x1323AFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x1323ECC", Offset = "0x1323ECC", VA = "0x1323ECC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x1323F64", Offset = "0x1323F64", VA = "0x1323F64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x1323FFC", Offset = "0x1323FFC", VA = "0x1323FFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x1324124", Offset = "0x1324124", VA = "0x1324124")]
		public TwistRelaxer()
		{
		}
	}
}
