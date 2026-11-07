using System;
using UnityEngine;

namespace Buoyancy
{
	public interface IBuoyant
	{
		bool Remove { get; }

		Rigidbody Rigid { get; }

		Action<Vector3> OnEnterWaterNoSkip { get; set; }

		Action<Vector3> OnPostSkip { get; set; }

		Action OnTargetExitedWater { get; set; }

		bool IsInWater { get; }

		void HandleFloating(IBuoyantWater water);

		void OnEnterWater(IBuoyantWater water);

		void OnExitWater(IBuoyantWater water);
	}
}
