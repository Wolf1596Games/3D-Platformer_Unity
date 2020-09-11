using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int itemsRemaining;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if(itemsRemaining <= 0)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currenSceneIndex + 1);
    }

    public void CountItems()
    {
        itemsRemaining++;
    }

    public void ItemDestroyed()
    {
        itemsRemaining--;
    }
}
