using System.ComponentModel;

namespace Rewired.Utils.Classes
{
	[EditorBrowsable]
	public abstract class CodeHelper
	{
		[EditorBrowsable]
		public override bool Equals(object obj)
		{
			return false;
		}

		[EditorBrowsable]
		public override int GetHashCode()
		{
			return 0;
		}

		[EditorBrowsable]
		public override string ToString()
		{
			return null;
		}
	}
}
