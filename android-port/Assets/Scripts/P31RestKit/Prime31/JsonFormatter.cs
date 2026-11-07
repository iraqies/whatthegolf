using System.Collections.Generic;
using System.Text;

namespace Prime31
{
	public class JsonFormatter
	{
		private enum JsonContextType
		{
			Object = 0,
			Array = 1
		}

		private bool inDoubleString;

		private bool inSingleString;

		private bool inVariableAssignment;

		private char prevChar;

		private Stack<JsonContextType> context;

		public static string prettyPrint(string input)
		{
			return null;
		}

		private static void buildIndents(int indents, StringBuilder output)
		{
		}

		private bool inString()
		{
			return false;
		}

		public string print(string input)
		{
			return null;
		}
	}
}
