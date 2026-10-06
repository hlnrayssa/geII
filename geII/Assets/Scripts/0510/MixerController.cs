using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    public AudioMixerSnapshot menu;
    public AudioMixerSnapshot battle;
    public AudioMixerSnapshot walking;
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
            menu.TransitionTo(1);
        }
        if (Input.GetKeyUp(KeyCode.N))
        {
            battle.TransitionTo(3);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            walking.TransitionTo(5);
        }

    }
}
