using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class UserControlAIMelee : UserControlThirdPerson
	{
		public BehaviourPuppet targetPuppet;

		public float stoppingDistance;

		public float stoppingThreshold;

		private bool isAttacking;

		private float attackTimer;

		private Transform moveTarget => null;

		protected override void Update()
		{
		}

		private bool CanAttack()
		{
			return false;
		}
	}
}
