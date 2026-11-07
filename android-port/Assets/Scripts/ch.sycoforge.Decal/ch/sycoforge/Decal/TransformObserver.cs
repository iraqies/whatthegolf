using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[Token(Token = "0x2000040")]
	internal class TransformObserver
	{
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 lastPosition;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 lastScale;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Quaternion lastRotation;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform transform;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2C70B8C", Offset = "0x2C70B8C", VA = "0x2C70B8C")]
		public TransformObserver(Transform transform)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2C70BB8", Offset = "0x2C70BB8", VA = "0x2C70BB8")]
		public OrientationChange CheckTransformChange()
		{
			return default;
		}
	}
}
