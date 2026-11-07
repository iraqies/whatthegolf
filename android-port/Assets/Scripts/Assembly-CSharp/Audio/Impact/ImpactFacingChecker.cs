using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x2001409")]
	public class ImpactFacingChecker : ImpactConditionBase
	{
		[Token(Token = "0x4006B8B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 ObjectDirection;

		[Token(Token = "0x4006B8C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 MustFaceDirection;

		[Token(Token = "0x4006B8D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float directionThreshold;

		[Token(Token = "0x6005D45")]
		[Address(RVA = "0x14E7260", Offset = "0x14E7260", VA = "0x14E7260", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D46")]
		[Address(RVA = "0x14E72D0", Offset = "0x14E72D0", VA = "0x14E72D0")]
		public ImpactFacingChecker()
		{
		}
	}
}
