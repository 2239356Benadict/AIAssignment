using UnityEngine;
using UnityEngine.UI;

public class SpaceshipController : MonoBehaviour
{
    public float speed = 5f; // Initial speed of the spaceship
    public float rotationSpeed = 100f; // Rotation speed of the spaceship

    public Slider speedSlider;
    public Button leftButton, rightButton, forwardButton, backwardButton;
    public Toggle autopilotButton;

    private bool autopilotActive = false;

    void Start()
    {
        // Add onClick listeners to the buttons
        leftButton.onClick.AddListener(TurnLeft);
        rightButton.onClick.AddListener(TurnRight);
        forwardButton.onClick.AddListener(MoveForward);
        backwardButton.onClick.AddListener(MoveBackward);
        autopilotButton.onValueChanged.AddListener(ToggleAutopilot);

        // Add listener to the speed slider
        speedSlider.onValueChanged.AddListener(ChangeSpeed);
    }

    void Update()
    {
        if (autopilotActive)
        {
            Autopilot();
        }
    }

    void TurnLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    void TurnRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void MoveBackward()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void Autopilot()
    {
        // Add your autopilot logic here
        // This function will be called when autopilot is active
    }

    void ToggleAutopilot(bool isOn)
    {
        autopilotActive = isOn;
    }

    void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
