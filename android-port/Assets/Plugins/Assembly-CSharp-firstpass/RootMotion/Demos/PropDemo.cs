using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200023D")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x20")]
		public PropMuscle propMuscleLeft;

		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x28")]
		public PropMuscle propMuscleRight;

		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x30")]
		public bool pickUpOnAwake;

		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x170001D8")]
		private PropMuscle connectTo
		{
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x13C1A90", Offset = "0x13C1A90", VA = "0x13C1A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x13C1A50", Offset = "0x13C1A50", VA = "0x13C1A50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x13C1AAC", Offset = "0x13C1AAC", VA = "0x13C1AAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x13C1B6C", Offset = "0x13C1B6C", VA = "0x13C1B6C")]
		public PropDemo()
		{
		}
	}
}
