using UnityEngine;

public class inimigo : MonoBehaviour
{
    [SerializeField]
    PlayerEvents player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
       player.Gritar += PintarDeVermelho;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PintarDeVermelho()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
