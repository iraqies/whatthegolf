using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CullWhenHidden : GolfBehaviour
{
	public bool disableAllScriptsWhenCull;
	public bool isCullingRigids;
	public MonoBehaviour[] disableSpecificScripts;
	public List<MonoBehaviour> currentDisableSpecificScripts;
	public bool disableAnimations = true;
	public bool disablePaticles = true;
	public bool disableAudioSources = true;
	public bool disableSprites;

	private bool isVisible;
	[SerializeField] private Rigidbody2D[] rigids;
	public InvisibleCullingObject cullingObject;
	[SerializeField] private AudioSource[] audiosources;
	[SerializeField] private Animator[] animators;
	[SerializeField] private ParticleSystem[] particles;
	[SerializeField] private SortByY[] sorties;
	[SerializeField] private LineRenderer[] lineRenders;
	private bool isSectionVisible;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		if (cullingObject == null)
			cullingObject = GetComponentInChildren<InvisibleCullingObject>();
		if (currentDisableSpecificScripts == null)
			currentDisableSpecificScripts = new List<MonoBehaviour>();
		else
			currentDisableSpecificScripts.Clear();

		if (disableSpecificScripts != null)
		{
			foreach (var s in disableSpecificScripts)
				if (s != null) currentDisableSpecificScripts.Add(s);
		}
		if (disableAllScriptsWhenCull)
		{
			foreach (var s in GetComponentsInChildren<MonoBehaviour>(true))
			{
				if (s != null && s != this && !(s is InvisibleCullingObject) && !(s is IgnoreSectionCulling))
					currentDisableSpecificScripts.Add(s);
			}
		}
		rigids = GetComponentsInChildren<Rigidbody2D>(true);
		audiosources = GetComponentsInChildren<AudioSource>(true).Where(a => a != null && a.playOnAwake).ToArray();
		animators = GetComponentsInChildren<Animator>(true).Where(a => a != null && a.enabled).ToArray();
		particles = GetComponentsInChildren<ParticleSystem>(true);
		sorties = GetComponentsInChildren<SortByY>(true);
		lineRenders = GetComponentsInChildren<LineRenderer>(true);
	}

	public void Init()
	{
		if (cullingObject == null)
			OnPrePlayOrPreCompile();
		isVisible = false;
		UpdateState();
		if (cullingObject != null)
		{
			cullingObject.OnVisible -= OnVisible;
			cullingObject.OnVisible += OnVisible;
			cullingObject.OnInvisible -= OnInvisible;
			cullingObject.OnInvisible += OnInvisible;
		}
	}

	public void OnVisible()
	{
		if (isVisible) return;
		isVisible = true;
		UpdateState();
	}

	public void OnInvisible()
	{
		if (!isVisible) return;
		isVisible = false;
		UpdateState();
	}

	public void UpdateState()
	{
		if (currentDisableSpecificScripts != null)
		{
			for (int i = 0; i < currentDisableSpecificScripts.Count; i++)
			{
				var s = currentDisableSpecificScripts[i];
				if (s != null) s.enabled = isVisible;
			}
		}
		if (isCullingRigids && rigids != null)
		{
			for (int i = 0; i < rigids.Length; i++)
			{
				var r = rigids[i];
				if (r != null) r.simulated = isVisible;
			}
		}
		if (disableAudioSources && audiosources != null)
		{
			for (int i = 0; i < audiosources.Length; i++)
			{
				var au = audiosources[i];
				if (au != null) au.enabled = isVisible;
			}
		}
		if (disableAnimations && animators != null)
		{
			for (int i = 0; i < animators.Length; i++)
			{
				var a = animators[i];
				if (a != null) a.enabled = isVisible;
			}
		}
		if (disablePaticles && particles != null)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				var p = particles[i];
				if (p != null && p.isPlaying)
				{
					var em = p.emission;
					em.enabled = isVisible;
				}
			}
		}
		if (sorties != null)
		{
			for (int i = 0; i < sorties.Length; i++)
			{
				var so = sorties[i];
				if (so != null) so.isSorting = isVisible;
			}
		}
		if (lineRenders != null)
		{
			for (int i = 0; i < lineRenders.Length; i++)
			{
				var lr = lineRenders[i];
				if (lr != null) lr.enabled = isVisible;
			}
		}
	}

	public void OnSectionInvisible()
	{
		if (cullingObject == null && isVisible)
		{
			isVisible = false;
			UpdateState();
		}
		isSectionVisible = false;
	}

	public void OnSectionVisible()
	{
		if (cullingObject == null && !isVisible)
		{
			isVisible = true;
			UpdateState();
		}
		isSectionVisible = true;
	}
}
