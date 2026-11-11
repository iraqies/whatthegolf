using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ArenaCharacters : MonoBehaviour
{
	[Serializable]
	public class CharacterGroup
	{
		public Vector3 LookTarget;

		public List<Character> Characters = new List<Character>();

		public void Init(ArenaCharacters settings)
		{
			for (int i = 0; i < Characters.Count; i++)
			{
				Characters[i]?.Init(settings, LookTarget);
			}
		}

		public void ApplySettings(ArenaCharacters settings)
		{
			for (int i = 0; i < Characters.Count; i++)
			{
				Characters[i]?.ApplySettings(settings, LookTarget);
			}
		}
	}

	[Serializable]
	public class Character
	{
		public GameObject Root;

		public Transform Head;

		public Transform Model;

		public Animator Animator;

		public Renderer Body;

		public Vector3 InitialEulerRotation;

		public void Init(ArenaCharacters settings, Vector3 lookTarget)
		{
			if (Head != null)
			{
				InitialEulerRotation = Head.eulerAngles;
			}
			ApplySettings(settings, lookTarget);
		}

		public void ApplySettings(ArenaCharacters settings, Vector3 lookTarget)
		{
			if (Animator != null)
			{
				Animator.Play("Idle", 0, UnityEngine.Random.Range(0f, 1f));
			}
			if (Body != null && settings != null && settings.TShirtMaterials != null && settings.TShirtMaterials.Count > 0)
			{
				Material mat = settings.TShirtMaterials[UnityEngine.Random.Range(0, settings.TShirtMaterials.Count)];
				Body.material = mat;
			}
		}
	}

	public List<Material> TShirtMaterials;

	public Vector2 HorizontalHeadRotationLimits = new Vector2(-45f, 45f);

	public Vector2 VerticalHeadRotationLimits = new Vector2(-20f, 20f);

	public float LookSpeed = 5f;

	public float MaxLookDistance = 30f;

	public Vector2 ScaleRange = new Vector2(0.9f, 1.1f);

	public Vector2 AnimatorSpeedRange = new Vector2(0.8f, 1.2f);

	public List<CharacterGroup> CharacterGroups = new List<CharacterGroup>();

	private Transform lookTarget;

	public void ApplySettingsToCharacterGroups()
	{
		for (int i = 0; i < CharacterGroups.Count; i++)
		{
			CharacterGroups[i]?.ApplySettings(this);
		}
	}

	public void InitCharacterGroups()
	{
		for (int i = 0; i < CharacterGroups.Count; i++)
		{
			CharacterGroups[i]?.Init(this);
		}
	}

	private void Start()
	{
		GolfBallController gbc = UnityEngine.Object.FindObjectOfType<GolfBallController>();
		if (gbc != null)
		{
			lookTarget = gbc.transform;
		}
		for (int i = 0; i < CharacterGroups.Count; i++)
		{
			CharacterGroup group = CharacterGroups[i];
			if (group == null)
			{
				continue;
			}
			for (int j = 0; j < group.Characters.Count; j++)
			{
				Character c = group.Characters[j];
				if (c == null)
				{
					continue;
				}
				if (c.Model != null)
				{
					Vector3 ls = c.Model.localScale;
					ls.y = UnityEngine.Random.Range(ScaleRange.x, ScaleRange.y);
					c.Model.localScale = ls;
				}
				if (c.Animator != null)
				{
					c.Animator.speed = UnityEngine.Random.Range(AnimatorSpeedRange.x, AnimatorSpeedRange.y);
					c.Animator.Play("Idle", 0, UnityEngine.Random.Range(0f, 1f));
				}
			}
		}
	}

	private void LateUpdate()
	{
		if (lookTarget == null)
		{
			return;
		}
		Vector3 targetPos = lookTarget.position;
		float maxDistSq = MaxLookDistance * MaxLookDistance;
		for (int i = 0; i < CharacterGroups.Count; i++)
		{
			CharacterGroup group = CharacterGroups[i];
			if (group == null)
			{
				continue;
			}
			for (int j = 0; j < group.Characters.Count; j++)
			{
				Character c = group.Characters[j];
				if (c == null || c.Head == null)
				{
					continue;
				}
				Vector3 diff = targetPos - c.Head.position;
				if (diff.sqrMagnitude <= maxDistSq && diff.sqrMagnitude > 0.001f)
				{
					Quaternion lookRot = Quaternion.LookRotation(diff);
					Vector3 euler = lookRot.eulerAngles;
					c.Head.eulerAngles = Vector3.Lerp(c.Head.eulerAngles, euler, Time.deltaTime * LookSpeed);
				}
			}
		}
	}
}
