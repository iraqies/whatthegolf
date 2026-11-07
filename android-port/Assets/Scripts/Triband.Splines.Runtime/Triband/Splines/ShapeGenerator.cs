using System;
using Il2CppDummyDll;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x200000E")]
	public abstract class ShapeGenerator
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x10")]
		public IShapeGeneratorData rootData;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B02AC", Offset = "0x1B02AC")]
		private SplineMesh.UVSettings UVSettings__BackingField;

		[Token(Token = "0x17000024")]
		public abstract Type DataType
		{
			[Token(Token = "0x6000073")]
			get;
		}

		[Token(Token = "0x17000025")]
		public abstract bool ClosedLoop
		{
			[Token(Token = "0x6000077")]
			get;
		}

		[Token(Token = "0x17000026")]
		public abstract bool AutoGenerateNormals
		{
			[Token(Token = "0x6000078")]
			get;
		}

		[Token(Token = "0x17000027")]
		public SplineMesh.UVSettings UVSettings
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2A02750", Offset = "0x2A02750", VA = "0x2A02750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B074C", Offset = "0x1B074C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2A02758", Offset = "0x2A02758", VA = "0x2A02758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B075C", Offset = "0x1B075C")]
			set
			{
			}
		}

		[Token(Token = "0x6000074")]
		public abstract Shape2D Generate(float t, float length);

		[Token(Token = "0x6000075")]
		public abstract Shape GenerateStartCap();

		[Token(Token = "0x6000076")]
		public abstract Shape GenerateEndCap();

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A02760", Offset = "0x2A02760", VA = "0x2A02760")]
		protected ShapeGenerator()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public abstract class ShapeGenerator<T> : ShapeGenerator where T : IShapeGeneratorData
	{
		[Token(Token = "0x17000028")]
		public override Type DataType
		{
			[Token(Token = "0x600007C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		protected T Data
		{
			[Token(Token = "0x600007D")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x600007E")]
		protected ShapeGenerator()
		{
		}
	}
}
