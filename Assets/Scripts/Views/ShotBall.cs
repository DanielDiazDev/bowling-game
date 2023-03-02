using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Rigidbody ballRigidbody;
    private void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }

    public void Shot()
    {
        Vector3 direction = new Vector3(0, 0, -2); 
        float force = 1000f; 

        ballRigidbody.AddForce(direction * force);
    }

}
