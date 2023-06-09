using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLookAt : MonoBehaviour
{
    public Transform objTf;

    [Range(0.0f,1.0f)]
    public float preciseness;
    void OnDrawGizmos()
    {
        Vector3 center = transform.position;
        Vector3 playerPos = objTf.position;
        Vector3 playerLookDir = objTf.right; //x axis

        Vector3 playerToTriggerDir = (center - playerPos).normalized;

        float lookness = Vector3.Dot(playerToTriggerDir, playerLookDir);

        bool isLooking = lookness >= preciseness;

        Gizmos.color = isLooking ? Color.green : Color.red;
        Gizmos.DrawLine( playerPos, playerPos + playerToTriggerDir );

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine( playerPos, playerPos + playerLookDir );
    }
}
