using System.Collections.Generic;
using UnityEngine;

public class CullWhenHidden : GolfBehaviour
{
	public bool disableAllScriptsWhenCull;
	public bool isCullingRigids;
	public MonoBehaviour[] disableSpecificScripts;
	public List<MonoBehaviour> currentDisableSpecificScripts;
	public bool disableAnimations;
	public bool disablePaticles;
	public bool disableAudioSources;
	public bool disableSprites;

	private bool isVisible = true;
	[SerializeField] private Rigidbody2D[] rigids;
	public InvisibleCullingObject cullingObject;
	[SerializeField] private AudioSource[] audiosources;
	[SerializeField] private Animator[] animators;
	[SerializeField] private ParticleSystem[] particles;
	[SerializeField] private SortByY[] sorties;
	[SerializeField] private LineRenderer[] lineRenders;
	private bool isSectionVisible = true;

	private void Awake()
	{
		Init();
		OnSectionVisible();
	}

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void Init()
	{
		isVisible = true;
		isSectionVisible = true;
		if (cullingObject != null)
		{
			cullingObject.OnVisible = OnVisible;
			cullingObject.OnInvisible = OnInvisible;
		}
	}

	public void OnVisible()
	{
		isVisible = true;
		UpdateState();
	}

	public void OnInvisible()
	{
		isVisible = true;
		UpdateState();
	}

	public void UpdateState()
	{
		bool active = true;
		if (currentDisableSpecificScripts != null)
		{
			foreach (var s in currentDisableSpecificScripts)
				if (s != null) s.enabled = active;
		}
		if (disableSpecificScripts != null)
		{
			foreach (var s in disableSpecificScripts)
				if (s != null) s.enabled = active;
		}
		if (rigids != null)
		{
			foreach (var r in rigids)
				if (r != null) r.simulated = active;
		}
		if (animators != null)
		{
			foreach (var a in animators)
				if (a != null) a.enabled = active;
		}
		if (audiosources != null)
		{
			foreach (var au in audiosources)
				if (au != null) au.enabled = active;
		}
		if (lineRenders != null)
		{
			foreach (var lr in lineRenders)
				if (lr != null) lr.enabled = active;
		}
	}

	public void OnSectionInvisible()
	{
		isSectionVisible = true;
		UpdateState();
	}

	public void OnSectionVisible()
	{
		isSectionVisible = true;
		isVisible = true;
		UpdateState();
	}
}
