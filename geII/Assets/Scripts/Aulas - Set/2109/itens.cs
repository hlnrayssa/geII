using UnityEngine;

public class itens : MonoBehaviour
{
    [SerializeField]
    PlayerEvents player;


    void OnEnable()
    {
        //PlayerEvents.Instance.Gritar += AumentarTamanho;
        //PlayerEvents.Instance.Gritar2 += AumentarAction;
    }

 
    private void OnDisable()
    {
        //PlayerEvents.Instance.Gritar -= AumentarTamanho;
       //PlayerEvents.Instance.Gritar2 -= AumentarAction;
    }

    void AumentarTamanho()
    {

        transform.localScale *= 2f;
    }

    void AumentarAction(int num)
    {
        transform.localScale *= num;
    }
}
