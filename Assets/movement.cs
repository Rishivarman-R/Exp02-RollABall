using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<Input>();
        xForce = 10.0f;
        yForce = 10.0f;
        zForce = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (input.GetKey(KeyCode.A))
        {
            x = x - xForce;
        }
        if (input.GetKey(KeyCode.D))
        {
            x = x - xForce;
        }
        if (input.GetKey(KeyCode.W))
        {
            z = z + zForce;
        }
        if (input.GetKey(KeyCode.S))
        {
            z = z - zForce;
        }
        if (input.GetKey(KeyCode.Space))
        {
            y = yForce;
        }
        GetComponent<rigidbody>().AddForce(x, y, z);

    }
    
}
