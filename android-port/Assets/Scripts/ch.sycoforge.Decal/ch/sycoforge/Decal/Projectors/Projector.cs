using System;
using Il2CppDummyDll;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	[Token(Token = "0x200002B")]
	public abstract class Projector
	{
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x10")]
		protected DynamicMesh dynamicMesh;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x18")]
		protected int id;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BBFC", Offset = "0x20BBFC")]
		private EasyDecal Parent__BackingField;

		[Token(Token = "0x17000054")]
		protected EasyDecal Parent
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2C6B74C", Offset = "0x2C6B74C", VA = "0x2C6B74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BE84", Offset = "0x20BE84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2C6B754", Offset = "0x2C6B754", VA = "0x2C6B754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BE94", Offset = "0x20BE94")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public DynamicMesh Mesh
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2C6B75C", Offset = "0x2C6B75C", VA = "0x2C6B75C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public virtual bool IsVisible
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2C6B764", Offset = "0x2C6B764", VA = "0x2C6B764", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2C6B85C", Offset = "0x2C6B85C", VA = "0x2C6B85C")]
		internal Projector(EasyDecal decal, RecreationMode mode)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2C6B900", Offset = "0x2C6B900", VA = "0x2C6B900", Slot = "5")]
		internal virtual void Reset()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2C6B91C", Offset = "0x2C6B91C", VA = "0x2C6B91C", Slot = "6")]
		internal virtual void Update()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2C6B920", Offset = "0x2C6B920", VA = "0x2C6B920")]
		internal void UpdateVertexColor()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2C6BA70", Offset = "0x2C6BA70", VA = "0x2C6BA70", Slot = "7")]
		internal virtual void OnGeometryPropertyChanged()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2C6BA74", Offset = "0x2C6BA74", VA = "0x2C6BA74", Slot = "8")]
		internal virtual void OnAlphaChanged()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2C6BA78", Offset = "0x2C6BA78", VA = "0x2C6BA78", Slot = "9")]
		internal virtual void OnBakeStatusChanged()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2C6BAD0", Offset = "0x2C6BAD0", VA = "0x2C6BAD0", Slot = "10")]
		internal virtual void OnFadeOutStarted()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2C6BAEC", Offset = "0x2C6BAEC", VA = "0x2C6BAEC", Slot = "11")]
		internal virtual void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000196")]
		internal abstract void Project();
	}
}
