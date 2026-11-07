using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000011")]
	internal class DecalSet : IEnumerable<EasyDecal>, IEnumerable
	{
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<EasyDecal> sceneDecals;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ProjectionTechnique, HashSet<EasyDecal>> techGroupedDecals;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ProjectionTechnique, Dictionary<DeferredFlags, HashSet<EasyDecal>>> flagsGroupedDecals;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<EasyDecal> empty;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x30")]
		private ProjectionTechniqueComparer ptc;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x31")]
		private DeferredFlagsComparer dfc;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x0")]
		private static int nextID;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2C5D934", Offset = "0x2C5D934", VA = "0x2C5D934")]
		internal DecalSet()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2C5E1B0", Offset = "0x2C5E1B0", VA = "0x2C5E1B0")]
		public void Add(EasyDecal decal)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2C5ED40", Offset = "0x2C5ED40", VA = "0x2C5ED40")]
		public void Remove(EasyDecal decal)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2C5F0F8", Offset = "0x2C5F0F8", VA = "0x2C5F0F8")]
		private void decal_OnDeactivated(DecalBase obj)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2C5E988", Offset = "0x2C5E988", VA = "0x2C5E988")]
		private void decal_OnDeferredFlagsChanged(DecalBase decal, DeferredFlags lastFlags, DeferredFlags currFlags)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2C5E54C", Offset = "0x2C5E54C", VA = "0x2C5E54C")]
		private void decal_OnTechniqueChanged(DecalBase decal, ProjectionTechnique lastTech, ProjectionTechnique currTech)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2C5F188", Offset = "0x2C5F188", VA = "0x2C5F188")]
		public HashSet<EasyDecal> GetDeferredDecals(DeferredFlags flags)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2C5F290", Offset = "0x2C5F290", VA = "0x2C5F290", Slot = "4")]
		public IEnumerator<EasyDecal> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2C5F314", Offset = "0x2C5F314", VA = "0x2C5F314", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2C5DAC8", Offset = "0x2C5DAC8", VA = "0x2C5DAC8")]
		private void Initialize()
		{
		}
	}
}
