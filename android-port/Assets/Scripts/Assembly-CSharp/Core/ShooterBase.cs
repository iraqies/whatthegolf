using UnityEngine;

namespace Core
{
	public abstract class ShooterBase : MonoBehaviour
	{
		public GolfBallController GolfBallController;

		public virtual void OnActivate() { }
		public virtual void OnAimStart() { }
		public virtual void OnAimUpdate(Vector3 boost, bool onlyAimArrow) { }
		public virtual void OnShoot(Vector3 boost) { }
		public virtual void OnCancel() { }
		public virtual void OnReset() { }
		public virtual void OnGoalReached() { }

		public GolfBallController GetOwner()
		{
			if (GolfBallController == null)
				GolfBallController = GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>();
			return GolfBallController;
		}
	}
}
