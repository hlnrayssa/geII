using UnityEngine;

public class Rodar : MonoBehaviour
{
    void OnEnable()
    {
        //PlayerEvents.Instance.Gritar += Rodar30;
    }
    private void OnDisable()
    {
        //PlayerEvents.Instance.Gritar -= Rodar30;
    }
    void Rodar30()
    {
        transform.Rotate(0, 0, 30);
    }
}
 