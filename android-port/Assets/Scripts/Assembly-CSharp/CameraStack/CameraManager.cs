using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001116")]
	public class CameraManager : MonoBehaviour
	{
		[Token(Token = "0x2001117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47C14", Offset = "0x47C14")]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			[Token(Token = "0x4005A7C")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x6004CF0")]
			[Address(RVA = "0x17809EC", Offset = "0x17809EC", VA = "0x17809EC")]
			public _003C_003Ec__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6004CF1")]
			[Address(RVA = "0x17809F4", Offset = "0x17809F4", VA = "0x17809F4")]
			internal bool _003COnChallengeSelected_003Eb__0(Challenge c)
			{
				return default;
			}
		}

		[Token(Token = "0x4005A6C")]
		[FieldOffset(Offset = "0x0")]
		private static CameraManager _instance;

		[Token(Token = "0x4005A6D")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56BD0", Offset = "0x56BD0")]
		private Action<CameraBehavior> m_OnActiveBehaviourChanged;

		[Token(Token = "0x4005A6E")]
		[FieldOffset(Offset = "0x20")]
		private Camera[] _cameras;

		[Token(Token = "0x4005A6F")]
		[FieldOffset(Offset = "0x28")]
		public bool useGyroSense;

		[Token(Token = "0x4005A70")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public CameraBehavior OnPlayCameraBehavior;

		[Token(Token = "0x4005A71")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public CameraBehavior DesktopCameraOverrideBehaviour;

		[Token(Token = "0x4005A72")]
		[FieldOffset(Offset = "0x40")]
		public bool challengeSetup;

		[Token(Token = "0x4005A73")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public CameraBehavior OnChallengeCameraBehavior;

		[Token(Token = "0x4005A74")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public CameraBehavior DesktopChallengeCameraOverrideBehaviour;

		[Token(Token = "0x4005A75")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56C20", Offset = "0x56C20")]
		private CameraBehavior ActiveBehavior__BackingField;

		[Token(Token = "0x4005A76")]
		[FieldOffset(Offset = "0x60")]
		private bool _started;

		[Token(Token = "0x4005A77")]
		[FieldOffset(Offset = "0x61")]
		private bool? _is2D;

		[Token(Token = "0x4005A78")]
		[FieldOffset(Offset = "0x68")]
		private PerlinShake shake;

		[Token(Token = "0x4005A79")]
		[FieldOffset(Offset = "0x70")]
		private GyroShake gyro;

		[Token(Token = "0x4005A7A")]
		[FieldOffset(Offset = "0x78")]
		private bool activeBehaviourAttachedToThis;

		[Token(Token = "0x4005A7B")]
		[FieldOffset(Offset = "0x7C")]
		public float gyroSenseMagnitude;

		[Token(Token = "0x17000821")]
		public static CameraManager Instance
		{
			[Token(Token = "0x6004CD6")]
			[Address(RVA = "0x17D655C", Offset = "0x17D655C", VA = "0x17D655C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000822")]
		public Camera[] Cameras
		{
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x17E4A74", Offset = "0x17E4A74", VA = "0x17E4A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000823")]
		public Camera MainCamera
		{
			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x17DF958", Offset = "0x17DF958", VA = "0x17DF958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000824")]
		public CameraBehavior ActiveBehavior
		{
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x17E4ADC", Offset = "0x17E4ADC", VA = "0x17E4ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC34", Offset = "0x6FC34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x17E4AE4", Offset = "0x17E4AE4", VA = "0x17E4AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC44", Offset = "0x6FC44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000825")]
		public bool Is2D
		{
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x17E4AEC", Offset = "0x17E4AEC", VA = "0x17E4AEC")]
			set
			{
			}
		}

		[Token(Token = "0x1400007E")]
		public event Action<CameraBehavior> OnActiveBehaviourChanged
		{
			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x17E492C", Offset = "0x17E492C", VA = "0x17E492C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC14", Offset = "0x6FC14")]
			add
			{
			}
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x17E49D0", Offset = "0x17E49D0", VA = "0x17E49D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC24", Offset = "0x6FC24")]
			remove
			{
			}
		}

		[Token(Token = "0x6004CDE")]
		[Address(RVA = "0x17E4B64", Offset = "0x17E4B64", VA = "0x17E4B64")]
		public void Reset()
		{
		}

		[Token(Token = "0x6004CDF")]
		[Address(RVA = "0x17E4BB0", Offset = "0x17E4BB0", VA = "0x17E4BB0")]
		public void SetChallengeBehaviour(CameraBehavior arg1, CameraBehavior arg2)
		{
		}

		[Token(Token = "0x6004CE0")]
		[Address(RVA = "0x17E4BB8", Offset = "0x17E4BB8", VA = "0x17E4BB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004CE1")]
		[Address(RVA = "0x17E5340", Offset = "0x17E5340", VA = "0x17E5340")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0x17E5440", Offset = "0x17E5440", VA = "0x17E5440")]
		private void OnChallengeSelected(string id)
		{
		}

		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x17E51E0", Offset = "0x17E51E0", VA = "0x17E51E0")]
		public void SetCurrentBehaviour()
		{
		}

		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x17E5B74", Offset = "0x17E5B74", VA = "0x17E5B74")]
		private void Start()
		{
		}

		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x17E4B60", Offset = "0x17E4B60", VA = "0x17E4B60")]
		private void StartCheckingForAirPlay()
		{
		}

		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x17E5820", Offset = "0x17E5820", VA = "0x17E5820")]
		private void OnReset()
		{
		}

		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x17E5BFC", Offset = "0x17E5BFC", VA = "0x17E5BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x17E59A8", Offset = "0x17E59A8", VA = "0x17E59A8")]
		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
		}

		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x17E5DA4", Offset = "0x17E5DA4", VA = "0x17E5DA4")]
		private void OnGoal(Level.CompletedState s)
		{
		}

		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x17E5DC4", Offset = "0x17E5DC4", VA = "0x17E5DC4")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x17D6644", Offset = "0x17D6644", VA = "0x17D6644")]
		public void Shake(float duration, float speed, float magnitude)
		{
		}

		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x17E5E70", Offset = "0x17E5E70", VA = "0x17E5E70")]
		public void StopShake()
		{
		}

		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x17E5F34", Offset = "0x17E5F34", VA = "0x17E5F34")]
		public float GetShakeMagnitude()
		{
			return default;
		}

		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x17E5FCC", Offset = "0x17E5FCC", VA = "0x17E5FCC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x17E66F0", Offset = "0x17E66F0", VA = "0x17E66F0")]
		public CameraManager()
		{
		}
	}
}
