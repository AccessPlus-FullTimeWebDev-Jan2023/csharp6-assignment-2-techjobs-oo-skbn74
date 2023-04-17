using System;
using System.Data;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        // TODO: Task 3: Add the two necessary constructors.
        public Job() 
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            if (this.Name == null || this.Name == "") {
                this.Name = "Data not available";
            };

            if (this.EmployerName.Value == null || this.EmployerName.Value == "")
            {
                this.EmployerName.Value = "Data not available";
            };

            if (this.EmployerLocation.Value == null || this.EmployerLocation.Value == "")
            {
                this.EmployerLocation.Value = "Data not available";
            };

            if (this.JobType.Value == null || this.JobType.Value == "")
            {
                this.JobType.Value = "Data not available";
            };

            if (this.JobCoreCompetency.Value == null || this.JobCoreCompetency.Value == "")
            {
                this.JobCoreCompetency.Value = "Data not available";
            };

            return Environment.NewLine + "ID: " + this.Id + Environment.NewLine + "Name: " + this.Name + Environment.NewLine + "Employer: " + this.EmployerName.Value + Environment.NewLine + "Location: " + this.EmployerLocation.Value + Environment.NewLine + "Position Type: " + this.JobType.Value + Environment.NewLine + "Core Competency: " + this.JobCoreCompetency.Value + Environment.NewLine;


        }

    }
}

