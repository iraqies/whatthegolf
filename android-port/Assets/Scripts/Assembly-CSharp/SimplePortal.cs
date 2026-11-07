using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class SimplePortal : MonoBehaviour
{
	[Serializable]
	public class UnityGameobjectEvent : UnityEvent<GameObject>
	{
	}

	public static Action FinishedTeleporting;

	[CompilerGenerated]
	private Action<SimplePortal, GameObject, SimplePortal> m_OnPortaling;

	public SimplePortal LinkedPortal;

	public Transmogrif sendThroughTransmogrif;

	public List<string> AllowedTags;

	public Color InactiveColor;

	public bool SetRotationOnTransfer;

	public bool hideUntilUsedFromOtherSide;

	public bool saveUnhideState;

	public AudioEventAsset portalSFX;

	[SerializeField]
	private AudioClip sfxPortal;

	public float BlockTimer;

	public float SpawnOffset;

	public Vector3 WorldPositionSpawnOffset;

	public Vector3 ForceDirectionOverride;

	public bool CheckForRigidParent;

	public UnityEvent OtherEvents;

	public UnityGameobjectEvent OtherEventsWithInfo;

	public bool IgnoreKinematicObjects;

	public float MinVelocityOnExit;

	public bool useTransitionCamera;

	public bool portAll;

	public bool portOnce;

	public Color baseColor;

	[CompilerGenerated]
	private Action m_OnPortalEnabledIfDidntStartEnabled;

	private SpriteRenderer render;

	private float colorValue;

	private float blockTimer;

	private Color targetColor;

	private ParticleSystem particles;

	private GridFiller filler;

	private readonly string saveFormat;

	public float transitionCamTime;

	private OverworldID overworldID;

	public bool NotSaved;

	public event Action<SimplePortal, GameObject, SimplePortal> OnPortaling
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnPortalEnabledIfDidntStartEnabled
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void OpenPortalFromOtherSide()
	{
	}

	public void Init(GridFiller gridFiller)
	{
	}

	private void Update()
	{
	}

	private bool IsActive()
	{
		return false;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerStay2D(Collider2D other)
	{
	}

	protected virtual void ObjectEnteredTrigger(GameObject other)
	{
	}

	private IEnumerator OpenHiddenPortal(GameObject other)
	{
		return null;
	}

	public void SaveOpenState()
	{
	}

	protected virtual void RecieveObject(GameObject go)
	{
	}

	private void ThrowOutOfPortal(GameObject go)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
