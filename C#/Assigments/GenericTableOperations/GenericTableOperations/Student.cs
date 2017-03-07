namespace GenericTableOperations
{   
    /// <summary>
    /// Student Class.
    /// </summary>
    class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        
        public int Age { get; set; }

        public string DateOfBirth { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return "StudentID : " + StudentID + "\nStudentName : " + StudentName + "\nDate of Birth : " + DateOfBirth + "\nAge : " + Age + "\nAddress : " + Address;
        }
    }
}
