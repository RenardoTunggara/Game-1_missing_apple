using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
class restart : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("test");

    }
}
