using UnityEngine;

public class SpawnNewCloneWhenEnteringPortal : MonoBehaviour
{
	public GameObject CloneToSpawn;

	public Transform Room;

	public Transform RoomToCopy;

	public SpawnNewCloneWhenEnteringPortal FollowRoom;

	public DestroyCloneWhenEnteringPortal DestroyRoom;

	public GameObject Player;

	private GameObject clone;

	private GameObject followObject;

	public void SpawnClone(GameObject entering)
	{
	}

	public void DeleteClone(GameObject newFollow)
	{
	}

	public void SetFollowTarget(GameObject newFollow)
	{
	}

	private void FixedUpdate()
	{
	}
}
