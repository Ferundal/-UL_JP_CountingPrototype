using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private bool isClickable;
    public bool isClicked;
    private Rigidbody targetRigidbody;

    [SerializeField] private Vector3 throwVelocity = new Vector3 (0, 5.0f, 5.0f);
    // Start is called before the first frame update
    void Start()
    {
        isClickable = false;
        isClicked = false;
        targetRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Conveyor Belt"))
        {
            isClickable = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals("Conveyor Belt"))
        {
            isClickable = false;
        }
    }

    private void OnMouseDown()
    {
        if (isClickable)
        {
            isClicked = true;
            targetRigidbody.velocity = throwVelocity;
        }
    }
}
