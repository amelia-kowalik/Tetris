using UnityEngine;

public class Block : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool _hasLanded = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Block")
        {
            _hasLanded = true;
            _rb.linearVelocity = Vector2.zero;
            _rb.simulated = false;
        }
    }
}
