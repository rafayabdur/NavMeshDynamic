using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public List<Vector3> list = new List<Vector3>();
    public int PositionIndex = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            /*Vector3 position = Input.mousePosition;
            list.Add(position);
            
            if (PositionIndex < list.Count)
            {
                Ray ray = cam.ScreenPointToRay(list[PositionIndex]);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (agent.gameObject.transform.position != hit.point)
                    {
                        agent.SetDestination(hit.point);
                    }
                }
                else if(agent.gameObject.transform.position == list[PositionIndex])
                {
                    PositionIndex++;
                }
            }
            else if (PositionIndex == list.Count)
            {
                list.Clear();
                PositionIndex = 0;
                Debug.Log("Second");
            }*/

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                list.Add(hit.point);
            }
        }

        if(list.Count > 0)
        {
            if ((agent.gameObject.transform.position.x != list[PositionIndex].x) && (agent.gameObject.transform.position.z != list[PositionIndex].z))
            {
                agent.SetDestination(list[PositionIndex]);
            }
            else if (PositionIndex == list.Count - 1)
            {
                list.Clear();
                PositionIndex = 0;
                Debug.Log("Second");
            }
            else
            {
                PositionIndex++;
            }
        }
    }
}
