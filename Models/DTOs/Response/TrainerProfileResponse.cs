namespace Models.DTOs.Response
{
    public class TrainerProfileResponse
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public int? ProfileType { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int EmploymentType { get; set; }
        public DateTime DateOfHire { get; set; }
    }
}