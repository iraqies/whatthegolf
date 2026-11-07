using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000199")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200019A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200019B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x18")]
		public string targetTag;

		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x20")]
		public float fadeInTime;

		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x28")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x36744", Offset = "0x36744")]
		public Collider characterCollider;

		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3677C", Offset = "0x3677C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x40")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x44")]
		public float camRaycastDistance;

		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x367B4", Offset = "0x367B4")]
		private List<InteractionTrigger> triggersInRange__BackingField;

		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0xC8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700018F")]
		public bool inInteraction
		{
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x139E170", Offset = "0x139E170", VA = "0x139E170")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000190")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x13A3EA0", Offset = "0x13A3EA0", VA = "0x13A3EA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x13A3EA8", Offset = "0x13A3EA8", VA = "0x13A3EA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x13A3EB0", Offset = "0x13A3EB0", VA = "0x13A3EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A64C", Offset = "0x3A64C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x13A3EB8", Offset = "0x13A3EB8", VA = "0x13A3EB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A65C", Offset = "0x3A65C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x13A1F24", Offset = "0x13A1F24", VA = "0x13A1F24")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A48C", Offset = "0x3A48C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x13A1F6C", Offset = "0x13A1F6C", VA = "0x13A1F6C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A4C4", Offset = "0x3A4C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x13A1FB4", Offset = "0x13A1FB4", VA = "0x13A1FB4")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A4FC", Offset = "0x3A4FC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x13A1FFC", Offset = "0x13A1FFC", VA = "0x13A1FFC")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A534", Offset = "0x3A534")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x13A2044", Offset = "0x13A2044", VA = "0x13A2044")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A56C", Offset = "0x3A56C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x13A208C", Offset = "0x13A208C", VA = "0x13A208C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A5A4", Offset = "0x3A5A4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x13A20D4", Offset = "0x13A20D4", VA = "0x13A20D4")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A5DC", Offset = "0x3A5DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x13A211C", Offset = "0x13A211C", VA = "0x13A211C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A614", Offset = "0x3A614")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x13A2250", Offset = "0x13A2250", VA = "0x13A2250")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default;
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x13A2380", Offset = "0x13A2380", VA = "0x13A2380")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default;
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x13A24AC", Offset = "0x13A24AC", VA = "0x13A24AC")]
		public bool IsPaused()
		{
			return default;
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x13A25D0", Offset = "0x13A25D0", VA = "0x13A25D0")]
		public bool IsInSync()
		{
			return default;
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x139D850", Offset = "0x139D850", VA = "0x139D850")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default;
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x13A274C", Offset = "0x13A274C", VA = "0x13A274C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x13A27E0", Offset = "0x13A27E0", VA = "0x13A27E0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x13A2874", Offset = "0x13A2874", VA = "0x13A2874")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default;
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x13A2908", Offset = "0x13A2908", VA = "0x13A2908")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x139E298", Offset = "0x139E298", VA = "0x139E298")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x13A297C", Offset = "0x13A297C", VA = "0x13A297C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x13A29E4", Offset = "0x13A29E4", VA = "0x13A29E4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x13A2A74", Offset = "0x13A2A74", VA = "0x13A2A74")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x13A2B88", Offset = "0x13A2B88", VA = "0x13A2B88")]
		public float GetMinActiveProgress()
		{
			return default;
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x13A2D20", Offset = "0x13A2D20", VA = "0x13A2D20")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default;
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x13A2FE4", Offset = "0x13A2FE4", VA = "0x13A2FE4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default;
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x13A3194", Offset = "0x13A3194", VA = "0x13A3194")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default;
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x13A3420", Offset = "0x13A3420", VA = "0x13A3420")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x13A3708", Offset = "0x13A3708", VA = "0x13A3708")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x13A374C", Offset = "0x13A374C", VA = "0x13A374C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x13A37C4", Offset = "0x13A37C4", VA = "0x13A37C4")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x13A38F0", Offset = "0x13A38F0", VA = "0x13A38F0")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x13A3AAC", Offset = "0x13A3AAC", VA = "0x13A3AAC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default;
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x13A3D58", Offset = "0x13A3D58", VA = "0x13A3D58")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x13A3538", Offset = "0x13A3538", VA = "0x13A3538")]
		public int GetClosestTriggerIndex()
		{
			return default;
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x13A3EC0", Offset = "0x13A3EC0", VA = "0x13A3EC0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x13A46B4", Offset = "0x13A46B4", VA = "0x13A46B4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x13A46D4", Offset = "0x13A46D4", VA = "0x13A46D4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x13A46F0", Offset = "0x13A46F0", VA = "0x13A46F0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x13A470C", Offset = "0x13A470C", VA = "0x13A470C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x13A47D8", Offset = "0x13A47D8", VA = "0x13A47D8")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x13A4918", Offset = "0x13A4918", VA = "0x13A4918")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x13A4A2C", Offset = "0x13A4A2C", VA = "0x13A4A2C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default;
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x13A4BFC", Offset = "0x13A4BFC", VA = "0x13A4BFC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x13A4D0C", Offset = "0x13A4D0C", VA = "0x13A4D0C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x13A4FD4", Offset = "0x13A4FD4", VA = "0x13A4FD4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x13A43E4", Offset = "0x13A43E4", VA = "0x13A43E4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x13A5114", Offset = "0x13A5114", VA = "0x13A5114")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x13A5244", Offset = "0x13A5244", VA = "0x13A5244")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x13A52EC", Offset = "0x13A52EC", VA = "0x13A52EC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x13A53D4", Offset = "0x13A53D4", VA = "0x13A53D4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x13A53EC", Offset = "0x13A53EC", VA = "0x13A53EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x13A2164", Offset = "0x13A2164", VA = "0x13A2164")]
		private bool IsValid(bool log)
		{
			return default;
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x13A2EBC", Offset = "0x13A2EBC", VA = "0x13A2EBC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x13A57AC", Offset = "0x13A57AC", VA = "0x13A57AC")]
		public InteractionSystem()
		{
		}
	}
}
