using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public List<Transform> cubeList = new List<Transform>();
    public int PositionIndex = 0;

   
    void Update()
    {
       
        if (cubeList.Count > 0)
        {
            //Debug.Log("P: " + agent.gameObject.transform.position + " cube: " + cubeList[PositionIndex].position);

            if (agent.gameObject.transform.position.x == cubeList[PositionIndex].position.x && agent.gameObject.transform.position.z == cubeList[PositionIndex].position.z)
            {
                Debug.Log("This");
                
                PositionIndex+=1;
            }
            agent.SetDestination(cubeList[PositionIndex].position);
          
        }
    }
}

