using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTriggerUI : MonoBehaviour
{
    public Text textField;
    bool Colliding = false;

    public GameObject Player;
    public Vector3 teleportLocation;
    public Quaternion teleportRotation;
    public string customText;

    public bool isDoor = false;

    public bool isPickable = false;
    public GameObject actualObject;

    public bool isHeli = false;
    public GameObject enableObject;

    public bool exitWindow = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actionFunction();
    }

    public void actionFunction() 
    {
        if (isDoor)
        {
            if (Colliding && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Teleport");
                Player.transform.position = teleportLocation;
                Player.transform.rotation = teleportRotation;
            }
        }
        else if (isPickable)
        {
            if (Colliding && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Picked up object");
                textField.text = "";
                Destroy(actualObject);
                Destroy(this.gameObject);
            }
        }
        else if (isHeli)
        {
            if (Colliding && Input.GetKeyDown(KeyCode.E))
            {
                textField.text = "";
                enableObject.SetActive(true);
                Player.SetActive(false);
            }
        }
        else if (exitWindow) {

            if (Colliding && Input.GetKeyDown(KeyCode.E))
            {
                textField.text = "";
                enableObject.SetActive(true);
                actualObject.SetActive(false);
                Destroy(this.gameObject);
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        textField.text = customText;
        Colliding = true;
    }

    void OnTriggerExit(Collider other)
    {
        textField.text = "";
        Colliding = false;
    }


}
