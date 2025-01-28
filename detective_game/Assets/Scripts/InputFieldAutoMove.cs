using UnityEngine;
using UnityEngine.UI;
public class InputFieldAutoMove : MonoBehaviour
{
    [SerializeField] InputField o1;
    [SerializeField] InputField o2;
    [SerializeField] InputField o3;
    [SerializeField] InputField o4;
    [SerializeField] InputField o5;
    [SerializeField] InputField o6;
    [SerializeField] InputField o7;
    public InputField[] inputFields = new InputField[7];
    private void Start()
    {
        inputFields[0] = o1;
        inputFields[1] = o2;
        inputFields[2] = o3;
        inputFields[3] = o4;
        inputFields[4] = o5;
        inputFields[5] = o6;
        inputFields[6] = o7;
        foreach (InputField inputField in inputFields)
        {
            if (inputField != null)
            {
                inputField.characterLimit = 1; 
                inputField.onValueChanged.AddListener(OnInputFieldValueChanged); 
            }
        }
    }
    private void OnInputFieldValueChanged(string value)
    {
        if (value.Length == 1)
        {
            char enteredChar = value[0];
            InputField currentInputField = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject?.GetComponent<InputField>();
            if (currentInputField != null)
            {
                int currentInputFieldIndex = System.Array.IndexOf(inputFields, currentInputField);

                if (currentInputFieldIndex < inputFields.Length - 1)
                {
                    InputField nextInputField = inputFields[currentInputFieldIndex + 1];
                    if (nextInputField != null && nextInputField.text.Length == 0)
                    {
                        nextInputField.text = enteredChar.ToString();
                        nextInputField.Select();
                        nextInputField.ActivateInputField();
                    }
                }
                else
                {
                    currentInputField.DeactivateInputField(); 
                }
            }
        }
    }
}