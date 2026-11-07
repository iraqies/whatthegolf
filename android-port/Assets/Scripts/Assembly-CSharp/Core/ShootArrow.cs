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

		[SerializeField] public List<Renderer> renderers = new List<Renderer>();
		[SerializeField] public List<Renderer> shadowRenderers = new List<Renderer>();
		[SerializeField] public Renderer arrowOutline;
		[SerializeField] public Color colorMin = new Color(1f, 0.9f, 0.2f, 1f);
		[SerializeField] public Color colorMax = new Color(1f, 0.2f, 0.2f, 1f);
		[SerializeField] public AnimationCurve colorCurve;
		[SerializeField] public Color blockedColor = Color.gray;
		[SerializeField] public Color outlineBlockedColor = Color.black;
		[SerializeField] public Transform overrideBall;
		[SerializeField] public Transform basePivot;
		[SerializeField] public float limitValue = 1f;
		[SerializeField] public Transform arrowHeadJoint;
		[SerializeField] public Transform arrowBaseJoint;
		[SerializeField] public MoveMethodEnum MoveMethod;
		[SerializeField] public MoveMethodEnum RotateMethod;
		[SerializeField] private GameObject boostArrow;
		[SerializeField] public bool AutoHide = true;
		[SerializeField] public float SmoothedPhysicsSpeed = 15f;
		[SerializeField] private float gyroMagnitude;
		[SerializeField] private float scaleMod = 1f;

		private float alphaDipSpeed;
		private float alphaDipStart;
		public float InsideAlpha = 0.5f;
		public float InsideAlphaOutline = 0.5f;
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
		public bool clampAimVector = true;

		public float ShaftLength => arrowSize * Scale;
		private float Scale => ball != null && ball.Scale > 0f ? ball.Scale : 1f;
		private Vector3 Up => ball != null && ball.AimPlane == AimPlanes.Camera ? Vector3.forward : Vector3.up;

		public bool CastShadow
		{
			set
			{
				if (shadowRenderers != null)
				{
					foreach (var r in shadowRenderers)
						if (r != null) r.enabled = value;
				}
			}
		}

		private Camera GetCam() => cam != null ? cam : (cam = Camera.main);

		public void Initialize(GolfBallController ballController, bool showArrowOnTop)
		{
			ball = ballController;
			if (scaleMod <= 0f) scaleMod = 1f;
			if (AutoHide) Hide();
		}

		public void SetOverrideBall(Transform newBall) => overrideBall = newBall;

		private Vector3 GetGyroDirection(float amount) => Vector3.zero;

		public void UpdateDashedArrow(Vector3 dir) { }

		public void UpdateArrow(Vector3 vec, bool isBlocked, bool onlyDashedArrow)
		{
			if (!gameObject.activeSelf)
				gameObject.SetActive(true);
			Transform target = overrideBall != null ? overrideBall : (ball != null ? ball.ArrowPosition : null);
			if (target != null)
				MoveArrow(target.position);
			RotateArrow(vec);
			ChangeLength(Mathf.Clamp01(vec.magnitude));
			SetArrowColor(isBlocked || overrideIsBlocked ? blockedColor : GetColor(vec));
		}

		public void SetBlockOverride(bool value) => overrideIsBlocked = value;

		private void MoveArrow(Vector3 position) => transform.position = position;

		private void RotateArrow(Vector3 vec)
		{
			if (vec.sqrMagnitude < 1e-5f) return;
			if (ball != null && (ball.AimPlane == AimPlanes.Camera || ball.AimPlane == AimPlanes.TwoD))
			{
				float angle = Mathf.Atan2(vec.y, vec.x) * 57.29578f;
				transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);
			}
			else
			{
				Vector3 flat = new Vector3(vec.x, 0f, vec.z);
				if (flat.sqrMagnitude > 1e-5f)
					transform.rotation = Quaternion.LookRotation(flat.normalized, Vector3.up);
			}
		}

		private void ChangeLength(float ratio)
		{
			arrowSize = ratio;
			float s = Mathf.Lerp(0.25f, 2.2f, ratio) * Scale;
			if (basePivot != null)
				basePivot.localScale = new Vector3(Scale, Scale, s);
			else
				transform.localScale = new Vector3(Scale, s, s);
		}

		public void PlayShootSequence(float t) => Hide();

		public void SetArrowColor(Color c)
		{
			if (renderers != null)
			{
				foreach (var r in renderers)
				{
					if (r != null && r.material != null)
						r.material.color = c;
				}
			}
		}

		public Color GetColor(Vector3 vec)
		{
			float t = Mathf.Clamp01(vec.magnitude);
			if (colorCurve != null && colorCurve.length > 0)
				t = colorCurve.Evaluate(t);
			return Color.Lerp(colorMin, colorMax, t);
		}

		public void StartAim()
		{
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			if (gameObject != null)
				gameObject.SetActive(false);
		}

		public void DoAlphaDip() { }
		public Vector3? GetClosestPointOnShaft(Vector3 pos) => transform.position;
	}
}
