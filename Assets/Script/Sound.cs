using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip musica1;
 

    private AudioSource audioSource;
    private bool tocandoMusica1 = true;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.clip = musica1;
        audioSource.Play();
    }


}
