using UnityEngine;

public class Player0510 : MonoBehaviour
{
    public AudioClip audioColisao;
    AudioSource audioSource;

    public AudioClip musicaBGM;
    public AudioClip battleFight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pular();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            audioSource.volume += 0.1f;
            Debug.Log("Aumentou");

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.volume -= 0.1f;
            Debug.Log("Diminuiu");
        }

        if ((Input.GetKeyDown(KeyCode.Tab)))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
                Debug.Log("Pause");
            }
            else
            {
                audioSource.Play();
                Debug.Log("Play");
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            audioSource.Stop();
            Debug.Log("Parou");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            audioSource.clip = musicaBGM;
            Debug.Log("BGM");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.clip = battleFight;
            Debug.Log("Battle");
        }


    }

    void Pular()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Tocou");
        //audioSource.Play();
        AudioSource.PlayClipAtPoint(audioColisao, transform.position);
    }
}
