#!/usr/bin/env python3
"""Implement all remaining CameraStack behaviors (CBOrthographic*, CBFollowClamped,
CBFollowOrbit, CBFollowOverworld, CBFollowTrailer, CBOrbit, CBBlend, CBPerspectiveFollow2D,
CBPerspecitveGyroscope, CBSphericalFollow, CBWinCamera, OverworldCamera), plus
AnimateRectTransform, MainMenu2Button, MainMenu2Navigator, AdventureButton,
OverworldTeleportMenu, QuickMenu, PackStarterManager, PackStarter, GeneralCampaignStarter,
CampaignStarter, FlagPackStarter, OverworldButton2D, ShortcutTunnel, ShortcutTunnelEntry,
SimplePortal, and clean up WTGPortRuntime.
"""
import os

ROOTS = [
    "/home/ubuntu/work/WhatTheGolf/android-port/Assets",
    "/home/ubuntu/c113work/ar_out/ExportedProject/Assets",
]


def write_both(rel_path: str, content: str) -> None:
    for r in ROOTS:
        if os.path.exists(r):
            p = os.path.join(r, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. CameraBehaviorOrthographic.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CameraBehaviorOrthographic.cs", """using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorOrthographic : CameraBehavior
	{
		[SerializeField]
		protected float orthographicSize = 8f;

		public override void Init()
		{
			base.Init();
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null)
					{
						c.orthographic = true;
						if (orthographicSize > 0.01f)
							c.orthographicSize = orthographicSize;
					}
				}
			}
		}
	}
}
""")

    # 2. CBOrthographicFollow2D.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBOrthographicFollow2D.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow2D : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 15f;
		[SerializeField] public float sideTrackPadding = 0.2f;
		[SerializeField] public float upperTrackPadding = 0.2f;
		[SerializeField] public float lowerTrackPadding = 0.2f;
		[SerializeField] public Vector2 offSetAxis;
		[SerializeField] public bool lockVerticalAxis;
		[SerializeField] public bool lockHorizontalAxis;
		[SerializeField] private Transform follow;
		[SerializeField] private bool autoAdjustOrthographicSize;
		[SerializeField] public float tweenTime = 0.15f;
		[SerializeField] private Vector3 desktopRotation;
		public Vector3 lookAhead;
		public bool isInPipeIntro;
		private Vector3 velocity;
		private Vector3 currentPosition;
		private Vector2 adjustedScreenPosition;
		public float lookAheadDistance;
		private bool _hasPos;

		public override void Init()
		{
			base.Init();
			currentPosition = transform.position;
			_hasPos = true;
		}

		public void SetFollowTarget(Transform newTarget) => follow = newTarget;

		public void SetPadding(float side, float upper, float lower)
		{
			sideTrackPadding = side;
			upperTrackPadding = upper;
			lowerTrackPadding = lower;
		}

		public void SetOrthoSize(float val)
		{
			if (val <= 0.01f) return;
			orthographicSize = val;
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null && c.orthographic)
						c.orthographicSize = orthographicSize;
				}
			}
		}

		public float GetOrthoSize() => orthographicSize > 0.01f ? orthographicSize : 8f;

		public Transform GetFollowTarget()
		{
			if (follow != null) return follow;
			if (OverworldManager2d.HasInstance)
			{
				var ow = OverworldManager2d.Instance;
				if (ow.cameraTarget != null) return ow.cameraTarget;
				if (ow.ball != null) return ow.ball.transform;
			}
			var b = Ball;
			return b != null ? b.transform : null;
		}

		public override void PreUpdate() { }

		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			Vector3 targetPos = t.position + new Vector3(offSetAxis.x, offSetAxis.y, 0f) + lookAhead;
			if (lockHorizontalAxis && _hasPos) targetPos.x = currentPosition.x;
			if (lockVerticalAxis && _hasPos) targetPos.y = currentPosition.y;
			Vector3 desired = targetPos - (rot * Vector3.forward) * dist;
			if (!_hasPos)
			{
				currentPosition = desired;
				_hasPos = true;
			}
			else
			{
				float st = Mathf.Max(0.05f, tweenTime);
				currentPosition = Vector3.SmoothDamp(currentPosition, desired, ref velocity, st, Mathf.Infinity, Time.unscaledDeltaTime);
			}
			return currentPosition;
		}
	}
}
""")

    # 3. CBOrthographicFollow.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBOrthographicFollow.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Transform followOverride;
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 15f;
		[SerializeField] private float leftSideTrackPadding;
		[SerializeField] private float rightSideTrackPadding;
		[SerializeField] private float upperTrackPadding;
		[SerializeField] private float lowerTrackPadding;
		[SerializeField] private bool lockVerticalAxis;
		[SerializeField] private bool lockHorizontalAxis;
		[SerializeField] private bool shouldCenterOnStart;
		[SerializeField] private float desktopOrthographicSize;
		[SerializeField] private Vector3 desktopRotation;
		private Transform follow;
		private Vector2 adjustedScreenPosition;

		public override void Init()
		{
			base.Init();
			if (followOverride != null) follow = followOverride;
		}

		public override void PreUpdate() { }
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			Vector3 desired = t.position - (rot * Vector3.forward) * dist;
			if (lockHorizontalAxis) desired.x = transform.position.x;
			if (lockVerticalAxis) desired.y = transform.position.y;
			return Vector3.Lerp(transform.position, desired, Time.unscaledDeltaTime * 8f);
		}

		public void SetFollowTarget(Transform target) => follow = target;

		public Transform GetFollowTarget()
		{
			if (follow != null) return follow;
			if (followOverride != null) return followOverride;
			var b = Ball;
			return b != null ? b.transform : null;
		}
	}
}
""")

    # 4. CBOrthographicStatic.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBOrthographicStatic.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicStatic : CameraBehaviorOrthographic
	{
		[SerializeField] private Transform trans;
		[SerializeField] private Vector3 desktopRotationOffset;
		[SerializeField] public bool autoAdjustOrthographicSize;
		private Quaternion baseRotation;
		[SerializeField] protected float orthographicSizeLongDevice;
		public bool AdjustForLongPhones;

		private void Awake()
		{
			if (trans == null) trans = transform;
			baseRotation = trans.rotation;
		}

		public override void Init()
		{
			base.Init();
			if (trans == null) trans = transform;
			baseRotation = trans.rotation;
		}

		protected override Vector3 CalculatePosition() => (trans != null ? trans : transform).position;
		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
""")

    # 5. CBOrthographicConstantMove.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBOrthographicConstantMove.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicConstantMove : CameraBehaviorOrthographic
	{
		[SerializeField] private Transform trans;
		[SerializeField] private Vector3 desktopRotationOffset;
		[SerializeField] public bool autoAdjustOrthographicSize;
		[SerializeField] public Vector3 moveSpeed;
		[SerializeField] public float rampUpTime;
		private float rampUpTimer;
		private Vector3 _pos;

		private void Awake()
		{
			if (trans == null) trans = transform;
			_pos = trans.position;
		}

		public override void Init()
		{
			base.Init();
			if (trans == null) trans = transform;
			_pos = trans.position;
			rampUpTimer = 0f;
		}

		protected override Vector3 CalculatePosition()
		{
			rampUpTimer += Time.deltaTime;
			float factor = rampUpTime > 0.01f ? Mathf.Clamp01(rampUpTimer / rampUpTime) : 1f;
			_pos += moveSpeed * (factor * Time.deltaTime);
			return _pos;
		}

		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
""")

    # 6. CBOverworldRoomStatic.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBOverworldRoomStatic.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBOverworldRoomStatic : CameraBehaviorOrthographic
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float smoothTime = 0.2f;
		[SerializeField] private float distance = 15f;
		[SerializeField] private bool lockVerticalAxis;
		[SerializeField] private bool lockHorizontalAxis;
		[SerializeField] private Transform follow;
		private Vector3 camVelocity;
		[SerializeField] private Vector3 desktopRotation;
		private Vector2 adjustedScreenPosition;

		public override void Init() => base.Init();
		public void SetFollowTarget(Transform newTarget) => follow = newTarget;
		public void SetOrthoSize(float val) => orthographicSize = val;
		public float GetOrthoSize() => orthographicSize > 0.01f ? orthographicSize : 8f;
		public Transform GetFollowTarget() => follow != null ? follow : transform;
		public override void PreUpdate() { }
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			return t.position - (rot * Vector3.forward) * dist;
		}
	}
}
""")

    # 7. CBFollowClamped.cs, CBFollowOrbit.cs, CBFollowOverworld.cs, CBFollowTrailer.cs, CBOrbit.cs, CBBlend.cs, CBPerspectiveFollow2D.cs, CBPerspecitveGyroscope.cs, CBSphericalFollow.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBFollowClamped.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBFollowClamped : CBFollow
	{
		[SerializeField] protected bool clampX;
		[SerializeField] protected float minX;
		[SerializeField] protected float maxX;
		[SerializeField] protected bool clampY;
		[SerializeField] protected float minY;
		[SerializeField] protected float maxY;
		[SerializeField] protected bool clampZ;
		[SerializeField] protected float minZ;
		[SerializeField] protected float maxZ;

		protected override Vector3 ballAtElevation => Clamp(base.ballAtElevation);

		private Vector3 Clamp(Vector3 position)
		{
			if (clampX && maxX > minX) position.x = Mathf.Clamp(position.x, minX, maxX);
			if (clampY && maxY > minY) position.y = Mathf.Clamp(position.y, minY, maxY);
			if (clampZ && maxZ > minZ) position.z = Mathf.Clamp(position.z, minZ, maxZ);
			return position;
		}

		protected override Vector3 CalculatePosition() => Clamp(base.CalculatePosition());
		private void OnDrawGizmos() { }
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBFollowOrbit.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBFollowOrbit : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] private float distance = 14f;
		[SerializeField] private Vector3 positionOffset;

		public Transform FollowTarget
		{
			get => GetFollowTarget();
			set => followTarget = value;
		}

		public override void Init() => base.Init();

		public override Quaternion CalculateRotation()
		{
			Transform f = GetFollowTarget();
			if (f != null && orbitTarget != null)
			{
				Vector3 dir = (orbitTarget.position - f.position).normalized;
				if (dir.sqrMagnitude > 0.001f)
					return Quaternion.LookRotation(dir, Vector3.up);
			}
			return transform.rotation;
		}

		protected override Vector3 CalculatePosition()
		{
			Transform f = GetFollowTarget();
			if (f == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 14f;
			return f.position + positionOffset - (rot * Vector3.forward) * dist;
		}

		public void SetOrbitTarget(Transform newOrbitTarget) => orbitTarget = newOrbitTarget;
		public void SetFollowTarget(Transform newFollowTarget) => followTarget = newFollowTarget;
		public override string ToString() => name;

		public Transform GetFollowTarget()
		{
			if (followTarget != null) return followTarget;
			var b = Ball;
			return b != null ? b.transform : orbitTarget;
		}
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBFollowOverworld.cs", """using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBFollowOverworld : CameraBehaviorPerspective
	{
		[SerializeField] protected new GolfBallController Ball;
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] private Vector3 rotation = new Vector3(45f, 0f, 0f);
		[SerializeField] private float elevation = 15f;
		[SerializeField] private bool shouldFollow = true;
		[SerializeField] private float startSmoothTime = 0.2f;
		[SerializeField] private float continuousSmoothTime = 0.15f;
		[SerializeField] private float aimSmoothTime = 0.2f;
		[SerializeField] private float continousTrackingTimer;
		[SerializeField] private Vector2 screenPosition = new Vector2(0.5f, 0.5f);
		[SerializeField] private float sideTrackPadding = 0.2f;
		[SerializeField] private float upperTrackPadding = 0.2f;
		[SerializeField] private float lowerTrackPadding = 0.2f;
		[SerializeField] private float elevationSmoothTime = 0.2f;
		private Vector2 velocity;
		private Vector3 pVelocity;
		private Vector2 adjustedScreenPosition;
		private float groundedElevation;
		private float targetGroundedElevation;
		private float continousTrackingTimerCountDown;
		private float diff;
		private float distance;
		private float elevationSmoothVel;
		private float smoothTime;

		public Transform FollowTarget
		{
			get => followTarget != null ? followTarget : (Ball != null ? Ball.transform : base.Ball?.transform);
			set => followTarget = value;
		}

		private Vector3 ballAtElevation => FollowTarget != null ? FollowTarget.position : Vector3.zero;
		private void Awake() { }
		public override void Init() => base.Init();
		public override void OutOfBounds() { }
		public void SetElevation(float newElevation) => elevation = newElevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);
		private Vector3 ScreenToWorld(Vector2 screenPos) => transform.position;

		protected override Vector3 CalculatePosition()
		{
			var t = FollowTarget;
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = elevation > 0.1f ? elevation : 15f;
			return t.position - (rot * Vector3.forward) * dist;
		}

		private bool IsBallOutsideOfBox() => true;
		private bool IsPointOutsideOfBox(Vector3 p) => true;
		private bool IsPointOutsideOfWindow(Vector3 p) => true;
		public override string ToString() => name;
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBFollowTrailer.cs", """using System.Collections;
using UnityEngine;

