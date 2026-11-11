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
		if (entering == Player && clone == null && CloneToSpawn != null)
		{
			followObject = Player;
			clone = Instantiate(CloneToSpawn);
			clone.tag = "Clone";
			clone.SetActive(true);
			if (FollowRoom != null)
			{
				FollowRoom.followObject = clone;
			}
		}
	}

	public void DeleteClone(GameObject newFollow)
	{
		if (newFollow != null && newFollow.tag != "Clone")
		{
			if (clone != null)
			{
				Destroy(clone);
			}
			if (FollowRoom != null)
			{
				FollowRoom.followObject = Player;
			}
		}
	}

	public void SetFollowTarget(GameObject newFollow)
	{
		followObject = newFollow;
	}

	private void FixedUpdate()
	{
		if (clone != null && followObject != null && RoomToCopy != null && Room != null)
		{
			Vector3 localPos = RoomToCopy.InverseTransformPoint(followObject.transform.position);
			clone.transform.position = Room.TransformPoint(localPos);
			clone.transform.rotation = followObject.transform.rotation;
		}
	}
}
