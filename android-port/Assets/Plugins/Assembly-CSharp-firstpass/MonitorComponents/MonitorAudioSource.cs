using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x2000268")]
	[ExecuteInEditMode]
	public class MonitorAudioSource : MonoBehaviour
	{
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x18")]
		public bool showVolume;

		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x20")]
		public Monitor monitor_volume;

		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x28")]
		private MonitorInput monitorInput_volume;

		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x30")]
		public bool showPitch;

		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x34")]
		public ValueAxisMode pitchMode;

		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x38")]
		public float pitchMin;

		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x3C")]
		public float pitchMax;

		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x40")]
		public Monitor monitor_pitch;

		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x48")]
		private MonitorInput monitorInput_pitch;

		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x50")]
		public bool showIsPlaying;

		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x58")]
		public Monitor monitor_isPlaying;

		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x60")]
		private MonitorInput monitorInput_isPlaying;

		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x68")]
		private AudioSource audioSource;

		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x13AEA80", Offset = "0x13AEA80", VA = "0x13AEA80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x13AEB08", Offset = "0x13AEB08", VA = "0x13AEB08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x13AEC20", Offset = "0x13AEC20", VA = "0x13AEC20")]
		public void UpdateMonitors()
		{
		}

		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x13AEC90", Offset = "0x13AEC90", VA = "0x13AEC90")]
		private void UpdateVolumeMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x13AEEA8", Offset = "0x13AEEA8", VA = "0x13AEEA8")]
		private void UpdatePitchMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x13AF0B4", Offset = "0x13AF0B4", VA = "0x13AF0B4")]
		private void UpdateIsPlayingMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x13AF4DC", Offset = "0x13AF4DC", VA = "0x13AF4DC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x13AF6AC", Offset = "0x13AF6AC", VA = "0x13AF6AC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x13AF6B0", Offset = "0x13AF6B0", VA = "0x13AF6B0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x13AF6B4", Offset = "0x13AF6B4", VA = "0x13AF6B4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x13AF6B8", Offset = "0x13AF6B8", VA = "0x13AF6B8")]
		public void RemoveMonitors()
		{
		}

		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x13AF7CC", Offset = "0x13AF7CC", VA = "0x13AF7CC")]
		public MonitorAudioSource()
		{
		}
	}
}
