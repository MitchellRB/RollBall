using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalBehaviour : MonoBehaviour
{
    public string NextLevel;
    public Text loadingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && SceneManager.GetActiveScene().name != NextLevel && NextLevel != string.Empty)
        {
            if (loadingText != null)
            {
                loadingText.enabled = true;
            }
            SceneManager.LoadScene(NextLevel, LoadSceneMode.Single);
        }
    }
}
