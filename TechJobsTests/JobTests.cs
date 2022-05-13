using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        //test the empty constructor
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(job1.Id + 1 , job2.Id);
        }

        //test the full constructor
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.Id, 1);
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

        //test the Equals() method
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        //Create First Test for ToString()
        [TestMethod]
        public void ToStringTest()
        {
            Job job1 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(), $"\nID: {job1.Id}\nName: {job1.Name}\nEmployer: Data Not Available\nLocation: {job1.EmployerLocation.Value}\nPosition Type: {job1.JobType.Value}\nCore Competency: {job1.JobCoreCompetency.Value}\n" );
        }
    }
}
