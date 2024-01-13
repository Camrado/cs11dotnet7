using System.Xml;
using static System.Environment;
using static System.IO.Path;

SectionTitle("Writing to text streams");

// define a file to write to
string textFile = Combine(CurrentDirectory, "streams.txt");

// create a text file and return a helper writer
StreamWriter text = File.CreateText(textFile);

// enumerate the strings, writing each one
// to the stream on a separate line
foreach (string item in Viper.Callsigns) {
    text.WriteLine(item);
}

text.Close(); // release resources

// output the contents of the file
WriteLine("{0} contains {1:N0} bytes.",
    arg0: textFile,
    arg1: new FileInfo(textFile).Length);

WriteLine(File.ReadAllText(textFile));