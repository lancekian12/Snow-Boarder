using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] ParticleSystem dustTrailEffect;
    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrailEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustTrailEffect.Stop();
        }
    }
}
