using UnityEngine;


public class mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody variavel;
    void Start()
    {
        variavel.AddForce(0, 20, 800);
    }

    // Update is called once per frame
    void Update()
    {
        variavel.AddForce(0, 0, 5);
    }
}
