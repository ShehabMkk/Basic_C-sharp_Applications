namespace Quiz_02;

public class Subject
{
    public int SubjectId { get; set; }
    public static int examType;
    public string SubjectName { get; set; }
    public Exam Exam { get; set; }

    public static int timeInMinutes;
    public Subject(int subjectId, string subjectName)
    {
        SubjectId = subjectId;
        SubjectName = subjectName;
    }

    public void CreateExam()
    {
        Console.WriteLine("Enter the time required to finish the exam (in minutes): ");
        timeInMinutes = int.Parse(Console.ReadLine());
        DateTime examTime = DateTime.Now.AddMinutes(timeInMinutes);

        Console.WriteLine("Enter the number of questions: ");
        int numberOfQuestions = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the type of exam (1 for Final, 2 for Practical): ");
        examType = int.Parse(Console.ReadLine());

        if (examType == 1)
        {
            Exam = new Final(examTime, numberOfQuestions);
        }
        else if (examType == 2)
        {
            Exam = new Practical(examTime, numberOfQuestions);
        }
        else
        {
            throw new Exception("Invalid exam type.");
        }

        for (int i = 0; i < numberOfQuestions; i++)
        {
            int questionType;
            if (examType == 1)
            {
                Console.WriteLine($"Enter the type of question {i + 1} (1 for True/False, 2 for MCQ): ");
                questionType = int.Parse(Console.ReadLine());
            }
            else questionType = 2;

            Console.WriteLine("Enter the header of the question: ");
            string header = Console.ReadLine();

            Console.WriteLine("Enter the body of the question: ");
            string body = Console.ReadLine();

            Console.WriteLine("Enter the mark for the question: ");
            int mark = int.Parse(Console.ReadLine());

            if (questionType == 1)
            {
                Answer[] answers = new Answer[2];
                answers[0] = new Answer(1, "True");
                answers[1] = new Answer(2, "False");

                Console.WriteLine("Enter the correct answer (1 for True, 2 for False): ");
                int correctAnswerIndex = int.Parse(Console.ReadLine()) - 1;

                TrueFalse question = new TrueFalse(header, body, mark, answers, answers[correctAnswerIndex]);
                Exam.QuestionsTorF.Add(question);
            }
            else if (questionType == 2)
            {
                Console.WriteLine("Enter the number of options: ");
                int numberOfOptions = int.Parse(Console.ReadLine());

                Answer[] answers = new Answer[numberOfOptions];
                for (int j = 0; j < numberOfOptions; j++)
                {
                    Console.WriteLine($"Enter the text for option {j + 1}: ");
                    string answerText = Console.ReadLine();
                    answers[j] = new Answer(j + 1, answerText);
                }

                Console.WriteLine("Enter the correct answer index (1 to n): ");
                int correctAnswerIndex = int.Parse(Console.ReadLine()) - 1;

                MCQ question = new MCQ(header, body, mark, answers, answers[correctAnswerIndex]);
                Exam.QuestionsMCQ.Add(question);
            }
            else
            {
                throw new Exception("Invalid question type.");
            }
        }
    }

    public void ShowExam()
    {
        if (examType == 1)
        {
            Console.WriteLine("the Final Exam");
        }
        else if (examType == 2)
        {
            Console.WriteLine("the Practical Exam");
        }
        
        Console.WriteLine($"Time to take the Exam is: {timeInMinutes} Minutes");
        Console.WriteLine();

        Exam.ShowExam();
    }

    public int TakeExam()
    {
        if (examType == 1)
        {
            Console.WriteLine("the Final Exam");
        }
        else if (examType == 2)
        {
            Console.WriteLine("the Practical Exam");
        }
        Console.WriteLine($"Time to take the Exam is: {timeInMinutes} Minutes");
        Console.WriteLine();

        return Exam.TakeExam();
    }
}