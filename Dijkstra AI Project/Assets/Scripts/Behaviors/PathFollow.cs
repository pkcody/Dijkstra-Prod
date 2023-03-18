using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : Seek
{
    public GameObject[] path;
    public int index = 0;
    public float distance = 1f;
    

    public override SteeringOutput getSteering()
    {
        target = path[index].gameObject;
        
        Vector3 directionToTarget = target.transform.position - character.transform.position;
        float distanceToTarget = directionToTarget.magnitude;

        if (distanceToTarget <= distance)
        {
            index = (index+1) % path.Length;
            target = path[index].gameObject;
        }

        return base.getSteering();
        
    }
}
