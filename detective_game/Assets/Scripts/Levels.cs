using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Levels : MonoBehaviour
{
    [SerializeField] InputField Answer1;
    public void CheckAnswer()
    {
        string rightAnswer1 = "Кладбище самолетов";
        string rightAnswer2 = "Кладбище Самолетов";
        string rightAnswer3 = "кладбище самолетов";
        string rightAnswer4 = "Кладбище самолётов";
        string rightAnswer5 = "Кладбище Самолётов";
        string rightanswer6 = "кладбище самолётов";
        string user = Answer1.text;
        if (user == rightAnswer1 || user == rightAnswer2 || user == rightAnswer3 || user == rightAnswer4 || user == rightAnswer5 || user == rightanswer6)
        {
            SceneManager.LoadScene("Answer1");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer");
        }
    }
    [SerializeField] InputField Answer2;
    public void CheckAnswer2()
    {
        string rightAnswer1 = "Угроза";
        string rightAnswer2 = "угроза";
        string rightAnswer3 = "УГРОЗА";
        string user2 = Answer2.text;
        if (user2 == rightAnswer1 || user2 == rightAnswer2 || user2 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer2");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer1");
        }
    }
    [SerializeField] InputField Answer3;
    public void CheckAnswer3()
    {
        string rightAnswer1 = "Рай";
        string rightAnswer2 = "рай";
        string rightAnswer3 = "РАЙ";
        string user3 = Answer3.text;
        if (user3 == rightAnswer1 || user3 == rightAnswer2 || user3 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer3");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer2");
        }
    }
    [SerializeField] InputField Answer4;
    public void CheckAnswer4()
    {
        string rightAnswer1 = "Гнев";
        string rightAnswer2 = "гнев";
        string rightAnswer3 = "ГНЕВ";
        string user4 = Answer4.text;
        if (user4 == rightAnswer1 || user4 == rightAnswer2 || user4 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer4");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer3");
        }
    }
    [SerializeField] InputField Answer5;
    public void CheckAnswer5()
    {
        string rightAnswer1 = "Сон";
        string rightAnswer2 = "сон";
        string rightAnswer3 = "СОН";
        string user5 = Answer5.text;
        if (user5 == rightAnswer1 || user5 == rightAnswer2 || user5 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer5");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer4");
        }
    }
    [SerializeField] InputField Answer6;
    public void CheckAnswer6()
    {
        string rightAnswer = "112";
        string user6 = Answer6.text;
        if (user6 == rightAnswer)
        {
            SceneManager.LoadScene("Answer6");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer5");
        }
    }
    [SerializeField] InputField Answer7;
    public void CheckAnswer7()
    {
        string rightAnswer1 = "Паркер";
        string rightAnswer2 = "паркер";
        string rightAnswer3 = "ПАРКЕР";
        string user7 = Answer7.text;
        if (user7 == rightAnswer1 || user7 == rightAnswer2 || user7 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer7");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer6");
        }
    }
    [SerializeField] InputField Answer8;
    public void CheckAnswer8()
    {
        string rightAnswer1 = "Звезда";
        string rightAnswer2 = "звезда";
        string rightAnswer3 = "ЗВЕЗДА";
        string user8 = Answer8.text;
        if (user8 == rightAnswer1 || user8 == rightAnswer2 || user8 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer8");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer7");
        }
    }
    [SerializeField] InputField Answer9;
    public void CheckAnswer9()
    {
        string rightAnswer1 = "Уилсон";
        string rightAnswer2 = "уилсон";
        string rightAnswer3 = "УИЛСОН";
        string user9 = Answer9.text;
        if (user9 == rightAnswer1 || user9 == rightAnswer2 || user9 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer9");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer8");
        }
    }
    [SerializeField] InputField Answer10;
    public void CheckAnswer10()
    {
        string rightAnswer1 = "Караван";
        string rightAnswer2 = "караван";
        string rightAnswer3 = "КАРАВАН";
        string user10 = Answer10.text;
        if (user10 == rightAnswer1 || user10 == rightAnswer2 || user10 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer10");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer9");
        }
    }
    [SerializeField] InputField Answer11;
    public void CheckAnswer11()
    {
        string rightAnswer1 = "титаник";
        string rightAnswer2 = "Титаник";
        string rightAnswer3 = "ТИТАНИК";
        string user11 = Answer11.text;
        if (user11 == rightAnswer1 || user11 == rightAnswer2 || user11 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer11");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer10");
        }
    }
    [SerializeField] InputField Answer12;
    public void CheckAnswer12()
    {
        string rightAnswer1 = "Топливо";
        string rightAnswer2 = "топливо";
        string rightAnswer3 = "ТОПЛИВО";
        string user12 = Answer12.text;
        if (user12 == rightAnswer1 || user12 == rightAnswer2 || user12 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer12");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer11");
        }
    }
    [SerializeField] InputField Answer13;
    public void CheckAnswer13()
    {
        string rightAnswer1 = "Забвение";
        string rightAnswer2 = "забвение";
        string rightAnswer3 = "ЗАБВЕНИЕ";
        string user13 = Answer13.text;
        if (user13 == rightAnswer1 || user13 == rightAnswer2 || user13 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer13");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer12");
        }
    }
    [SerializeField] InputField Answer14;
    public void CheckAnswer14()
    {
        string rightAnswer1 = "Ярослав Сейферт";
        string user14 = Answer14.text;
        if (user14 == rightAnswer1)
        {
            SceneManager.LoadScene("Answer14");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer13");
        }
    }
    [SerializeField] InputField Answer15;
    public void CheckAnswer15()
    {
        string rightAnswer1 = "Атолл";
        string rightAnswer2 = "атолл";
        string rightAnswer3 = "АТОЛЛ";
        string user15 = Answer15.text;
        if (user15 == rightAnswer1 || user15 == rightAnswer2 || user15 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer15");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer14");
        }
    }
    [SerializeField] InputField Answer16;
    public void CheckAnswer16()
    {
        string rightAnswer1 = "Приказ";
        string rightAnswer2 = "приказ";
        string rightAnswer3 = "ПРИКАЗ";
        string user16 = Answer16.text;
        if (user16 == rightAnswer1 || user16 == rightAnswer2 || user16 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer16");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer15");
        }
    }
    [SerializeField] InputField Answer17;
    public void CheckAnswer17()
    {
        string rightAnswer1 = "Тут лес";
        string rightAnswer2 = "Тут Лес";
        string rightAnswer3 = "тут лес";
        string rightAnswer4 = "ТУТ ЛЕС";
        string user17 = Answer17.text;
        if (user17 == rightAnswer1 || user17 == rightAnswer2 || user17 == rightAnswer3 || user17 == rightAnswer4)
        {
            SceneManager.LoadScene("Answer17");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer16");
        }
    }
    [SerializeField] InputField Answer18;
    public void CheckAnswer18()
    {
        string rightAnswer1 = "Абрис";
        string rightAnswer2 = "абрис";
        string rightAnswer3 = "АБРИС";
        string user18 = Answer18.text;
        if (user18 == rightAnswer1 || user18 == rightAnswer2 || user18 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer18");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer17");
        }
    }
    [SerializeField] InputField Answer19;
    public void CheckAnswer19()
    {
        string rightAnswer1 = "нейрохимия";
        string rightAnswer2 = "Нейрохимия";
        string rightAnswer3 = "НЕЙРОХИМИЯ";
        string user19 = Answer19.text;
        if (user19 == rightAnswer1 || user19 == rightAnswer2 || user19 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer19");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer18");
        }
    }
    [SerializeField] InputField Answer20;
    public void CheckAnswer20()
    {
        string rightAnswer1 = "3416";
        string user20 = Answer20.text;
        if (user20 == rightAnswer1)
        {
            SceneManager.LoadScene("Answer20");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer19");
        }
    }
    [SerializeField] InputField Answer21;
    public void CheckAnswer21()
    {
        string rightAnswer1 = "захолустье";
        string rightAnswer2 = "Захолустье";
        string rightAnswer3 = "ЗАХОЛУСТЬЕ";
        string user21 = Answer21.text;
        if (user21 == rightAnswer1 || user21 == rightAnswer2 || user21 == rightAnswer3)
        {
            SceneManager.LoadScene("Answer21");
        }
        else
        {
            SceneManager.LoadScene("WrongAnswer20");
        }
    }
}
