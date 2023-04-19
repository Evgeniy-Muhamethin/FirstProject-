using UnityEngine;
using UnityEngine.AI;

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

    //Реакция на игрока
    public void TrigerOnPlayer(GameObject startPoint, Transform endPoint,
        RaycastHit hit, float duration)
    {
        var directions = endPoint.transform.position 
            - startPoint.transform.position;//Для корректной работы расчитал расстояние от стартовой точки до конейной точки
		var startPosition = startPoint.transform.position;
        var resultRaycast = Physics.Raycast(startPosition, directions, out hit,
            duration);

        Color color = Color.red;
        if (resultRaycast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                color = Color.green;
            }
        }
        Debug.DrawRay(startPosition, directions, color);
    }
}