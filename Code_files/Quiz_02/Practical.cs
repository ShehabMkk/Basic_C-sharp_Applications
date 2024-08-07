namespace Quiz_02;

public class Practical : Exam
{
    public Practical(DateTime timeOfExam, int numberOfQuestions)
        : base(timeOfExam, numberOfQuestions) { }

    public override void ShowExam()
    {
        foreach (var question in QuestionsMCQ)
        {
            question.DisplayQuestion();
            Console.WriteLine($"Right Answer: {question.RightAnswer.AnswerText}\n");
        }
    }
}