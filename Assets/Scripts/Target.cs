using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem explosition;

    private Rigidbody targetRb;

    private float minSpeed = 30.0f;
    private float maxSpeed = 40.0f;

    private float minTorque = -1.0f;
    private float maxTorque = 1.0f;

    private float xRange = 6.0f;
    private float yRange = -10;

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(0, RandomTorque(), 0, ForceMode.Impulse);
        transform.position = RandomPosition();
    }

    void Update()
    {
        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Instantiate(explosition, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(minTorque, maxTorque);
    }

    Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(xRange, -xRange), yRange);
    }
}
