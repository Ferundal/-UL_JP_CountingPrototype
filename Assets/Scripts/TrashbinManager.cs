using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashbinManager : MonoBehaviour
{
    private GameObject trashbinLid;
    public int activeTrashCounter;
    public int trashCounter;
    [SerializeField] private Vector3 trashbinLidRotation;
    private Quaternion startTrashbinLidRotation;
    // Start is called before the first frame update
    void Awake()
    {
        trashbinLid = this.transform.parent.GetChild(0).gameObject;
        startTrashbinLidRotation = trashbinLid.transform.rotation;
        activeTrashCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTrashCounter == 0)
        {
            trashbinLid.transform.rotation = startTrashbinLidRotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (activeTrashCounter == 0)
        {
            trashbinLid.transform.Rotate(trashbinLidRotation, Space.Self);
        }
        Debug.Log("Increase Active " + other.name);
        ++activeTrashCounter;
    }
}
