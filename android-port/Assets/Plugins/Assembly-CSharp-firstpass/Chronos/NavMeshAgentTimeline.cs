using UnityEngine.AI;

namespace Chronos
{
	public class NavMeshAgentTimeline : ComponentTimeline<NavMeshAgent>
	{
		private float _speed;

		private float _angularSpeed;

		public float speed => 0f;

		public float angularSpeed => 0f;

		public NavMeshAgentTimeline(Timeline timeline, NavMeshAgent component)
			: base((Timeline)null, (NavMeshAgent)null)
		{
		}

		public override void Update()
		{
		}

		public override void CopyProperties(NavMeshAgent source)
		{
		}

		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
