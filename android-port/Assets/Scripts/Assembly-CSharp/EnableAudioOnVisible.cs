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
	}

	private void Update()
	{
	}

	private void SetEnabledStatus(bool status)
	{
	}
}
