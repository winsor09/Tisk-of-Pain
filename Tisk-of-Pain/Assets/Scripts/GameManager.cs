using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer = 0f;
    float time2goal = 6000f;
    static GameManager instance;

    public static GameManager Instance
    {
        get { return instance ?? ((instance = new GameManager())); }
    }

    public Character MyCharacter
    {
        get; set;
    }

    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }

    private void Update()
    {
        timer += Time.deltaTime;

    }

    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}