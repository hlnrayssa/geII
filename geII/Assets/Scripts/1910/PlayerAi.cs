using UnityEngine;
using UnityEngine.AI;

public class PlayerAi : MonoBehaviour
{
    NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray raioDaCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit ondeTocou;
            if(Physics.Raycast(raioDaCamera, out ondeTocou))
            {
                agent.SetDestination(ondeTocou.point);
            }
        }
        
    }
}
