using Il2CppDummyDll;

namespace Cinemachine.Utility
{
	[Token(Token = "0x2000091")]
	internal abstract class GaussianWindow1d<T>
	{
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x0")]
		protected T[] mData;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x0")]
		protected float[] mKernel;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x0")]
		protected int mCurrentPos;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x793E8", Offset = "0x793E8")]
		private float Sigma__BackingField;

		[Token(Token = "0x170000D5")]
		private float Sigma
		{
			[Token(Token = "0x6000342")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B68", Offset = "0x79B68")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public int KernelSize
		{
			[Token(Token = "0x6000343")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000344")]
		private void GenerateKernel(float sigma, int maxKernelRadius)
		{
		}

		[Token(Token = "0x6000345")]
		protected abstract T Compute(int windowPos);

		[Token(Token = "0x6000346")]
		public GaussianWindow1d(float sigma, int maxKernelRadius = 10)
		{
		}

		[Token(Token = "0x6000347")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000348")]
		public bool IsEmpty()
		{
			return default;
		}

		[Token(Token = "0x6000349")]
		public void AddValue(T v)
		{
		}

		[Token(Token = "0x600034A")]
		public T Value()
		{
			return (T)null;
		}
	}
}
