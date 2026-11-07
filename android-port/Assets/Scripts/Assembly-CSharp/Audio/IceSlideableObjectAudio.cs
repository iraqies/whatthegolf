using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013E6")]
	public class IceSlideableObjectAudio : MonoBehaviour
	{
		[Token(Token = "0x4006B19")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioMaterial m_AudioMaterial;

		[Token(Token = "0x4006B1A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4006B1B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource m_AudioSource;

		[Token(Token = "0x4006B1C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MinMax m_VelocityRange;

		[Token(Token = "0x4006B1D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MinMax m_VolumeRange;

		[Token(Token = "0x4006B1E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MinMax m_PitchRange;

		[Token(Token = "0x4006B1F")]
		[FieldOffset(Offset = "0x48")]
		private RigidbodyCollisionInfo rigidInfo;

		[Token(Token = "0x4006B20")]
		[FieldOffset(Offset = "0x50")]
		private List<GameObject> currentSurfaces;

		[Token(Token = "0x4006B21")]
		[FieldOffset(Offset = "0x58")]
		private List<AudioMaterial> mustIncludeMaterial;

		[Token(Token = "0x4006B22")]
		[FieldOffset(Offset = "0x60")]
		private float onSurfaceGain;

		[Token(Token = "0x4006B23")]
		[FieldOffset(Offset = "0x64")]
		private float velocityGain;

		[Token(Token = "0x4006B24")]
		[FieldOffset(Offset = "0x68")]
		private float targetVolume;

		[Token(Token = "0x4006B25")]
		[FieldOffset(Offset = "0x6C")]
		private float targetPitch;

		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0x14E51E8", Offset = "0x14E51E8", VA = "0x14E51E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0x14E5400", Offset = "0x14E5400", VA = "0x14E5400")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0x14E55E0", Offset = "0x14E55E0", VA = "0x14E55E0")]
		private void OnRigidCollisionEnter(Collision obj)
		{
		}

		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0x14E56FC", Offset = "0x14E56FC", VA = "0x14E56FC")]
		private void OnRigidCollisionExit(Collision obj)
		{
		}

		[Token(Token = "0x6005CD2")]
		[Address(RVA = "0x14E57D4", Offset = "0x14E57D4", VA = "0x14E57D4")]
		public IceSlideableObjectAudio()
		{
		}
	}
}
