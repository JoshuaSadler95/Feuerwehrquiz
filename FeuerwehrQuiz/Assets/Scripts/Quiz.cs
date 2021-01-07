using System;
using System.IO;

public class Quiz
{
    private FireClass[] fireClasses = new FireClass[5];
    private string[] fireClassNames = { "BrandklasseA", "BrandklasseB", "BrandklasseC", "BrandklasseD", "BrandklasseF" };

    //read all the questions into the dataModel
    public string readQuestions()
    {
        for(int i = 0; i<5; i++)
        {
            string path = "Assets/Resources/"+fireClassNames[i]+".txt";

            //Read the text from directly from the test.txt file
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadToEnd();
            reader.Close();

            fireClasses[i] = createFireClass(data, fireClassNames[i]);
        }

        FireClass fireClass = fireClasses[0];
        Question question = fireClass.getQuestions()[0];

        return getTestTextOf(4,2);
    }

    private string getTestTextOf(int index1, int index2)
    {
        FireClass fireClass = fireClasses[index1];

        string answers = "";
        foreach(string answer in fireClass.getQuestions()[index2].getAnswers())
        {
            answers += answer + "\n";
        }

        string result = fireClass.getName() + "\n" +
                        "Frage "+(index2+1)+": " + fireClass.getQuestions()[index2].getQuestionsText() + "\n\n" +
                        answers + "Right Answer: " + fireClass.getQuestions()[index2].getRightAnswer();

        return result;
    }

    private FireClass createFireClass(string data, string name)
    {
        FireClass fireClass = new FireClass();
        string[] dataSplit = data.Split('#');

        fireClass.setName(name);

        foreach(string newData in dataSplit){
            fireClass.addQuestion(createQuestion(newData));
        }
        return fireClass;
    }

    private Question createQuestion(string data)
    {
        Question question = new Question();
        string[] dataSplit = data.Split('|');
        string[] answers = dataSplit[1].Split(',');

        question.setQuestionText(dataSplit[0]);

        question.setRightAnswer(answers[0]);

        foreach(string answer in answers)
        { 
            question.addAnswer(answer);
        }

        return question;
    }
}
