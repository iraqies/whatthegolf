using Core;

namespace Audio.Conditions
{
	public class DelayAfterShootCondition : AudioDelayCondition
	{
		public GolfBallController golfBallController;

		private void Awake()
		{
		}

		public override bool CheckCondition()
		{
			return false;
		}
	}
}
