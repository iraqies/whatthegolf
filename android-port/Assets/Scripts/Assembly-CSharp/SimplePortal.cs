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
	private Action<SimplePortal, GameObject, SimplePortal> m_OnPortaling;

	public SimplePortal LinkedPortal;
	public Transmogrif sendThroughTransmogrif;
	public List<string> AllowedTags = new List<string>();
	public Color InactiveColor = Color.gray;
	public bool SetRotationOnTransfer;
	public bool hideUntilUsedFromOtherSide;
	public bool saveUnhideState;
	public AudioEventAsset portalSFX;
	[SerializeField] private AudioClip sfxPortal;
	public float BlockTimer = 0.5f;
	public float SpawnOffset = 1f;
	public Vector3 WorldPositionSpawnOffset;
	public Vector3 ForceDirectionOverride;
	public bool CheckForRigidParent = true;
	public UnityEvent OtherEvents = new UnityEvent();
	public UnityGameobjectEvent OtherEventsWithInfo = new UnityGameobjectEvent();
	public bool IgnoreKinematicObjects;
	public float MinVelocityOnExit = 5f;
	public bool useTransitionCamera;
	public bool portAll = true;
	public bool portOnce;
	public Color baseColor = Color.white;

	private Action m_OnPortalEnabledIfDidntStartEnabled;
	private SpriteRenderer render;
	private float colorValue;
	private float blockTimer;
	private Color targetColor;
	private ParticleSystem particles;
	private GridFiller filler;
	private readonly string saveFormat;
	public float transitionCamTime = 0.5f;
	private OverworldID overworldID;
	public bool NotSaved;

	public event Action<SimplePortal, GameObject, SimplePortal> OnPortaling
	{
		add => m_OnPortaling = (Action<SimplePortal, GameObject, SimplePortal>)Delegate.Combine(m_OnPortaling, value);
		remove => m_OnPortaling = (Action<SimplePortal, GameObject, SimplePortal>)Delegate.Remove(m_OnPortaling, value);
	}

	public event Action OnPortalEnabledIfDidntStartEnabled
	{
		add => m_OnPortalEnabledIfDidntStartEnabled = (Action)Delegate.Combine(m_OnPortalEnabledIfDidntStartEnabled, value);
		remove => m_OnPortalEnabledIfDidntStartEnabled = (Action)Delegate.Remove(m_OnPortalEnabledIfDidntStartEnabled, value);
	}

	private void Awake()
	{
		render = GetComponent<SpriteRenderer>();
		particles = GetComponentInChildren<ParticleSystem>();
	}

	public void OpenPortalFromOtherSide()
	{
		hideUntilUsedFromOtherSide = false;
		gameObject.SetActive(true);
		m_OnPortalEnabledIfDidntStartEnabled?.Invoke();
	}

	public void Init(GridFiller gridFiller) => filler = gridFiller;

	private void Update()
	{
		if (blockTimer > 0f) blockTimer -= Time.deltaTime;
	}

	private bool IsActive() => blockTimer <= 0f && !hideUntilUsedFromOtherSide;

	private void OnTriggerEnter(Collider other)
	{
		if (other != null) ObjectEnteredTrigger(other.gameObject);
	}

	private void OnTriggerStay(Collider other) { }

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null) ObjectEnteredTrigger(other.gameObject);
	}

	private void OnTriggerStay2D(Collider2D other) { }

	protected virtual void ObjectEnteredTrigger(GameObject other)
	{
		if (!IsActive() || other == null || LinkedPortal == null) return;
		GameObject target = other;
		if (CheckForRigidParent)
		{
			var rb2d = other.GetComponentInParent<Rigidbody2D>();
			if (rb2d != null) target = rb2d.gameObject;
			else
			{
				var rb = other.GetComponentInParent<Rigidbody>();
				if (rb != null) target = rb.gameObject;
			}
		}
		blockTimer = Mathf.Max(0.4f, BlockTimer);
		LinkedPortal.OpenPortalFromOtherSide();
		LinkedPortal.RecieveObject(target);
		m_OnPortaling?.Invoke(this, target, LinkedPortal);
		OtherEvents?.Invoke();
		OtherEventsWithInfo?.Invoke(target);
		FinishedTeleporting?.Invoke();
	}

	private IEnumerator OpenHiddenPortal(GameObject other) { yield break; }
	public void SaveOpenState() { }

	protected virtual void RecieveObject(GameObject go)
	{
		if (go == null) return;
		blockTimer = Mathf.Max(0.4f, BlockTimer);
		go.transform.position = transform.position + WorldPositionSpawnOffset + transform.up * SpawnOffset;
		ThrowOutOfPortal(go);
	}

	private void ThrowOutOfPortal(GameObject go)
	{
		if (go == null) return;
		Vector3 dir = ForceDirectionOverride.sqrMagnitude > 0.01f ? ForceDirectionOverride.normalized : transform.up;
		var rb2d = go.GetComponent<Rigidbody2D>();
		if (rb2d != null)
			rb2d.velocity = dir * Mathf.Max(MinVelocityOnExit, rb2d.velocity.magnitude);
		var rb = go.GetComponent<Rigidbody>();
		if (rb != null && !rb.isKinematic)
			rb.velocity = dir * Mathf.Max(MinVelocityOnExit, rb.velocity.magnitude);
	}

	private void OnDrawGizmosSelected() { }
}
