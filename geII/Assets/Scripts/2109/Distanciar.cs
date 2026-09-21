using UnityEngine;

public class Distanciar : MonoBehaviour
{
    void OnEnable()
    {
        PlayerEvents.Instance.Gritar += DistanciarObjetos;
    }
    private void OnDisable()
    {
        PlayerEvents.Instance.Gritar -= DistanciarObjetos;
    }

    void DistanciarObjetos()
    {
        transform.position = transform.position + new Vector3(1f, 0, 0);
    }
}
