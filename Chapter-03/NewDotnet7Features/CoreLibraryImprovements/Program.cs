using CoreLibraryImprovements;

Console.WriteLine("Demonstrating time-related data type improvements.");
TimeDatatypeImprovements.DemoNewTimeFeatures();

Console.WriteLine("Demonstrating JSON improvements.");
NewJsonFeatures.DemoJsonWriterOptions();
NewJsonFeatures.ShowDefaultJsonSerializerOptions();
NewJsonFeatures.DemoJsonPolymorphism();

Console.WriteLine("Demonstrating Stream improvements.");
NewStreamFeatures.DemoReadExactly();
NewStreamFeatures.DemoReadAtLeast();

Console.WriteLine("Demonstrating RegEx improvements.");

var lettersOnlyText = "letters";
var mixedText = "fwef340";

NewRegexFeatures.DemoSpanFeatures(lettersOnlyText);
NewRegexFeatures.DemoSpanFeatures(mixedText);

Console.WriteLine("Demonstrating cryptography improvements.");
CryptographyEnhancements.DemoCertificateNameBuilder();