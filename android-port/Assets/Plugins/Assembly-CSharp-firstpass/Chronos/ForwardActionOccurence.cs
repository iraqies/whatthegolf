namespace Chronos
{
	internal sealed class ForwardActionOccurence : Occurrence
	{
		private ForwardAction forward { get; set; }

		public ForwardActionOccurence(ForwardAction forward)
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
