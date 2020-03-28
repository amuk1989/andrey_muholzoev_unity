using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputSpeed = Input.GetAxis("Horizontal") * _speed *Time.deltaTime;
        var velocity = transform.right

    }
}
