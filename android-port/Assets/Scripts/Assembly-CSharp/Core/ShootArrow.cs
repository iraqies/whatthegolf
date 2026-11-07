using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200143D")]
	public class ShootArrow : MonoBehaviour
	{
		[Token(Token = "0x200143E")]
		public enum MoveMethodEnum
		{
			[Token(Token = "0x4006DD5")]
			Normal = 0,
			[Token(Token = "0x4006DD6")]
			Physics = 1,
			[Token(Token = "0x4006DD7")]
			Physics2D = 2,
			[Token(Token = "0x4006DD8")]
			None = 3,
			[Token(Token = "0x4006DD9")]
			SmoothedPhysics = 4
		}

		[Token(Token = "0x4006DAE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<Renderer> renderers;

		[Token(Token = "0x4006DAF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<Renderer> shadowRenderers;

		[Token(Token = "0x4006DB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Renderer arrowOutline;

		[Token(Token = "0x4006DB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Color colorMin;

		[Token(Token = "0x4006DB2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public Color colorMax;

		[Token(Token = "0x4006DB3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public AnimationCurve colorCurve;

		[Token(Token = "0x4006DB4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public Color blockedColor;

		[Token(Token = "0x4006DB5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public Color outlineBlockedColor;

		[Token(Token = "0x4006DB6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public Transform overrideBall;

		[Token(Token = "0x4006DB7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public Transform basePivot;

		[Token(Token = "0x4006DB8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public float limitValue;

		[Token(Token = "0x4006DB9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public Transform arrowHeadJoint;

		[Token(Token = "0x4006DBA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		public Transform arrowBaseJoint;

		[Token(Token = "0x4006DBB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public MoveMethodEnum MoveMethod;

		[Token(Token = "0x4006DBC")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		public MoveMethodEnum RotateMethod;

		[Token(Token = "0x4006DBD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject boostArrow;

		[Token(Token = "0x4006DBE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public bool AutoHide;

		[Token(Token = "0x4006DBF")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		public float SmoothedPhysicsSpeed;

		[Token(Token = "0x4006DC0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float gyroMagnitude;

		[Token(Token = "0x4006DC1")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float scaleMod;

		[Token(Token = "0x4006DC2")]
		[FieldOffset(Offset = "0xC0")]
		private float alphaDipSpeed;

		[Token(Token = "0x4006DC3")]
		[FieldOffset(Offset = "0xC4")]
		private float alphaDipStart;

		[Token(Token = "0x4006DC4")]
		[FieldOffset(Offset = "0xC8")]
		public float InsideAlpha;

		[Token(Token = "0x4006DC5")]
		[FieldOffset(Offset = "0xCC")]
		public float InsideAlphaOutline;

		[Token(Token = "0x4006DC6")]
		[FieldOffset(Offset = "0xD0")]
		public Camera cam;

		[Token(Token = "0x4006DC7")]
		[FieldOffset(Offset = "0xD8")]
		private GolfBallController ball;

		[Token(Token = "0x4006DC8")]
		[FieldOffset(Offset = "0xE0")]
		private float blockValue;

		[Token(Token = "0x4006DC9")]
		[FieldOffset(Offset = "0xE8")]
		private Material arrowMaterial;

		[Token(Token = "0x4006DCA")]
		[FieldOffset(Offset = "0xF0")]
		private Material arrowOutlineMaterial;

		[Token(Token = "0x4006DCB")]
		[FieldOffset(Offset = "0xF8")]
		private float arrowSize;

		[Token(Token = "0x4006DCC")]
		[FieldOffset(Offset = "0xFC")]
		private float targetArrowSize;

		[Token(Token = "0x4006DCD")]
		[FieldOffset(Offset = "0x100")]
		private float arrowSizeChangeSpeed;

		[Token(Token = "0x4006DCE")]
		[FieldOffset(Offset = "0x108")]
		private Rigidbody rigid;

		[Token(Token = "0x4006DCF")]
		[FieldOffset(Offset = "0x110")]
		private Rigidbody2D rigid2D;

		[Token(Token = "0x4006DD0")]
		[FieldOffset(Offset = "0x118")]
		private float alphaTarget;

		[Token(Token = "0x4006DD1")]
		[FieldOffset(Offset = "0x11C")]
		private float currentAlpha;

		[Token(Token = "0x4006DD2")]
		[FieldOffset(Offset = "0x120")]
		private bool overrideIsBlocked;

		[Token(Token = "0x4006DD3")]
		[FieldOffset(Offset = "0x121")]
		public bool clampAimVector;

		[Token(Token = "0x17000ABD")]
		public float ShaftLength
		{
			[Token(Token = "0x6005E9C")]
			[Address(RVA = "0x169FA54", Offset = "0x169FA54", VA = "0x169FA54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000ABE")]
		private float Scale
		{
			[Token(Token = "0x6005E9D")]
			[Address(RVA = "0x169FA80", Offset = "0x169FA80", VA = "0x169FA80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000ABF")]
		private Vector3 Up
		{
			[Token(Token = "0x6005EA0")]
			[Address(RVA = "0x16A0038", Offset = "0x16A0038", VA = "0x16A0038")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AC0")]
		public bool CastShadow
		{
			[Token(Token = "0x6005EB0")]
			[Address(RVA = "0x16A1474", Offset = "0x16A1474", VA = "0x16A1474")]
			set
			{
			}
		}

		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0x169FAA4", Offset = "0x169FAA4", VA = "0x169FAA4")]
		private Camera GetCam()
		{
			return null;
		}

		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0x169FB48", Offset = "0x169FB48", VA = "0x169FB48")]
		public void Initialize(GolfBallController ballController, bool showArrowOnTop)
		{
		}

		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0x16A0080", Offset = "0x16A0080", VA = "0x16A0080")]
		public void SetOverrideBall(Transform ball)
		{
		}

		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0x16A00F8", Offset = "0x16A00F8", VA = "0x16A00F8")]
		private Vector3 GetGyroDirection(float amount)
		{
			return default;
		}

		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0x16A026C", Offset = "0x16A026C", VA = "0x16A026C")]
		public void UpdateDashedArrow(Vector3 dir)
		{
		}

		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0x16A03C0", Offset = "0x16A03C0", VA = "0x16A03C0")]
		public void UpdateArrow(Vector3 vec, bool isBlocked, bool onlyDashedArrow)
		{
		}

		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0x16A111C", Offset = "0x16A111C", VA = "0x16A111C")]
		public void SetBlockOverride(bool value)
		{
		}

		[Token(Token = "0x6005EA6")]
		[Address(RVA = "0x16A0978", Offset = "0x16A0978", VA = "0x16A0978")]
		private void MoveArrow(Vector3 position)
		{
		}

		[Token(Token = "0x6005EA7")]
		[Address(RVA = "0x16A0B3C", Offset = "0x16A0B3C", VA = "0x16A0B3C")]
		private void RotateArrow(Vector3 vec)
		{
		}

		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0x16A10E8", Offset = "0x16A10E8", VA = "0x16A10E8")]
		private void ChangeLength(float ratio)
		{
		}

		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0x16A1124", Offset = "0x16A1124", VA = "0x16A1124")]
		public void PlayShootSequence(float t)
		{
		}

		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0x16A10CC", Offset = "0x16A10CC", VA = "0x16A10CC")]
		public void SetArrowColor(Color c)
		{
		}

		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0x16A1024", Offset = "0x16A1024", VA = "0x16A1024")]
		public Color GetColor(Vector3 vec)
		{
			return default;
		}

		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0x16A1158", Offset = "0x16A1158", VA = "0x16A1158")]
		public void StartAim()
		{
		}

		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0x16A1324", Offset = "0x16A1324", VA = "0x16A1324")]
		public void Hide()
		{
		}

		[Token(Token = "0x6005EAE")]
		[Address(RVA = "0x16A13F4", Offset = "0x16A13F4", VA = "0x16A13F4")]
		public void DoAlphaDip()
		{
		}

		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0x16A1400", Offset = "0x16A1400", VA = "0x16A1400")]
		public Vector3? GetClosestPointOnShaft(Vector3 pos)
		{
			return null;
		}

		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0x16A15CC", Offset = "0x16A15CC", VA = "0x16A15CC")]
		public ShootArrow()
		{
		}
	}
}
