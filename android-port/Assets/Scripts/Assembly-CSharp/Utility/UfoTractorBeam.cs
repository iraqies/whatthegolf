using System;
using System.Collections.Generic;
using System.Linq;
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

		private List<BeamableObject> _objectsInBeam = new List<BeamableObject>();

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
			_objectsInBeam = new List<BeamableObject>();
			if (beamPoint != null)
			{
				beamPoint.OnEnterBeamPoint = (Action<BeamableObject>)Delegate.Combine(beamPoint.OnEnterBeamPoint, new Action<BeamableObject>(OnEnterBeamPoint));
			}
			if (coneRenderer != null)
			{
				_coneMaterial = coneRenderer.material;
			}
			_currentColor = normalColor;
			if (beamParticles != null)
			{
				_initParticlePosition = beamParticles.transform.position;
			}
		}

		private void OnEnterBeamPoint(BeamableObject obj)
		{
			if (DestroyBeamedObjects && obj != null && obj.isDestroyable && _objectsInBeam != null && _objectsInBeam.Contains(obj))
			{
				_objectsInBeam.Remove(obj);
				UnityEngine.Object.Destroy(obj.Root);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			CheckObject(other, true);
		}

		private void OnTriggerExit(Collider other)
		{
			CheckObject(other, false);
		}

		private void CheckObject(Collider other, bool add)
		{
			if (other == null)
			{
				return;
			}
			int num = AffectedObjectLayers;
			if (num != (num | (1 << other.gameObject.layer)))
			{
				return;
			}
			BeamableObject component = other.GetComponent<BeamableObject>();
			if (component == null || !component.isBeamAble || _objectsInBeam == null)
			{
				return;
			}
			if (add)
			{
				if (!_objectsInBeam.Contains(component))
				{
					_objectsInBeam.Add(component);
				}
			}
			else if (_objectsInBeam.Contains(component))
			{
				_objectsInBeam.Remove(component);
			}
		}

		private void SwitchState(UFOStates newState)
		{
			currentUFOState = newState;
			_stateTime = 0f;
			switch (newState)
			{
			case UFOStates.Tracking:
				_currentColor = normalColor;
				break;
			case UFOStates.Aiming:
				break;
			case UFOStates.Beaming:
				if (beamParticles != null)
				{
					Transform transform = beamParticles.transform;
					if (_objectsInBeam != null && _objectsInBeam.Count > 0)
					{
						BeamableObject beamableObject = _objectsInBeam.Last();
						if (beamableObject != null)
						{
							transform.position = beamableObject.transform.position;
						}
					}
					else
					{
						transform.position = _initParticlePosition;
					}
					beamParticles.Play();
				}
				break;
			default:
				throw new ArgumentOutOfRangeException("newState", newState, null);
			}
		}

		private void FixedUpdate()
		{
			switch (currentUFOState)
			{
			case UFOStates.Tracking:
				if (_objectsInBeam != null && _objectsInBeam.Count >= 1)
				{
					currentUFOState = UFOStates.Aiming;
					_stateTime = 0f;
				}
				if (rayGfx != null)
				{
					rayGfx.transform.localScale = Vector3.Lerp(rayGfx.transform.localScale, Vector3.one, Mathf.Clamp01(Time.deltaTime * 2f));
				}
				_currentColor = Color.Lerp(_currentColor, normalColor, _stateTime);
				break;
			case UFOStates.Aiming:
				_stateTime += Time.deltaTime;
				if (rayGfx != null)
				{
					rayGfx.transform.localScale = Vector3.Lerp(rayGfx.transform.localScale, new Vector3(0.2f, 1f, 0.2f), Mathf.Clamp01(_stateTime));
				}
				_currentColor = Color.Lerp(_currentColor, trackingColor, _stateTime);
				if (_stateTime > 1f)
				{
					SwitchState(UFOStates.Beaming);
				}
				break;
			case UFOStates.Beaming:
				if (_objectsInBeam == null || _objectsInBeam.Count == 0)
				{
					currentUFOState = UFOStates.Tracking;
					_stateTime = 0f;
					_currentColor = normalColor;
					return;
				}
				_stateTime += Time.deltaTime;
				_currentColor = Color.Lerp(shootColor, normalColor, _stateTime * 2f);
				if (_stateTime > 0.5f)
				{
					currentUFOState = UFOStates.Tracking;
					_stateTime = 0f;
					_currentColor = normalColor;
					for (int num = _objectsInBeam.Count - 1; num >= 0; num--)
					{
						BeamableObject beamableObject = _objectsInBeam[num];
						if (beamableObject != null && beamPoint != null)
						{
							beamableObject.BeamMeUp(beamPoint.transform);
						}
						_objectsInBeam.Remove(beamableObject);
					}
				}
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
			if (_coneMaterial != null)
			{
				_coneMaterial.SetColor("_TintColor", _currentColor);
			}
		}
	}
}
