/*
Program Description: An instructor needs to calculate individual student grades for one of their classes. They  needs to find the average of the grades for each student by calculating 5 homework grades, 3 quiz grades and 2 exam grades. At the end of the program, the instructor should be able to see the student's grade in an alphabetical value (A,B,C,D,F).

Programmer: Olivia Daake
Date last modified: January 5, 2024

Requirements:
1. The user (instructor) will provide the number of students for which grades need to be calculated.  
    i) This number must be at least one.
2. For each student, the instructor will provide five homework grades, three quiz grades, and two exam grades.  
    i) All grades entered must be between 0 and 100 inclusively.
3. A student's final grade average is calculated by adding together 50% of the homework average, 30% of the quiz average and 20% of the exam average.
4. A student's final grade is calculated  based on the final grade average.  
    i) If it is 90% or greater, it is an A; 80% or better is a B; 70% or better is a C; 60% or better is a D; and anything less than 60% is an F.
5. Once calculated, the program will display the student's name, homework average, quiz average, exam average, final average and final grade.


Algorithm:
a) Prompt the user (instructor) to enter the number of students.
    i) Validate that the number of students is at least one.

do loop
b) Prompt the user (instructor) to enter the student's name

c) Create variables for homework, quiz, exam grades, and final grade

d) loop for each student
    1) Prompt the user (instructor) to enter the 5 homework grades
        i) Validate that the grades are between 0 and 100 inclusively

    2) Prompt the user (instructor) to enter the 3 quiz grades
        i) Validate that the grades are between 0 and 100 inclusively

    3) Prompt the user (instructor) to enter the 2 exam grades
        i) Validate that the grades are between 0 and 100 inclusively

e) Calculate the homework average using the homework, quiz and exam grades
    i) Calculate the quiz average using the quiz and exam grades
    ii) Calculate the exam average using the exam and homework grades
    iii) Calculate the final grade using the final grade average

f) Calculate the final grade using the final grade average
    i) Final average = .5 * homework average + .3 * quiz average + .2 * exam average 

g)Find the final grade using the scale below:
    i) If the final grade is 90% or greater, set the final grade to A
    ii) If the final grade is 80% or greater, set the final grade to B
    iii) If the final grade is 70% or greater, set the final grade to C
    iv) If the final grade is 60% or greater, set the final grade to D
    v) If the final grade is less than 60%, set the final grade to F

h) Display the student's information
    i) Name
    ii) Homework average
    iii) Quiz average
    iv) Exam average
    v) Final average
    vi) Final grade

i) Repeat steps b-h until the user is completed and all student information is displayed

*/

using System;

class CalculateStudentGrades
{
    static void Main()
    {
        // Step a: Prompt the user to enter the amount of students they need to enter
        Console.Write("Enter the number of students: ");
        int numberOfStudents;

        //Step a (i)  Validate that the number of students is at least one
        while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents < 1)
        {
            Console.WriteLine("Invalid input. Please enter a number of students greater than or equal to one.");
            Console.Write("Enter the number of students: ");
        }

        //do loop for each student
        for (int i = 1; i <= numberOfStudents; i++)
        {
            //Step b: Prompt the user to enter the student's name
            Console.Write("Enter the name of the student:");
            string studentName = Console.ReadLine();

            //Step c: Create variables for homework, quiz, exam grades, and
            double[] homeworkGrades = new double[5];
            double[] quizGrades = new double[3];
            double[] examGrades = new double[2];

            //Step d: loop for each student
            //Step d (i) Prompt the user to enter the 5 homework grades
            for (int j = 0; j < 5; j++)
            {
                //Step d(1)(i): validate the grades are between 0 and 100 inclusively
                Console.Write($"Enter homework grade {j + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out homeworkGrades[j]) || homeworkGrades[j] < 0 || homeworkGrades[j] > 100)
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                    Console.Write($"Enter homework grade {j + 1}: ");
                }
            }

            //Step d(ii) Prompt the user to enter the 3 quiz grades
            for (int j = 0; j < 3; j++)
            {
                //Step d(1)(i): validate the grades are between 0 and 100 inclusively
                Console.Write($"Enter quiz grade {j + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out quizGrades[j]) || quizGrades[j] < 0 || quizGrades[j] > 100)
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                    Console.Write($"Enter quiz grade {j + 1}: ");
                }
            }

            //Step d(iii) Prompt the user to enter the 2 exam grades
            for (int j = 0; j < 2; j++)
            {
                //Step d(1)(i): validate the grades are between 0 and 100 inclusively
                Console.Write($"Enter exam grade {j + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out examGrades[j]) || examGrades[j] < 0 || examGrades[j] > 100)
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                    Console.Write($"Enter exam grade {j + 1}: ");
                }
            }

            //Step e: Calculate the homework average using the homework, quiz and exam grades
            double homeworkAverage = CalculateAverage(homeworkGrades);
            double quizAverage = CalculateAverage(quizGrades);
            double examAverage = CalculateAverage(examGrades);

            //Step f: Calculate the final grade using the final grade
            double finalGradeAverage = 0.5 * homeworkAverage + 0.3 * quizAverage + 0.2 * examAverage;

            //Step g: Find the final grade using the scale
            char finalGrade = CalculateFinalGrade(finalGradeAverage);

            //Step h: Display the student's information
            Console.WriteLine($"Student Information for {studentName}::");
            Console.WriteLine($"Homework Average: {homeworkAverage}");
            Console.WriteLine($"Quiz Average: {quizAverage}");
            Console.WriteLine($"Exam Average: {examAverage}");
            Console.WriteLine($"Final Average: {finalGradeAverage}");
            Console.WriteLine($"Final Grade: {finalGrade}");

            //Step i: Steps b-h will repeat until the user is completed, and all student information is displayed
        }
    }

    // Method to calculate the average of an array of grades
    static double CalculateAverage(double[] grades)
    {
        double sum = 0;
        foreach (double grade in grades)
        {
            sum += grade;
        }
        return sum / grades.Length;
    }

    //Method to calculate the final grade based on the final grade average
    static char CalculateFinalGrade(double finalGradeAverage)
    {
        if (finalGradeAverage >= 90)
            return 'A';
        else if (finalGradeAverage >= 80)
            return 'B';
        else if (finalGradeAverage >= 70)
            return 'C';
        else if (finalGradeAverage >= 60)
            return 'D';
        else
            return 'F';
    }
}