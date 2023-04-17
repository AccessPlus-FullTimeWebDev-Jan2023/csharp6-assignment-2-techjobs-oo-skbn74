
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
         Job job1 = new Job();

         Job job2 = new Job();

          Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

          Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


        /*  [TestMethod]
          public void TestMethod()
          {
              //TODO: Task 4: remove this method before you create your first test method 
          }*/
        [TestMethod]
        public void TestSettingJobId()
        {
           
         
            //verify
            Assert.AreNotEqual(job1.Id, job2.Id, "Unique Id Test");
            Assert.IsTrue(job2.Id - job1.Id == 1, "Id increments by 1 test");
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
   


            //verify
            Assert.AreEqual(job3.Name, "Product tester", "Testing Job Name Assignment");
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME", "Testing Employer Name Assignment");
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert", "Testing Job Location Assignment");
            Assert.AreEqual(job3.JobType.ToString(), "Quality control", "Testing Job Type Assignment");
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence", "Testing Core Competency Assignment");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {


            //verify
            Assert.IsFalse(job3.Equals(job4));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
          Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
          Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            var output = Environment.NewLine + "ID: " + job3.Id + Environment.NewLine + "Name: " + job3.Name + Environment.NewLine + "Employer: " + job3.EmployerName.Value + Environment.NewLine + "Location: " + job3.EmployerLocation.Value + Environment.NewLine + "Position Type: " + job3.JobType.Value + Environment.NewLine + "Core Competency: " +job3.JobCoreCompetency.Value + Environment.NewLine;

            //  Assert.IsTrue(output.Contains($"Name: Product tester") && output.Contains("Employer: ACME") && output.Contains("Location: Desert") && output.Contains("Position Type: Quality control") && output.Contains("Core Competency: Persistence"));

            Assert.IsTrue(job3.ToString() == output);
            

        }
        [TestMethod]

        public void TestToStringHandlesEmptyField()
        {
            var output = Environment.NewLine + "ID: " + job3.Id + Environment.NewLine + "Name: " + job3.Name + Environment.NewLine + "Employer: Data not available" + Environment.NewLine + "Location: " + job3.EmployerLocation.Value + Environment.NewLine + "Position Type: " + job3.JobType.Value + Environment.NewLine + "Core Competency: " + job3.JobCoreCompetency.Value + Environment.NewLine;

            job3.EmployerName.Value = "";

            Assert.IsTrue(job3.ToString() == output);
        }
    }
}

