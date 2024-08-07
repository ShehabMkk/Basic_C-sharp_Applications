namespace Quiz_02;

public class MCQ : Question
{
    public MCQ(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        : base(header, body, mark, answerList, rightAnswer) { }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"{Header}\n{Body}");
        for (int i = 0; i < AnswerList.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
        }
    }
}