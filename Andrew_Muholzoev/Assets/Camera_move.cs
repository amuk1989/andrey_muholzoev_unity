using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject _charakter;
    private Vector3 _position;
    
    void Start()
    {
        _charakter = GameObject.Find("charckter");
        _position = new Vector3(_charakter.transform.position.x, _charakter.transform.position.y, gameObject.transform.position.z);
        //print(_charakter.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        _position = new Vector3(_charakter.transform.position.x, _charakter.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = _position;
    }
}
