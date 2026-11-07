using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001103")]
	public class CBFollowOrbit : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[Token(Token = "0x40059C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform orbitTarget;

		[Token(Token = "0x40059C7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Transform followTarget;

		[Token(Token = "0x40059C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x40059C9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 positionOffset;

		[Token(Token = "0x1700080F")]
		public Transform FollowTarget
		{
			[Token(Token = "0x6004C37")]
			[Address(RVA = "0x17DC820", Offset = "0x17DC820", VA = "0x17DC820")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C38")]
			[Address(RVA = "0x17DC828", Offset = "0x17DC828", VA = "0x17DC828")]
			set
			{
			}
		}

		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x17DC830", Offset = "0x17DC830", VA = "0x17DC830", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x17DC8D4", Offset = "0x17DC8D4", VA = "0x17DC8D4", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x17DC974", Offset = "0x17DC974", VA = "0x17DC974", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0x17DCA1C", Offset = "0x17DCA1C", VA = "0x17DCA1C")]
		public void SetOrbitTarget(Transform newOrbitTarget)
		{
		}

		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0x17DCA24", Offset = "0x17DCA24", VA = "0x17DCA24", Slot = "12")]
		public void SetFollowTarget(Transform newFollowTarget)
		{
		}

		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x17DCA2C", Offset = "0x17DCA2C", VA = "0x17DCA2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x17DCA70", Offset = "0x17DCA70", VA = "0x17DCA70", Slot = "13")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x17DCA78", Offset = "0x17DCA78", VA = "0x17DCA78")]
		public CBFollowOrbit()
		{
		}
	}
}
