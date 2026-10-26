using UnityEngine;

public class Player2610 : MonoBehaviour
{
    public PlayerStatus meuStatus;

    Rigidbody rb;
    float speedMovimentacao = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        switch (meuStatus)
        {
            case PlayerStatus.Normal:
                GetComponent<Renderer>().material.color = Color.purple;
                Moves(1);
                break;
            case PlayerStatus.Paralizado:
                GetComponent<Renderer>().material.color = Color.yellow;
                Moves(0.5f);
                break;
            case PlayerStatus.Congelado:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case PlayerStatus.Envenenado:
                GetComponent<Renderer>().material.color = Color.blue;
                Moves(1);
                break;
        }
    }

    void Moves(float debuffSpeed)
    {
        float dirX, dirZ;
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector3(dirX, 0, dirZ) * speedMovimentacao * debuffSpeed;
        
    }
    
    void MudarAstatus (PlayerStatus newStatus)
    {
        if (meuStatus == PlayerStatus.Normal)
        {
            meuStatus = newStatus;
        }
    }

}
public enum PlayerStatus { Normal, Paralizado, Congelado, Envenenado}
