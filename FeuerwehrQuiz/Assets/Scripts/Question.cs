public class Question
{
    private string questionText;
    private string[] answers = new string[4];
    private int numberOfAnswers = 0;
    private string rightAnswer;


    public void setQuestionText(string text)
    {
        this.questionText = text;
    }

    public void setRightAnswer(string answer)
    {
        this.rightAnswer = answer;
    }

    public void addAnswer(string answer)
    {
        this.answers[numberOfAnswers] = answer;
        numberOfAnswers++;
    }

    public string getQuestionsText()
    {
        return questionText;
    }

    public string[] getAnswers()
    {
        return answers;
    }

    public int getNumberOfAnswers()
    {
        return numberOfAnswers;
    }

    public string getRightAnswer()
    {
        return rightAnswer;
    }
}
