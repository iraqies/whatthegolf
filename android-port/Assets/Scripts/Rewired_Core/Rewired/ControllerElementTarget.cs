namespace Rewired
{
	public struct ControllerElementTarget
	{
		private Controller.Element DxtFUupqUGmyUsjBAudqHmDVBidJ;

		private AxisRange dnqcDaKuDzTeZpkjWrulGAfmNtHmA;

		public int elementIdentifierId => 0;

		public AxisRange axisRange
		{
			get
			{
				return AxisRange.Full;
			}
			set
			{
			}
		}

		public Controller controller => null;

		public ControllerElementTarget(ActionElementMap P_0)
		{
			DxtFUupqUGmyUsjBAudqHmDVBidJ = null;
			dnqcDaKuDzTeZpkjWrulGAfmNtHmA = AxisRange.Full;
		}

		public ControllerElementTarget(IControllerElementTarget P_0)
		{
			DxtFUupqUGmyUsjBAudqHmDVBidJ = null;
			dnqcDaKuDzTeZpkjWrulGAfmNtHmA = AxisRange.Full;
		}

		public static implicit operator ControllerElementTarget(ActionElementMap actionElementMap)
		{
			return default;
		}
	}
}
