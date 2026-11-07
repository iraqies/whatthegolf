using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Challenges
{
	[Token(Token = "0x20010F9")]
	public class GhostRecorderData : MonoBehaviour
	{
		[Token(Token = "0x4005970")]
		[FieldOffset(Offset = "0x18")]
		public Transform recordObject;

		[Token(Token = "0x4005971")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] DisableObjects;

		[Token(Token = "0x4005972")]
		[FieldOffset(Offset = "0x28")]
		public bool record;

		[Token(Token = "0x4005973")]
		[FieldOffset(Offset = "0x2C")]
		public float recordInterval;

		[Token(Token = "0x4005974")]
		[FieldOffset(Offset = "0x30")]
		public List<ChallengeGhostRecorder.GhostData> data;

		[Token(Token = "0x4005975")]
		[FieldOffset(Offset = "0x38")]
		private float m_recordTimer;

		[Token(Token = "0x4005976")]
		[FieldOffset(Offset = "0x3C")]
		private float m_timeAtStart;

		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x1485C7C", Offset = "0x1485C7C", VA = "0x1485C7C")]
		public void StartRecording()
		{
		}

		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x1485E38", Offset = "0x1485E38", VA = "0x1485E38")]
		private void Update()
		{
		}

		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x1485F1C", Offset = "0x1485F1C", VA = "0x1485F1C")]
		public GhostRecorderData()
		{
		}
	}
}
