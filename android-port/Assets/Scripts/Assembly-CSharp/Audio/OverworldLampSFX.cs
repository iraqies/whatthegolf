using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001394")]
	public class OverworldLampSFX : MonoBehaviour
	{
		[Token(Token = "0x4006913")]
		[FieldOffset(Offset = "0x18")]
		public float threshold;

		[Token(Token = "0x4006914")]
		[FieldOffset(Offset = "0x20")]
		public OnCollisionAudioBase col;

		[Token(Token = "0x4006915")]
		[FieldOffset(Offset = "0x28")]
		public PlayClipOnAudioEvent SFX;

		[Token(Token = "0x4006916")]
		[FieldOffset(Offset = "0x30")]
		public float averageValue;

		[Token(Token = "0x4006917")]
		[FieldOffset(Offset = "0x38")]
		private HingeJoint2D hinge;

		[Token(Token = "0x4006918")]
		[FieldOffset(Offset = "0x40")]
		private float postCollisionCheckTime;

		[Token(Token = "0x4006919")]
		[FieldOffset(Offset = "0x44")]
		private float collisionTime;

		[Token(Token = "0x400691A")]
		[FieldOffset(Offset = "0x48")]
		public float lastJointAngle;

		[Token(Token = "0x400691B")]
		[FieldOffset(Offset = "0x4C")]
		private bool canCheck;

		[Token(Token = "0x400691C")]
		[FieldOffset(Offset = "0x4D")]
		private bool isGoingLeft;

		[Token(Token = "0x400691D")]
		[FieldOffset(Offset = "0x4E")]
		public bool crossedMiddle;

		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x15BA660", Offset = "0x15BA660", VA = "0x15BA660")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x15BA71C", Offset = "0x15BA71C", VA = "0x15BA71C")]
		private void Col_OnAudioPlay()
		{
		}

		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x15BA770", Offset = "0x15BA770", VA = "0x15BA770")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x15BA7B8", Offset = "0x15BA7B8", VA = "0x15BA7B8")]
		private void HandleSwing2()
		{
		}

		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x15BA974", Offset = "0x15BA974", VA = "0x15BA974")]
		public OverworldLampSFX()
		{
		}
	}
}
