using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private Vector3 charPos;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _camera;
    private int sayi;


     void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charPos = transform.position;
        sayi = 1;
    }

    private void FixedUpdate()
    {
        
        //r2d.velocity = new Vector2(x: speed, y: 0f);
        sayi = 2;
    }
    void Update()
    {
        charPos = new Vector3(x: charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;
        if(Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat(name:"speed", value:0.0f);
        }
        else
        {
            _animator.SetFloat(name: "speed", value:1.0f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        }else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
        
        sayi = 3;
        Debug.Log(message: "Update" + sayi);
    }

    private void LateUpdate()
    {
        //_camera.transform.position = new Vector3(charPos.x, charPos.y, z:charPos.z - 1.0f);
        sayi = 4;
    }
}
