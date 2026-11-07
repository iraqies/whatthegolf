using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Buoyancy
{
	public class BuoyancyTrigger : MonoBehaviour, IBuoyantWater
	{
		[SerializeField]
		private float forceMultiplier;

		[SerializeField]
		private float viscosity;

		private Transform _transform;

		[CompilerGenerated]
		private Action<IBuoyant> m_OnEnterWater;

		[CompilerGenerated]
		private Action<IBuoyant> m_OnExitWater;

		private List<IBuoyant> remove;

		public List<IBuoyant> buoyantsInTrigger { get; private set; }

		public float SurfacePositionY { get; set; }

		public float Viscosity => 0f;

		public float WaterForceUp => 0f;

		public float AccumulatedMass { get; private set; }

		public event Action<IBuoyant> OnEnterWater
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IBuoyant> OnExitWater
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
