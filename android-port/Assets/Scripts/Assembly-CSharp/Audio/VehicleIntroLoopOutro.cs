using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013E3")]
	public class VehicleIntroLoopOutro : MonoBehaviour
	{
		[Token(Token = "0x4006AE3")]
		[FieldOffset(Offset = "0x18")]
		public List<WheelJoint2D> joints;

		[Token(Token = "0x4006AE4")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController ballController;

		[Token(Token = "0x4006AE5")]
		[FieldOffset(Offset = "0x28")]
		public bool useEngine;

		[Token(Token = "0x4006AE6")]
		[FieldOffset(Offset = "0x30")]
		public IntroLoopOutro introLoopOutro;

		[Token(Token = "0x4006AE7")]
		[FieldOffset(Offset = "0x38")]
		public float minWheelSpeed;

		[Token(Token = "0x4006AE8")]
		[FieldOffset(Offset = "0x3C")]
		public float maxWheelSpeed;

		[Token(Token = "0x4006AE9")]
		[FieldOffset(Offset = "0x40")]
		public float wheelMaxDelta;

		[Token(Token = "0x4006AEA")]
		[FieldOffset(Offset = "0x44")]
		public float minVolume;

		[Token(Token = "0x4006AEB")]
		[FieldOffset(Offset = "0x48")]
		public float maxVolume;

		[Token(Token = "0x4006AEC")]
		[FieldOffset(Offset = "0x4C")]
		public float minPitch;

		[Token(Token = "0x4006AED")]
		[FieldOffset(Offset = "0x50")]
		public float maxPitch;

		[Token(Token = "0x4006AEE")]
		[FieldOffset(Offset = "0x54")]
		public bool useSuspension;

		[Token(Token = "0x4006AEF")]
		[FieldOffset(Offset = "0x58")]
		public RandomAudioClips clips;

		[Token(Token = "0x4006AF0")]
		[FieldOffset(Offset = "0x60")]
		public float minTranslation;

		[Token(Token = "0x4006AF1")]
		[FieldOffset(Offset = "0x64")]
		public float maxTranslation;

		[Token(Token = "0x4006AF2")]
		[FieldOffset(Offset = "0x68")]
		public float cooldown;

		[Token(Token = "0x4006AF3")]
		[FieldOffset(Offset = "0x6C")]
		public float maxRecordedSpeed;

		[Token(Token = "0x4006AF4")]
		[FieldOffset(Offset = "0x70")]
		public float lastRecordedTranslation;

		[Token(Token = "0x4006AF5")]
		[FieldOffset(Offset = "0x74")]
		public float maxRecordedTranslation;

		[Token(Token = "0x4006AF6")]
		[FieldOffset(Offset = "0x78")]
		private float wheelSpeed;

		[Token(Token = "0x4006AF7")]
		[FieldOffset(Offset = "0x7C")]
		private float lastWheelSpeed;

		[Token(Token = "0x4006AF8")]
		[FieldOffset(Offset = "0x80")]
		private float nextEventTime;

		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0x17496F8", Offset = "0x17496F8", VA = "0x17496F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x1749774", Offset = "0x1749774", VA = "0x1749774")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x17497B4", Offset = "0x17497B4", VA = "0x17497B4")]
		private void HandleWheelspeed()
		{
		}

		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0x17499B0", Offset = "0x17499B0", VA = "0x17499B0")]
		private void HandleSuspension()
		{
		}

		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0x1749BF0", Offset = "0x1749BF0", VA = "0x1749BF0")]
		public VehicleIntroLoopOutro()
		{
		}
	}
}
