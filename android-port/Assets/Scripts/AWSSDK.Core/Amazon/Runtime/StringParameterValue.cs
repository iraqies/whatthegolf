namespace Amazon.Runtime
{
	public class StringParameterValue : ParameterValue
	{
		public string Value { get; set; }

		public StringParameterValue(string value)
		{
		}

		internal StringParameterValue()
		{
		}
	}
}
