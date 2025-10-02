using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    Dictionary<string, GameObject> _inventory = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Next Feature: ADD a tutorial UI that has the player go to the key, then to the door and then after they are done, the UI says, good luck

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject item = collision.gameObject;
        string itemName = item.tag;

        switch (itemName)
        {
            case "Key":
                AddItemToInventory(itemName, item);
                break;
            case "Door":
                OpenDoor(item);
                break;
        }
    }

    void AddItemToInventory(string name, GameObject itemObj) 
    {
        //Debug.Log($"{name} has been added to your inventory");
        _inventory.Add(name, itemObj); 
        Destroy(itemObj);
    }

    void OpenDoor(GameObject door)
    {
        if (!_inventory.ContainsKey("Key"))
        {
            //Debug.Log("You have no key");
            return;
        }

        //Debug.Log("Door has opened");
        Destroy(door);
        _inventory.Remove("Key");
    }
}
