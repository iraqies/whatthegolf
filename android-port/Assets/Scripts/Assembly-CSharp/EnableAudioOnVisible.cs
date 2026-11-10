using Audio;
using UnityEngine;

public class EnableAudioOnVisible : GolfBehaviour
{
	public InvisibleCullingObject cullingObject;

	public bool findFirstRendererInChildren;

	public Renderer m_renderer;

	private AudioSource[] m_audioSources;

	private IAudioCullable[] cullables;

	public bool IsVisible { get; private set; }

	private void Awake()
	{
		m_audioSources = GetComponents<AudioSource>();
		cullables = GetComponentsInChildren<IAudioCullable>(true);
		if (cullingObject == null && m_renderer == null && findFirstRendererInChildren)
		{
			m_renderer = GetComponentInChildren<Renderer>();
		}
		if (cullingObject == null && m_renderer == null)
		{
			IsVisible = true;
			SetEnabledStatus(true);
			return;
		}
		SetEnabledStatus(false);
		if (cullingObject != null)
		{
			cullingObject.OnVisible += OnBecameVisibleHandler;
			cullingObject.OnInvisible += OnBecameInvisibleHandler;
		}
	}

	private void OnBecameVisibleHandler() => SetEnabledStatus(true);
	private void OnBecameInvisibleHandler() => SetEnabledStatus(false);

	private void Update()
	{
		if (m_renderer != null)
		{
			bool vis = m_renderer.isVisible;
			if (vis != IsVisible)
			{
				IsVisible = vis;
				SetEnabledStatus(vis);
			}
		}
	}

	private void SetEnabledStatus(bool status)
	{
		if (m_audioSources != null)
		{
			for (int i = 0; i < m_audioSources.Length; i++)
			{
				if (m_audioSources[i] != null)
					m_audioSources[i].enabled = status;
			}
		}
		if (cullables != null)
		{
			for (int i = 0; i < cullables.Length; i++)
			{
				if (cullables[i] != null)
					cullables[i].IsVisible = status;
			}
		}
	}
}
