using StudentGrades;
    
//Get pourcentage
var gradeCalculator = new GradeCalcul();

Console.Write("Entrer la pourcentage : ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade= gradeCalculator.GetGradeByPercentage(percentage);

Console.WriteLine($"Student Grade :{grade}");
