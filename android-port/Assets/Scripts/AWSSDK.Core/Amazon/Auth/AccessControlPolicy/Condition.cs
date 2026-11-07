namespace Amazon.Auth.AccessControlPolicy
{
	public class Condition
	{
		private string type;

		private string conditionKey;

		private string[] values;

		public string Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ConditionKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] Values
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Condition()
		{
		}

		public Condition(string type, string conditionKey, params string[] values)
		{
		}
	}
}
