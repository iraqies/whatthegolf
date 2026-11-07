using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013E4")]
	public class WheelJointAudio : MonoBehaviour
	{
		[Token(Token = "0x4006AF9")]
		[FieldOffset(Offset = "0x18")]
		public List<WheelJoint2D> joints;

		[Token(Token = "0x4006AFA")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource engineAudioSource;

		[Token(Token = "0x4006AFB")]
		[FieldOffset(Offset = "0x28")]
		public float maxWheelSpeed;

		[Token(Token = "0x4006AFC")]
		[FieldOffset(Offset = "0x2C")]
		public float wheelMaxDelta;

		[Token(Token = "0x4006AFD")]
		[FieldOffset(Offset = "0x30")]
		public float minVolume;

		[Token(Token = "0x4006AFE")]
		[FieldOffset(Offset = "0x34")]
		public float maxVolume;

		[Token(Token = "0x4006AFF")]
		[FieldOffset(Offset = "0x38")]
		public float minPitch;

		[Token(Token = "0x4006B00")]
		[FieldOffset(Offset = "0x3C")]
		public float maxPitch;

		[Token(Token = "0x4006B01")]
		[FieldOffset(Offset = "0x40")]
		public RandomAudioClips clips;

		[Token(Token = "0x4006B02")]
		[FieldOffset(Offset = "0x48")]
		public float minTranslation;

		[Token(Token = "0x4006B03")]
		[FieldOffset(Offset = "0x4C")]
		public float maxTranslation;

		[Token(Token = "0x4006B04")]
		[FieldOffset(Offset = "0x50")]
		public float cooldown;

		[Token(Token = "0x4006B05")]
		[FieldOffset(Offset = "0x54")]
		public float maxRecordedSpeed;

		[Token(Token = "0x4006B06")]
		[FieldOffset(Offset = "0x58")]
		public float lastRecordedTranslation;

		[Token(Token = "0x4006B07")]
		[FieldOffset(Offset = "0x5C")]
		public float maxRecordedTranslation;

		[Token(Token = "0x4006B08")]
		[FieldOffset(Offset = "0x60")]
		private float wheelSpeed;

		[Token(Token = "0x4006B09")]
		[FieldOffset(Offset = "0x64")]
		private float nextEventTime;

		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0x1753BC0", Offset = "0x1753BC0", VA = "0x1753BC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0x1753C78", Offset = "0x1753C78", VA = "0x1753C78")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0x1753C9C", Offset = "0x1753C9C", VA = "0x1753C9C")]
		private void HandleWheelspeed()
		{
		}

		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0x1753E30", Offset = "0x1753E30", VA = "0x1753E30")]
		private void HandleSuspension()
		{
		}

		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0x1754070", Offset = "0x1754070", VA = "0x1754070")]
		public WheelJointAudio()
		{
		}
	}
}
