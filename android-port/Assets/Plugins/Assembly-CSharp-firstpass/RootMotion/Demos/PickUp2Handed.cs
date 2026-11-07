using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200020B")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000DC8")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170001C1")]
		private bool holding
		{
			[Token(Token = "0x6000E37")]
			[Address(RVA = "0x13BED20", Offset = "0x13BED20", VA = "0x13BED20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x13BEA34", Offset = "0x13BEA34", VA = "0x13BEA34")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E31")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x13BED40", Offset = "0x13BED40", VA = "0x13BED40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x13BEEE8", Offset = "0x13BEEE8", VA = "0x13BEEE8")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x13BF068", Offset = "0x13BF068", VA = "0x13BF068")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x13BF148", Offset = "0x13BF148", VA = "0x13BF148")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x13BF280", Offset = "0x13BF280", VA = "0x13BF280")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x13BF3EC", Offset = "0x13BF3EC", VA = "0x13BF3EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x13BF5E0", Offset = "0x13BF5E0", VA = "0x13BF5E0")]
		protected PickUp2Handed()
		{
		}
	}
}
