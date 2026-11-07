using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000D7")]
	public class AvatarUtility
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x12F42F8", Offset = "0x12F42F8", VA = "0x12F42F8")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x12F48E8", Offset = "0x12F48E8", VA = "0x12F48E8")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default;
		}
	}
}
