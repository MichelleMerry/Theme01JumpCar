using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDown : MonoBehaviour
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
        transform.Translate(Vector3.back * _speed * Time.deltaTime);

        if (transform.position.z < -18f)
        {
            transform.position = new Vector3(0, 0, 32);
        }
    }
}
