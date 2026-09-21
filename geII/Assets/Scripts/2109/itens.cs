using UnityEngine;

public class itens : MonoBehaviour
{
 
    void OnEnable()
    {
        PlayerEvents.Instance.Gritar += AumentarTamanho;
    }

 
    private void OnDisable()
    {
        PlayerEvents.Instance.Gritar -= AumentarTamanho;
    }

    void AumentarTamanho()
    {

        transform.localScale *= 2f;
    }
}
