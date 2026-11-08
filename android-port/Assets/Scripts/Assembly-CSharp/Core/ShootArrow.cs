using System.Collections.Generic;
using CameraStack;
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
		private float arrowSizeChangeSpeed = 20f;
		private Rigidbody rigid;
		private Rigidbody2D rigid2D;
		private float alphaTarget;
		private float currentAlpha = 1f;
		private bool overrideIsBlocked;
		public bool clampAimVector = true;

		public float ShaftLength => Scale * 6f;
		private float Scale => (ball != null && ball.Scale > 0f ? ball.Scale : 1f) * (scaleMod > 0f ? scaleMod : 1f);
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

		private Camera GetCam() => cam != null ? cam : (cam = (CameraManager.Instance != null ? CameraManager.Instance.MainCamera : Camera.main));

		public void Initialize(GolfBallController ballController, bool showArrowOnTop)
		{
			ball = ballController;
			if (scaleMod <= 0f) scaleMod = 1f;
			if (arrowSizeChangeSpeed <= 0f) arrowSizeChangeSpeed = 20f;
			if (renderers != null && renderers.Count > 0 && renderers[0] != null)
			{
				arrowMaterial = new Material(renderers[0].sharedMaterial);
				foreach (var r in renderers)
				{
					if (r != null) r.sharedMaterial = arrowMaterial;
				}
			}
			if (arrowOutline != null && arrowOutline.sharedMaterial != null)
			{
				arrowOutlineMaterial = new Material(arrowOutline.sharedMaterial);
				arrowOutline.sharedMaterial = arrowOutlineMaterial;
			}
			if (boostArrow != null)
				boostArrow.SetActive(false);
			if (AutoHide)
				Hide();
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

			blockValue = Mathf.MoveTowards(blockValue, (isBlocked || overrideIsBlocked) ? 1f : 0f, Time.unscaledDeltaTime * 10f);
			Color c = Color.Lerp(GetColor(vec), blockedColor, blockValue);
			c.a = 1f;
			SetArrowColor(c);
			if (arrowOutlineMaterial != null)
				arrowOutlineMaterial.color = Color.Lerp(Color.white, outlineBlockedColor, blockValue);

			float len = onlyDashedArrow ? 0f : Mathf.Clamp01(vec.magnitude);
			ChangeLength(len);

			if (boostArrow != null)
				boostArrow.SetActive(false);

			targetArrowSize = 1f;
			arrowSize = Mathf.MoveTowards(arrowSize, targetArrowSize, Time.unscaledDeltaTime * arrowSizeChangeSpeed);
			if (basePivot != null)
				basePivot.localScale = Vector3.one * (arrowSize * Scale * 0.45f);
		}

		public void SetBlockOverride(bool value) => overrideIsBlocked = value;

		private void MoveArrow(Vector3 position)
		{
			if (MoveMethod == MoveMethodEnum.Physics)
			{
				if (rigid == null) rigid = GetComponentInChildren<Rigidbody>();
				if (rigid != null) { rigid.MovePosition(position); return; }
			}
			else if (MoveMethod == MoveMethodEnum.Physics2D)
			{
				if (rigid2D == null) rigid2D = GetComponentInChildren<Rigidbody2D>();
				if (rigid2D != null) { rigid2D.MovePosition(position); return; }
			}
			transform.position = position;
		}

		private void RotateArrow(Vector3 vec)
		{
			if (vec.sqrMagnitude < 1e-5f || ball == null) return;
			Vector3 normal = ball.GetPlane(ball.AimPlane).normal;
			Quaternion rot = Quaternion.LookRotation(vec.normalized, normal);
			if (RotateMethod == MoveMethodEnum.Physics)
			{
				if (rigid == null) rigid = GetComponentInChildren<Rigidbody>();
				if (rigid != null) { rigid.MoveRotation(rot); return; }
			}
			else if (RotateMethod == MoveMethodEnum.SmoothedPhysics)
			{
				if (rigid == null) rigid = GetComponentInChildren<Rigidbody>();
				if (rigid != null)
				{
					rigid.MoveRotation(Quaternion.Slerp(rigid.transform.rotation, rot, Time.deltaTime * SmoothedPhysicsSpeed));
					return;
				}
			}
			else if (RotateMethod == MoveMethodEnum.Physics2D)
			{
				if (rigid2D == null) rigid2D = GetComponentInChildren<Rigidbody2D>();
				if (rigid2D != null)
				{
					float angle = Vector3.SignedAngle(Vector2.right, rot * Vector2.right, Vector3.forward);
					rigid2D.MoveRotation(angle);
					return;
				}
			}
			transform.rotation = rot;
		}

		private void ChangeLength(float ratio)
		{
			if (arrowHeadJoint != null)
				arrowHeadJoint.localPosition = new Vector3(0f, ratio * 0.1264f, 0f);
		}

		public void PlayShootSequence(float t)
		{
			if (arrowHeadJoint != null)
				arrowHeadJoint.localPosition = new Vector3(0f, t * 0.1264f, 0f);
		}

		public void SetArrowColor(Color c)
		{
			if (arrowMaterial != null)
				arrowMaterial.color = c;
			if (renderers != null)
			{
				foreach (var r in renderers)
				{
					if (r != null && r.sharedMaterial != null)
						r.sharedMaterial.color = c;
				}
			}
		}

		public Color GetColor(Vector3 vec)
		{
			float t = vec.magnitude;
			if (colorCurve != null && colorCurve.length > 0)
				t = colorCurve.Evaluate(t);
			return Color.Lerp(colorMin, colorMax, t);
		}

		public void StartAim()
		{
			gameObject.SetActive(true);
			Transform target = overrideBall != null ? overrideBall : (ball != null ? ball.ArrowPosition : null);
			if (target == null) return;
			if (MoveMethod == MoveMethodEnum.Normal)
			{
				transform.position = target.position;
			}
			else if (MoveMethod == MoveMethodEnum.Physics)
			{
				if (rigid == null) rigid = GetComponentInChildren<Rigidbody>();
				if (rigid != null) rigid.position = target.position;
			}
			else if (MoveMethod == MoveMethodEnum.Physics2D)
			{
				if (rigid2D == null) rigid2D = GetComponentInChildren<Rigidbody2D>();
				if (rigid2D != null) rigid2D.position = target.position;
			}
		}

		public void Hide()
		{
			if (!AutoHide) return;
			arrowSize = 0f;
			targetArrowSize = 0f;
			if (basePivot != null)
				basePivot.localScale = Vector3.zero;
			if (gameObject != null)
				gameObject.SetActive(false);
		}

		public void DoAlphaDip() { }
		public Vector3? GetClosestPointOnShaft(Vector3 pos) => transform.position;
	}
}
