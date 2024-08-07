namespace Quiz_02;

public abstract class Exam
{
    public DateTime TimeOfExam { get; set; }
    public int NumberOfQuestions { get; set; }
    public List<TrueFalse> QuestionsTorF { get; set; }
    public List<MCQ> QuestionsMCQ { get; set; }


    public Exam(DateTime timeOfExam, int numberOfQuestions)
    {
        TimeOfExam = timeOfExam;
        NumberOfQuestions = numberOfQuestions;
        QuestionsTorF = new List<TrueFalse>();
        QuestionsMCQ = new List<MCQ>();
    }

    public int TakeExam()
    {
        int score = 0;
        Console.WriteLine($"Time Of the Exam is: {TimeOfExam}");

        Console.WriteLine();

        foreach (var question in QuestionsTorF)
        {
            question.DisplayQuestion();
            Console.Write("Your answer: ");
            int userAnswer = int.Parse(Console.ReadLine()) - 1;

            if (question.AnswerList[userAnswer].AnswerId == question.RightAnswer.AnswerId)
            {
                score += question.Mark;
            }
        }
        foreach (var question in QuestionsMCQ)
        {
            question.DisplayQuestion();
            Console.Write("Your answer: ");
            int userAnswer = int.Parse(Console.ReadLine()) - 1;

            if (question.AnswerList[userAnswer].AnswerId == question.RightAnswer.AnswerId)
            {
                score += question.Mark;
            }
        }

        return score;
    }

    public abstract void ShowExam();
    
}