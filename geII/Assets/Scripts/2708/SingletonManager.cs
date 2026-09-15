using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    public static SingletonManager Instance;

    public int vida = 100;

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Instance = this;
        
        }
    }
}
