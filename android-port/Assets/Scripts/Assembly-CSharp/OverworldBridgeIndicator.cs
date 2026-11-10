using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldBridgeIndicator : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldBridgeIndicator> m_OnOpen;

	[CompilerGenerated]
	private Action<OverworldBridgeIndicator> m_OnChangeCount;

	public bool isOpen;

	public List<OverworldGoal> requireGoals;

	public int requireCountMinus;

	public Transform startPoint;

	public Transform endPoint;

	public ParticleSystem openParticles;

	public GeneratedIsland visualBridge;

	[SerializeField]
	private BoxCollider borderPrefab;

	[SerializeField]
	private BoxCollider groundPrefab;

	public ParticleSystem openParticlesPrefab;

	private float bridgeWidth = 10f;

	public event Action<OverworldBridgeIndicator> OnOpen
	{
		[CompilerGenerated]
		add
		{
			m_OnOpen = (Action<OverworldBridgeIndicator>)Delegate.Combine(m_OnOpen, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnOpen = (Action<OverworldBridgeIndicator>)Delegate.Remove(m_OnOpen, value);
		}
	}

	public event Action<OverworldBridgeIndicator> OnChangeCount
	{
		[CompilerGenerated]
		add
		{
			m_OnChangeCount = (Action<OverworldBridgeIndicator>)Delegate.Combine(m_OnChangeCount, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnChangeCount = (Action<OverworldBridgeIndicator>)Delegate.Remove(m_OnChangeCount, value);
		}
	}

	public void Awake()
	{
		if (visualBridge != null)
		{
			visualBridge.gameObject.SetActive(false);
		}
		if (requireGoals == null)
		{
			return;
		}
		foreach (OverworldGoal requireGoal in requireGoals)
		{
			if (requireGoal != null)
			{
				requireGoal.OnUpdateData += Goal_OnUpdateData;
			}
		}
	}

	private void Goal_OnUpdateData(OverworldGoal obj)
	{
		m_OnChangeCount?.Invoke(this);
	}

	public int GetFlagsMissingCount()
	{
		int num = 0;
		if (requireGoals != null)
		{
			foreach (OverworldGoal requireGoal in requireGoals)
			{
				if (requireGoal != null && requireGoal.IsCompleted())
				{
					num++;
				}
			}
		}
		return requireCountMinus - num;
	}

	private void UpdateLockStatus(bool instant)
	{
		int num = 0;
		if (requireGoals != null)
		{
			foreach (OverworldGoal requireGoal in requireGoals)
			{
				if (requireGoal != null && requireGoal.IsCompleted())
				{
					num++;
				}
			}
		}
		if (num >= requireCountMinus && !isOpen)
		{
			isOpen = true;
			Open(instant);
		}
	}

	public void TryOpen(bool instant = false)
	{
		UpdateLockStatus(instant);
		m_OnChangeCount?.Invoke(this);
	}

	public bool CanBeOpened()
	{
		return GetFlagsMissingCount() < 1;
	}

	private void Unlock(bool instant)
	{
		if (!isOpen)
		{
			isOpen = true;
			Open(instant);
		}
	}

	public void Open(bool instant)
	{
		if (instant)
		{
			if (visualBridge != null)
			{
				visualBridge.gameObject.SetActive(true);
			}
			m_OnOpen?.Invoke(this);
			return;
		}
		m_OnOpen?.Invoke(this);
		if (visualBridge != null)
		{
			visualBridge.gameObject.SetActive(true);
			if (openParticles != null)
			{
				openParticles.Emit(200);
			}
			Vector3 endPosition = visualBridge.transform.position;
			Vector3 startPosition = visualBridge.transform.position - Vector3.up * 20f;
			StartCoroutine(pTween.To(0.07f, 0f, 1f, delegate(float t)
			{
				if (visualBridge != null)
				{
					visualBridge.transform.position = Vector3.Lerp(startPosition, endPosition, t);
				}
			}).Then(delegate
			{
			}));
		}
	}

	public void Make()
	{
		if (base.transform == null || endPoint == null || startPoint == null)
		{
			Debug.LogError("Missing points on BridgeIndicator: " + base.transform.name, base.gameObject);
		}
		base.transform.position = (startPoint.position + endPoint.position) * 0.5f;
		Vector3 position = endPoint.position;
		Vector3 position2 = startPoint.position;
		GeneratedIsland componentInChildren = GetComponentInChildren<GeneratedIsland>();
		if (componentInChildren != null)
		{
			UnityEngine.Object.DestroyImmediate(componentInChildren.gameObject);
		}
		GameObject gameObject = new GameObject("Bridge");
		gameObject.AddComponent<GeneratedIsland>();
		gameObject.transform.parent = base.transform;
		GeneratedIsland component = gameObject.GetComponent<GeneratedIsland>();
		component.transform.localPosition = Vector3.zero;
		base.transform.name = "Bridge_" + startPoint.name + "_to_" + endPoint.name;
		Vector3 dir = position - position2;
		MakeGround(component, dir);
		MakeWalls(component, dir);
		MakeParticles(component, dir);
		visualBridge = component;
	}

	private void MakeParticles(GeneratedIsland island, Vector3 dir)
	{
		if (island != null && openParticlesPrefab != null)
		{
			openParticles = UnityEngine.Object.Instantiate(openParticlesPrefab, island.transform);
			openParticles.transform.forward = dir;
			float magnitude = dir.magnitude;
			ParticleSystem.ShapeModule shape = openParticles.shape;
			shape.scale = new Vector3(bridgeWidth, 1f, magnitude);
			openParticles.transform.localPosition = Vector3.up * -0.5f;
		}
	}

	private void MakeGround(GeneratedIsland island, Vector3 dir)
	{
		if (island != null && groundPrefab != null)
		{
			BoxCollider boxCollider = UnityEngine.Object.Instantiate(groundPrefab, island.transform);
			boxCollider.transform.forward = dir;
			float magnitude = dir.magnitude;
			boxCollider.transform.localScale = new Vector3(bridgeWidth, 1f, magnitude);
			boxCollider.transform.localPosition = Vector3.up * -0.5f;
		}
	}

	private void MakeWalls(GeneratedIsland island, Vector3 dir)
	{
		if (island != null && borderPrefab != null)
		{
			BoxCollider boxCollider = UnityEngine.Object.Instantiate(borderPrefab, island.transform);
			BoxCollider boxCollider2 = UnityEngine.Object.Instantiate(borderPrefab, island.transform);
			boxCollider.transform.forward = dir;
			boxCollider2.transform.forward = dir;
			float magnitude = dir.magnitude;
			boxCollider.transform.localScale = new Vector3(3f, 3.5f, magnitude);
			boxCollider2.transform.localScale = new Vector3(3f, 3.5f, magnitude);
			boxCollider.transform.localPosition = Vector3.up * 3.5f * 0.5f - Vector3.up * 0.5f - boxCollider.transform.right * bridgeWidth * 0.5f - boxCollider.transform.right * 3f * 0.5f;
			boxCollider2.transform.localPosition = Vector3.up * 3.5f * 0.5f - Vector3.up * 0.5f + boxCollider2.transform.right * bridgeWidth * 0.5f + boxCollider2.transform.right * 3f * 0.5f;
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (requireGoals == null)
		{
			return;
		}
		foreach (OverworldGoal requireGoal in requireGoals)
		{
			if (requireGoal != null)
			{
				Gizmos.color = Color.magenta;
				Gizmos.DrawLine(base.transform.position, requireGoal.transform.position);
			}
		}
	}
}
