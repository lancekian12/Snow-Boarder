using UnityEngine;

public class RollDown : MonoBehaviour
{
    [SerializeField] float rollSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rollDown = Input.GetAxis("Horizontal") * rollSpeed * Time.deltaTime;
        transform.Translate(0, rollDown, 0);
    }
}
