using UnityEngine;

public class inimigo : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        PlayerEvents.Instance.Gritar += PintarDeVermelho;
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
