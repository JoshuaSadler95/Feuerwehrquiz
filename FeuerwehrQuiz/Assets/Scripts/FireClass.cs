public class FireClass
{
    private string name;
    private Question[] questions = new Question[3];
    private int numberOfQuestions = 0;

    public void setName(string name)
    {
        this.name = name;
    }

    public void addQuestion(Question question)
    {
        this.questions[numberOfQuestions] = question;
        numberOfQuestions++;
    }

    public string getName()
    {
        return name;
    }

    public Question[] getQuestions()
    {
        return questions;
    }

    public int getNumberOfQuestions()
    {
        return numberOfQuestions;
    }
}
