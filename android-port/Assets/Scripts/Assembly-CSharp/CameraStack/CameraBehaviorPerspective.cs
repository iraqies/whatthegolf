using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001115")]
	public abstract class CameraBehaviorPerspective : CameraBehavior
	{
		[Token(Token = "0x4005A6B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float fieldOfView;

		[Token(Token = "0x17000820")]
		public virtual float FOV
		{
			[Token(Token = "0x6004CD2")]
			[Address(RVA = "0x17E4410", Offset = "0x17E4410", VA = "0x17E4410", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0x17DA298", Offset = "0x17DA298", VA = "0x17DA298", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004CD4")]
		[Address(RVA = "0x17E2CB0", Offset = "0x17E2CB0", VA = "0x17E2CB0", Slot = "6")]
		public override void PreUpdate()
		{
		}

		[Token(Token = "0x6004CD5")]
		[Address(RVA = "0x17DA8D4", Offset = "0x17DA8D4", VA = "0x17DA8D4")]
		protected CameraBehaviorPerspective()
		{
		}
	}
}
