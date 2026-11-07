using System.Collections.Generic;

namespace ZXing.Common.ReedSolomon
{
	public sealed class ReedSolomonEncoder
	{
		private readonly GenericGF field;

		private readonly IList<GenericGFPoly> cachedGenerators;

		public ReedSolomonEncoder(GenericGF field)
		{
		}

		private GenericGFPoly buildGenerator(int degree)
		{
			return null;
		}

		public void encode(int[] toEncode, int ecBytes)
		{
		}
	}
}
