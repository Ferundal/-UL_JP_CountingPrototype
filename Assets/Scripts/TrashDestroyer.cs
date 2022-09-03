using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDestroyer : MonoBehaviour
{
    private TrashbinManager trashbinManager;
    private GameManager gameManager;
    // Start is called before the first frame update

    void Awake()
    {
        trashbinManager = this.transform.parent.GetChild(3).gameObject.GetComponent<TrashbinManager>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        --(trashbinManager.activeTrashCounter);
        if (trashbinManager.gameObject.CompareTag(collision.gameObject.tag))
        {
            gameManager.AddSuccessfulSort();
        }
    }
}
