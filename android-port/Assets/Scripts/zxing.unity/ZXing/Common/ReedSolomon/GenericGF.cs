namespace ZXing.Common.ReedSolomon
{
	public sealed class GenericGF
	{
		public static GenericGF AZTEC_DATA_12;

		public static GenericGF AZTEC_DATA_10;

		public static GenericGF AZTEC_DATA_6;

		public static GenericGF AZTEC_PARAM;

		public static GenericGF QR_CODE_FIELD_256;

		public static GenericGF DATA_MATRIX_FIELD_256;

		public static GenericGF AZTEC_DATA_8;

		public static GenericGF MAXICODE_FIELD_64;

		private readonly int[] expTable;

		private readonly int[] logTable;

		private readonly GenericGFPoly zero;

		private readonly GenericGFPoly one;

		private readonly int size;

		private readonly int primitive;

		private readonly int generatorBase;

		internal GenericGFPoly Zero => null;

		public int GeneratorBase => 0;

		public GenericGF(int primitive, int size, int genBase)
		{
		}

		internal GenericGFPoly buildMonomial(int degree, int coefficient)
		{
			return null;
		}

		internal static int addOrSubtract(int a, int b)
		{
			return 0;
		}

		internal int exp(int a)
		{
			return 0;
		}

		internal int log(int a)
		{
			return 0;
		}

		internal int inverse(int a)
		{
			return 0;
		}

		internal int multiply(int a, int b)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
