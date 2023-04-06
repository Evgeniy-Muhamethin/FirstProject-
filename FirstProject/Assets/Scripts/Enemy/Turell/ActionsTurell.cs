using UnityEngine;

public class ActionsTurell 
{
    public void ObjectLookRotation(Transform transformTurell, 
        Transform transformPlayer)
    {
        Vector3 relativePosition = transformPlayer.position - transformTurell.position;
        Quaternion rotations = Quaternion.LookRotation(relativePosition);
        transformTurell.rotation = rotations;
    }

    public float DistanceObject(Transform objectOne, 
        Transform objectTwo)
    {
        float distanceResult = 0;
        distanceResult = Mathf.Sqrt((objectOne.position - 
            objectTwo.position).sqrMagnitude);
        return distanceResult;
    }
}