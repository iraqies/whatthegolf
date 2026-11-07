using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x200012C")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x200012D")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x400074B")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35A74", Offset = "0x35A74")]
			public int puppetsPerFrame;

			[Token(Token = "0x400074C")]
			[FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x1353D7C", Offset = "0x1353D7C", VA = "0x1353D7C")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x1353DA8", Offset = "0x1353DA8", VA = "0x1353DA8")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1353DC4", Offset = "0x1353DC4", VA = "0x1353DC4")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default;
			}
		}

		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x18")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35A44", Offset = "0x35A44")]
		private int currentlyActivePuppets__BackingField;

		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35A54", Offset = "0x35A54")]
		private int currentlyKinematicPuppets__BackingField;

		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35A64", Offset = "0x35A64")]
		private int currentlyDisabledPuppets__BackingField;

		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x1700011D")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x13D53D0", Offset = "0x13D53D0", VA = "0x13D53D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D24", Offset = "0x38D24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x13D53D8", Offset = "0x13D53D8", VA = "0x13D53D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D34", Offset = "0x38D34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x13D53E0", Offset = "0x13D53E0", VA = "0x13D53E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D44", Offset = "0x38D44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x13D53E8", Offset = "0x13D53E8", VA = "0x13D53E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D54", Offset = "0x38D54")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x13D53F0", Offset = "0x13D53F0", VA = "0x13D53F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D64", Offset = "0x38D64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x13D53F8", Offset = "0x13D53F8", VA = "0x13D53F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38D74", Offset = "0x38D74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x13D5400", Offset = "0x13D5400", VA = "0x13D5400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x13D5408", Offset = "0x13D5408", VA = "0x13D5408")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x13D54A8", Offset = "0x13D54A8", VA = "0x13D54A8")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x13D550C", Offset = "0x13D550C", VA = "0x13D550C")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x13D5534", Offset = "0x13D5534", VA = "0x13D5534")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x13D555C", Offset = "0x13D555C", VA = "0x13D555C")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x13D5584", Offset = "0x13D5584", VA = "0x13D5584")]
		private void Update()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x13D57BC", Offset = "0x13D57BC", VA = "0x13D57BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x13D5814", Offset = "0x13D5814", VA = "0x13D5814")]
		public PuppetMasterSettings()
		{
		}
	}
}
