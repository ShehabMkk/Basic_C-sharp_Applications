namespace Quiz_02;

public class Final : Exam
{
    public Final(DateTime timeOfExam, int numberOfQuestions)
        : base(timeOfExam, numberOfQuestions) { }

    public override void ShowExam()
    {
        foreach (var question in QuestionsTorF)
        {
            question.DisplayQuestion();
        }
        foreach (var question in QuestionsMCQ)
        {
            question.DisplayQuestion();
        }
    }
}