namespace CameraStack
{
	public class CBFollowTrailer : CameraBehaviorPerspective
	{
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] protected bool followGoalOnWin;
		[SerializeField] public Vector3 rotation = new Vector3(45f, 0f, 0f);
		[SerializeField] public float elevation = 15f;
		[SerializeField] public bool shouldFollow = true;
		[SerializeField] public float startSmoothTime = 0.2f;
		[SerializeField] public float continuousSmoothTime = 0.15f;
		[SerializeField] public float aimSmoothTime = 0.2f;
		[SerializeField] private float continousTrackingTimer;
		[SerializeField] public Vector2 screenPosition = new Vector2(0.5f, 0.5f);
		[SerializeField] private float sideTrackPadding;
		[SerializeField] private float upperTrackPadding;
		[SerializeField] private float lowerTrackPadding;
		[SerializeField] private float startFOV = 60f;
		[SerializeField] private float offsetFOV;
		private float trailerFOV;
		[SerializeField] private Vector3 globalOffset;
		[SerializeField] private Vector3 cameraOffset;
		private bool useGlobalOffset;
		private Vector3 cachedCameraOffset;
		private float elevationSmoothTime;
		private Vector2 velocity;
		private Vector2 adjustedScreenPosition;
		public float groundedElevation;
		public float targetGroundedElevation;
		private float continousTrackingTimerCountDown;
		private float diff;
		private float distance;
		private float elevationSmoothVel;
		private float smoothTime;
		private float width;
		private float height;

		public float OffsetFOV { get => offsetFOV; set => offsetFOV = value; }
		public Vector3 GlobalOffset { get => globalOffset; set => globalOffset = value; }
		public Vector3 CameraOffset { get => cameraOffset; set => cameraOffset = value; }
		public Transform FollowTarget
		{
			get => followTarget != null ? followTarget : (Ball != null ? Ball.transform : orbitTarget);
			set => followTarget = value;
		}
		private Vector3 ballAtElevation => FollowTarget != null ? FollowTarget.position : Vector3.zero;

