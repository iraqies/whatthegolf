namespace Chronos
{
	internal sealed class FuncOccurence<T> : Occurrence
	{
		private ForwardFunc<T> forward { get; set; }

		private BackwardFunc<T> backward { get; set; }

		private T transfer { get; set; }

		public FuncOccurence(ForwardFunc<T> forward, BackwardFunc<T> backward)
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
