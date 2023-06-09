using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class LookAt : MonoBehaviour
{
    public Transform playerObj;
    public Transform enemyObj;
    public float raioVisao;
    
    [Range(0.0f, 1.0f)]
    public float precisao;

    private void OnDrawGizmos()
    {
        Vector3 playerPos = playerObj.position;
        Vector3 playerLookAt = playerObj.right; //eixo X
        Vector3 enemyPos = enemyObj.position;

        raioVisao = Vector3.Dot(playerLookAt.normalized,enemyPos.normalized);
        bool isLooking = raioVisao >= precisao;
        
        Gizmos.color = isLooking ? Color.green : Color.red;
        Gizmos.DrawLine(playerPos, enemyPos);
        
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPos, playerPos+playerLookAt);
        
        //Gizmos.color = Color.white;
        //Gizmos.DrawLine();
    }
}
