using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);

        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
