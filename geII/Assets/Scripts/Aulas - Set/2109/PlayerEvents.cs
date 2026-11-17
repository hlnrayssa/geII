using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEvents : MonoBehaviour
{

    public static PlayerEvents Instance; //cria uma instância do script para ser acessado por outros scripts, sem precisar ficar criando o serialize field em todos

    public delegate void TodosEventos(); //declara a estrutura de um evento, que pode ser chamado por outros scripts, e que pode ter várias funções atreladas a ele

    public event TodosEventos Gritar;//serve para quando tem várias funções para um evento

    //public event Action Falar; //serve para realizar uma unica ação
    //public event Action<int> Gritar2;

    public UnityEvent MeuOnClick;
   


    public void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Gritar(); //quando este é chamado irá ativar funções em outros scripts
            //Falar();
            //Gritar2(5);
           
        }

        if(Input.GetKeyDown(KeyCode.U))
        {
            MeuOnClick.Invoke();
        }
    }
}
