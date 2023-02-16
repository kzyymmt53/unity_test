using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _speed = 8.0f;
    private bool _isEnemyLaser = false;


    // Update is called once per frame
    void Update()
    {
        if(_isEnemyLaser == false){
            Debug.Log("Up");
            CalculateMovement();
        }else{
            Debug.Log("down2");
            CalculateMovementDown();
        }
       
    }

    void CalculateMovement()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if(transform.position.y > 8.0f)
        {
            if(transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }

    }

    void CalculateMovementDown()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        Debug.Log("down");
        Debug.Log(transform.position.y);

        if(transform.position.y < -8f)
        {
            if(transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }

    }

    public void AssignEnemyLaser() {
        _isEnemyLaser = true;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && _isEnemyLaser == true){
            Player player = other.GetComponent<Player>();
            if(player != null){
                player.Damage();
            }
        }
        
    }
}
