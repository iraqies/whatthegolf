using System.Collections.Generic;

namespace Amazon.Auth.AccessControlPolicy
{
	public class Policy
	{
		private const string DEFAULT_POLICY_VERSION = "2012-10-17";

		private string id;

		private string version;

		private IList<Statement> statements;

		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Statement> Statements
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Policy()
		{
		}

		public Policy(string id)
		{
		}

		public Policy(string id, IList<Statement> statements)
		{
		}

		public Policy WithId(string id)
		{
			return null;
		}

		public bool CheckIfStatementExists(Statement statement)
		{
			return false;
		}

		private static bool StatementContainsResources(Statement statement, IList<Resource> resources)
		{
			return false;
		}

		private static bool StatementContainsActions(Statement statement, IList<ActionIdentifier> actions)
		{
			return false;
		}

		private static bool StatementContainsConditions(Statement statement, IList<Condition> conditions)
		{
			return false;
		}

		private static bool StatementContainsPrincipals(Statement statement, IList<Principal> principals)
		{
			return false;
		}

		public Policy WithStatements(params Statement[] statements)
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}

		public string ToJson(bool prettyPrint)
		{
			return null;
		}

		public static Policy FromJson(string json)
		{
			return null;
		}
	}
}
