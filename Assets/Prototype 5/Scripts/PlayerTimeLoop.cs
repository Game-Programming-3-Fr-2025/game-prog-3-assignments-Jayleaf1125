using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeLoop : MonoBehaviour
{
    public List<Vector3> positionSaves;
    public List<Vector3> scaleSaves;
    public List<float> rotationSaves;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionSaves = new List<Vector3>();
        scaleSaves = new List<Vector3>();
        rotationSaves = new List<float>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SavePositions();
        //}

        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    LoadPositions();
        //}
    }

    public void SavePositions()
    {
        Debug.LogWarning("Save");

        Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        Vector3 scale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        float rotation = this.transform.eulerAngles.z;

        positionSaves.Add(position);
        rotationSaves.Add(rotation);
        scaleSaves.Add(scale);
    }

    public void LoadPositions()
    {
        if (positionSaves.Count <= 0) return;

        for (int i = positionSaves.Count - 1; i >= 0; i--)
        {
            Load(i);
        }
    }

    void Load(int i)
    {
        Vector3 lastSavePos = positionSaves[i];
        float lastSaveRot = rotationSaves[i];
        Vector3 lastSaveScale = scaleSaves[i];

        this.transform.position = lastSavePos;
        this.transform.rotation = Quaternion.Euler(0, 0, lastSaveRot);
        this.transform.localScale = lastSaveScale;

        positionSaves.Remove(lastSavePos);
        rotationSaves.Remove(lastSaveRot);
        scaleSaves.Remove(lastSaveScale);
    }
}
