using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class OverworldLinkedGoal : GolfBehaviour
{
	[Serializable]
	public class LinkedLevelData
	{
		public LevelData LevelData;

		public List<LevelData> AdditionalLevels;
	}

	public List<OverworldGoal> Flags;

	public List<LinkedLevelData> OrderedLevels;

	private OverworldManager2d Manager;

	private int completed;

	private Dictionary<Collider2D, Collider2D[]> goals;

	private int[] completeOrder;

	[SerializeField]
	private Collider2D circleCollider;

	[SerializeField]
	private Collider2D boxCollider;

	private readonly string saveFormat = "LINKED_FLAGS_{0}_ORDER";

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		circleCollider = GetComponentInChildren<CircleCollider2D>();
		boxCollider = GetComponentInChildren<BoxCollider2D>();
	}

	private void Awake()
	{
		Manager = OverworldManager2d.Instance;
		if (Manager != null)
		{
			Manager.OnLevelComplete = (Action<OverworldGoal, bool>)Delegate.Combine(Manager.OnLevelComplete, new Action<OverworldGoal, bool>(OnlevelCompleted));
			Manager.OnLevelAbandoned = (Action<OverworldGoal>)Delegate.Combine(Manager.OnLevelAbandoned, new Action<OverworldGoal>(OnlevelAbandoned));
		}
		goals = new Dictionary<Collider2D, Collider2D[]>();
		if (Flags == null || OrderedLevels == null || OrderedLevels.Count == 0)
		{
			return;
		}
		completeOrder = new int[Flags.Count];
		for (int i = 0; i < completeOrder.Length; i++)
		{
			completeOrder[i] = -1;
		}
		string key = string.Format(saveFormat, OrderedLevels[0].LevelData.SceneName);
		string value;
		SaveGame.TryGetValue(key, out value, "");
		if (!string.IsNullOrEmpty(value))
		{
			string[] array = value.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == completeOrder.Length)
			{
				for (int j = 0; j < array.Length; j++)
				{
					completeOrder[j] = Convert.ToInt16(array[j]);
				}
			}
			else
			{
				SaveGame.ClearValue(key);
			}
		}
		for (int k = 0; k < Flags.Count; k++)
		{
			OverworldGoal overworldGoal = Flags[k];
			if (overworldGoal == null)
			{
				continue;
			}
			Collider2D original = (overworldGoal.IsStuckToWall ? boxCollider : circleCollider);
			Collider2D collider2D = UnityEngine.Object.Instantiate(original, overworldGoal.transform.position, Quaternion.identity, base.transform);
			collider2D.enabled = true;
			collider2D.gameObject.SetActive(true);
			collider2D.transform.up = overworldGoal.transform.forward;
			collider2D.name = overworldGoal.name + " Linked collider";
			Collider2D[] value2 = (from col in overworldGoal.gameObject.GetComponentsInChildren<Collider2D>()
				where col != null && !col.isTrigger
				select col).ToArray();
			goals.Add(collider2D, value2);
			int num = completeOrder[k];
			if (num != -1 && num < OrderedLevels.Count)
			{
				overworldGoal.levelData = OrderedLevels[num].LevelData;
				overworldGoal.AdditionalLevelData = OrderedLevels[num].AdditionalLevels;
				completed++;
			}
			else
			{
				overworldGoal.levelData = OrderedLevels[OrderedLevels.Count - 1].LevelData;
				overworldGoal.AdditionalLevelData = OrderedLevels[OrderedLevels.Count - 1].AdditionalLevels;
			}
		}
	}

	private void FixedUpdate()
	{
		if (goals == null)
		{
			return;
		}
		foreach (KeyValuePair<Collider2D, Collider2D[]> goal in goals)
		{
			Collider2D key = goal.Key;
			Collider2D[] value = goal.Value;
			if (key == null || value == null || value.Length == 0 || value[0] == null)
			{
				continue;
			}
			key.transform.position = value[0].transform.position;
			key.transform.up = value[0].transform.forward;
			for (int i = 0; i < value.Length; i++)
			{
				if (value[i] != null && value[i].enabled)
				{
					value[i].enabled = false;
				}
			}
		}
	}

	private void OnlevelAbandoned(OverworldGoal overworldGoal)
	{
		if (Flags != null && Flags.Contains(overworldGoal))
		{
			int num = Flags.IndexOf(overworldGoal);
			if (num >= 0 && num < completeOrder.Length && completeOrder[num] < 0 && OrderedLevels != null && OrderedLevels.Count > 0)
			{
				overworldGoal.levelData = OrderedLevels[OrderedLevels.Count - 1].LevelData;
				overworldGoal.AdditionalLevelData = OrderedLevels[OrderedLevels.Count - 1].AdditionalLevels;
			}
		}
	}

	private void OnlevelCompleted(OverworldGoal overworldGoal, bool parUnlocked)
	{
		if (Flags == null || !Flags.Contains(overworldGoal))
		{
			return;
		}
		int num = Flags.IndexOf(overworldGoal);
		if (num >= 0 && num < completeOrder.Length && completeOrder[num] < 0)
		{
			completeOrder[num] = completed;
			if (OrderedLevels != null && OrderedLevels.Count > 0)
			{
				string key = string.Format(saveFormat, OrderedLevels[0].LevelData.SceneName);
				string value = string.Join(",", completeOrder);
				SaveGame.SetValue(key, value, true);
			}
			completed++;
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other == null || !other.gameObject.CompareTag("Player") || other.rigidbody == null)
		{
			return;
		}
		OverworldBall2D component = other.rigidbody.GetComponent<OverworldBall2D>();
		if (component == null || !component.GetCanEnableFlagsAndDoors() || other.contacts.Length == 0)
		{
			return;
		}
		Collider2D otherCollider = other.contacts[0].otherCollider;
		if (otherCollider == null || goals == null || !goals.ContainsKey(otherCollider))
		{
			return;
		}
		Collider2D[] array = goals[otherCollider];
		if (array == null || array.Length == 0 || array[0] == null)
		{
			return;
		}
		OverworldGoal component2 = array[0].GetComponent<OverworldGoal>();
		if (component2 == null || Flags == null)
		{
			return;
		}
		int num = Flags.IndexOf(component2);
		if (num >= 0 && num < completeOrder.Length && completeOrder[num] == -1 && OrderedLevels != null && completed < OrderedLevels.Count)
		{
			component2.levelData = OrderedLevels[completed].LevelData;
			component2.AdditionalLevelData = OrderedLevels[completed].AdditionalLevels;
		}
		Collider2D col = other.contacts[0].otherCollider;
		col.enabled = false;
		component2.PlayerOutOfRangeAgain = delegate
		{
			if (col != null)
			{
				col.enabled = true;
			}
		};
		component2.OnCollisionEnter2D(other);
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawCube(base.transform.position, Vector3.one);
	}
}
