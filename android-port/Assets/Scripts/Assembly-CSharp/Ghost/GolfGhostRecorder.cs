using Il2CppDummyDll;
using UnityEngine;

namespace Ghost
{
	[Token(Token = "0x20010F5")]
	public class GolfGhostRecorder : MonoBehaviour
	{
		[Token(Token = "0x400594F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x563C0", Offset = "0x563C0")]
		private GolfGhostData Ghost__BackingField;

		[Token(Token = "0x4005950")]
		[FieldOffset(Offset = "0x20")]
		private Transform ball;

		[Token(Token = "0x4005951")]
		[FieldOffset(Offset = "0x28")]
		private bool isRecording;

		[Token(Token = "0x4005952")]
		[FieldOffset(Offset = "0x2C")]
		private float startTime;

		[Token(Token = "0x4005953")]
		[FieldOffset(Offset = "0x30")]
		private float nextSaveTime;

		[Token(Token = "0x4005954")]
		[FieldOffset(Offset = "0x34")]
		public float UpdateRate;

		[Token(Token = "0x4005955")]
		[FieldOffset(Offset = "0x38")]
		public int currentStroke;

		[Token(Token = "0x17000808")]
		public GolfGhostData Ghost
		{
			[Token(Token = "0x6004BDD")]
			[Address(RVA = "0x149FDD8", Offset = "0x149FDD8", VA = "0x149FDD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB4", Offset = "0x6FAB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BDE")]
			[Address(RVA = "0x149FDE0", Offset = "0x149FDE0", VA = "0x149FDE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC4", Offset = "0x6FAC4")]
			private set
			{
			}
		}

		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x149FDE8", Offset = "0x149FDE8", VA = "0x149FDE8")]
		public void StartNewRecording()
		{
		}

		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x149FEB4", Offset = "0x149FEB4", VA = "0x149FEB4")]
		public void RecordStroke(Transform ball)
		{
		}

		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x14A0290", Offset = "0x14A0290", VA = "0x14A0290")]
		public void PauseRecording()
		{
		}

		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x149FF9C", Offset = "0x149FF9C", VA = "0x149FF9C")]
		private static string GetPrefabID(Transform ball)
		{
			return null;
		}

		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x14A0298", Offset = "0x14A0298", VA = "0x14A0298")]
		public void EndRecording()
		{
		}

		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x14A00FC", Offset = "0x14A00FC", VA = "0x14A00FC")]
		private void SavePoint()
		{
		}

		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x14A02A0", Offset = "0x14A02A0", VA = "0x14A02A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x14A0414", Offset = "0x14A0414", VA = "0x14A0414")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x14A05B8", Offset = "0x14A05B8", VA = "0x14A05B8")]
		public GolfGhostRecorder()
		{
		}
	}
}
