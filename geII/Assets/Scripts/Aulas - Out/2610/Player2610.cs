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
        MudarStatus(PlayerStatus.Normal);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MudarStatus(PlayerStatus.Normal);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MudarStatus(PlayerStatus.Paralizado);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            MudarStatus(PlayerStatus.Congelado);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MudarStatus(PlayerStatus.Envenenado);
        }

        UpdateStatus();
    }

    #region Movimentacao
    void Moves(float debuffSpeed)
    {
        float dirX, dirZ;
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector3(dirX, 0, dirZ) * speedMovimentacao * debuffSpeed;

    }
    #endregion
    void MudarStatus(PlayerStatus newStatus)
    {
        ExitStatus(meuStatus);
        EnterStatus(newStatus);

        meuStatus = newStatus;
    }

    void UpdateStatus()
    {
        switch (meuStatus)
        {
            case PlayerStatus.Normal:
                Moves(1);
                break;
            case PlayerStatus.Paralizado:
                Moves(0.5f);
                break;
            case PlayerStatus.Congelado:
                break;
            case PlayerStatus.Envenenado:
                Moves(1);
                break;
        }

    }

    void EnterStatus(PlayerStatus novoStatus)
    {
        switch (novoStatus)
        {
            case PlayerStatus.Normal:
                GetComponent<Renderer>().material.color = Color.purple;
                break;
            case PlayerStatus.Paralizado:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case PlayerStatus.Congelado:
                GetComponent<Renderer>().material.color = Color.green;
                transform.localScale *= 2f;
                break;
            case PlayerStatus.Envenenado:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
        }
    }
    void ExitStatus(PlayerStatus oldStatus)
    {
        switch (oldStatus)
        {
            case PlayerStatus.Congelado:
                GetComponent<Renderer>().material.color = Color.green;
                transform.localScale *= 0.5f;
                break;
        }
    }

}
public enum PlayerStatus { Normal, Paralizado, Congelado, Envenenado}
