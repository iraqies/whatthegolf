using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000214")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000215")]
		public class EffectorLink
		{
			[Token(Token = "0x4000DE0")]
			[FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000DE1")]
			[FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000DE2")]
			[FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000DE3")]
			[FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000DE4")]
			[FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000DE5")]
			[FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000DE6")]
			[FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000DE7")]
			[FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x4000DE8")]
			[FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x4000DE9")]
			[FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000DEA")]
			[FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000DEB")]
			[FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000DEC")]
			[FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000DED")]
			[FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000DEE")]
			[FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000DEF")]
			[FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000DF0")]
			[FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000DF1")]
			[FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000DF2")]
			[FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000DF3")]
			[FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x1357050", Offset = "0x1357050", VA = "0x1357050")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x1357318", Offset = "0x1357318", VA = "0x1357318")]
			private bool FindWalls(Vector3 direction)
			{
				return default;
			}

			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x13573F8", Offset = "0x13573F8", VA = "0x13573F8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000E5F")]
			[Address(RVA = "0x1357890", Offset = "0x1357890", VA = "0x1357890")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x1357980", Offset = "0x1357980", VA = "0x1357980")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x1357A1C", Offset = "0x1357A1C", VA = "0x1357A1C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x1357AB4", Offset = "0x1357AB4", VA = "0x1357AB4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x1357B4C", Offset = "0x1357B4C", VA = "0x1357B4C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x1357CF0", Offset = "0x1357CF0", VA = "0x1357CF0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x1322E98", Offset = "0x1322E98", VA = "0x1322E98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x1322F14", Offset = "0x1322F14", VA = "0x1322F14")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x1322F84", Offset = "0x1322F84", VA = "0x1322F84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x132305C", Offset = "0x132305C", VA = "0x132305C")]
		public TouchWalls()
		{
		}
	}
}
