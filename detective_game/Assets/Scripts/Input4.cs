using UnityEngine;
using UnityEngine.UI;

public class Input4 : MonoBehaviour
{
    [SerializeField] InputField n4;
    [SerializeField] InputField n5;
    [SerializeField] InputField n6;
    public InputField[] inputFields = new InputField[3];
    private void Start()
    {
        inputFields[0] = n4;
        inputFields[1] = n5;
        inputFields[2] = n6;
        foreach (InputField inputField in inputFields)
        {
            if (inputField != null)
            {
                inputField.characterLimit = 1; // Устанавливаем ограничение на один символ
                inputField.onValueChanged.AddListener(OnInputFieldValueChanged); // Подписываемся на событие изменения значения
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
                        nextInputField.ActivateInputField(); // Активируем следующее поле ввода
                    }
                }
                else
                {
                    currentInputField.DeactivateInputField(); // Деактивируем текущее поле ввода, если достигнут конец массива
                }
            }
        }
    }
}
