public interface IEmailValidator
{
    bool Validate(Speaker speaker);
}

public class StandardEmailValidator : IEmailValidator
{
    public bool Validate(Speaker speaker)
    {
        var domains = new List<string>() { "aol.com", "hotmail.com", "prodigy.com", "CompuServe.com" };
        var emps = new List<string>() { "Microsoft", "Google", "Fog Creek Software", "37Signals" };

        if (speaker.Exp > 10 || speaker.HasBlog || speaker.Certifications?.Count > 3 || emps.Contains(speaker.Employer))
            return true;

        string emailDomain = speaker.Email.Split('@').Last();
        var browserToUse = speaker.Browser ?? new WebBrowser();

        if (domains.Contains(emailDomain) && (browserToUse.Name == WebBrowser.BrowserName.InternetExplorer && browserToUse.MajorVersion < 9))
        {
            throw new SpeakerDoesntMeetRequirementsException("Speaker doesn't meet our arbitrary and capricious standards.");
        }

        return false;
    }
}

