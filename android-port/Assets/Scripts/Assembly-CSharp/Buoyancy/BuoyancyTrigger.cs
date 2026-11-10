using System;
using System.Collections.Generic;
using UnityEngine;

namespace Buoyancy
{
	public class BuoyancyTrigger : MonoBehaviour, IBuoyantWater
	{
		[SerializeField]
		private float forceMultiplier = 1.7f;

		[SerializeField]
		private float viscosity;

		private Transform _transform;

		private List<IBuoyant> remove;

		public List<IBuoyant> buoyantsInTrigger { get; private set; }

		public float SurfacePositionY { get; set; }

		public float Viscosity => viscosity;

		public float WaterForceUp => -Physics.gravity.y * forceMultiplier;

		public float AccumulatedMass { get; private set; }

		public event Action<IBuoyant> OnEnterWater;

		public event Action<IBuoyant> OnExitWater;

		private void Awake()
		{
			remove = new List<IBuoyant>();
			_transform = base.transform;
			buoyantsInTrigger = new List<IBuoyant>();
			Collider col = GetComponent<Collider>();
			if (col != null)
			{
				SurfacePositionY = col.bounds.max.y;
			}
		}

		private void FixedUpdate()
		{
			if (remove == null || buoyantsInTrigger == null)
				return;

			remove.Clear();
			foreach (IBuoyant buoyant in buoyantsInTrigger)
			{
				if (buoyant != null)
				{
					buoyant.HandleFloating(this);
					if (buoyant.Remove)
					{
						remove.Add(buoyant);
					}
				}
			}
		}

		private void LateUpdate()
		{
			if (remove != null && remove.Count >= 1 && buoyantsInTrigger != null)
			{
				foreach (IBuoyant buoyant in remove)
				{
					buoyantsInTrigger.Remove(buoyant);
				}
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other == null || other.attachedRigidbody == null)
				return;

			if (other.attachedRigidbody.TryGetComponent<IBuoyant>(out IBuoyant buoyant))
			{
				buoyant.OnEnterWater(this);
				this.OnEnterWater?.Invoke(buoyant);
				buoyantsInTrigger?.Add(buoyant);
			}
			if (other.attachedRigidbody != null && !other.attachedRigidbody.isKinematic)
			{
				AccumulatedMass += other.attachedRigidbody.mass;
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (other == null || other.attachedRigidbody == null)
				return;

			if (other.attachedRigidbody.TryGetComponent<IBuoyant>(out IBuoyant buoyant))
			{
				buoyant.OnExitWater(this);
				this.OnExitWater?.Invoke(buoyant);
				buoyantsInTrigger?.Remove(buoyant);
			}
			if (other.attachedRigidbody != null && !other.attachedRigidbody.isKinematic)
			{
				AccumulatedMass -= other.attachedRigidbody.mass;
			}
		}
	}
}
