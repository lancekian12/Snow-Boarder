using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    CircleCollider2D playerHead;
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool crash = true;


    private void Start()
    {
        playerHead = GetComponent<CircleCollider2D>();
    }
    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.tag == "Ground")
    //     {
    //         Debug.Log("You bumped");
    //     }
    // }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" && playerHead.IsTouching(other.collider) && crash)
        {
            FindAnyObjectByType<PlayerController>().DisabledControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
            crash = false;

        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
