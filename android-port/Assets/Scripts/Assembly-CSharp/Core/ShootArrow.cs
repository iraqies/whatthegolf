using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class ShootArrow : MonoBehaviour
	{
		public enum MoveMethodEnum
		{
			Normal = 0,
			Physics = 1,
			Physics2D = 2,
			None = 3,
			SmoothedPhysics = 4
		}

		[SerializeField]
		public List<Renderer> renderers;

		[SerializeField]
		public List<Renderer> shadowRenderers;

		[SerializeField]
		public Renderer arrowOutline;

		[SerializeField]
		public Color colorMin;

		[SerializeField]
		public Color colorMax;

		[SerializeField]
		public AnimationCurve colorCurve;

		[SerializeField]
		public Color blockedColor;

		[SerializeField]
		public Color outlineBlockedColor;

		[SerializeField]
		public Transform overrideBall;

		[SerializeField]
		public Transform basePivot;

		[SerializeField]
		public float limitValue;

		[SerializeField]
		public Transform arrowHeadJoint;

		[SerializeField]
		public Transform arrowBaseJoint;

		[SerializeField]
		public MoveMethodEnum MoveMethod;

		[SerializeField]
		public MoveMethodEnum RotateMethod;

		[SerializeField]
		private GameObject boostArrow;

		[SerializeField]
		public bool AutoHide;

		[SerializeField]
		public float SmoothedPhysicsSpeed;

		[SerializeField]
		private float gyroMagnitude;

		[SerializeField]
		private float scaleMod;

		private float alphaDipSpeed;

		private float alphaDipStart;

		public float InsideAlpha;

		public float InsideAlphaOutline;

		public Camera cam;

		private GolfBallController ball;

		private float blockValue;

		private Material arrowMaterial;

		private Material arrowOutlineMaterial;

		private float arrowSize;

		private float targetArrowSize;

		private float arrowSizeChangeSpeed;

		private Rigidbody rigid;

		private Rigidbody2D rigid2D;

		private float alphaTarget;

		private float currentAlpha;

		private bool overrideIsBlocked;

		public bool clampAimVector;

		public float ShaftLength => 0f;

		private float Scale => 0f;

		private Vector3 Up => default;

		public bool CastShadow
		{
			set
			{
			}
		}

		private Camera GetCam()
		{
			return null;
		}

		public void Initialize(GolfBallController ballController, bool showArrowOnTop)
		{
		}

		public void SetOverrideBall(Transform ball)
		{
		}

		private Vector3 GetGyroDirection(float amount)
		{
			return default;
		}

		public void UpdateDashedArrow(Vector3 dir)
		{
		}

		public void UpdateArrow(Vector3 vec, bool isBlocked, bool onlyDashedArrow)
		{
		}

		public void SetBlockOverride(bool value)
		{
		}

		private void MoveArrow(Vector3 position)
		{
		}

		private void RotateArrow(Vector3 vec)
		{
		}

		private void ChangeLength(float ratio)
		{
		}

		public void PlayShootSequence(float t)
		{
		}

		public void SetArrowColor(Color c)
		{
		}

		public Color GetColor(Vector3 vec)
		{
			return default;
		}

		public void StartAim()
		{
		}

		public void Hide()
		{
		}

		public void DoAlphaDip()
		{
		}

		public Vector3? GetClosestPointOnShaft(Vector3 pos)
		{
			return null;
		}
	}
}
