using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Utility
{
	[Token(Token = "0x2001025")]
	public class UfoTractorBeam : MonoBehaviour
	{
		[Token(Token = "0x2001026")]
		public enum UFOStates
		{
			[Token(Token = "0x4005533")]
			Tracking = 0,
			[Token(Token = "0x4005534")]
			Aiming = 1,
			[Token(Token = "0x4005535")]
			Beaming = 2
		}

		[Token(Token = "0x4005523")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask AffectedObjectLayers;

		[Token(Token = "0x4005524")]
		[FieldOffset(Offset = "0x1C")]
		public bool DestroyBeamedObjects;

		[Token(Token = "0x4005525")]
		[FieldOffset(Offset = "0x20")]
		public BeamPoint beamPoint;

		[Token(Token = "0x4005526")]
		[FieldOffset(Offset = "0x28")]
		public GameObject rayGfx;

		[Token(Token = "0x4005527")]
		[FieldOffset(Offset = "0x30")]
		private List<BeamableObject> _objectsInBeam;

		[Token(Token = "0x4005528")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem beamParticles;

		[Token(Token = "0x4005529")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _initParticlePosition;

		[Token(Token = "0x400552A")]
		[FieldOffset(Offset = "0x4C")]
		public UFOStates currentUFOState;

		[Token(Token = "0x400552B")]
		[FieldOffset(Offset = "0x50")]
		public Color normalColor;

		[Token(Token = "0x400552C")]
		[FieldOffset(Offset = "0x60")]
		public Color trackingColor;

		[Token(Token = "0x400552D")]
		[FieldOffset(Offset = "0x70")]
		public Color shootColor;

		[Token(Token = "0x400552E")]
		[FieldOffset(Offset = "0x80")]
		private Color _currentColor;

		[Token(Token = "0x400552F")]
		[FieldOffset(Offset = "0x90")]
		private Material _coneMaterial;

		[Token(Token = "0x4005530")]
		[FieldOffset(Offset = "0x98")]
		public Renderer coneRenderer;

		[Token(Token = "0x4005531")]
		[FieldOffset(Offset = "0xA0")]
		private float _stateTime;

		[Token(Token = "0x600482F")]
		[Address(RVA = "0x1739384", Offset = "0x1739384", VA = "0x1739384")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004830")]
		[Address(RVA = "0x173952C", Offset = "0x173952C", VA = "0x173952C")]
		private void OnEnterBeamPoint(BeamableObject obj)
		{
		}

		[Token(Token = "0x6004831")]
		[Address(RVA = "0x173962C", Offset = "0x173962C", VA = "0x173962C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6004832")]
		[Address(RVA = "0x1739800", Offset = "0x1739800", VA = "0x1739800")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6004833")]
		[Address(RVA = "0x1739634", Offset = "0x1739634", VA = "0x1739634")]
		private void CheckObject(Collider other, bool add)
		{
		}

		[Token(Token = "0x6004834")]
		[Address(RVA = "0x1739808", Offset = "0x1739808", VA = "0x1739808")]
		private void SwitchState(UFOStates newState)
		{
		}

		[Token(Token = "0x6004835")]
		[Address(RVA = "0x1739994", Offset = "0x1739994", VA = "0x1739994")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004836")]
		[Address(RVA = "0x1739E14", Offset = "0x1739E14", VA = "0x1739E14")]
		public UfoTractorBeam()
		{
		}
	}
}