		public override void Init() => base.Init();
		private IEnumerator WaitForActiveBall() { yield break; }
		public override void OutOfBounds() { }
		public void SetElevation(float newElevation) => elevation = newElevation;
		public float GetElevation() => elevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);
		private Vector3 ScreenToWorld(Vector2 screenPos) => transform.position;
		private void UpdateWidthAndHeight() { }

		protected override Vector3 CalculatePosition()
		{
			var t = FollowTarget;
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = elevation > 0.1f ? elevation : 15f;
			return t.position + globalOffset + cameraOffset - (rot * Vector3.forward) * dist;
		}

		public override void PreUpdate() { }
		private bool IsBallOutsideOfBox() => true;
		private bool IsPointOutsideOfBox(Vector3 p) => true;
		public override string ToString() => name;

		public void CopyVariables(CBFollow cbFollow)
		{
			if (cbFollow == null) return;
			rotation = cbFollow.rotation;
			elevation = cbFollow.elevation;
			shouldFollow = cbFollow.shouldFollow;
		}
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBOrbit.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBOrbit : CameraBehaviorPerspective
	{
		[SerializeField] private Vector3 target;
		[SerializeField] private float distance = 15f;
		[SerializeField] private float speed = 15f;
		private float angle;

		private void Awake() { }

		public override Quaternion CalculateRotation()
		{
			angle += speed * Time.deltaTime;
			return Quaternion.Euler(30f, angle, 0f);
		}

		protected override Vector3 CalculatePosition()
		{
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			return target - (rot * Vector3.forward) * dist;
		}
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBBlend.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBBlend : CameraBehaviorPerspective
	{
		public CameraBehaviorPerspective cameraA;
		public CameraBehaviorPerspective cameraB;
		public float AtoBBlend;
		private float width;
		private float height;

		public override float FOV
		{
			get
			{
				float a = cameraA != null ? cameraA.FOV : 60f;
				float b = cameraB != null ? cameraB.FOV : 60f;
				return Mathf.Lerp(a, b, Mathf.Clamp01(AtoBBlend));
			}
		}

		public override void Init()
		{
			cameraA?.Init();
			cameraB?.Init();
			base.Init();
		}

		public void UpdateCameras()
		{
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null && !c.orthographic)
						c.fieldOfView = FOV;
				}
			}
		}

		public override void OutOfBounds()
		{
			cameraA?.OutOfBounds();
			cameraB?.OutOfBounds();
		}

		public override Quaternion CalculateRotation()
		{
			Quaternion qa = cameraA != null ? cameraA.CalculateRotation() : transform.rotation;
			Quaternion qb = cameraB != null ? cameraB.CalculateRotation() : qa;
			return Quaternion.Slerp(qa, qb, Mathf.Clamp01(AtoBBlend));
		}

		private void UpdateWidthAndHeight() { }

		protected override Vector3 CalculatePosition()
		{
			Vector3 pa = cameraA != null ? cameraA.Position : transform.position;
			Vector3 pb = cameraB != null ? cameraB.Position : pa;
			return Vector3.Lerp(pa, pb, Mathf.Clamp01(AtoBBlend));
		}
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBPerspectiveFollow2D.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBPerspectiveFollow2D : CameraBehaviorPerspective
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 15f;
		[SerializeField] private float sideTrackPadding;
		[SerializeField] private float upperTrackPadding;
		[SerializeField] private float lowerTrackPadding;
		[SerializeField] private bool lockVerticalAxis;
		private Vector2 adjustedScreenPosition;

		public override void Init() => base.Init();
		public override void PreUpdate() { }
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			var b = Ball;
			if (b == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			Vector3 targetPos = b.transform.position;
			if (lockVerticalAxis) targetPos.y = transform.position.y;
			return targetPos - (rot * Vector3.forward) * dist;
		}
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBPerspecitveGyroscope.cs", """using System.Collections;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBPerspecitveGyroscope : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		public Vector3 offset;
		public Vector3 rotationOffset;
		public Transform gyroTransform;
		public float ControllerSensitivity = 2f;
		public float clampAngle = 80f;
		public Vector2 clampInDegrees = new Vector2(360f, 180f);
		public bool lockCursor;
		public Vector2 sensitivity = new Vector2(2f, 2f);
		public Vector2 smoothing = new Vector2(3f, 3f);
		public Vector2 targetDirection;
		public GolfBallController Controller;
		public bool FreeLookWhileAiming;
		public bool AutoHideArrow;
		public bool LookAtFlagOnStart;
		public FPGHelper HelperPrefab;
		private Quaternion startOffset;
		private float baseControllerSensitivity;
		private Vector2 _mouseAbsolute;
		private Vector2 _smoothMouse;
		private bool initialized;
		private TimeControl _timeControll;
		private Quaternion _lastRotation = Quaternion.identity;
		private const string HNAME = "Handheld";

		public override void Init()
		{
			base.Init();
			if (Controller == null) Controller = Ball;
			_lastRotation = Quaternion.Euler(rotationOffset);
		}

		private IEnumerator Setup() { yield break; }
		private void OnDestroy() { }
		private void InitPlayer() { }
		private void OnReset() { }
		public override Quaternion CalculateRotation() => _lastRotation;
		private bool IsUsingGyro() => false;
		public Quaternion CalculateRotation(float addUpMagnitude) => _lastRotation;

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			return t != null ? t.position + offset : transform.position;
		}

		private Quaternion GetSwitchGyro() => Quaternion.identity;
		public void SetFollowTarget(Transform target) { }
		public Transform GetFollowTarget() => Controller != null ? Controller.transform : (Ball != null ? Ball.transform : transform);
	}
}
""")

    write_both("Scripts/Assembly-CSharp/CameraStack/CBSphericalFollow.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBSphericalFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField] protected Transform followTarget;
		[SerializeField] protected Transform ball;
		[SerializeField] protected float distance = 15f;
		[SerializeField] protected Vector3 offset;

		public override Quaternion CalculateRotation()
		{
			Transform t = GetFollowTarget();
			if (t != null && followTarget != null && t != followTarget)
			{
				Vector3 up = (t.position - followTarget.position).normalized;
				if (up.sqrMagnitude > 0.001f)
					return Quaternion.LookRotation(-up, Vector3.forward);
			}
			return transform.rotation;
		}

		public Transform GetFollowTarget() => ball != null ? ball : (Ball != null ? Ball.transform : followTarget);
		public void SetFollowTarget(Transform target) => ball = target;

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			return t.position + offset - (rot * Vector3.forward) * dist;
		}
	}
}
""")

    # 8. OverworldCamera.cs (use ActiveBehavior properly!)
    write_both("Scripts/Assembly-CSharp/CameraStack/OverworldCamera.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraStack
{
	public class OverworldCamera : MonoBehaviour
	{
		private Action m_OnPreLateUpdate;
		private Camera[] _cameras;
		public static OverworldCamera Instance;
		public Transform OverridePositionTransform;
		public float OverridePositionWeight;
		[SerializeField] private CameraBehavior MobileCameraBehaviour;
		[SerializeField] private CameraBehavior StandaloneCameraBehaviour;
		[SerializeField] private CBOverworldRoomStatic PuzzleRoomCameraBehaviour;
		private PerlinShake shake;
		private List<OverworldCameraSettings> cameraSettings = new List<OverworldCameraSettings>();
		private GyroShakeOverworld gyro;
		public OverworldCameraSettings defaultSettings;
		public OverworldCameraSettings resetCamearaSettings;
		private float currentCameraSettingsTweenTime;
		private Vector3 lastBallPosition;
		private Vector3 lookAhead;

		public Camera[] Cameras => _cameras ?? (_cameras = GetComponentsInChildren<Camera>(true));
		public Camera MainCamera => GetComponent<Camera>() ?? (Cameras.Length > 0 ? Cameras[0] : Camera.main);
		public CameraBehavior ActiveBehavior { get; private set; }

		public event Action OnPreLateUpdate
		{
			add => m_OnPreLateUpdate = (Action)Delegate.Combine(m_OnPreLateUpdate, value);
			remove => m_OnPreLateUpdate = (Action)Delegate.Remove(m_OnPreLateUpdate, value);
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
			Instance = null;
		}

		private void Awake()
		{
			Instance = this;
			_cameras = GetComponentsInChildren<Camera>(true);
			var b = MobileCameraBehaviour != null ? MobileCameraBehaviour : StandaloneCameraBehaviour;
			if (b == null) b = GetComponent<CameraBehavior>();
			if (b != null) SwitchBehavior(b);
		}

		private IEnumerator ResetCameraNextFrame()
		{
			yield return null;
		}

		private void OnCameraSettingsChanged(OverworldCameraSettings settings, float pct)
		{
			if (settings != null && settings.IOSData != null && ActiveBehavior is CBOrthographicFollow2D ortho)
			{
				if (settings.IOSData.orthographicSize > 0.1f)
					ortho.SetOrthoSize(settings.IOSData.orthographicSize);
			}
		}

		public void OnRoomEnter(CBOverworldRoomStatic camSettings)
		{
			if (camSettings != null) SwitchBehavior(camSettings);
		}

		public void OnRoomExit()
		{
			var b = MobileCameraBehaviour != null ? MobileCameraBehaviour : StandaloneCameraBehaviour;
			if (b != null) SwitchBehavior(b);
		}

		private void LateUpdate()
		{
			m_OnPreLateUpdate?.Invoke();
			if (ActiveBehavior != null)
			{
				ActiveBehavior.PreUpdate();
				Vector3 pos = ActiveBehavior.Position;
				if (OverridePositionTransform != null && OverridePositionWeight > 0f)
				{
					Vector3 ov = new Vector3(OverridePositionTransform.position.x, OverridePositionTransform.position.y, pos.z);
					pos = Vector3.Lerp(pos, ov, Mathf.Clamp01(OverridePositionWeight));
				}
				transform.position = pos;
				transform.rotation = ActiveBehavior.Rotation;
			}
			else
			{
				Transform target = OverridePositionTransform;
				if (target == null && OverworldManager2d.HasInstance)
				{
					var ow = OverworldManager2d.Instance;
					if (ow.cameraTarget != null) target = ow.cameraTarget;
					else if (ow.ball != null) target = ow.ball.transform;
				}
				if (target != null)
				{
					Vector3 desired = new Vector3(target.position.x, target.position.y, transform.position.z);
					transform.position = Vector3.Lerp(transform.position, desired, Time.unscaledDeltaTime * 6f);
				}
			}
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
			if (newCameraBehavior == null) return;
			ActiveBehavior?.Cleanup();
			ActiveBehavior = newCameraBehavior;
			ActiveBehavior.Cameras = Cameras;
			ActiveBehavior.Init();
		}

		public void Shake(float duration, float speed, float magnitude) { }
		public bool IsWorldPosNearScreen(Vector3 pos, float nearThreshold = 0.25f) => true;
	}
}
""")

    # 17. CameraStack/CBWinCamera.cs
    write_both("Scripts/Assembly-CSharp/CameraStack/CBWinCamera.cs", """namespace CameraStack
{
	public class CBWinCamera : CBFollow
	{
		public override void Init() => base.Init();
	}
}
""")

    # 18. AnimateRectTransform.cs
    write_both("Scripts/Assembly-CSharp/AnimateRectTransform.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateRectTransform : MonoBehaviour
{
	public enum Property
	{
		sizeDelta = 0,
		position = 1,
		scale = 2,
		color = 3
	}

	[Serializable]
	public struct TransitionType
	{
		public float duration;
		public EasingFunction.Ease ease;
		public Property prop;
		public Graphic overrideColorGraphic;
	}

	[Serializable]
	[SerializeField]
	public struct RectState
	{
		public bool useSize;
		public Vector2 sizeDelta;
		public bool useScale;
		public Vector2 scale;
		public bool usePos;
		public Vector2 anchoredPos;
		public bool useColor;
		public Color color;
	}

	public bool disableOnHide;
	[SerializeField] private List<TransitionType> overrideTransition;
	private TransitionType defaultT;
	[SerializeField] public RectState HideState;
	[SerializeField] private RectState ShowState;
	[SerializeField] private bool alternate;
	[SerializeField] private List<RectState> AlternateStates;
	[SerializeField] private RectTransform overrideRectTransform;

	private RectTransform RectTransform => overrideRectTransform != null ? overrideRectTransform : GetComponent<RectTransform>();

	private Graphic Graphic(TransitionType transitionType)
	{
		return transitionType.overrideColorGraphic != null ? transitionType.overrideColorGraphic : GetComponent<Graphic>();
	}

	public float SetShow(bool s, bool instant = false)
	{
		if (s) gameObject.SetActive(true);
		RectState state = s ? ShowState : HideState;
		if (instant) SetInstant(state);
		else SetProps(state);
		if (!s && disableOnHide)
		{
			if (instant || !gameObject.activeInHierarchy) gameObject.SetActive(false);
			else StartCoroutine(DeactiveAfter(GetLongestTransition(state)));
		}
		return instant ? 0f : GetLongestTransition(state);
	}

	private void Deactivate() => gameObject.SetActive(false);

	public float Show() => SetShow(true, false);

	private IEnumerator AlternateAfter(float a)
	{
		yield return new WaitForSecondsRealtime(a);
		Alternate();
	}

	public float Hide() => SetShow(false, false);

	private void SetProps(RectState s) => SetInstant(s);

	private void SetInstant(RectState s)
	{
		var rt = RectTransform;
		if (rt != null)
		{
			if (s.useSize) rt.sizeDelta = s.sizeDelta;
			if (s.useScale) rt.localScale = new Vector3(s.scale.x, s.scale.y, 1f);
			if (s.usePos) rt.anchoredPosition = s.anchoredPos;
		}
		if (s.useColor)
		{
			var g = GetComponent<Graphic>();
			if (g != null) g.color = s.color;
		}
	}

	private IEnumerator DeactiveAfter(float t)
	{
		if (t > 0f) yield return new WaitForSecondsRealtime(t);
		if (disableOnHide) gameObject.SetActive(false);
	}

	public float GetLongestTransition(RectState s)
	{
		float max = 0.2f;
		if (overrideTransition != null)
		{
			foreach (var tr in overrideTransition)
				if (tr.duration > max) max = tr.duration;
		}
		return max;
	}

	private TransitionType GetTransitionLength(Property p)
	{
		if (overrideTransition != null)
		{
			foreach (var tr in overrideTransition)
				if (tr.prop == p) return tr;
		}
		return defaultT;
	}

	private void SetProp(Property p, Vector2 end) { }
	private void SetProp(Property p, Color c) { }
	private void Alternate() { }
	private IEnumerator AlternateCR() { yield break; }
}
""")

    # 19. MainMenu2Button.cs, MainMenu2Navigator.cs, MainMenu2NavigatorSorter.cs, AdventureButton.cs
    write_both("Scripts/Assembly-CSharp/MainMenu2Button.cs", """using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenu2Button : Button
{
	private UINavigationHelper _navigationHelper;
	public UnityEvent onSelected = new UnityEvent();

	protected override void Start()
	{
		base.Start();
		_navigationHelper = GetComponent<UINavigationHelper>();
	}

	public override void OnSelect(BaseEventData eventData)
	{
		base.OnSelect(eventData);
		onSelected?.Invoke();
	}

	public override Selectable FindSelectableOnLeft()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnLeft() ?? base.FindSelectableOnLeft()) : base.FindSelectableOnLeft();
	}

	public override Selectable FindSelectableOnRight()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnRight() ?? base.FindSelectableOnRight()) : base.FindSelectableOnRight();
	}

	public override Selectable FindSelectableOnUp()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnTop() ?? base.FindSelectableOnUp()) : base.FindSelectableOnUp();
	}

	public override Selectable FindSelectableOnDown()
	{
		var nav = GetComponent<MainMenu2Navigator>();
		return nav != null ? (nav.FindSelectableOnBottom() ?? base.FindSelectableOnDown()) : base.FindSelectableOnDown();
	}
}
""")

    write_both("Scripts/Assembly-CSharp/MainMenu2Navigator.cs", """using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu2Navigator : MonoBehaviour
{
	[SerializeField] private List<Selectable> left = new List<Selectable>();
	[SerializeField] private List<Selectable> right = new List<Selectable>();
	[SerializeField] private List<Selectable> up = new List<Selectable>();
	[SerializeField] private List<Selectable> down = new List<Selectable>();

	private static Selectable FirstActive(List<Selectable> list)
	{
		if (list == null) return null;
		foreach (var s in list)
			if (s != null && s.IsInteractable() && s.gameObject.activeInHierarchy) return s;
		return null;
	}

	public Selectable FindSelectableOnLeft() => FirstActive(left);
	public Selectable FindSelectableOnRight() => FirstActive(right);
	public Selectable FindSelectableOnTop() => FirstActive(up);
	public Selectable FindSelectableOnBottom() => FirstActive(down);

	public void SortDown(Comparison<Selectable> comparer)
	{
		if (down != null && comparer != null) down.Sort(comparer);
	}
}
""")

    write_both("Scripts/Assembly-CSharp/MainMenu2NavigatorSorter.cs", """using System.Collections;
using UnityEngine;

public class MainMenu2NavigatorSorter : MonoBehaviour
{
	private IEnumerator Start()
	{
		yield break;
	}
}
""")

    write_both("Scripts/Assembly-CSharp/AdventureButton.cs", """using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureButton : MainMenu2Button
{
	[SerializeField] private RectTransform _progressRoot;
	[SerializeField] private RectTransform _progressFill;
	[SerializeField] private TMP_Text _progressText;
	[SerializeField] private GameObject _lockedImage;
	[SerializeField] private GameObject _numberPanel;
	[SerializeField] private TMP_Text _numberText;
	[SerializeField] private MaskableGraphic[] _adventureImages;
	[SerializeField] private TextMeshProLocalized _titleText;
	[SerializeField] private GameObject _playIcon;
	[SerializeField] private RectTransform _percentagePanel;
	[SerializeField] private Color _colorBad = Color.red;
	[SerializeField] private Color _colorMedium = Color.yellow;
	[SerializeField] private Color _colorGood = Color.green;
	[SerializeField] private Color _colorActive = Color.white;
	[SerializeField] private Color _colorNormal = Color.gray;
	[SerializeField] private GameObject _newGraphic;
	[SerializeField] private Material _grayscaleMaterial;
	[SerializeField] private CountdownTimer _countdown;
	[SerializeField] private MaskableGraphic _buttonOutline;

	public bool shouldAnimateSize;
	public float animationSpeed = 4f;
	public float animationSizeMax = 1.05f;
	public float animationSizeMin = 0.98f;
	public Transform button;
	private bool _locked;

	public ContentPackDef levelPackContainer { get; set; }
	public IPackWithData CurrentPack { get; private set; }

	public bool isNewVisible
	{
		set { if (_newGraphic != null) _newGraphic.SetActive(value); }
	}

	public string campaignTag { get; set; }

	public bool isLocked
	{
		get => _locked;
		set
		{
			_locked = value;
			if (_lockedImage != null) _lockedImage.SetActive(value);
		}
	}

	private bool isProgressVisible
	{
		set { if (_progressRoot != null) _progressRoot.gameObject.SetActive(value); }
	}

	public bool hasNumberPanel
	{
		set { if (_numberPanel != null) _numberPanel.SetActive(value); }
	}

	public string number
	{
		set { if (_numberText != null) _numberText.text = value; }
	}

	public Sprite adventureImage
	{
		set
		{
			if (_adventureImages != null)
			{
				foreach (var g in _adventureImages)
					if (g is Image img) img.sprite = value;
			}
		}
	}

	public string adventureTitleID
	{
		set { if (_titleText != null) _titleText.ChangeTextAfterTranslation(value); }
	}

	public float progress
	{
		set
		{
			int pct = Mathf.Clamp(Mathf.RoundToInt(value * 100f), 0, 100);
			if (_progressText != null) _progressText.text = pct + "%";
		}
	}

	public bool IsSpecial { get; private set; }

	public new bool IsActive
	{
		set { if (_playIcon != null) _playIcon.SetActive(value); }
	}

	public void UpdatePack(ContentPackDef container, IPackWithData pack)
	{
		levelPackContainer = container;
		CurrentPack = pack ?? container?.pack;
		if (CurrentPack != null)
		{
			adventureTitleID = CurrentPack.TitleID;
			isLocked = false;
			if (CurrentPack is ContentPack cp)
				progress = SaveGame.GetCompletedPercentage(cp.campaignType) / 100f;
		}
	}

	public void Update() { }
}
""")

    # 20. OverworldTeleportMenu.cs & QuickMenu.cs
    write_both("Scripts/Assembly-CSharp/OverworldTeleportMenu.cs", """using System.Collections.Generic;
using UnityEngine;

public class OverworldTeleportMenu : MonoBehaviour
{
	[SerializeField] private RectTransform _mainPanel;
	private List<AdventureButton> _teleportButtons = new List<AdventureButton>();
	private bool _initialized;
	private Coroutine closeCR;
	private int activeTeleportButton;

	private OverworldLevelData _campaignData => OverworldManager2d.HasInstance ? OverworldManager2d.Instance.overworldLevelData : null;

	private void InitializeIfNot()
	{
		if (_initialized) return;
		_initialized = true;
		_teleportButtons = new List<AdventureButton>(GetComponentsInChildren<AdventureButton>(true));
		PopulateMainCampaignSections();
	}

	private void PopulateMainCampaignSections()
	{
		var data = _campaignData;
		if (data == null || data.Sections == null) return;
		for (int i = 0; i < _teleportButtons.Count && i < data.Sections.Count; i++)
		{
			int idx = i;
			var sec = data.Sections[i];
			var btn = _teleportButtons[i];
			if (btn == null) continue;
			btn.gameObject.SetActive(true);
			btn.number = (i + 1).ToString();
			btn.onClick.RemoveAllListeners();
			btn.onClick.AddListener(() => Teleport(sec, idx));
		}
	}

	private void Teleport(OverworldLevelSection section, int index)
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null && section != null)
		{
			var goals = OverworldManager2d.Instance.goals;
			if (goals != null && index >= 0 && index < goals.Count && goals[index] != null)
				OverworldManager2d.Instance.ball.transform.position = goals[index].transform.position + Vector3.down * 1.5f;
		}
		if (Menu.Menu.Exists) Menu.Menu.Instance.Close();
	}

	private void RefreshButtons() => InitializeIfNot();

	public void Show()
	{
		gameObject.SetActive(true);
		InitializeIfNot();
	}

	private void OnDisable() { }
}
""")

    write_both("Scripts/Assembly-CSharp/QuickMenu.cs", """using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class QuickMenu : MonoBehaviour
{
	[Serializable]
	public class MenuButton
	{
		public SVGImage Icon;
		public Sprite IconSprite;
		public UnityEvent OnClick;
		public List<string> DisableInScenes;
	}

	public delegate void MenuOpenDelegate(bool state);

	private enum MenuStateEnum
	{
		Inactive = 0,
		TransitionIn = 1,
		Active = 2,
		TransitionOut = 3
	}

	public List<MenuButton> Buttons = new List<MenuButton>();
	public MenuButton GyroButton;
	public Transform MenuContainer;
	public float MenuTransitionSpeed = 8f;
	public float ButtonTransitionSpeed = 10f;
	public List<string> ScenesWithoutMenu = new List<string>();
	public List<string> AllowInSpecialScenes = new List<string>();
	public GameObject Container;
	public Transform selectionHand;
	public GameObject UseGyro;
	public GameObject UseStick;
	public ClipSettingsCollection HoverSFX;
	public ClipSettingsCollection ClickSFX;
	public ClipSettingsCollection OpenSFX;
	public List<AudioClip> HoverOnButtonClips = new List<AudioClip>();
	public List<AudioClip> ButtonSelectedClips = new List<AudioClip>();
	public List<AudioClip> MenuOpening = new List<AudioClip>();
	public List<AudioClip> MenuClosing = new List<AudioClip>();
	public float Volume = 1f;

	private List<Behaviour> currentBlockers = new List<Behaviour>();
	private MenuStateEnum menuState;
	private int currentActiveButton;
	private int lastActiveButton;
	private float transitionTimer;
	private float buttonSwitchDelay;
	private Dictionary<GolfBallController, bool> controllers = new Dictionary<GolfBallController, bool>();
	private string currentScene;
	private List<MenuButton> currentButtons = new List<MenuButton>();
	private Vector3 currentUIUp;
	private Vector3 handposition;

	public static QuickMenu Instance;
	private static MenuOpenDelegate m_OnMenuStateChanged;

	private bool ShouldHandBeVisible => menuState == MenuStateEnum.Active;
	private Vector3 HandTarget => Vector3.zero;

	public static event MenuOpenDelegate OnMenuStateChanged
	{
		add => m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Combine(m_OnMenuStateChanged, value);
		remove => m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Remove(m_OnMenuStateChanged, value);
	}

	public void PlayConfirmationSFX() { }

	private void Awake()
	{
		Instance = this;
		if (Container != null) Container.SetActive(false);
	}

	public void AddBlocker(Behaviour blockingBehaviour)
	{
		if (blockingBehaviour != null && !currentBlockers.Contains(blockingBehaviour))
			currentBlockers.Add(blockingBehaviour);
	}

	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
		currentBlockers.Remove(blockingBehaviour);
	}

	private void OnMouseUpEvent(GameObject icon) { }
	private void OnMouseOverEvent(GameObject icon) { }

	private void Update()
	{
		if (InputHelper.GetAllPlayerButtonOpenMenu())
		{
			if (menuState == MenuStateEnum.Active) CloseMenu();
			else Show();
		}
	}

	private void HandleTransitionInState() { }
	private void HandleTransitionOutState() { }
	private void HandleInactiveState() { }

	public void Show()
	{
		menuState = MenuStateEnum.Active;
		if (Container != null) Container.SetActive(true);
		m_OnMenuStateChanged?.Invoke(true);
	}

	private void HandleActiveState() { }
	private void GameCenterAccessPointTrigger() { }
	private void UpdateSelectionHand(float speed) { }

	public void CloseMenu()
	{
		menuState = MenuStateEnum.Inactive;
		if (Container != null) Container.SetActive(false);
		m_OnMenuStateChanged?.Invoke(false);
	}

	public void OpenSettings() { }
	public void ReturnFromSettings() { }
	public void ExitFromSettings() => CloseMenu();

	public void ExitGame()
	{
		CloseMenu();
		if (Level.HasInstance) Level.Instance.Abort();
		else _ = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
	}

	public void SkipLevel()
	{
		CloseMenu();
		if (Level.HasInstance) Level.Instance.Complete("SKIPPED!", 0.2f);
	}

	public void ChangeGyroControls()
	{
		SaveGame.SwitchUseGyro = !SaveGame.SwitchUseGyro;
	}

	public void RestartLevel()
	{
		CloseMenu();
		if (Level.HasInstance) Level.Instance.Restart();
		else SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
""")

    # 21. PackStarterManager, PackStarter, GeneralCampaignStarter, CampaignStarter, Hub.FlagPackStarter
    write_both("Scripts/Assembly-CSharp/PackStarter.cs", """using UnityEngine;

public class PackStarter : MonoBehaviour
{
	[SerializeField] private string packId;

	public void StartPack()
	{
		if (!string.IsNullOrEmpty(packId))
			_ = Hub.FlagPackStarter.StartFlag(packId);
	}
}
""")

    write_both("Scripts/Assembly-CSharp/PackStarterManager.cs", """using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class PackStarterManager : MonoBehaviour
{
	[SerializeField] private List<PackStarterDef> packStarters = new List<PackStarterDef>();
	private static PackStarterManager instance;
	public Action<ContentPack> PackStarted;
	public Action<string, bool> PackFinished;
	public string lastPackId;

	public static PackStarterManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<PackStarterManager>();
				if (instance == null)
				{
					var go = new GameObject("PackStarterManager");
					instance = go.AddComponent<PackStarterManager>();
					DontDestroyOnLoad(go);
				}
			}
			return instance;
		}
		private set => instance = value;
	}

	private void Awake()
	{
		instance = this;
	}

	public static Task<bool> StartPack(ContentPack pack, bool isLevelNotification, params object[] args)
	{
		return Instance.StartPack((IPackWithData)pack, isLevelNotification, args);
	}

	public async Task<bool> StartPack(IPackWithData pack, bool isLevelNotification, params object[] args)
	{
		if (pack == null) return false;
		lastPackId = pack.PackID;
		if (pack is ContentPack cp)
		{
			PackStarted?.Invoke(cp);
			SaveGame.SetOverworld(cp.campaignType);
			SaveGame.IncrementContentPackPlayCount(cp.contentPackID);

			if (packStarters != null)
			{
				foreach (var def in packStarters)
				{
					if (def != null && def.starter != null && def.contentPackIds != null && def.contentPackIds.Contains(cp.contentPackID))
					{
						return await StartPack(pack, def.starter, args);
					}
				}
			}

			string sceneName = ResolveOverworldScene(cp);
			if (!string.IsNullOrEmpty(sceneName))
			{
				try
				{
					var h = Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, true);
					if (h.IsValid())
					{
						while (!h.IsDone) await Task.Yield();
						return true;
					}
				}
				catch { }
				if (Application.CanStreamedLevelBeLoaded(sceneName))
				{
					var op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
					while (op != null && !op.isDone) await Task.Yield();
					return true;
				}
			}
		}
		return false;
	}

	private static string ResolveOverworldScene(ContentPack cp)
	{
		if (cp == null) return "main overworld new";
		string id = (cp.contentPackID ?? cp.name ?? "").ToLowerInvariant();
		if (id.Contains("sport") || id.Contains("olympic")) return "Sports_Overworld";
		if (id.Contains("snow") || id.Contains("winter")) return "SnowySnow Overworld";
		if (id.Contains("hole") || id.Contains("living")) return "LivingThings_Overworld";
		if (id.Contains("impossible")) return "Impossible_Overworld";
		if (id.Contains("hotdog")) return "Hotdog_Overworld";
		if (id.Contains("hub")) return "Hub_Overworld";
		var cat = WTGPortCatalog.Instance;
		if (cat != null && cat.episodes != null)
		{
			foreach (var ep in cat.episodes)
			{
				if (ep.pack == cp && !string.IsNullOrEmpty(ep.overworldScene))
					return ep.overworldScene;
			}
		}
		return "main overworld new";
	}

	private Task<bool> StartPack(IPackWithData pack, BasePackStarter starter, params object[] args)
	{
		if (starter != null && pack is ContentPack cp)
		{
			bool ok = starter.StartPack(cp, args);
			return Task.FromResult(ok);
		}
		return Task.FromResult(false);
	}

	private void PackCompleted(bool didComplete)
	{
		PackFinished?.Invoke(lastPackId, didComplete);
	}

	public static Task PackFinishedAsync() => Task.CompletedTask;
}
""")

    write_both("Scripts/Assembly-CSharp/GeneralCampaignStarter.cs", """using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class GeneralCampaignStarter : BasePackStarter
{
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		if (pack == null) return false;
		_ = PackStarterManager.StartPack(pack, false, additionalContext);
		return true;
	}

	private IEnumerator StartPack(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		yield return StartCampaignCR(pack, level, shape);
	}

	public Task StartCampaign(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return PackStarterManager.StartPack(pack, false, level, shape);
	}

	private IEnumerator StartCampaignCR(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		var task = PackStarterManager.StartPack(pack, false, level, shape);
		while (!task.IsCompleted) yield return null;
		OnPackDone?.Invoke(task.Result);
	}

	private IEnumerator GoToComputerCR(string notificationId) { yield break; }
	private IEnumerator AwaitLevelLoadCR(float delay) { yield break; }
	private IEnumerator GoToLevelCR(string level, Transmogrif.BALLSHAPES shape, float delay = 0f) { yield break; }
	private IEnumerator GoToPosition(Vector2 position) { yield break; }
	private bool CheckDoors(string level) => true;
}
""")

    write_both("Scripts/Assembly-CSharp/CampaignStarter.cs", """using System.Collections;

public class CampaignStarter : BasePackStarter
{
	private OverworldManager2d overworldCaller;

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		if (pack == null) return false;
		_ = PackStarterManager.StartPack(pack, false, additionalContext);
		return true;
	}

	private IEnumerator StartCampaignCR(ContentPack pack, OverworldLevelSection section)
	{
		var task = PackStarterManager.StartPack(pack, false, section);
		while (!task.IsCompleted) yield return null;
		OnPackDone?.Invoke(task.Result);
	}

	private void LevelAborted() => OnPackDone?.Invoke(false);
	private void BackFromOnboarding(bool isComplete) => OnPackDone?.Invoke(isComplete);
	private IEnumerator WaitAfterLevelLoaded() { yield break; }
}
""")

    write_both("Scripts/Assembly-CSharp/Hub/FlagPackStarter.cs", """using System;
using System.Collections;
using System.Threading.Tasks;
using Core;
using UnityEngine;

namespace Hub
{
	public class FlagPackStarter : MonoBehaviour
	{
		[SerializeField] private GameObject crown;
		[SerializeField] private GameObject completedFlag;
		[SerializeField] private GameObject uncompletedFlag;
		[SerializeField] private Collider2D circleCollider;
		[SerializeField] private Collider2D boxCollider;
		[SerializeField] private bool dontDisableOverworld;
		[SerializeField] private WhatTheCarPopup carPopup;
		private DayOfWeek lastUpdate;
		[SerializeField] public string pack;
		[NonSerialized] private ContentPackDef packDef;

		private NotificationConfiguration notifs => null;
		private bool IsImpossiblePack => !string.IsNullOrEmpty(pack) && pack.Contains("IMPOSSIBLE");
		private ContentPackDef PackDef
		{
			get
			{
				if (packDef == null && RuntimeStoreData.instance != null && RuntimeStoreData.instance.contentPacksDefs != null)
				{
					foreach (var c in RuntimeStoreData.instance.contentPacksDefs)
					{
						if (c != null && c.pack != null && (c.pack.contentPackID == pack || c.pack.name == pack))
						{
							packDef = c;
							break;
						}
					}
				}
				return packDef;
			}
		}

		private void Start() => SetState();
		private void Update() { }

		private void SetState()
		{
			bool done = IsCompleted();
			if (completedFlag != null) completedFlag.SetActive(done);
			if (uncompletedFlag != null) uncompletedFlag.SetActive(!done);
		}

		public virtual void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null && collision.collider.GetComponentInParent<OverworldBall2D>() != null)
				StartPack();
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other != null && other.GetComponentInParent<OverworldBall2D>() != null)
				StartPack();
		}

		public void StartPack()
		{
			if (!string.IsNullOrEmpty(pack))
				_ = StartFlag(pack);
			else if (PackDef?.pack != null)
				_ = PackStarterManager.StartPack(PackDef.pack, false);
		}

		private IEnumerator DisableOverworldWithDelay() { yield break; }
		private void DisableInteraction() { }
		private void EnableInteraction() { }
		private WTGNotification GetNotification() => default;
		private bool IsCompleted() => !string.IsNullOrEmpty(pack) && SaveGame.IsContentPackComplete(pack);

		public static async Task<bool> StartFlag(string packId)
		{
			if (string.IsNullOrEmpty(packId)) return false;
			if (RuntimeStoreData.instance != null && RuntimeStoreData.instance.contentPacksDefs != null)
			{
				foreach (var c in RuntimeStoreData.instance.contentPacksDefs)
				{
					if (c != null && c.pack != null && (c.pack.contentPackID == packId || c.pack.name == packId))
						return await PackStarterManager.StartPack(c.pack, false);
				}
			}
			var cat = WTGPortCatalog.Instance;
			if (cat != null && cat.episodes != null)
			{
				foreach (var ep in cat.episodes)
				{
					if (ep.pack != null && (ep.pack.contentPackID == packId || ep.packId == packId))
						return await PackStarterManager.StartPack(ep.pack, false);
				}
			}
			return false;
		}
	}
}
""")

    # 22. OverworldButton2D.cs, ShortcutTunnel.cs, ShortcutTunnelEntry.cs, SimplePortal.cs
    write_both("Scripts/Assembly-CSharp/OverworldButton2D.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldButton2D : GolfBehaviour
{
	public enum ButtonType
	{
		fromLeft = 0,
		fromRight = 1,
		fromBelow = 2,
		fromAboveTilted = 3
	}

	public enum AddOrRemoveNotification
	{
		Add = 0,
		Remove = 1
	}

	public OverworldButton2D previous;
	public OverworldMainDoorRobot previousBoss;
	private Action m_OnOpen;
	private Action m_OnStartingToOpen;
	public bool isStartingOpen;
	public Transform flagContainer;
	public int flagsRequiredOffset;
	public TextMeshPro missingFlagsText;
	public Transform openIndicator;
	public PlantParticles openParticles;
	public float BallDistanceThreshold = 3f;
	public bool canOpen = true;
	public float volumeMultiplier = 1f;
	public ButtonType orientation;
	public AudioClip sfxOnOpen;
	public AudioClip sfxExplosion;
	public bool isTilted;
	public OverworldDoor HorizontalDoor;
	public OverworldDoor VerticalDoor;
	public Transform DoorBubbleTransform;
	public SpriteRenderer BubbleSprite;
	public SpriteRenderer SubObjectiveSprite;
	public bool isSnappingToGrid;
	public bool isShowingHintLines;
	public int maxHintLinesToShow;
	public bool onlyIncludeFlagsBelowThis;
	public bool useOpenIndicator;
	public Collectable subObjective;
	public int subObjectiveGoal;
	public List<OverworldGoal> requireGoals = new List<OverworldGoal>();
	public ClipSettingsCollection sfxOpen;
	public ClipSettingsCollection sfxAfterOpen;
	public bool OnlyAcceptCrowns;
	public bool UseAllFlagsInOverworld;

	private OverworldCamera camera;
	private bool currentlyCheating;
	private float cheatUnlockTimer;
	private Tilemap tileMap;
	protected DoorBubble doorBubble;
	private OverworldDoor door;
	public OverworldMainButton ConsoleButton;
	[NonSerialized] public bool openOrOpening;
	private bool hasSubobjectives;
	[SerializeField] private PerlinShake bubbleShake;
	private int count;
	public float UnlockBlinkRate = 1f;
	public Color[] OpenColors;
	public Color[] UnlockedColors;
	public Color[] LockedColors;
	public SpriteRenderer[] ButtonRenderers;
	public SpriteRenderer[] ButtonBackRenderers;
	private OverworldID overworldID;
	private Coroutine currentBlinkRoutine;
	private bool isActive = true;
	private bool canShowBubble;
	[SerializeField] private AddOrRemoveNotification addOrRemoveNotification;
	[SerializeField] private string levelNotificationId;

	public int GetTotalCount => requireGoals != null ? requireGoals.Count : 0;
	public bool IsOpenOrOpening => openOrOpening;
	public bool CanOpen => GetFlagsLeft() <= 0;

	public event Action OnOpen
	{
		add => m_OnOpen = (Action)Delegate.Combine(m_OnOpen, value);
		remove => m_OnOpen = (Action)Delegate.Remove(m_OnOpen, value);
	}

	public event Action OnStartingToOpen
	{
		add => m_OnStartingToOpen = (Action)Delegate.Combine(m_OnStartingToOpen, value);
		remove => m_OnStartingToOpen = (Action)Delegate.Remove(m_OnStartingToOpen, value);
	}

	public override void OnPrePlayOrPreCompile() { }

	private void Awake()
	{
		overworldID = GetComponent<OverworldID>();
		door = HorizontalDoor != null ? HorizontalDoor : VerticalDoor;
	}

	private void Start()
	{
		if (isStartingOpen || (overworldID != null && SaveGame.GetIsDoorOpen(overworldID.ID)))
			JustOpen(true);
		else
			UpdateStatus();
	}

	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
		this.tileMap = tilemap;
		this.camera = camera;
		UpdateStatus();
	}

	private void HandlePreviousOpened() => UpdateStatus();
	public void AfterInit() => UpdateStatus();
	private IEnumerator FlagHintRoutine() { yield break; }
	private IEnumerator BlinkRoutine() { yield break; }
	private void Goal_OnUpdateData(OverworldGoal obj) => UpdateStatus();

	public virtual int GetFlagsLeft()
	{
		if (requireGoals == null || requireGoals.Count == 0) return 0;
		int completed = 0;
		foreach (var g in requireGoals)
		{
			if (g != null && g.IsCompleted()) completed++;
		}
		return Mathf.Max(0, requireGoals.Count + flagsRequiredOffset - completed);
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
		if (openIndicator != null) openIndicator.gameObject.SetActive(open);
	}

	public void ToggleBlinkRoutine(bool turnOn) { }

	public virtual void UpdateStatus()
	{
		int left = GetFlagsLeft();
		if (missingFlagsText != null)
			missingFlagsText.text = left > 0 ? left.ToString() : string.Empty;
	}

	public void CheckOpen()
	{
		if (CanDoorBeOpened()) OpenDoor();
	}

	private void OnOpenDoorAnalytcis() { }
	public void InstantOpenDoor() => JustOpen(true);
	public bool CanDoorBeOpened() => !openOrOpening && GetFlagsLeft() <= 0;

	public void OpenDoor()
	{
		if (openOrOpening) return;
		JustOpen(false);
	}

	public void RemoveButton() => gameObject.SetActive(false);

	public void JustOpen(bool instant = false)
	{
		openOrOpening = true;
		m_OnStartingToOpen?.Invoke();
		if (overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
			SaveGame.SetDoorOpen(overworldID.ID);
		if (HorizontalDoor != null) HorizontalDoor.gameObject.SetActive(false);
		if (VerticalDoor != null) VerticalDoor.gameObject.SetActive(false);
		if (door != null) door.gameObject.SetActive(false);
		SetOpenIndicator(true);
		m_OnOpen?.Invoke();
	}

	public IEnumerator OpenAndClose(float delay)
	{
		JustOpen(false);
		yield return new WaitForSeconds(delay);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.collider.GetComponentInParent<OverworldBall2D>() != null)
			CheckOpen();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null && other.GetComponentInParent<OverworldBall2D>() != null)
			CheckOpen();
	}

	private Vector3 GetSnappedPosition() => transform.position;
	private ButtonType FlipTiltedOrientation(ButtonType orientation) => orientation;
	public void OnDrawGizmos() { }
	private void OnDrawGizmosSelected() { }
	private IEnumerator CheatingRoutine() { yield break; }
	public void OnMouseDown() => CheckOpen();
	public void OnMouseExit() { }
	public void OnMouseUp() { }
	public void DebugOpenDoor() => JustOpen(true);
}
""")

    write_both("Scripts/Assembly-CSharp/ShortcutTunnel.cs", """using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class ShortcutTunnel : MonoBehaviour
{
	private Action<ShortcutTunnel> m_OnBallEnterTunnel;
	private Action<ShortcutTunnel> m_OnBallExitTunnel;
	private Action<float> m_OnMovementUpdate;

	public Transform pathContainer;
	public bool useCameraBlend = true;
	public float speed = 15f;
	public float shootoutSpeed = 12f;
	public float shootOutOffset = 0.8f;
	public RandomAudioClips clips;
	public RandomAudioClips tunnelHitClips;
	public RumbleEventAsset rumbleOnCorner;

	private ShortcutTunnelEntry[] entries;
	private Coroutine movementRoutine;
	private bool isTraveling;
	private ShortcutTunnelTraversable lastThing;
	private bool isPaused;

	public event Action<ShortcutTunnel> OnBallEnterTunnel
	{
		add => m_OnBallEnterTunnel = (Action<ShortcutTunnel>)Delegate.Combine(m_OnBallEnterTunnel, value);
		remove => m_OnBallEnterTunnel = (Action<ShortcutTunnel>)Delegate.Remove(m_OnBallEnterTunnel, value);
	}

	public event Action<ShortcutTunnel> OnBallExitTunnel
	{
		add => m_OnBallExitTunnel = (Action<ShortcutTunnel>)Delegate.Combine(m_OnBallExitTunnel, value);
		remove => m_OnBallExitTunnel = (Action<ShortcutTunnel>)Delegate.Remove(m_OnBallExitTunnel, value);
	}

	public event Action<float> OnMovementUpdate
	{
		add => m_OnMovementUpdate = (Action<float>)Delegate.Combine(m_OnMovementUpdate, value);
		remove => m_OnMovementUpdate = (Action<float>)Delegate.Remove(m_OnMovementUpdate, value);
	}

	public void Start()
	{
		entries = GetComponentsInChildren<ShortcutTunnelEntry>(true);
		if (entries != null)
		{
			foreach (var e in entries)
			{
				if (e != null)
				{
					e.OnEntered -= Entry_OnEntered;
					e.OnEntered += Entry_OnEntered;
				}
			}
		}
	}

	public void Pause() => isPaused = true;
	public void Resume() => isPaused = false;

	private void Entry_OnEntered(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		if (!isTraveling && thing != null)
			movementRoutine = StartCoroutine(TraverseTunnelRoutine(entry, thing));
	}

	private void OnDisable() => KillTravel();

	public void KillTravel()
	{
		if (movementRoutine != null) StopCoroutine(movementRoutine);
		isTraveling = false;
	}

	private IEnumerator TraverseTunnelRoutine(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		isTraveling = true;
		lastThing = thing;
		m_OnBallEnterTunnel?.Invoke(this);
		if (pathContainer != null && pathContainer.childCount > 0)
		{
			int count = pathContainer.childCount;
			bool rev = entry != null && entry.isPathReverse;
			for (int i = 0; i < count; i++)
			{
				int idx = rev ? (count - 1 - i) : i;
				Transform wp = pathContainer.GetChild(idx);
				if (wp == null) continue;
				while (Vector2.Distance(thing.transform.position, wp.position) > 0.15f)
				{
					if (!isPaused)
						thing.transform.position = Vector3.MoveTowards(thing.transform.position, wp.position, Mathf.Max(8f, speed) * Time.deltaTime);
					yield return null;
				}
			}
		}
		m_OnBallExitTunnel?.Invoke(this);
		isTraveling = false;
	}
}
""")

    write_both("Scripts/Assembly-CSharp/ShortcutTunnelEntry.cs", """using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;

