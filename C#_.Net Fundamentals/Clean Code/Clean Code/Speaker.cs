using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace BusinessLayer
{
    public class Speaker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Exp { get; set; }
        public bool HasBlog { get; set; }
        public string BlogURL { get; set; }
        public WebBrowser Browser { get; set; }
        public List<string> Certifications { get; set; }
        public string Employer { get; set; }
        public int RegistrationFee { get; set; }
        public List<Session> Sessions { get; set; }

        private IFeeCalculator feeCalculator = new ExperienceBasedFeeCalculator();
        private IEmailValidator emailValidator = new StandardEmailValidator();

        public int? Register(IRepository repository)
        {
           
            ValidateSpeaker();
            CheckSessionApproval();
            CalculateRegistrationFee();

            try
            {
                return repository.SaveSpeaker(this);
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to register speaker.", ex);
            }

        }


        private void ValidateSpeaker()
        {
            ValidateBasicInformation();
            ValidateExperienceAndCertifications();
            ValidateEmail();
            

            if (Sessions == null || Sessions.Count == 0)
                throw new ArgumentException("Can't register speaker with no sessions to present.");
        }

        private void ValidateBasicInformation()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                throw new ArgumentNullException(nameof(FirstName), "First Name is required.");

            if (string.IsNullOrWhiteSpace(LastName))
                throw new ArgumentNullException(nameof(LastName), "Last Name is required.");

            if (string.IsNullOrWhiteSpace(Email))
                throw new ArgumentNullException(nameof(Email), "Email is required.");

            if (string.IsNullOrWhiteSpace(Employer))
                throw new ArgumentNullException(nameof(Employer), "Employer is required.");

        }

        private void ValidateExperienceAndCertifications()
        {
            if (Exp <= 0)
                throw new ArgumentException("Experience must be a positive number.", nameof(Exp));

            if (Certifications.Count < 3)
                throw new ArgumentException("At least 3 certifications are required.", nameof(Certifications));
        }

        private void ValidateEmail()
        {
            if (emailValidator.Validate(this))
                throw new SpeakerDoesntMeetRequirementsException("Speaker doesn't meet our arbitrary and capricious standards.");
        }

        private void CheckSessionApproval()
        {
            if (Sessions == null || !Sessions.Any(s => s.Approved))
                throw new NoSessionsApprovedException("No sessions approved.");
        }

        private void CalculateRegistrationFee()
        {
            RegistrationFee = feeCalculator.CalculateRegistrationFee(Exp);
        }
    }
}