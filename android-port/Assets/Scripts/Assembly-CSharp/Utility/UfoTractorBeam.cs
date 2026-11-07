using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
	public class UfoTractorBeam : MonoBehaviour
	{
		public enum UFOStates
		{
			Tracking = 0,
			Aiming = 1,
			Beaming = 2
		}

		public LayerMask AffectedObjectLayers;

		public bool DestroyBeamedObjects;

		public BeamPoint beamPoint;

		public GameObject rayGfx;

		private List<BeamableObject> _objectsInBeam;

		public ParticleSystem beamParticles;

		private Vector3 _initParticlePosition;

		public UFOStates currentUFOState;

		public Color normalColor;

		public Color trackingColor;

		public Color shootColor;

		private Color _currentColor;

		private Material _coneMaterial;

		public Renderer coneRenderer;

		private float _stateTime;

		private void Awake()
		{
		}

		private void OnEnterBeamPoint(BeamableObject obj)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void CheckObject(Collider other, bool add)
		{
		}

		private void SwitchState(UFOStates newState)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
