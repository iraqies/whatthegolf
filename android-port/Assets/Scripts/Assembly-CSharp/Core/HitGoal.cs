using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001445")]
	public class HitGoal : MonoBehaviour
	{
		[Token(Token = "0x4006DF8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GolfBallController ball;

		[Token(Token = "0x4006DF9")]
		[FieldOffset(Offset = "0x20")]
		private GolfGoal goal;

		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0x14CD0E8", Offset = "0x14CD0E8", VA = "0x14CD0E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005EC8")]
		[Address(RVA = "0x14CD144", Offset = "0x14CD144", VA = "0x14CD144")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005EC9")]
		[Address(RVA = "0x14CD20C", Offset = "0x14CD20C", VA = "0x14CD20C")]
		public HitGoal()
		{
		}
	}
}