public class ShortcutTunnelEntry : MonoBehaviour
{
	public bool isBlocked;
	public bool isOnlyForExit;
	public bool isOneWayAndItsNotThisOne;
	public float pushAwayForce = 5f;
	public float pushAwayTime = 0.25f;
	[NonSerialized] public bool canBeUsed = true;
	public bool isPathReverse;
	public Transform block;
	public ClipSettingsCollection EnterSFX;

	private Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> m_OnEntered;
	private readonly string saveFormat;
	private GridFiller filler;
	private float nextEnterTime;

	public event Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> OnEntered
	{
		add => m_OnEntered = (Action<ShortcutTunnelEntry, ShortcutTunnelTraversable>)Delegate.Combine(m_OnEntered, value);
		remove => m_OnEntered = (Action<ShortcutTunnelEntry, ShortcutTunnelTraversable>)Delegate.Remove(m_OnEntered, value);
	}

	public IEnumerator Start()
	{
		canBeUsed = !isBlocked && !isOnlyForExit;
		yield break;
	}

	public void UnblockAndSave()
	{
		isBlocked = false;
		canBeUsed = true;
		if (block != null) block.gameObject.SetActive(false);
	}

	private IEnumerator PushAway(ShortcutTunnelTraversable thing)
	{
		yield break;
	}

