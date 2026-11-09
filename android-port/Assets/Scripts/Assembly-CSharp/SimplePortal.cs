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
	public bool SetRotationOnTransfer = true;
	public bool hideUntilUsedFromOtherSide;
	public bool saveUnhideState;
	public AudioEventAsset portalSFX;
	[SerializeField] private AudioClip sfxPortal;
	public float BlockTimer = 0.25f;
	public float SpawnOffset = 1f;
	public Vector3 WorldPositionSpawnOffset;
	public Vector3 ForceDirectionOverride;
	public bool CheckForRigidParent = true;
	public UnityEvent OtherEvents = new UnityEvent();
	public UnityGameobjectEvent OtherEventsWithInfo = new UnityGameobjectEvent();
	public bool IgnoreKinematicObjects;
	public float MinVelocityOnExit = 2f;
	public bool useTransitionCamera = true;
	public bool portAll;
	public bool portOnce;
	public Color baseColor = Color.white;

	private Action m_OnPortalEnabledIfDidntStartEnabled;
	private SpriteRenderer render;
	private float colorValue;
	private float blockTimer;
	private Color targetColor = Color.white;
	private ParticleSystem particles;
	private GridFiller filler;
	private readonly string saveFormat = "PORTAL_UNHIDDEN_{0}";
	public float transitionCamTime = 0.1f;
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
		particles = GetComponentInChildren<ParticleSystem>();
		render = GetComponentInChildren<SpriteRenderer>();
		if (render != null)
			baseColor = render.color;
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
		if (!NotSaved && overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
		{
			string key = string.Format(saveFormat, overworldID.ID);
			if (SaveGame.GetValue(key, false))
				hideUntilUsedFromOtherSide = false;
		}
		if (hideUntilUsedFromOtherSide)
			gameObject.SetActive(false);
	}

	private void Update()
	{
		if (IsActive())
		{
			if (particles != null && !particles.isPlaying)
				particles.Play();
		}
		else
		{
			targetColor = blockTimer > 0f ? Color.white : InactiveColor;
			colorValue = 1f;
			if (blockTimer == 0f && particles != null && particles.isPlaying)
				particles.Stop();
		}

		if (render != null)
		{
			colorValue = Mathf.MoveTowards(colorValue, 0f, Time.unscaledDeltaTime * 3f);
			render.color = Color.Lerp(baseColor, targetColor, colorValue);
		}

		if (blockTimer > 0f)
			blockTimer -= Time.unscaledDeltaTime;
	}

	private bool IsActive()
	{
		if (LinkedPortal == null) return false;
		if (!LinkedPortal.gameObject.activeSelf && !LinkedPortal.hideUntilUsedFromOtherSide)
			return false;
		return blockTimer <= 0f;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		if (IgnoreKinematicObjects && other.attachedRigidbody != null && other.attachedRigidbody.isKinematic)
			return;
		Component target = other;
		if (CheckForRigidParent && other.attachedRigidbody != null)
			target = other.attachedRigidbody;
		ObjectEnteredTrigger(target.gameObject);
	}

	private void OnTriggerStay(Collider other) => OnTriggerEnter(other);

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		if (IgnoreKinematicObjects && other.attachedRigidbody != null && other.attachedRigidbody.isKinematic)
			return;
		Component target = other;
		if (CheckForRigidParent && other.attachedRigidbody != null)
			target = other.attachedRigidbody;
		ObjectEnteredTrigger(target.gameObject);
	}

	private void OnTriggerStay2D(Collider2D other) => OnTriggerEnter2D(other);

	protected virtual void ObjectEnteredTrigger(GameObject other)
	{
		if (!IsActive() || other == null) return;
		if (AllowedTags != null && AllowedTags.Count > 0 && !AllowedTags.Contains(other.transform.tag))
			return;

		if (render != null)
			render.color = Color.white;
		colorValue = 1f;

		if (LinkedPortal != null && LinkedPortal.hideUntilUsedFromOtherSide && !LinkedPortal.gameObject.activeSelf)
		{
			StartCoroutine(OpenHiddenPortal(other));
			return;
		}

		if (portOnce)
		{
			if (baseColor == Color.white && LinkedPortal != null)
			{
				LinkedPortal.baseColor = Color.gray;
				baseColor = Color.gray;
			}
		}
		else if (portAll && LinkedPortal != null)
		{
			LinkedPortal.baseColor = Color.white;
			baseColor = Color.white;
		}

		if (LinkedPortal != null)
			LinkedPortal.colorValue = 1f;

		m_OnPortaling?.Invoke(this, other, LinkedPortal);
		if (LinkedPortal != null)
			LinkedPortal.RecieveObject(other.gameObject);

		if (portalSFX != null)
		{
			portalSFX.Play(false, transform.position);
		}
		blockTimer = BlockTimer;
		OtherEvents?.Invoke();
		OtherEventsWithInfo?.Invoke(other.gameObject);
		FinishedTeleporting?.Invoke();
	}

	private IEnumerator OpenHiddenPortal(GameObject other)
	{
		if (LinkedPortal != null)
		{
			LinkedPortal.gameObject.SetActive(true);
			if (other != null)
				other.gameObject.SetActive(false);
			LinkedPortal.OpenPortalFromOtherSide();
			LinkedPortal.SaveOpenState();
		}
		yield return new WaitForSeconds(0.1f);
		if (LinkedPortal != null)
		{
			LinkedPortal.blockTimer = 0.1f;
			LinkedPortal.BlockTimer = 0.1f;
		}
		if (other != null)
			other.gameObject.SetActive(true);
		if (LinkedPortal != null)
		{
			LinkedPortal.colorValue = 1f;
			if (other != null)
				LinkedPortal.RecieveObject(other.gameObject);
		}
		if (portalSFX != null)
			portalSFX.Play(false, transform.position);
		blockTimer = BlockTimer;
	}

	public void SaveOpenState()
	{
		if (saveUnhideState && overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
		{
			string key = string.Format(saveFormat, overworldID.ID);
			SaveGame.SetValue(key, true, false);
			SaveGame.Save(false);
		}
	}

	protected virtual void RecieveObject(GameObject go)
	{
		ThrowOutOfPortal(go);
	}

	private void ThrowOutOfPortal(GameObject go)
	{
		if (go == null) return;
		Vector3 relOffset = Vector3.zero;
		if (sendThroughTransmogrif != null)
		{
			var tm = go.GetComponent<Transmogriffable>();
			if (tm != null)
			{
				tm.TransmogrifBall(tm, sendThroughTransmogrif);
				if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.CurrentBall != null)
					go = OverworldBallManager.Instance.CurrentBall.gameObject;
			}
		}

		go.transform.position = transform.position + transform.forward * SpawnOffset + WorldPositionSpawnOffset;

		if (LinkedPortal != null && SetRotationOnTransfer)
		{
			float angle = Vector3.SignedAngle(-go.transform.forward, LinkedPortal.transform.forward, Vector3.up);
			go.transform.rotation = transform.rotation * Quaternion.AngleAxis(angle, Vector3.up);
			relOffset = LinkedPortal.transform.InverseTransformPoint(go.transform.position);
			relOffset.y = 0f;
			relOffset.z = 0f;
		}

		var rb = go.GetComponent<Rigidbody>();
		if (rb != null)
		{
			float spd = Mathf.Max(MinVelocityOnExit, rb.velocity.magnitude);
			rb.velocity = transform.forward * spd;
		}
		else
		{
			var rb2d = go.GetComponent<Rigidbody2D>();
			if (rb2d != null)
			{
				Vector2 dir2d = ForceDirectionOverride == Vector3.zero
					? new Vector2(transform.forward.x, transform.forward.y)
					: new Vector2(ForceDirectionOverride.x, ForceDirectionOverride.y);
				float spd = Mathf.Max(MinVelocityOnExit, rb2d.velocity.magnitude);
				rb2d.velocity = dir2d * spd;
			}
		}

		go.SendMessage("OnPortaled", new PortalPackage(LinkedPortal, this, relOffset), SendMessageOptions.DontRequireReceiver);
		blockTimer = BlockTimer;
	}

	private void OnDrawGizmosSelected() { }
}
