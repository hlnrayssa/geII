using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    public AudioMixerSnapshot menu;
    public AudioMixerSnapshot battle;
    public AudioMixerSnapshot walking;

    public AudioMixer meuMixer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per f[rame
    void Update()
    {
        // em game msm, pode usar por trigger ao inves de teclas


        if (Input.GetKeyUp(KeyCode.M))
        {
            menu.TransitionTo(3);
        }
        if (Input.GetKeyUp(KeyCode.N))
        {
            battle.TransitionTo(5);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            walking.TransitionTo(5);
        }

    }

    //gambiarra 01 do prof, pq não tem como igualar o volume do mixer com o volume audiosource
    public void UpdateVolume(float newVolume)
    {
        float volume;
        volume = Mathf.Log10(newVolume) * 20;
        meuMixer.SetFloat("VolumeMaster", volume);
    }

    //gambiarra 02, criada no BRASIL-SIL-SIL-SIL
    public void AlterarVolume(float newVolume)
    {
        float volume = 20f;
        if (newVolume > 0)
        {
            volume = volume * newVolume;
            volume -= 20;
        }
        else
        {
            volume = -80f;
        }
        meuMixer.SetFloat("VolumeMaster", volume);

    }
}
