using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Distances : MonoBehaviour
{
    public Transform aTf;
    public Transform bTf;

    [Range(0.0f,0.5f)]
    public float offset = 0.0f;
    
    void OnDrawGizmos()
    {
        Vector3 aPosition = aTf.position;
        Vector3 bPosition = bTf.position;
        Vector3 aToB = bPosition - aPosition;

        //Line - A
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero,aPosition);
        
        //Line - B
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero,bPosition);
        
        //Line - AB
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(aPosition,aPosition+aToB.normalized);
        
        //Draw Circle
        Gizmos.color = Color.yellow;
        Vector3 aPosOffSet = aToB * offset + aPosition;
        Gizmos.DrawSphere(aPosOffSet,0.05f);
    }
}


/*
 *
 *  public Transform aTf;
    public Transform bTf;
    public float distBA;
    public float distBO;
    public float distAO;
    
    void OnDrawGizmos()
    {
        Vector3 aPos = aTf.position;
        Vector3 bPos = bTf.position;

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, aPos);
        distAO = Vector3.Distance(Vector3.zero, aPos);

        
        Gizmos.color = Color.yellow;
        //Gizmos.DrawLine(Vector3.zero, bPos);
        distBO = Vector3.Distance(Vector3.zero, bPos);

        
        //Distance b - a
        Gizmos.color = Color.blue;
        Vector3 aToB = (bPos - aPos);
        Vector3 aToBDir = aToB.normalized;
        Gizmos.DrawLine(aPos,aPos+aToBDir);
        distBA = Vector3.Distance(bPos, aToB);
    }
 */