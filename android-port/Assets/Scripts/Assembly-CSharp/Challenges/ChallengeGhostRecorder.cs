using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Challenges
{
	[Token(Token = "0x20010F7")]
	public class ChallengeGhostRecorder : Challenge
	{
		[Serializable]
		[Token(Token = "0x20010F8")]
		public class GhostData
		{
			[Token(Token = "0x400596D")]
			[FieldOffset(Offset = "0x10")]
			public float time;

			[Token(Token = "0x400596E")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 position;

			[Token(Token = "0x400596F")]
			[FieldOffset(Offset = "0x20")]
			public Quaternion rotation;

			[Token(Token = "0x6004BF3")]
			[Address(RVA = "0x1782F00", Offset = "0x1782F00", VA = "0x1782F00")]
			public GhostData()
			{
			}

			[Token(Token = "0x6004BF4")]
			[Address(RVA = "0x1782F08", Offset = "0x1782F08", VA = "0x1782F08")]
			public GhostData(float time, Transform transform)
			{
			}

			[Token(Token = "0x6004BF5")]
			[Address(RVA = "0x1782F70", Offset = "0x1782F70", VA = "0x1782F70")]
			public static GhostData Lerp(GhostData data1, GhostData data2, float t)
			{
				return null;
			}
		}

		[Token(Token = "0x4005958")]
		[FieldOffset(Offset = "0xA8")]
		public List<GhostData> ghostDataList;

		[Token(Token = "0x4005959")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x563F0", Offset = "0x563F0")]
		public Transform ghostObject;

		[Token(Token = "0x400595A")]
		[FieldOffset(Offset = "0xB8")]
		private bool _isStarted;

		[Token(Token = "0x400595B")]
		[FieldOffset(Offset = "0xBC")]
		private float _timer;

		[Token(Token = "0x400595C")]
		[FieldOffset(Offset = "0xC0")]
		private float _nextTime;

		[Token(Token = "0x400595D")]
		[FieldOffset(Offset = "0xC4")]
		public float recordInterval;

		[Token(Token = "0x400595E")]
		[FieldOffset(Offset = "0xC8")]
		private GolfBallController _controller;

		[Token(Token = "0x400595F")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x56428", Offset = "0x56428")]
		public bool recordGhostData;

		[Token(Token = "0x4005960")]
		[FieldOffset(Offset = "0xD4")]
		private int _currentData;

		[Token(Token = "0x4005961")]
		[FieldOffset(Offset = "0xD8")]
		private GhostData _currentGhostData;

		[Token(Token = "0x4005962")]
		[FieldOffset(Offset = "0xE0")]
		private GhostData _nextGhostData;

		[Token(Token = "0x4005963")]
		[FieldOffset(Offset = "0xE8")]
		private bool _countingDown;

		[Token(Token = "0x4005964")]
		[FieldOffset(Offset = "0xEC")]
		private int _countTime;

		[Token(Token = "0x4005965")]
		[FieldOffset(Offset = "0xF0")]
		private bool _failed;

		[Token(Token = "0x4005966")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 _moveDelta;

		[Token(Token = "0x4005967")]
		[FieldOffset(Offset = "0x100")]
		private Vector3 _oldPosition;

		[Token(Token = "0x4005968")]
		[FieldOffset(Offset = "0x110")]
		private StopwatchSFX stopwatchSFX;

		[Token(Token = "0x4005969")]
		[FieldOffset(Offset = "0x118")]
		public float sheepSpeed;

		[Token(Token = "0x400596A")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float sheepHeightY;

		[Token(Token = "0x400596B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Rigidbody ghostRigid;

		[Token(Token = "0x400596C")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool usePhysicsToMove;

		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x1893410", Offset = "0x1893410", VA = "0x1893410", Slot = "8")]
		protected override void Activate()
		{
		}

		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x189390C", Offset = "0x189390C", VA = "0x189390C", Slot = "9")]
		protected override void ChallengeUpdate()
		{
		}

		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x1893D74", Offset = "0x1893D74", VA = "0x1893D74")]
		private void Tick()
		{
		}

		[Token(Token = "0x6004BED")]
		[Address(RVA = "0x1893FC4", Offset = "0x1893FC4", VA = "0x1893FC4", Slot = "10")]
		public override void OnLevelComplete(Level.CompletedState completedState)
		{
		}

		[Token(Token = "0x6004BEE")]
		[Address(RVA = "0x1893F10", Offset = "0x1893F10", VA = "0x1893F10")]
		private void RecordData()
		{
		}

		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0x1893FF8", Offset = "0x1893FF8", VA = "0x1893FF8", Slot = "5")]
		public override string GetDescription()
		{
			return null;
		}

		[Token(Token = "0x6004BF0")]
		[Address(RVA = "0x18940C8", Offset = "0x18940C8", VA = "0x18940C8", Slot = "6")]
		public override string GetWinMessageID()
		{
			return null;
		}

		[Token(Token = "0x6004BF1")]
		[Address(RVA = "0x189412C", Offset = "0x189412C", VA = "0x189412C")]
		public ChallengeGhostRecorder()
		{
		}

		[Token(Token = "0x6004BF2")]
		[Address(RVA = "0x189414C", Offset = "0x189414C", VA = "0x189414C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAD4", Offset = "0x6FAD4")]
		private bool _003CActivate_003Eb__22_0(GameObject g)
		{
			return default;
		}
	}
}
