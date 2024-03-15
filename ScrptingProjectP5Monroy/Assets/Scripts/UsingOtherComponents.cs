using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yettAnotherScript;
    private BoxCollider boxCol;

    // Start is called before the first frame update
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The players score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yettAnotherScript.numberOfPlayerDeaths + "times");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
