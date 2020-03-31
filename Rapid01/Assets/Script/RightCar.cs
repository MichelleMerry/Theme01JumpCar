using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCar : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);


        if (transform.position.x < -16f)
        {
            transform.position = new Vector3(Random.Range( 12, 8),0, 0);
        }

    }
}
