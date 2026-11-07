using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000254")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x34100", Offset = "0x34100")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000255")]
		public enum RotationMode
		{
			[Token(Token = "0x4000F69")]
			Smooth = 0,
			[Token(Token = "0x4000F6A")]
			Linear = 1
		}

		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x18")]
		public CameraController cameraController;

		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x20")]
		public float accelerationTime;

		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x24")]
		public float turnTime;

		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x28")]
		public bool walkByDefault;

		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x2C")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x30")]
		public float moveSpeed;

		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36ED8", Offset = "0x36ED8")]
		private bool isGrounded__BackingField;

		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170001E5")]
		public bool isGrounded
		{
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x13FA570", Offset = "0x13FA570", VA = "0x13FA570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B3CC", Offset = "0x3B3CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F6A")]
			[Address(RVA = "0x13FA578", Offset = "0x13FA578", VA = "0x13FA578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B3DC", Offset = "0x3B3DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x13FA580", Offset = "0x13FA580", VA = "0x13FA580")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x13FA614", Offset = "0x13FA614", VA = "0x13FA614")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x13FAC18", Offset = "0x13FAC18", VA = "0x13FAC18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x13FA66C", Offset = "0x13FA66C", VA = "0x13FA66C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x13FA99C", Offset = "0x13FA99C", VA = "0x13FA99C")]
		private void Move()
		{
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x13FAC54", Offset = "0x13FAC54", VA = "0x13FAC54")]
		private Vector3 GetInputVector()
		{
			return default;
		}

		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x13FACFC", Offset = "0x13FACFC", VA = "0x13FACFC")]
		private Vector3 GetInputVectorRaw()
		{
			return default;
		}

		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x13FAD88", Offset = "0x13FAD88", VA = "0x13FAD88")]
		public SimpleLocomotion()
		{
		}
	}
}
