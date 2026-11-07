using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Token(Token = "0x200126F")]
	public class Ball : Selectable<BallDefinition>
	{
		[Token(Token = "0x4006325")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GolfBallController m_Controller;

		[Token(Token = "0x4006326")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform m_CameraTarget;

		[Token(Token = "0x4006327")]
		private const float kMaxBallDistanceFromOrigin = 1000f;

		[Token(Token = "0x4006328")]
		[FieldOffset(Offset = "0x70")]
		private bool m_PlayMode;

		[Token(Token = "0x4006329")]
		[FieldOffset(Offset = "0x78")]
		private Transform m_targetFollower;

		[Token(Token = "0x170009A8")]
		public GolfBallController controller
		{
			[Token(Token = "0x6005530")]
			[Address(RVA = "0x1517ABC", Offset = "0x1517ABC", VA = "0x1517ABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A9")]
		public Transform cameraTarget
		{
			[Token(Token = "0x6005531")]
			[Address(RVA = "0x1517B68", Offset = "0x1517B68", VA = "0x1517B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005532")]
		[Address(RVA = "0x1517D70", Offset = "0x1517D70", VA = "0x1517D70", Slot = "6")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x6005533")]
		[Address(RVA = "0x1517E78", Offset = "0x1517E78", VA = "0x1517E78", Slot = "7")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x6005534")]
		[Address(RVA = "0x1517F00", Offset = "0x1517F00", VA = "0x1517F00")]
		private void OnExitPlayMode()
		{
		}

		[Token(Token = "0x6005535")]
		[Address(RVA = "0x1517F08", Offset = "0x1517F08", VA = "0x1517F08")]
		private void OnEnterPlayMode()
		{
		}

		[Token(Token = "0x6005536")]
		[Address(RVA = "0x1517F14", Offset = "0x1517F14", VA = "0x1517F14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005537")]
		[Address(RVA = "0x1517FDC", Offset = "0x1517FDC", VA = "0x1517FDC")]
		public Ball()
		{
		}
	}
}
