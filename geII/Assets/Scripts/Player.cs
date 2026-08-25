using UnityEngine;
using UnityEngine.Video;

public class Player : MonoBehaviour
{

    public static Player Instance;
    public string nome = "José";
    public int ataque;
    public static int level = 1;
    public int vida = 100;


    public void Awake()
    {
       
            Instance = this;
   
    }

    private void Update()
    {
        //informações no console
        Debug.Log("Nome: "+ nome + "; Vida: " + vida);
    }
}