	public void EnterTunnel(ShortcutTunnelTraversable thing)
	{
		if (Time.time < nextEnterTime || isOnlyForExit || isBlocked) return;
		nextEnterTime = Time.time + 0.75f;
		m_OnEntered?.Invoke(this, thing);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var tr = other.GetComponentInParent<ShortcutTunnelTraversable>();
		if (tr != null) EnterTunnel(tr);
	}
}
""")

    write_both("Scripts/Assembly-CSharp/SimplePortal.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class SimplePortal : MonoBehaviour
{
	[Serializable]
	public class UnityGameobjectEvent : UnityEvent<GameObject>
	{
	}

	public static Action FinishedTeleporting;
	private Action<SimplePortal, GameObject, SimplePortal> m_OnPortaling;

	public SimplePortal LinkedPortal;
	public Transmogrif sendThroughTransmogrif;
	public List<string> AllowedTags = new List<string>();
	public Color InactiveColor = Color.gray;
	public bool SetRotationOnTransfer;
	public bool hideUntilUsedFromOtherSide;
	public bool saveUnhideState;
	public AudioEventAsset portalSFX;
	[SerializeField] private AudioClip sfxPortal;
	public float BlockTimer = 0.5f;
	public float SpawnOffset = 1f;
	public Vector3 WorldPositionSpawnOffset;
	public Vector3 ForceDirectionOverride;
	public bool CheckForRigidParent = true;
	public UnityEvent OtherEvents = new UnityEvent();
	public UnityGameobjectEvent OtherEventsWithInfo = new UnityGameobjectEvent();
	public bool IgnoreKinematicObjects;
	public float MinVelocityOnExit = 5f;
	public bool useTransitionCamera;
	public bool portAll = true;
	public bool portOnce;
	public Color baseColor = Color.white;

	private Action m_OnPortalEnabledIfDidntStartEnabled;
	private SpriteRenderer render;
	private float colorValue;
	private float blockTimer;
	private Color targetColor;
	private ParticleSystem particles;
	private GridFiller filler;
	private readonly string saveFormat;
	public float transitionCamTime = 0.5f;
	private OverworldID overworldID;
	public bool NotSaved;

	public event Action<SimplePortal, GameObject, SimplePortal> OnPortaling
	{
		add => m_OnPortaling = (Action<SimplePortal, GameObject, SimplePortal>)Delegate.Combine(m_OnPortaling, value);
		remove => m_OnPortaling = (Action<SimplePortal, GameObject, SimplePortal>)Delegate.Remove(m_OnPortaling, value);
	}

	public event Action OnPortalEnabledIfDidntStartEnabled
	{
		add => m_OnPortalEnabledIfDidntStartEnabled = (Action)Delegate.Combine(m_OnPortalEnabledIfDidntStartEnabled, value);
		remove => m_OnPortalEnabledIfDidntStartEnabled = (Action)Delegate.Remove(m_OnPortalEnabledIfDidntStartEnabled, value);
	}

	private void Awake()
	{
		render = GetComponent<SpriteRenderer>();
		particles = GetComponentInChildren<ParticleSystem>();
	}

	public void OpenPortalFromOtherSide()
	{
		hideUntilUsedFromOtherSide = false;
		gameObject.SetActive(true);
		m_OnPortalEnabledIfDidntStartEnabled?.Invoke();
	}

	public void Init(GridFiller gridFiller) => filler = gridFiller;

	private void Update()
	{
		if (blockTimer > 0f) blockTimer -= Time.deltaTime;
	}

	private bool IsActive() => blockTimer <= 0f && !hideUntilUsedFromOtherSide;

	private void OnTriggerEnter(Collider other)
	{
		if (other != null) ObjectEnteredTrigger(other.gameObject);
	}

	private void OnTriggerStay(Collider other) { }

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null) ObjectEnteredTrigger(other.gameObject);
	}

	private void OnTriggerStay2D(Collider2D other) { }

	protected virtual void ObjectEnteredTrigger(GameObject other)
	{
		if (!IsActive() || other == null || LinkedPortal == null) return;
		GameObject target = other;
		if (CheckForRigidParent)
		{
			var rb2d = other.GetComponentInParent<Rigidbody2D>();
			if (rb2d != null) target = rb2d.gameObject;
			else
			{
				var rb = other.GetComponentInParent<Rigidbody>();
				if (rb != null) target = rb.gameObject;
			}
		}
		blockTimer = Mathf.Max(0.4f, BlockTimer);
		LinkedPortal.OpenPortalFromOtherSide();
		LinkedPortal.RecieveObject(target);
		m_OnPortaling?.Invoke(this, target, LinkedPortal);
		OtherEvents?.Invoke();
		OtherEventsWithInfo?.Invoke(target);
		FinishedTeleporting?.Invoke();
	}

	private IEnumerator OpenHiddenPortal(GameObject other) { yield break; }
	public void SaveOpenState() { }

	protected virtual void RecieveObject(GameObject go)
	{
		if (go == null) return;
		blockTimer = Mathf.Max(0.4f, BlockTimer);
		go.transform.position = transform.position + WorldPositionSpawnOffset + transform.up * SpawnOffset;
		ThrowOutOfPortal(go);
	}

	private void ThrowOutOfPortal(GameObject go)
	{
		if (go == null) return;
		Vector3 dir = ForceDirectionOverride.sqrMagnitude > 0.01f ? ForceDirectionOverride.normalized : transform.up;
		var rb2d = go.GetComponent<Rigidbody2D>();
		if (rb2d != null)
			rb2d.velocity = dir * Mathf.Max(MinVelocityOnExit, rb2d.velocity.magnitude);
		var rb = go.GetComponent<Rigidbody>();
		if (rb != null && !rb.isKinematic)
			rb.velocity = dir * Mathf.Max(MinVelocityOnExit, rb.velocity.magnitude);
	}

	private void OnDrawGizmosSelected() { }
}
""")

    # 23. Clean WTGPortRuntime.cs (no permanent debug OnGUI bar covering 1:1 UI!)
    write_both("Scripts/Assembly-CSharp/Core/WTGPortRuntime.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
	public class WTGPortRuntime : MonoBehaviour
	{
		private static WTGPortRuntime _instance;
		private bool _showMenu;
		private int _selectedEpisodeIndex;
		private Vector2 _scrollPos;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AutoBoot()
		{
			if (_instance != null) return;
			var go = new GameObject("WTGPortRuntime");
			DontDestroyOnLoad(go);
			_instance = go.AddComponent<WTGPortRuntime>();
		}

		private void Awake()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(gameObject);
				return;
			}
			_instance = this;
			DontDestroyOnLoad(gameObject);
			Application.targetFrameRate = 60;
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

		private void OnDestroy()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			Game.strokes = 0;
			EnsureScenePlayable();
		}

		private void EnsureScenePlayable()
		{
			var ctrls = FindObjectsOfType<GolfBallController>();
			foreach (var c in ctrls)
			{
				if (c != null && !c.enabled)
					c.Activate();
			}
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F1) || (Input.touchCount == 4 && Input.GetTouch(3).phase == TouchPhase.Began))
				_showMenu = !_showMenu;
		}

		private void OnGUI()
		{
			if (!_showMenu) return;

			float scale = Mathf.Clamp(Screen.height / 720f, 0.85f, 2.2f);
			int fontSize = Mathf.RoundToInt(18f * scale);
			var btnStyle = new GUIStyle(GUI.skin.button) { fontSize = fontSize, fontStyle = FontStyle.Bold };
			var labelStyle = new GUIStyle(GUI.skin.label) { fontSize = fontSize, fontStyle = FontStyle.Bold, normal = { textColor = Color.white } };

			DrawEpisodeMenu(scale, btnStyle, labelStyle);
		}

		private void DrawEpisodeMenu(float scale, GUIStyle btnStyle, GUIStyle labelStyle)
		{
			float w = Mathf.Min(Screen.width - 40f * scale, 920f * scale);
			float h = Mathf.Min(Screen.height - 90f * scale, 580f * scale);
			Rect boxRect = new Rect((Screen.width - w) * 0.5f, 48f * scale, w, h);
			GUI.Box(boxRect, "WHAT THE GOLF? — Level Selector");

			GUILayout.BeginArea(new Rect(boxRect.x + 16f * scale, boxRect.y + 36f * scale, boxRect.width - 32f * scale, boxRect.height - 48f * scale));

			GUILayout.BeginHorizontal();
			if (GUILayout.Button("Close", btnStyle, GUILayout.Height(36f * scale))) _showMenu = false;
			if (GUILayout.Button("Restart", btnStyle, GUILayout.Height(36f * scale))) { _showMenu = false; RestartActiveScene(); }
			if (GUILayout.Button("Hub", btnStyle, GUILayout.Height(36f * scale))) { _showMenu = false; LoadSceneByName("Hub_Overworld"); }
			GUILayout.EndHorizontal();

			var catalog = WTGPortCatalog.Instance;
			if (catalog != null && catalog.episodes != null && catalog.episodes.Count > 0)
			{
				GUILayout.BeginHorizontal();
				for (int i = 0; i < catalog.episodes.Count; i++)
				{
					var ep = catalog.episodes[i];
					if (GUILayout.Button(ep.title, btnStyle, GUILayout.Height(36f * scale)))
						_selectedEpisodeIndex = i;
				}
				GUILayout.EndHorizontal();

				var curEp = catalog.episodes[Mathf.Clamp(_selectedEpisodeIndex, 0, catalog.episodes.Count - 1)];
				if (!string.IsNullOrEmpty(curEp.overworldScene))
				{
					if (GUILayout.Button($"Enter Overworld: {curEp.overworldScene}", btnStyle, GUILayout.Height(40f * scale)))
					{
						_showMenu = false;
						LoadSceneByName(curEp.overworldScene);
					}
				}

				_scrollPos = GUILayout.BeginScrollView(_scrollPos);
				if (curEp.levels != null)
				{
					foreach (var lvl in curEp.levels)
					{
						if (lvl == null) continue;
						string sName = lvl.SceneName;
						if (GUILayout.Button($"{lvl.name}  ({sName})  [Par {lvl.StrokesToPar}]", btnStyle, GUILayout.Height(36f * scale)))
						{
							_showMenu = false;
							if (LevelManager.Instance != null)
								LevelManager.Instance.StartCoroutine(LevelManager.Instance.Play(lvl, discardLoadedScenes: true));
							else
								LoadSceneByName(sName);
						}
					}
				}
				GUILayout.EndScrollView();
			}

			GUILayout.EndArea();
		}

		private void RestartActiveScene()
		{
			if (Level.HasInstance) Level.Instance.ResetLevel();
			else SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		private void LoadSceneByName(string sceneName)
		{
			if (string.IsNullOrEmpty(sceneName)) return;
			try
			{
				var handle = UnityEngine.AddressableAssets.Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, true);
				if (handle.IsValid()) return;
			}
			catch { }
			if (Application.CanStreamedLevelBeLoaded(sceneName))
				SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		}
	}
}
""")

    print("Wrote all CameraStack, UI, Menu, PackStarter, Overworld, and Runtime implementations.")


if __name__ == "__main__":
    main()
