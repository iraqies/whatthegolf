using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectDestroyable : MonoBehaviour
{
	public List<GameObject> destroyableObjects;

	public Action<GameObject> onDestroyObject { get; set; }
}
