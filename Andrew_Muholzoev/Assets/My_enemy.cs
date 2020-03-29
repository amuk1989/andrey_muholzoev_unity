using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_enemy : MonoBehaviour
{
    [SerializeField] private int _healthPoints;
    [SerializeField] private float _speed;

    private Vector3 _direction; // направление
    private GameObject _destination; // куда бежать
    //private SpriteRenderer sprite;
    private GameObject _player; //объект - игрок
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("charckter");
        _destination = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        _direction = _destination.transform.position - gameObject.transform.position;
        transform.position += _direction * _speed * Time.deltaTime;
        //MoveTo(gameObject.transform.position.x - _destination.x);
    }

    public void Hurt(int damage)
    {
        _healthPoints -= damage;
        //sprite.color = Color.red;
        if (_healthPoints <= 0) Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _player)
        {
            _destination = _player; //задали точку назначения - игрок
        }
    }

   
}
