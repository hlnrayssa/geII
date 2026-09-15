using Unity.VisualScripting;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject item;
    public GameObject spawnDir;
    public GameObject spawnEsq;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(item, spawnDir.transform.position, Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(item, spawnEsq.transform.position, Quaternion.identity);
        }

    }

}