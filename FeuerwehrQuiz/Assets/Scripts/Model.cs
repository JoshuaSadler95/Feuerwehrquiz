public class Model
{
    private static Quiz quiz;

    //get this instance
    public static Quiz getInstance()
    {
        if(quiz == null)
        {
            quiz = new Quiz();
        }

        return quiz;
    }
}
