using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcherController : MonoBehaviour
{
    public bool _paused = false; // set the game to 

    [SerializeField] private GameObject _appleGeneratorField;
    [SerializeField] private int _fallingAppleAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StopTime();
    }

    public void DroppingApples()
    {
        float temp = Random.Range(0, 3);
        Invoke(nameof(GenerateApple), temp);
    }

    void GenerateApple()
    {
        _appleGeneratorField.GetComponent<FallingItems>().SpawnObject(); // spawn the apple
    }

    // stop time depends on if pause has been triggered
    // This stops time.deltatime, but it does not stop anything in fixedUpdate
    private void StopTime()
    {
        if (_paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
