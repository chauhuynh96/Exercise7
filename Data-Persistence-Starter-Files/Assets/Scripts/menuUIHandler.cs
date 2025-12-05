using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class menuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        DataBetweenScene.playerName = nameInput.text;
        SceneManager.LoadScene(1);
    }
}
