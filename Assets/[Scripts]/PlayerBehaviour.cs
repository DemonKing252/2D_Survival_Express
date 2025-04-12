using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // return type, function name, () -> arguments
    string GetMessage()  // def GetMessage() -> String
    {
        var message = "Pressing W!"; // message = str("Pressing W")
        return message;
    }

    // Called once whenever you run the game
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log(GetMessage());
        }
    }
}
