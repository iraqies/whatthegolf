namespace Amazon
{
	public class Arn
	{
		private string _accountId;

		public string Partition { get; set; }

		public string Service { get; set; }

		public string Region { get; set; }

		public string AccountId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Resource { get; set; }

		public static bool IsArn(string arn)
		{
			return false;
		}

		public static bool TryParse(string arnString, out Arn arn)
		{
			arn = null;
			return false;
		}

		public static Arn Parse(string arnString)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
