using Structural_Design_Patterns.Decorator;

class Program
{
    static void Main(string[] args)
    {
        // Create a SimpleText instance
        SimpleText simpleText = new SimpleText("This is a simple text.");

        // Apply UnderlineText formatting
        ITextFormat formatter = new UnderlineTextFormatter(simpleText);
        string formattedText = formatter.Apply(simpleText.Apply());

        Console.WriteLine(formattedText); // Output: <u>Apply UnderlineText formatting</u>

        // Remove UnderlineText formatting
        formattedText = formatter.Remove(simpleText.Remove());
        Console.WriteLine(formattedText);

        // Example of applying multiple formatting options at once
        ITextFormat IBUCFormatter = new ItalicTextFormatter(
            new BoldTextFormatter(
                new UnderlineTextFormatter(
                    new ColorTextFormatter(simpleText, "red"))));
        string IBUCText = IBUCFormatter.Apply(simpleText.Apply());

        Console.WriteLine(IBUCText);

        // Remove all formatting options
        IBUCText = IBUCFormatter.Remove(simpleText.Remove());
        Console.WriteLine(IBUCText);

        // Apply formatting options again
        IBUCText = IBUCFormatter.Apply(simpleText.Apply());
        Console.WriteLine(IBUCText);

        // Remove specific formatting (UnderlineText) while keeping others intact
        IBUCText = formatter.Remove(simpleText.Remove(IBUCText));
        Console.WriteLine(IBUCText);

        // Another way to remove specific formatting (BoldText) while keeping others intact
        IBUCText = new BoldTextFormatter(simpleText).Remove(simpleText.Remove(IBUCText));
        Console.WriteLine(IBUCText);

        // Reapply formatting to the text
        //Console.WriteLine(simpleText.Apply(IBUCText));

        // Completely remove all formatting
        IBUCText = IBUCFormatter.Remove(simpleText.Remove(IBUCText));
        Console.WriteLine(IBUCText);
    }

}