using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float MovementSpeed = 10;

    private Rigidbody2D _Rigidbody2D;
    private float _Movement = 0f;

    // Use this for initialization
    void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
		
    }
	
    // Update is called once per frame
    void Update()
    {
        _Movement = Input.GetAxis("Horizontal") * MovementSpeed;
        if (_Movement > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (_Movement < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = _Rigidbody2D.velocity;
        velocity.x = _Movement;
        _Rigidbody2D.velocity = velocity;
    }

}
