using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialTrigger : MonoBehaviour
{
    [Range(0.0f, 5.0f)]
    public float radius;

    public Transform radialTF;
    public Transform triggerTF;
    [SerializeField]
    private float dist;

    void OnDrawGizmos()
    {
        Vector3 aPos = radialTF.position; //Radial
        Vector3 bPos = triggerTF.position; //Trigger

        //Vector3.Distance(aPos, bPos)
        dist = ((bPos.x - aPos.x) * (bPos.x - aPos.x)) 
                + ((bPos.z - aPos.z) * (bPos.z - aPos.z));
        
        //Radial
        Gizmos.color = dist < radius*radius ? Color.green : Color.red;
        Gizmos.DrawWireSphere(aPos,radius);
        
        //Trigger
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(bPos,0.1f);
    }
}
