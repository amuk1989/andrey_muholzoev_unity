using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var speed = transform.right * _speed * Time.deltaTime;
        transform.position += speed;
    }
}
