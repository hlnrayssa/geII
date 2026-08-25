using UnityEngine;
using UnityEngine.Video;

public class Player : MonoBehaviour
{

    public static Player Instance;
    public string nome = "José";
    public int ataque;
    public static int level = 1;
    public int vida = 100;
    Rigidbody rb;
    public float raio;


    public void Awake()
     {

             Instance = this;

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; //fazer a cápsula parar de girar
    }

    private void Update()
    {
        //informações no console
        Debug.Log("Nome: "+ nome + "; Vida: " + vida);

        float speedX, speedZ;
        speedX = Input.GetAxis("Horizontal");
        speedZ = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(speedX, 0, speedZ) * 5F;

        if(Input.GetKeyDown(KeyCode.E))
        {
            PegarItem();
        }
    }

    //verifica a colisão do item através de raycast
    void PegarItem()
    {
        Debug.Log("Pegando item");
        RaycastHit[] objetosProximo;

        objetosProximo = Physics.SphereCastAll(transform.position, raio, Vector3.up);
        foreach (RaycastHit vitima in objetosProximo)
        {
            if (vitima.transform.gameObject.tag == "Item")
            {
                Destroy(vitima.transform.gameObject);
            }
        } 
    }

    //coloca uma esfera vermelha ao redor do player para mostrar o raio de colisão
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, raio);
    }

}
