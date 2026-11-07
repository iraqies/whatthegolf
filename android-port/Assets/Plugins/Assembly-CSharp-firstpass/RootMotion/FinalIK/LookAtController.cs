using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001CA")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36A88", Offset = "0x36A88")]
		public float weight;

		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x38")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x3C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x40")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x44")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x48")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x4C")]
		public float slerpSpeed;

		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x5C")]
		public float minDistance;

		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36AA0", Offset = "0x36AA0")]
		public float maxRootAngle;

		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170001AC")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x13A8EE8", Offset = "0x13A8EE8", VA = "0x13A8EE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x13A8E78", Offset = "0x13A8E78", VA = "0x13A8E78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x13A8F78", Offset = "0x13A8F78", VA = "0x13A8F78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x13A94BC", Offset = "0x13A94BC", VA = "0x13A94BC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x13A95A8", Offset = "0x13A95A8", VA = "0x13A95A8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x13A97A0", Offset = "0x13A97A0", VA = "0x13A97A0")]
		public LookAtController()
		{
		}
	}
}
