using UnityEngine;
using UnityEngine.UI;

public class Input2 : MonoBehaviour
{
    [SerializeField] InputField t1;
    [SerializeField] InputField t2;
    [SerializeField] InputField t3;
    [SerializeField] InputField t4;
    [SerializeField] InputField t5;
    [SerializeField] InputField t6;
    [SerializeField] InputField t7;
    public InputField[] inputFields = new InputField[7];
    private void Start()
    {
        inputFields[0] = t1;
        inputFields[1] = t2;
        inputFields[2] = t3;
        inputFields[3] = t4;
        inputFields[4] = t5;
        inputFields[5] = t6;
        inputFields[6] = t7;
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
