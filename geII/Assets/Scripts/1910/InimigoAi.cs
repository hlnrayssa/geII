using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class InimigoAi : MonoBehaviour
{
    public Transform alvo;
    NavMeshAgent agent;
    public float raioDeteccao = 5f;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //se alvo não estiver vazio
        if (alvo != null)
        {
            //calcula a distancia entre o inimigo e o player
            float distancia = Vector3.Distance(transform.position, alvo.position);

            //se a distancia do player for menor ou igual ao raio de detecção, o inimigo vai atrás do player
            if (distancia <= raioDeteccao)
            {
                agent.SetDestination(alvo.position);
            }
           
        }
    }

    private void OnDrawGizmos()
    {
        //cria um gizmo na posição do inimigo com o raio de detecção
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, raioDeteccao);
    }
}
