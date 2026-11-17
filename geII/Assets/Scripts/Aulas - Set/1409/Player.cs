using NUnit.Framework;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float raioforca;
    public float forca;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Forca();
        }
    }

    void Forca()
    {
        Collider[] objetosProximos; //cria um array vazio para colocar os colliders dos objetos proximos, pq não sabemos qntos tem ao redor, mas serão colocados dentro desse array
        objetosProximos = Physics.OverlapSphere(transform.position, raioforca); //cria uma esfera a partir da posição do player e pega os colliders
        Debug.Log("Objetos próximos: " +  objetosProximos.Length);//dá o valor de objetos próximos, mas tbm vai contar o player

        //passar por cada objeto próximo para verificar quais dos objetos próximos possuem a tag item dentro do array de objetos próximos, e aplicar a força apenas nesses objetos
        foreach (Collider objetoDaVez in objetosProximos)
        {
            if(objetoDaVez.gameObject.tag== "Item")
            {
                //se o objeto tiver a tag item, terá força aplicada 

                //por causa da explosão, o objeto tem q ir na direção oposta do player
                Vector3 direcao;
                direcao = transform.position - objetoDaVez.transform.position;
                direcao.Normalize(); //independente do tamanho do objeto, ele vai para a mesma direção

                objetoDaVez.gameObject.GetComponent<Rigidbody>().AddForce(-direcao * forca);//se tirar o menos da frente da direção, ele puxa
            }
        }

    }

    //cria um metodo q cria um gizmo vermelho a partir da posição do player
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, raioforca);
    }

   
}
