using System.Collections.Generic;
using RootMotion.Dynamics;
using UnityEngine;

namespace Audio
{
	public class ImpactSFXPuppetMaster : ImpactUser
	{
		[SerializeField]
		private PuppetMaster puppetMaster;

		[SerializeField]
		private List<Muscle.Group> muscleGroups;

		private void Start()
		{
		}

		private void OnMuscleCollision(MuscleCollision colData)
		{
		}
	}
}
