using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
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

	public List<string> AllowedTags;

	public Color InactiveColor = Color.gray;

	public bool SetRotationOnTransfer = true;

	public bool hideUntilUsedFromOtherSide;

	public bool saveUnhideState;

	public AudioEventAsset portalSFX;

	[SerializeField]
	private AudioClip sfxPortal;

	public float BlockTimer = 0.25f;

	public float SpawnOffset = 1f;

	public Vector3 WorldPositionSpawnOffset;

	public Vector3 ForceDirectionOverride;

	public bool CheckForRigidParent;

	public UnityEvent OtherEvents;

	public UnityGameobjectEvent OtherEventsWithInfo;

	public bool IgnoreKinematicObjects;

	public float MinVelocityOnExit = 2f;

	public bool useTransitionCamera = true;

	public bool portAll;

	public bool portOnce;

	public Color baseColor;

	private Action m_OnPortalEnabledIfDidntStartEnabled;

	private SpriteRenderer render;

	private float colorValue;

	private float blockTimer;

	private Color targetColor = Color.white;

	private ParticleSystem particles;

	private GridFiller filler;

	private readonly string saveFormat = "PORTAL_UNLOCK_{0}";

	public float transitionCamTime = 0.1f;

	private OverworldID overworldID;

	public bool NotSaved;

	public event Action<SimplePortal, GameObject, SimplePortal> OnPortaling
	{
		add
		{
			m_OnPortaling = (Action<SimplePortal, GameObject, SimplePortal>)Delegate.Combine(m_OnPortaling, value);
		}
		remove
		{
			m_OnPortaling = (Action<SimplePortal, GameObject, SimplePortal>)Delegate.Remove(m_OnPortaling, value);
		}
	}

	public event Action OnPortalEnabledIfDidntStartEnabled
	{
		add
		{
			m_OnPortalEnabledIfDidntStartEnabled = (Action)Delegate.Combine(m_OnPortalEnabledIfDidntStartEnabled, value);
		}
		remove
		{
			m_OnPortalEnabledIfDidntStartEnabled = (Action)Delegate.Remove(m_OnPortalEnabledIfDidntStartEnabled, value);
		}
	}

	private void Awake()
	{
		particles = GetComponentInChildren<ParticleSystem>();
		render = GetComponentInChildren<SpriteRenderer>();
		if (render != null)
		{
			baseColor = render.color;
		}
	}

	public void OpenPortalFromOtherSide()
	{
		if (hideUntilUsedFromOtherSide)
		{
			m_OnPortalEnabledIfDidntStartEnabled?.Invoke();
		}
	}

	public void Init(GridFiller gridFiller)
	{
		filler = gridFiller;
		overworldID = GetComponent<OverworldID>();
		if (!NotSaved)
		{
			if (SaveGame.TryGetValue(string.Format(saveFormat, overworldID.ID), out bool value) && value)
			{
				hideUntilUsedFromOtherSide = false;
			}
			if (hideUntilUsedFromOtherSide)
			{
				base.gameObject.SetActive(value: false);
			}
		}
	}

	private void Update()
	{
		if (IsActive())
		{
			if (particles != null && !particles.isPlaying)
			{
				particles.Play();
			}
		}
		else
		{
			targetColor = ((blockTimer > 0f) ? Color.white : InactiveColor);
			colorValue = 1f;
			if (blockTimer == 0f && particles != null && particles.isPlaying)
			{
				particles.Stop();
			}
		}
		if (render != null)
		{
			colorValue = Mathf.MoveTowards(colorValue, 0f, Time.unscaledDeltaTime * 3f);
			render.color = Color.Lerp(baseColor, targetColor, colorValue);
		}
		if (blockTimer > 0f)
		{
			blockTimer -= Time.unscaledDeltaTime;
		}
	}

	private bool IsActive()
	{
		if (LinkedPortal == null || (!LinkedPortal.gameObject.activeSelf && !LinkedPortal.hideUntilUsedFromOtherSide) || blockTimer > 0f)
		{
			return false;
		}
		return true;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (IgnoreKinematicObjects && other.attachedRigidbody != null && other.attachedRigidbody.isKinematic)
		{
			return;
		}
		Component component = other;
		if (CheckForRigidParent && other.attachedRigidbody != null)
		{
			component = other.attachedRigidbody;
		}
		ObjectEnteredTrigger(component.gameObject);
	}

	private void OnTriggerStay(Collider other)
	{
		OnTriggerEnter(other);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (IgnoreKinematicObjects && other.attachedRigidbody != null && other.attachedRigidbody.isKinematic)
		{
			return;
		}
		Component component = other;
		if (CheckForRigidParent && other.attachedRigidbody != null)
		{
			component = other.attachedRigidbody;
		}
		ObjectEnteredTrigger(component.gameObject);
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		OnTriggerEnter2D(other);
	}

	protected virtual void ObjectEnteredTrigger(GameObject other)
	{
		if (!IsActive() || !AllowedTags.Contains(other.transform.tag))
		{
			return;
		}
		if (render != null)
		{
			render.color = Color.white;
		}
		colorValue = 1f;
		if (LinkedPortal.hideUntilUsedFromOtherSide && !LinkedPortal.gameObject.activeSelf)
		{
			StartCoroutine(OpenHiddenPortal(other));
			return;
		}
		if (portOnce)
		{
			if (baseColor == Color.white)
			{
				LinkedPortal.baseColor = Color.gray;
				baseColor = Color.gray;
			}
		}
		else if (portAll)
		{
			LinkedPortal.baseColor = Color.white;
			baseColor = Color.white;
		}
		LinkedPortal.colorValue = 1f;
		m_OnPortaling?.Invoke(this, other, LinkedPortal);
		LinkedPortal.RecieveObject(other.gameObject);
		if (portalSFX != null)
		{
			portalSFX.Play(0, base.transform.position);
			if (AudioManager.Instance != null && portalSFX.AudioSource != null)
			{
				AudioManager.Instance.AudioSourceFollowTransform(portalSFX.AudioSource.Source, other.transform, 0.2f);
			}
		}
		blockTimer = BlockTimer;
		OtherEvents.Invoke();
		OtherEventsWithInfo.Invoke(other.gameObject);
		FinishedTeleporting?.Invoke();
	}

	private IEnumerator OpenHiddenPortal(GameObject other)
	{
		LinkedPortal.gameObject.SetActive(value: true);
		other.gameObject.SetActive(value: false);
		LinkedPortal.OpenPortalFromOtherSide();
		LinkedPortal.SaveOpenState();
		yield return new WaitForSeconds(0.1f);
		LinkedPortal.blockTimer = 0.1f;
		LinkedPortal.BlockTimer = 0.1f;
		other.gameObject.SetActive(value: true);
		LinkedPortal.colorValue = 1f;
		LinkedPortal.RecieveObject(other.gameObject);
		if (portalSFX != null)
		{
			portalSFX.Play(0, base.transform.position);
			if (AudioManager.Instance != null && portalSFX.AudioSource != null)
			{
				AudioManager.Instance.AudioSourceFollowTransform(portalSFX.AudioSource.Source, other.transform, 0.2f);
			}
		}
		blockTimer = BlockTimer;
	}

	public void SaveOpenState()
	{
		if (saveUnhideState)
		{
			SaveGame.SetValue(string.Format(saveFormat, overworldID.ID), value: true, save: false);
			SaveGame.Save(async: false);
		}
	}

	protected virtual void RecieveObject(GameObject go)
	{
		ThrowOutOfPortal(go);
	}

	private void ThrowOutOfPortal(GameObject go)
	{
		Vector3 offset = Vector3.zero;
		if (sendThroughTransmogrif != null)
		{
			Transmogriffable component = go.GetComponent<Transmogriffable>();
			if (component != null)
			{
				component.TransmogrifBall(component, sendThroughTransmogrif);
				go = OverworldBallManager.Instance.Ball.gameObject;
			}
		}
		go.transform.position = base.transform.position + base.transform.forward * SpawnOffset + WorldPositionSpawnOffset;
		if (LinkedPortal != null && SetRotationOnTransfer)
		{
			float angle = Vector3.SignedAngle(-go.transform.forward, LinkedPortal.transform.forward, Vector3.up);
			go.transform.rotation = base.transform.rotation * Quaternion.AngleAxis(angle, Vector3.up);
			offset = LinkedPortal.transform.InverseTransformPoint(go.transform.position);
			offset.y = 0f;
			offset.z = 0f;
		}
		Rigidbody component2 = go.GetComponent<Rigidbody>();
		if (component2 != null)
		{
			component2.velocity = base.transform.forward * Mathf.Max(MinVelocityOnExit, component2.velocity.magnitude);
		}
		else
		{
			Rigidbody2D component3 = go.GetComponent<Rigidbody2D>();
			if (component3 != null)
			{
				Vector2 vector = ((ForceDirectionOverride == Vector3.zero) ? ((Vector2)base.transform.forward) : ((Vector2)ForceDirectionOverride));
				component3.velocity = vector * Mathf.Max(MinVelocityOnExit, component3.velocity.magnitude);
			}
		}
		go.SendMessage("EnteredPortal", new PortalPackage(LinkedPortal, this, offset), SendMessageOptions.DontRequireReceiver);
		blockTimer = BlockTimer;
	}

	private void OnDrawGizmosSelected()
	{
		if (LinkedPortal != null)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawLine(base.transform.position, LinkedPortal.transform.position);
		}
	}
}
