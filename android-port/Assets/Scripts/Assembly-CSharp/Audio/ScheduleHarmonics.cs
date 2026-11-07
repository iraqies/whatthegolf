using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013C0")]
	public class ScheduleHarmonics : MonoBehaviour
	{
		[Token(Token = "0x20013C1")]
		public enum PlayMode
		{
			[Token(Token = "0x4006A4D")]
			Ascending = 0,
			[Token(Token = "0x4006A4E")]
			Descending = 1,
			[Token(Token = "0x4006A4F")]
			PingPong = 2
		}

		[Token(Token = "0x20013C2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x48FDC", Offset = "0x48FDC")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x4006A50")]
			[FieldOffset(Offset = "0x10")]
			public float pitch;

			[Token(Token = "0x6005C3B")]
			[Address(RVA = "0x183E99C", Offset = "0x183E99C", VA = "0x183E99C")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6005C3C")]
			[Address(RVA = "0x183E9A4", Offset = "0x183E9A4", VA = "0x183E9A4")]
			internal void _003CFixedUpdate_003Eb__0(AudioSource s)
			{
			}
		}

		[Token(Token = "0x4006A3B")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x4006A3C")]
		[FieldOffset(Offset = "0x20")]
		public float baseTimeInterval;

		[Token(Token = "0x4006A3D")]
		[FieldOffset(Offset = "0x24")]
		public int baseNote;

		[Token(Token = "0x4006A3E")]
		[FieldOffset(Offset = "0x28")]
		public bool ascendingOnEachPlay;

		[Token(Token = "0x4006A3F")]
		[FieldOffset(Offset = "0x2C")]
		public int minStartNote;

		[Token(Token = "0x4006A40")]
		[FieldOffset(Offset = "0x30")]
		public int maxStartNote;

		[Token(Token = "0x4006A41")]
		[FieldOffset(Offset = "0x34")]
		public int StopOnIncrement;

		[Token(Token = "0x4006A42")]
		[FieldOffset(Offset = "0x38")]
		public MusicMathUtils.Scale scale;

		[Token(Token = "0x4006A43")]
		[FieldOffset(Offset = "0x3C")]
		public PlayMode playMode;

		[Token(Token = "0x4006A44")]
		[FieldOffset(Offset = "0x40")]
		private float nextEventTime;

		[Token(Token = "0x4006A45")]
		[FieldOffset(Offset = "0x48")]
		private ScheduleAudio scheduler;

		[Token(Token = "0x4006A46")]
		[FieldOffset(Offset = "0x50")]
		private bool init;

		[Token(Token = "0x4006A47")]
		[FieldOffset(Offset = "0x51")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AA8C", Offset = "0x5AA8C")]
		private bool isPlaying__BackingField;

		[Token(Token = "0x4006A48")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AA9C", Offset = "0x5AA9C")]
		private float speedMultiplier__BackingField;

		[Token(Token = "0x4006A49")]
		[FieldOffset(Offset = "0x58")]
		private int m_BaseNote;

		[Token(Token = "0x4006A4A")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AAAC", Offset = "0x5AAAC")]
		private int m_NoteIncrement__BackingField;

		[Token(Token = "0x4006A4B")]
		[FieldOffset(Offset = "0x60")]
		private int m_IncrementPerPlay;

		[Token(Token = "0x17000A6A")]
		public bool isPlaying
		{
			[Token(Token = "0x6005C2D")]
			[Address(RVA = "0x167B7C0", Offset = "0x167B7C0", VA = "0x167B7C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x727C0", Offset = "0x727C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005C2E")]
			[Address(RVA = "0x167B7C8", Offset = "0x167B7C8", VA = "0x167B7C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x727D0", Offset = "0x727D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A6B")]
		public float speedMultiplier
		{
			[Token(Token = "0x6005C2F")]
			[Address(RVA = "0x167B7D0", Offset = "0x167B7D0", VA = "0x167B7D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x727E0", Offset = "0x727E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005C30")]
			[Address(RVA = "0x167B7D8", Offset = "0x167B7D8", VA = "0x167B7D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x727F0", Offset = "0x727F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A6C")]
		public int m_NoteIncrement
		{
			[Token(Token = "0x6005C31")]
			[Address(RVA = "0x167B7E0", Offset = "0x167B7E0", VA = "0x167B7E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72800", Offset = "0x72800")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005C32")]
			[Address(RVA = "0x167B7E8", Offset = "0x167B7E8", VA = "0x167B7E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72810", Offset = "0x72810")]
			private set
			{
			}
		}

		[Token(Token = "0x6005C33")]
		[Address(RVA = "0x167B7F0", Offset = "0x167B7F0", VA = "0x167B7F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x167B874", Offset = "0x167B874", VA = "0x167B874")]
		public void StartScheduleLoop()
		{
		}

		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x167B8D8", Offset = "0x167B8D8", VA = "0x167B8D8")]
		public void StopScheduleLoop()
		{
		}

		[Token(Token = "0x6005C36")]
		[Address(RVA = "0x167B8E0", Offset = "0x167B8E0", VA = "0x167B8E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005C37")]
		[Address(RVA = "0x167BAE0", Offset = "0x167BAE0", VA = "0x167BAE0")]
		private int NoteByPlaymode()
		{
			return default;
		}

		[Token(Token = "0x6005C38")]
		[Address(RVA = "0x167BB20", Offset = "0x167BB20", VA = "0x167BB20")]
		private int ReturnNote(int index)
		{
			return default;
		}

		[Token(Token = "0x6005C39")]
		[Address(RVA = "0x167BC14", Offset = "0x167BC14", VA = "0x167BC14")]
		public void SetVolume(float v)
		{
		}

		[Token(Token = "0x6005C3A")]
		[Address(RVA = "0x167BC94", Offset = "0x167BC94", VA = "0x167BC94")]
		public ScheduleHarmonics()
		{
		}
	}
}
