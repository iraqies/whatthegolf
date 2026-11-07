namespace Newtonsoft.Json.Linq
{
	public class JsonLoadSettings
	{
		private CommentHandling _commentHandling;

		private LineInfoHandling _lineInfoHandling;

		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling;

		public CommentHandling CommentHandling => CommentHandling.Ignore;

		public LineInfoHandling LineInfoHandling => LineInfoHandling.Ignore;

		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling => DuplicatePropertyNameHandling.Replace;
	}
}
