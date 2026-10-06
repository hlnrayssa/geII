using UnityEngine;
using UnityEngine.UI;

public class BarraSom : MonoBehaviour
{
    public AudioSource audioSource;


    private void Start()
    {
        audioSource.volume = GetComponent<Slider>().value;
    }
    public void AtualizarVolume(float novoVolume)
    {
        audioSource.volume = novoVolume;
    }
}
