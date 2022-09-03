using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltScript : MonoBehaviour
{
    [SerializeField] private float beltSpeed = 100.0f;
    [SerializeField] Vector3 direction = Vector3.right;
    private List<GameObject> onBeltObjects;
    // Start is called before the first frame update
    void Start()
    {
        onBeltObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject currentOnBelt in onBeltObjects)
        {
            if (!(currentOnBelt.GetComponent<Target>().isClicked))
            {
                currentOnBelt.GetComponent<Rigidbody>().velocity = beltSpeed * Time.deltaTime * direction;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        onBeltObjects.Add(collision.gameObject);
    }
    private void OnCollisionExit(Collision collision)
    {
        onBeltObjects.Remove(collision.gameObject);
    }
}
