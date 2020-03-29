using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    [SerializeField] private int _damage = 1;
    private Vector3 _direction;
    private Vector3 _scale;
    void Start()
    {
        _direction = new Vector3(GameObject.Find("charckter").transform.localScale.x,0,0);
        _scale = new Vector3(_direction.x,1,1);
        transform.localScale = _scale;
        Destroy(gameObject, _lifeTime);

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += _direction  * _speed * Time.deltaTime;
        //transform.localScale = _scale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) Destroy(gameObject, 0);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<My_enemy>();
            enemy.Hurt(_damage);
        }
        
    }
}
