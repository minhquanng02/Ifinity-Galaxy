using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    [SerializeField] private GameObject player;
    //private IUnit unit;

    Vector3 playerPosition;

    private void Awake() {
        //unit = unitGameObject.GetComponent<IUnit>();
        SaveSystem.Init();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.K)) {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            Load();
        }
    }

    private void Save() {
        // Save
        playerPosition = player.transform.position;

        SaveObject saveObject = new SaveObject { 
            playerPosition = playerPosition
        };
        string json = JsonUtility.ToJson(saveObject);
        SaveSystem.Save(json);

        Debug.Log("Saved!");
        
    }

    private void Load() {
        // Load
        string saveString = SaveSystem.Load();
        if (saveString != null) {
            Debug.Log("Loaded: " + saveString);

            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);

            //unit.SetPosition(saveObject.playerPosition);
            player.transform.position = playerPosition;
        } else {
            Debug.Log("No save");
        }
    }


    private class SaveObject {
        public Vector3 playerPosition;
    }
}