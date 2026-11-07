using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001FB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C94", Offset = "0x36C94")]
		public float aimWeight;

		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36CAC", Offset = "0x36CAC")]
		public float sightWeight;

		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36CC4", Offset = "0x36CC4")]
		public float maxAngle;

		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000D5A")]
		[FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000D5B")]
		[FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000D5C")]
		[FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000D5D")]
		[FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000D5E")]
		[FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000D5F")]
		[FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36CE0", Offset = "0x36CE0")]
		public float cameraRecoilWeight;

		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x136F76C", Offset = "0x136F76C", VA = "0x136F76C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x136F8E8", Offset = "0x136F8E8", VA = "0x136F8E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x136F8F4", Offset = "0x136F8F4", VA = "0x136F8F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x136FB8C", Offset = "0x136FB8C", VA = "0x136FB8C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x136FD48", Offset = "0x136FD48", VA = "0x136FD48")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x136F9C0", Offset = "0x136F9C0", VA = "0x136F9C0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x1370660", Offset = "0x1370660", VA = "0x1370660")]
		public FPSAiming()
		{
		}
	}
}
