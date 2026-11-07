using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace BustAMoveGolf
{
	[Token(Token = "0x20010DE")]
	public class BustAMoveBall : MonoBehaviour
	{
		[Token(Token = "0x40058E1")]
		[FieldOffset(Offset = "0x18")]
		public BustAMoveColor Color;

		[Token(Token = "0x40058E2")]
		[FieldOffset(Offset = "0x20")]
		public BustAMoveBall[] neighbors;

		[Token(Token = "0x40058E3")]
		[FieldOffset(Offset = "0x28")]
		public bool even;

		[Token(Token = "0x40058E4")]
		[FieldOffset(Offset = "0x29")]
		public bool moving;

		[Token(Token = "0x40058E5")]
		[FieldOffset(Offset = "0x2A")]
		public bool attached;

		[Token(Token = "0x40058E6")]
		[FieldOffset(Offset = "0x30")]
		public RandomAudioClips snapClips;

		[Token(Token = "0x40058E7")]
		[FieldOffset(Offset = "0x38")]
		public RandomAudioClips bounceClips;

		[Token(Token = "0x40058E8")]
		[FieldOffset(Offset = "0x40")]
		private SimplexGridManager simplexGridManager;

		[Token(Token = "0x40058E9")]
		[FieldOffset(Offset = "0x48")]
		private int bounces;

		[Token(Token = "0x40058EA")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 velocity;

		[Token(Token = "0x6004B88")]
		[Address(RVA = "0x17D8B04", Offset = "0x17D8B04", VA = "0x17D8B04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B89")]
		[Address(RVA = "0x17D8B88", Offset = "0x17D8B88", VA = "0x17D8B88")]
		public static BustAMoveColor GetRandomColor()
		{
			return default;
		}

		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0x17D8B98", Offset = "0x17D8B98", VA = "0x17D8B98")]
		public void Fall()
		{
		}

		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x17D8CE0", Offset = "0x17D8CE0", VA = "0x17D8CE0")]
		public void DisconnectFromNeighbors()
		{
		}

		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x17D8E0C", Offset = "0x17D8E0C", VA = "0x17D8E0C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x17D8EF0", Offset = "0x17D8EF0", VA = "0x17D8EF0")]
		public void UpdateNeighbors()
		{
		}

		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x17D9054", Offset = "0x17D9054", VA = "0x17D9054")]
		private void OnCollisionEnter(Collision col)
		{
		}

		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x17D9394", Offset = "0x17D9394", VA = "0x17D9394")]
		public void SetColor(BustAMoveColor color)
		{
		}

		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x17D942C", Offset = "0x17D942C", VA = "0x17D942C")]
		public BustAMoveBall[] FindBallsConnectedByColor()
		{
			return null;
		}

		[Token(Token = "0x6004B91")]
		[Address(RVA = "0x17D96B0", Offset = "0x17D96B0", VA = "0x17D96B0")]
		public bool CheckIfConnctedToAttachedBall()
		{
			return default;
		}

		[Token(Token = "0x6004B92")]
		[Address(RVA = "0x17D9928", Offset = "0x17D9928", VA = "0x17D9928")]
		public BustAMoveBall()
		{
		}
	}
}
