using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
/*
 * The PlayerController handles player movement & rotation logic
 */
public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent; // reference to NavMeshAgent component

    //private Vector3 targetPos;

    // Update is called once per frame
    //void Update()
    //{
    //    // If the targetPos is valid (is not zero)
    //    if(targetPos.magnitude > 0)
    //    {
    //        // Follow the target!
    //        agent.SetDestination(targetPos);
    //    }
    //}

    // Call this to tell agent where to go!
    public void SetDestination(Vector3 target)
    {
        NavMeshPath path = new NavMeshPath();
        if(agent.CalculatePath(target, path))
        {
            if(path.status == NavMeshPathStatus.PathComplete)
            {
                agent.SetDestination(target);
            }
        }
       
    }
}
