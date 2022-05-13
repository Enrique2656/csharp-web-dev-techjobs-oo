using System;
namespace TechJobsOO
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

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName,  Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job&&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if(Name == null || Name == "")
            {
                Name = "Data Not Available";
            }
            if(EmployerName.Value == null || EmployerName.Value == "")
            {
                EmployerName.Value = "Data Not Available";
            }
            if (EmployerLocation.Value == null || EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data Not Available";
            }
            if (JobType.Value == null || JobType.Value == "")
            {
                JobType.Value = "Data Not Available";
            }
            if(JobCoreCompetency.Value == null || JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data Not Available";
            }
                return $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName.Value}\nLocation: {EmployerLocation.Value}\nPosition Type: {JobType.Value}\nCore Competency: {JobCoreCompetency.Value}\n";
        }
    }
}
