using System.Runtime.CompilerServices;

namespace Cinemachine.Utility
{
	internal abstract class GaussianWindow1d<T>
	{
		protected T[] mData;

		protected float[] mKernel;

		protected int mCurrentPos;

		[CompilerGenerated]
		private float Sigma__BackingField;

		private float Sigma
		{
			[CompilerGenerated]
			set
			{
				Sigma__BackingField = value;
			}
		}

		public int KernelSize => 0;

		private void GenerateKernel(float sigma, int maxKernelRadius)
		{
		}

		protected abstract T Compute(int windowPos);

		public GaussianWindow1d(float sigma, int maxKernelRadius = 10)
		{
		}

		public void Reset()
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void AddValue(T v)
		{
		}

		public T Value()
		{
			return default;
		}
	}
}
