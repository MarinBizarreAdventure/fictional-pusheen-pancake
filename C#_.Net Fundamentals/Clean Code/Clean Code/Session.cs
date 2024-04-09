using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    /// <summary>
    /// Represents a single conference session
    /// </summary>
    public class Session
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }

        public Session(string title, string description)
        {
            Title = title;
            Description = description;
            CheckApproval();
        }
        private void CheckApproval()
        {
            bool containsObsoleteTech = Title.ContainsObsoleteTechnology() || Description.ContainsObsoleteTechnology();
            Approved = !containsObsoleteTech;
        }
    }

    public static class StringExtensions
    {
        public static bool ContainsObsoleteTechnology(this string text)
        {
            var obsoleteTechnologies = new List<string> { "Cobol", "Punch Cards", "Commodore", "VBScript" };
            return obsoleteTechnologies.Any(tech => text.Contains(tech));
        }
    }
}