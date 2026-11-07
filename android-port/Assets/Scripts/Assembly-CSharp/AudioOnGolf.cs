using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B5")]
public class AudioOnGolf : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003B6")]
	public class ClipsFromBoost
	{
		[Token(Token = "0x400147D")]
		[FieldOffset(Offset = "0x10")]
		public List<AudioClip> clips;

		[Token(Token = "0x400147E")]
		[FieldOffset(Offset = "0x18")]
		public float minBoost;

		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0x1C")]
		public float maxBoost;

		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0x20")]
		public float minVolume;

		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0x24")]
		public float maxVolume;

		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x28")]
		public float volumeVariation;

		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x2C")]
		public float minPitch;

		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x30")]
		public float maxPitch;

		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x34")]
		public float pitchVariation;

		[Token(Token = "0x600119B")]
		[Address(RVA = "0x17700B8", Offset = "0x17700B8", VA = "0x17700B8")]
		public ClipsFromBoost()
		{
		}
	}

	[Token(Token = "0x20003B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F7A4", Offset = "0x3F7A4")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x10")]
		public ClipsFromBoost setting;

		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0x18")]
		public float vol_output;

		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x1C")]
		public float pct;

		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x20")]
		public AudioOnGolf _003C_003E4__this;

		[Token(Token = "0x600119C")]
		[Address(RVA = "0x176FE14", Offset = "0x176FE14", VA = "0x176FE14")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600119D")]
		[Address(RVA = "0x176FE1C", Offset = "0x176FE1C", VA = "0x176FE1C")]
		internal void _003CShoot_003Eb__0(AudioSource s)
		{
		}

		[Token(Token = "0x600119E")]
		[Address(RVA = "0x176FEB0", Offset = "0x176FEB0", VA = "0x176FEB0")]
		internal void _003CShoot_003Eb__1(AudioSource s)
		{
		}
	}

	[Token(Token = "0x20003B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F7B4", Offset = "0x3F7B4")]
	private sealed class _003CPlayAfterDelay_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400148C")]
		[FieldOffset(Offset = "0x20")]
		public AudioOnGolf _003C_003E4__this;

		[Token(Token = "0x17000210")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60011A2")]
			[Address(RVA = "0x1770068", Offset = "0x1770068", VA = "0x1770068", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000211")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x17700B0", Offset = "0x17700B0", VA = "0x17700B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600119F")]
		[Address(RVA = "0x176FF78", Offset = "0x176FF78", VA = "0x176FF78")]
		[DebuggerHidden]
		public _003CPlayAfterDelay_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x176FFA4", Offset = "0x176FFA4", VA = "0x176FFA4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x176FFA8", Offset = "0x176FFA8", VA = "0x176FFA8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x1770068", Offset = "0x1770068", VA = "0x1770068", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x1770070", Offset = "0x1770070", VA = "0x1770070", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x17700B0", Offset = "0x17700B0", VA = "0x17700B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isSpatialAudio;

	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallController golfball;

	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 playBelowThreshold;

	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector3 playAboveThreshold;

	[Token(Token = "0x400146F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool localAxis;

	[Token(Token = "0x4001470")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool PlayShootOnAimStart;

	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<ClipsFromBoost> boostSoundSettings;

	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool resetDelayAfterFirstShot;

	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool VolumeByCooldown;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float cooldown;

	[Token(Token = "0x4001475")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float multiplyBy;

	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool VolumeByShotFrequency;

	[Token(Token = "0x4001477")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private int reduceOverShots;

	[Token(Token = "0x4001478")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float frequencyCooldown;

	[Token(Token = "0x4001479")]
	[FieldOffset(Offset = "0x68")]
	private int shots;

	[Token(Token = "0x400147A")]
	[FieldOffset(Offset = "0x6C")]
	private float shotTimer;

	[Token(Token = "0x400147B")]
	[FieldOffset(Offset = "0x70")]
	private float lastBoost;

	[Token(Token = "0x400147C")]
	[FieldOffset(Offset = "0x74")]
	private float multiply;

	[Token(Token = "0x6001194")]
	[Address(RVA = "0x150A174", Offset = "0x150A174", VA = "0x150A174")]
	private void Start()
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0x150A400", Offset = "0x150A400", VA = "0x150A400")]
	private void FPS_OnActualShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0x150A734", Offset = "0x150A734", VA = "0x150A734")]
	private void Golfball_OnPreShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001197")]
	[Address(RVA = "0x150A404", Offset = "0x150A404", VA = "0x150A404")]
	private void Shoot()
	{
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0x150A8B0", Offset = "0x150A8B0", VA = "0x150A8B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001199")]
	[Address(RVA = "0x150A83C", Offset = "0x150A83C", VA = "0x150A83C")]
	private IEnumerator PlayAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x600119A")]
	[Address(RVA = "0x150A928", Offset = "0x150A928", VA = "0x150A928")]
	public AudioOnGolf()
	{
	}
}
