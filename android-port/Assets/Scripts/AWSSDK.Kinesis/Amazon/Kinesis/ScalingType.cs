using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class ScalingType : ConstantClass
	{
		public static readonly ScalingType UNIFORM_SCALING;

		public ScalingType(string value)
			: base(null)
		{
		}

		public static ScalingType FindValue(string value)
		{
			return null;
		}

		public static implicit operator ScalingType(string value)
		{
			return null;
		}
	}
}
