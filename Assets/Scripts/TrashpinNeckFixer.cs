using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashpinNeckFixer : MonoBehaviour
{
    private Vector3 neckCenterPosition;
    // Start is called before the first frame update
    void Start()
    {
        neckCenterPosition = this.transform.parent.transform.position;
        neckCenterPosition.y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().velocity = neckCenterPosition - collision.gameObject.transform.position;
    }
}
