using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcherController : MonoBehaviour
{
    [SerializeField] private GameObject _appleGeneratorField;
    [SerializeField] private int _fallingAppleAmount = 10;

    private bool _paused = false; // set the game to 

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

    public void SwitchPause()
    {
        _paused = !_paused;
    }

    // stop time depends on if pause has been triggered
    // This stops time.deltatime, but it does not stop anything in fixedUpdate
    private void StopTime()
    {
        if (_paused)
        {
            Debug.Log("Time paused");
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Unpaused");
            Time.timeScale = 1;
        }
    }
}
