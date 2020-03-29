using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpSpeed = 1;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private GameObject StartBullet;
    //Vector3 vector = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputSpeed = Input.GetAxis("Horizontal") * _speed *Time.deltaTime;
        var jumpSpeed = Input.GetAxis("Jump") * _jumpSpeed *Time.deltaTime;
        var velocity = transform.right * inputSpeed;
        var velocityJump = transform.up * jumpSpeed;
        transform.position += velocity;
        transform.position += velocityJump;
        //transform.localScale = new Vector3(Input.GetAxis("Horizontal"),1,1);
        if (Input.GetKeyDown(KeyCode.D)) gameObject.transform.localScale = new Vector3(1,1,1);
        if (Input.GetKeyDown(KeyCode.A)) gameObject.transform.localScale = new Vector3(-1,1,1);
        if (Input.GetButton("Fire1")) Fire();
    }

    private void Fire()
    {
        Instantiate(Bullet, StartBullet.transform.position, StartBullet.transform.rotation);
    }
}
