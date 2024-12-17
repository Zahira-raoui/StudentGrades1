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
            //Pr�parer les donn�es ou les objets n�cessaires au test
            var pourcentage = 99;

            //Act
            //Appeler la m�thode � tester
            var grade = _gradeCalculator.GetGradeByPercentage(pourcentage);

            //Assert
            // V�rifier que les r�sultats sont corrects
            Assert.AreEqual("A", grade);
              
        }
    }
}