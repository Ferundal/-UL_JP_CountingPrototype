using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TrashGeneratorScript trashGeneratorScript;
    [SerializeField] private TextMeshProUGUI totalTrashText;

    [SerializeField] private int totalTrashAmount = 20;
    private int successTrashSorts;
    [SerializeField] private TextMeshProUGUI successTrashText;

    private void Awake()
    {
        totalTrashText.SetText("Total: " + totalTrashAmount);
        successTrashSorts = 0;
        successTrashText.SetText("Success: " + successTrashSorts);
    }
    // Start is called before the first frame update
    void Start()
    {
        trashGeneratorScript.StartSpawn(totalTrashAmount);
    }

    void LateStart()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSuccessfulSort()
    {
        ++successTrashSorts;
        successTrashText.SetText("Success: " + successTrashSorts);
    }
}
