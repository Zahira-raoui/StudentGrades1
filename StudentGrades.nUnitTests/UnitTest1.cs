namespace StudentGrades.nUnitTests
{
    public class Tests
    {
        private GradeCalcul _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalcul();
        }

        [Test]
        public void GetGradeByPercentage_EqualTest()
        {
            //Assign
            //Préparer les données ou les objets nécessaires au test
            var pourcentage = 99;

            //Act
            //Appeler la méthode à tester
            var grade = _gradeCalculator.GetGradeByPercentage(pourcentage);

            //Assert
            // Vérifier que les résultats sont corrects
            Assert.AreEqual("A", grade);
              
        }
    }
}