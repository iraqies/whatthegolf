using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x2001403")]
	public class RumbleOnRagdollImpact : MonoBehaviour
	{
		[Token(Token = "0x4006B6B")]
		[FieldOffset(Offset = "0x18")]
		public float minVelocity;

		[Token(Token = "0x4006B6C")]
		[FieldOffset(Offset = "0x1C")]
		public float maxVelocity;

		[Token(Token = "0x4006B6D")]
		[FieldOffset(Offset = "0x20")]
		public float cooldown;

		[Token(Token = "0x4006B6E")]
		[FieldOffset(Offset = "0x28")]
		public VelocityRumble[] velocityRumble;

		[Token(Token = "0x4006B6F")]
		[FieldOffset(Offset = "0x30")]
		public LayerMask layerMask;

		[Token(Token = "0x4006B70")]
		[FieldOffset(Offset = "0x34")]
		public LimbGroupType limbGroupType;

		[Token(Token = "0x4006B71")]
		[FieldOffset(Offset = "0x38")]
		public RagdollLimbSettings ragdollSettings;

		[Token(Token = "0x4006B72")]
		[FieldOffset(Offset = "0x40")]
		public GolfBallController golfballController;

		[Token(Token = "0x4006B73")]
		[FieldOffset(Offset = "0x48")]
		private float nextPlayTime;

		[Token(Token = "0x17000A8A")]
		private int PlayerIndex
		{
			[Token(Token = "0x6005D27")]
			[Address(RVA = "0x1662308", Offset = "0x1662308", VA = "0x1662308")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005D28")]
		[Address(RVA = "0x166239C", Offset = "0x166239C", VA = "0x166239C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005D29")]
		[Address(RVA = "0x1662550", Offset = "0x1662550", VA = "0x1662550")]
		private void OnCollision(HitInfo obj)
		{
		}

		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0x1662704", Offset = "0x1662704", VA = "0x1662704")]
		public RumbleOnRagdollImpact()
		{
		}
	}
}
