namespace Chronos
{
	internal sealed class ActionOccurence : Occurrence
	{
		private ForwardAction forward { get; set; }

		private BackwardAction backward { get; set; }

		public ActionOccurence(ForwardAction forward, BackwardAction backward)
		{
		}

		public override void Forward()
		{
		}

		public override void Backward()
		{
		}
	}
}
