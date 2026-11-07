using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000117")]
	public class PropMuscle : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		public delegate void PropDelegate(PuppetMasterProp prop);

		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x20")]
		public PuppetMasterProp currentProp;

		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 additionalPinOffset;

		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x35884", Offset = "0x35884")]
		private PuppetMasterProp activeProp__BackingField;

		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x40")]
		public PropDelegate OnPickUpProp;

		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x48")]
		public PropDelegate OnDropProp;

		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x50")]
		private Muscle _muscle;

		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x58")]
		private PuppetMasterProp lastProp;

		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 targetDefaultLocalPos;

		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 lastAdditionalPinOffset;

		[Token(Token = "0x170000FF")]
		public Muscle muscle
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x13C1E4C", Offset = "0x13C1E4C", VA = "0x13C1E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		public PuppetMasterProp activeProp
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x13C1F58", Offset = "0x13C1F58", VA = "0x13C1F58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x387F4", Offset = "0x387F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x13C1F60", Offset = "0x13C1F60", VA = "0x13C1F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x38804", Offset = "0x38804")]
			private set
			{
			}
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x13C1F68", Offset = "0x13C1F68", VA = "0x13C1F68")]
		public bool AddAdditionalPin()
		{
			return default;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x13C23E8", Offset = "0x13C23E8", VA = "0x13C23E8")]
		public bool RemoveAdditionalPin()
		{
			return default;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x13C258C", Offset = "0x13C258C", VA = "0x13C258C")]
		public void OnInitiate()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x13C27EC", Offset = "0x13C27EC", VA = "0x13C27EC")]
		public void TakeOver()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x13C2834", Offset = "0x13C2834", VA = "0x13C2834")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x13C30C0", Offset = "0x13C30C0", VA = "0x13C30C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x13C335C", Offset = "0x13C335C", VA = "0x13C335C")]
		public PropMuscle()
		{
		}
	}
}
