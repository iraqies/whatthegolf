using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013F2")]
	public class AnimationRumble : MonoBehaviour
	{
		[Token(Token = "0x4006B38")]
		[FieldOffset(Offset = "0x18")]
		public List<RumbleEventAsset> rumbles;

		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x1418358", Offset = "0x1418358", VA = "0x1418358")]
		public void AnimationRumbleOneshot(int index)
		{
		}

		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0x141835C", Offset = "0x141835C", VA = "0x141835C")]
		public AnimationRumble()
		{
		}
	}
}
