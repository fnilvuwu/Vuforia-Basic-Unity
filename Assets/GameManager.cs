using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class GameManager : MonoBehaviour
{
    // Method to start the game and move to "SampleScene"
    public void StartGame()
    {
        // Load the scene named "SampleScene"
        SceneManager.LoadScene("SampleScene");
    }

    // Method to exit the game
    public void ExitGame()
    {
        // Log a message in the editor (useful for debugging in the Unity Editor)
        Debug.Log("Exiting Game...");
        // Exit the application
        Application.Quit();
    }
}
